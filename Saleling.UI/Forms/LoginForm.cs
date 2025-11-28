using Saleling.Controller;
using Saleling.Model;
using Saleling.Util;

namespace Saleling.UI
{
    public partial class LoginForm : Form
    {
        private readonly UserController _userRepository;

        private const int MAX_ATTEMPTS = 5;
        private int _loginAttempts = 0;

        public LoginForm()
        {
            InitializeComponent();
            _userRepository = new UserController();

            MouseMove += ResetInactivityTimer;
            KeyDown += ResetInactivityTimer;
            txtUsername.KeyDown += ResetInactivityTimer;
            txtPassword.KeyDown += ResetInactivityTimer;
            cbShowPassword.Click += ResetInactivityTimer;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = cbShowPassword.Checked;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (!btnLogin.Enabled) return;

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            try
            {
                UserModel validatedUser = await _userRepository.AuthenticateAsync(username, password);
                _loginAttempts = 0;

                SessionUtil.Instance.SetLoggedInUser(validatedUser);
                await LoggerUtil.Instance.LogInfoAsync($"User '{validatedUser.Username}' logged in successfully as '{validatedUser.Role}'.");

                inactivityTimer.Stop();
                txtUsername.Clear();
                txtPassword.Clear();

                if (validatedUser.Role.Equals("Admin"))
                {
                    using (AdminNavigationForm adminNavigationForm = new AdminNavigationForm())
                    {
                        Hide();
                        if (adminNavigationForm.ShowDialog() == DialogResult.OK)
                        {
                            Show();
                        }
                    }
                }
                else if (validatedUser.Role.Equals("Cashier"))
                {
                    using (CashierNavigationForm cashierNavigationForm = new CashierNavigationForm())
                    {
                        Hide();
                        if (cashierNavigationForm.ShowDialog() == DialogResult.OK)
                        {
                            Show();
                        }
                    }
                }
                else
                {
                    throw new InvalidOperationException("User role is not recognized.");
                }
            }
            catch (ArgumentException ex)
            {
                _loginAttempts++;
                txtPassword.Clear();
                int attemptsRemaining = MAX_ATTEMPTS - _loginAttempts;

                await LoggerUtil.Instance.LogExceptionAsync(ex, "Login failed due to invalid credentials or empty input.");

                if (_loginAttempts >= MAX_ATTEMPTS)
                {
                    btnLogin.Enabled = false;
                    await LoggerUtil.Instance.LogInfoAsync($"Maximum login attempts reached for user '{username}'. Application closing.");

                    MessageBox.Show(
                        "Maximum login attempts reached (5 attempts). The application will now close for security reasons.",
                        "Security Alert: Locked",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop
                    );
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show(
                        $"{ex.Message}\nAttempts remaining: {attemptsRemaining} out of {MAX_ATTEMPTS}",
                        "Input Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(ex, "An unexpected error occurred during login.");
                MessageBox.Show("An unexpected error occurred. See logs for details.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Login_Load(object sender, EventArgs e)
        {
            await LoggerUtil.Instance.LogInfoAsync("Application has started.");
            inactivityTimer.Start();
        }

        private async void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            await LoggerUtil.Instance.LogInfoAsync("Application has closed.");
        }

        private async void inactivityTimer_Tick(object sender, EventArgs e)
        {
            inactivityTimer.Stop();
            MessageBox.Show("Login attempt timed out. The application will now close.", "Inactivity Timeout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            await LoggerUtil.Instance.LogInfoAsync("Application closed due to inactivity timeout.");
            Application.Exit();
        }

        private void ResetInactivityTimer(object? sender, EventArgs e)
        {
            inactivityTimer.Stop();
            inactivityTimer.Start();
        }
    }
}
