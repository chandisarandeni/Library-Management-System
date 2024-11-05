using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();

            txt_adminUsername.TabIndex = 0;
            txt_adminPassword.TabIndex = 1;
            btn_adminLogin.TabIndex = 2;

            btn_adminCancel.TabStop = false;
            lbl_adminForgotPassword.TabStop = false;
            checkBox_showPassword.TabStop = false;
            btn_adminLogin.TabStop = false;
        }

        private void btn_adminCancel_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void lbl_adminForgotPassword_Click(object sender, EventArgs e)
        {
            Admin_Forgot_Password admin_Forgot_Password = new Admin_Forgot_Password();
            admin_Forgot_Password.Show();
            this.Hide();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void checkBox_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showPassword.Checked)
            {
                txt_adminPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txt_adminPassword.UseSystemPasswordChar = true;
            }
        }

        private void btn_adminLogin_Click(object sender, EventArgs e)
        {
            Admin_Dashboard admin_Dashboard = new Admin_Dashboard();
            admin_Dashboard.Show();
            this.Hide();
        }

        private void txt_adminPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;          // Prevents the sound
                e.SuppressKeyPress = true;  // Prevents the default key press action
                btn_adminLogin.PerformClick();
            }
        }
    }
}
