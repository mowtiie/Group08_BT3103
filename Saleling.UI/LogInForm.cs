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
    public partial class LoginForm : Form
    {

        private readonly UserController accountController;

        public LoginForm()
        {
            InitializeComponent();
            this.accountController = new UserController();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
