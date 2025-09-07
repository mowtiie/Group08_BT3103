namespace Saleling.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminlogin form = new adminlogin();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cashierlogin form = new cashierlogin();
            form.Show();
        }
    }
}
