using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saleling.UI
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.MdiParent = this;
            adminDashboard.WindowState = FormWindowState.Maximized;
            adminDashboard.Show();
        }
    }
}
