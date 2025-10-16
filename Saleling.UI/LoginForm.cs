using Saleling.Controller;

namespace Saleling.UI
{
    public partial class LoginForm : Form
    {

        private readonly UserController accountController;

        public LoginForm()
        {
            InitializeComponent();
            this.accountController = new UserController();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
