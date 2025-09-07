namespace Saleling.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLogin form = new AdminLogin();
            form.Show();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin adminLoginForm = new AdminLogin();
            adminLoginForm.ShowDialog();
        }

        private void btn_cashier_Click(object sender, EventArgs e)
        {
            this.Hide();
            CashierLogin cashierLoginForm = new CashierLogin();
            cashierLoginForm.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
