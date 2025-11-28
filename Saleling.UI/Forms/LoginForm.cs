using Saleling.Controller;
using Saleling.Model;
using Saleling.Util;
using System.Threading.Tasks;

namespace Saleling.UI
{
    public partial class LoginForm : Form
    {

        private readonly UserController userRepository;

        public LoginForm()
        {
            InitializeComponent();
            this.userRepository = new UserController();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkboxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = chkboxShowPassword.Checked;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string usernameInput = txtUsername.Text.Trim();
            string passwordInput = txtPassword.Text.Trim();

            try
            {
                UserModel? validatedUser = await userRepository.AuthenticateUserAsync(usernameInput, passwordInput);
                SessionUtil.Instance.SetLoggedInUser(validatedUser);

                txtUsername.Clear();
                txtPassword.Clear();

                switch (validatedUser.Role)
                {
                    case "Admin":
                        using (AdminNavigationForm adminNavigationForm = new AdminNavigationForm())
                        {
                            this.Hide();
                            if (adminNavigationForm.ShowDialog() == DialogResult.OK)
                            {
                                this.Show();
                            }
                        }
                        break;
                    case "Cashier":
                        using (CashierNavigationForm cashierNavigationForm = new CashierNavigationForm())
                        {
                            this.Hide();
                            if (cashierNavigationForm.ShowDialog() == DialogResult.OK)
                            {
                                this.Show();
                            }
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogInfoAsync($"Error: {ex.Message}");
                MessageBox.Show(ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoginForm_Load(object sender, EventArgs e)
        {
            await LoggerUtil.Instance.LogInfoAsync("Application has started.");
        }

        private async void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            await LoggerUtil.Instance.LogInfoAsync("Application has closed.");
        }
    }
}
