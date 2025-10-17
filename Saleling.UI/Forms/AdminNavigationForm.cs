using Saleling.Model;
using Saleling.Util;

namespace Saleling.UI
{
    public partial class AdminNavigationForm : Form
    {
        private UserModel currentLoggedInUser;

        public AdminNavigationForm()
        {
            InitializeComponent();

            this.currentLoggedInUser = SessionUtil.Instance.CurrentUser;
        }

        private void AdminNavigationForm_Load(object sender, EventArgs e)
        {
            lblName.Text = $"{currentLoggedInUser.FirstName} {currentLoggedInUser.LastName}";
            lblRole.Text = currentLoggedInUser.Role;
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
                await LoggerUtil.Instance.LogAsync("User has logged out.");
                SessionUtil.Instance.Logout();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
