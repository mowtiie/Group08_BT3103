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
    public partial class AdminLoginForm : Form
    {
        private readonly UserController userController;

        public AdminLoginForm()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.userController = new UserController();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string adminUsernameInput = field_username.Text;
                string adminPasswordInput = field_password.Text;

                UserModel matchingUser = userController.ValidateAdmin(adminUsernameInput, adminPasswordInput);
                if (matchingUser != null)
                {
                    this.Hide();                    
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.ShowDialog();
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

        private void checkbox_show_password_CheckedChanged(object sender, EventArgs e)
        {
            field_password.UseSystemPasswordChar = checkbox_show_password.Checked;
        }
    }
}
