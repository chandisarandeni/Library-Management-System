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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            txt_memberUsername.TabIndex = 0;
            txt_memberPassword.TabIndex = 1;
            btn_Login.TabIndex = 2;

            btn_Cancel.TabStop = false;
            lbl_forgotPassword.TabStop = false;
            lbl_getHelp.TabStop = false;
            checkBox_showPassword.TabStop = false;
            btn_Login.TabStop = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showPassword.Checked)
            {
                txt_memberPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txt_memberPassword.UseSystemPasswordChar = true;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_memberUsername.Text = "";
            txt_memberPassword.Text = "";
        }

        private void lbl_forgotPassword_Click(object sender, EventArgs e)
        {
            Member_Forgot_Password member_Forgot_Password = new Member_Forgot_Password();
            member_Forgot_Password.Show();
            this.Hide();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_memberUsername.Text == "./admin") { 
                AdminLogin adminLogin = new AdminLogin();
                adminLogin.Show();
                this.Hide();
            }
            else
            {
                Member_Dashboard member_Dashboard = new Member_Dashboard();
                member_Dashboard.Show();
                this.Hide();
            }
        }

        private void lbl_getHelp_Click(object sender, EventArgs e)
        {
            Member_FAQ member_FAQ = new Member_FAQ();
            member_FAQ.Show();
            this.Hide();
        }

        private void btn_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login.PerformClick();
            }
        }

        private void txt_memberUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;          // Prevents the sound
                e.SuppressKeyPress = true;  // Prevents the default key press action
                btn_Login.PerformClick();
            }
        }

        private void txt_memberPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;          // Prevents the sound
                e.SuppressKeyPress = true;  // Prevents the default key press action
                btn_Login.PerformClick();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
