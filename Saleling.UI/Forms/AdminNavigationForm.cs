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
    }
}
