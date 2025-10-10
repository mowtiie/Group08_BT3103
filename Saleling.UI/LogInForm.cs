using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Saleling.Controller;

namespace Saleling.UI
{
    public partial class LogInForm : Form
    {

        private readonly UserController accountController;

        public LogInForm()
        {
            InitializeComponent();
            this.accountController = new UserController();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
