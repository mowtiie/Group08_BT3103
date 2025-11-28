using Saleling.Model;
using Saleling.UI.UserControls;
using Saleling.Util;

namespace Saleling.UI
{
    public partial class CashierNavigationForm : Form
    {
        private UserModel currentLoggedInUser;
        private readonly List<Button> drawerButtons;

        private readonly Color defaultDrawerButtonColor;
        private readonly Color highlightedDrawerButtonColor;

        public CashierNavigationForm()
        {
            InitializeComponent();

            this.defaultDrawerButtonColor = SystemColors.Highlight;
            this.highlightedDrawerButtonColor = Color.FromArgb(0, 77, 138);

            this.drawerButtons = new List<Button>();
            this.currentLoggedInUser = SessionUtil.Instance.CurrentUser;

            InitializeDrawerButtons();
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
            LoadScreen(new AdminDashboardScreen());
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
                    button.BackColor = highlightedDrawerButtonColor;
                }
                else
                {
                    button.BackColor = defaultDrawerButtonColor;
                }
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboardScreen();
        }

        private async void CashierNavigationForm_Load(object sender, EventArgs e)
        {
            await LoggerUtil.Instance.LogInfoAsync($"{currentLoggedInUser.Username} has logged in.");
            lblName.Text = $"{currentLoggedInUser.FirstName} {currentLoggedInUser.LastName}";
            lblRole.Text = currentLoggedInUser.Role;
            LoadDashboardScreen();
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            HighlightDrawerButton(sender);
            LoadScreen(new PointOfSaleScreen());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            HighlightDrawerButton(sender);
            LoadScreen(new ProductMaintenanceScreen());
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            HighlightDrawerButton(sender);
            LoadScreen(new InventoryManagementControls());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            HighlightDrawerButton(sender);
            LoadScreen(new ReportsManagementScreen());
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
                await LoggerUtil.Instance.LogInfoAsync("User has logged out.");
                SessionUtil.Instance.Logout();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
