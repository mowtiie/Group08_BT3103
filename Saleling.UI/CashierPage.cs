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
    public partial class CashierPage : Form
    {
        public CashierPage()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void CashierPage_Load(object sender, EventArgs e)
        {
            CashierDashboard cashierDashboard = new CashierDashboard();
            cashierDashboard.MdiParent = this;
            cashierDashboard.Show();
        }
    }
}
