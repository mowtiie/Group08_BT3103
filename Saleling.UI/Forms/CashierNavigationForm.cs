using Saleling.Model;
using Saleling.Util;
using Saleling_Debug.UI;

namespace Saleling.UI
{
    public partial class CashierNavigationForm : Form
    {
        private UserModel _currentUser;
        private List<Button> _drawerButtons;

        private Color _defaultButtonBackColor;
        private Color _pressedButtonBackColor;

        public CashierNavigationForm()
        {
            InitializeComponent();

            _defaultButtonBackColor = SystemColors.Highlight;
            _pressedButtonBackColor = Color.FromArgb(0, 77, 138);
            _drawerButtons = new List<Button>();
            _currentUser = SessionUtil.Instance.CurrentUser;

            lblUsername.Text = _currentUser.FullName;
            lblRole.Text = _currentUser.Role;

            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;

            InitializeDrawerButtons();
        }

        private void CashierDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardScreen();
        }

        private void InitializeDrawerButtons()
        {
            foreach (Control control in drawerPanel.Controls)
            {
                if (control is Button button && button.Name.StartsWith("btn"))
                {
                    _drawerButtons.Add(button);
                }
            }
        }

        private async void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult logoutResult = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (logoutResult == DialogResult.Yes)
            {
                await LoggerUtil.Instance.LogInfoAsync($"{_currentUser.Username} has logged out.");
                SessionUtil.Instance.Logout();

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void LoadScreen(UserControl screen)
        {
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(screen);
            screen.Dock = DockStyle.Fill;
            screen.BringToFront();
        }

        private void HighlightDrawerButton(object selectedButton)
        {
            if (selectedButton is not Button clickedButton)
            {
                return;
            }

            foreach (Button button in _drawerButtons)
            {
                if (button == clickedButton)
                {
                    button.BackColor = _pressedButtonBackColor;
                }
                else
                {
                    button.BackColor = _defaultButtonBackColor;
                }
            }
        }

        private void LoadDashboardScreen()
        {
            HighlightDrawerButton(btnDashboard);
            LoadScreen(new CashierDashboardControls());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboardScreen();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            HighlightDrawerButton(sender);
            LoadScreen(new PointOfSalesControls());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            HighlightDrawerButton(sender);
            LoadScreen(new ProductListingControls());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            HighlightDrawerButton(sender);
            LoadScreen(new ReportsManagementControls());
        }
    }
}
