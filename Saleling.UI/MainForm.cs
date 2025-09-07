namespace Saleling.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLoginForm form = new AdminLoginForm();
            form.Show();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLoginForm adminLoginForm = new AdminLoginForm();
            adminLoginForm.ShowDialog();
        }

        private void btn_cashier_Click(object sender, EventArgs e)
        {
            this.Hide();
            cashierlogin cashierLoginForm = new cashierlogin();
            cashierLoginForm.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
