using Saleling.Model;
using Saleling.Util;

namespace Saleling.UI
{
    public partial class AdminNavigationForm : Form
    {
        private UserModel _currentUser;
        private List<Button> drawerButtons;

        private Color _defaultButtonBackColor;
        private Color _pressedButtonBackColor;

        public AdminNavigationForm()
        {
            InitializeComponent();

            drawerButtons = new List<Button>();
            _defaultButtonBackColor = SystemColors.Highlight;
            _pressedButtonBackColor = Color.FromArgb(0, 77, 138);
            _currentUser = SessionUtil.Instance.CurrentUser;

            lblRole.Text = _currentUser.Role;
            lblUsername.Text = _currentUser.FullName;

            InitializeDrawerButtons();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardScreen();
        }

        private void InitializeDrawerButtons()
        {
            foreach (Control control in drawerPanel.Controls)
            {
                if (control is Button button && button.Name.StartsWith("btn"))
                {
                    drawerButtons.Add(button);
                }
            }
        }

        private void LoadDashboardScreen()
        {
            HighlightDrawerButton(btnDashboard);
            LoadScreen(new AdminDashboardControls());
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

            foreach (Button button in drawerButtons)
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboardScreen();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            HighlightDrawerButton(sender);
            LoadScreen(new ProductMaintenanceControls());
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            HighlightDrawerButton(sender);
            LoadScreen(new InventoryManagementControls());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            HighlightDrawerButton(sender);
            LoadScreen(new ReportsManagementControls());
        }
    }
}
