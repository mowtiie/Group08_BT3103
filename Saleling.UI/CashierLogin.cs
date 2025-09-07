using Saleling.Controller;
using Saleling.Model;
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
    public partial class CashierLogin : Form
    {
        private readonly UserController userController;

        public CashierLogin()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.userController = new UserController();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string cashierUsernameInput = field_username.Text;
                string cashierPasswordInput = field_password.Text;

                UserModel matchingUser = userController.ValidateCashier(cashierUsernameInput, cashierPasswordInput);
                if (matchingUser != null)
                {
                    this.Hide();
                    CashierDashboard cashierDashboard = new CashierDashboard();
                    cashierDashboard.ShowDialog();
                }
                else
                {
                    throw new Exception("The submitted credentials are invalid.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mainForm = new Main();
            mainForm.ShowDialog();
        }

        private void checkbox_show_password_CheckedChanged(object sender, EventArgs e)
        {
            field_password.UseSystemPasswordChar = checkbox_show_password.Checked;
        }
    }
}
