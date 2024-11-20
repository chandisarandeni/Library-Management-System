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
    public partial class Member_Forgot_Password : Form
    {
        public Member_Forgot_Password()
        {
            InitializeComponent();

            btn_Verify.TabStop = false;
            btn_Back.TabStop = false;

            txt_memberUsername.TabIndex = 0;
            txt_memberNIC.TabIndex = 1;
        }

        private void Member_Forgot_Password_Load(object sender, EventArgs e)
        {
            //Showing feilds
            lbl_passwordResetInstructions.Show();

            //Hiding feilds
            lbl_redStar.Hide();
            lbl_verifiedSuccessfully.Hide();
            lbl_newPassword.Hide();
            lbl_confirmPassword.Hide();
            lbl_dot1.Hide();
            lbl_dot2.Hide();
            txt_newPassword.Hide();
            txt_confirmPassword.Hide();
            btn_resetPassword.Hide();
            btn_Cancel.Hide();
            checkBox_newPassword.Hide();
            checkBox_condirmPassword.Hide();
        }

        private void checkBox_newPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_newPassword.Checked)
            {
                txt_newPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txt_newPassword.UseSystemPasswordChar = true;
            }
        }

        private void checkBox_condirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_condirmPassword.Checked)
            {
                txt_confirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txt_confirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Member_Forgot_Password member_Forgot_Password = new Member_Forgot_Password();
            member_Forgot_Password.Show();
            this.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btn_Verify_Click(object sender, EventArgs e)
        {
            lbl_passwordResetInstructions.Hide();

            lbl_verifiedSuccessfully.Show();
            lbl_newPassword.Show();
            lbl_confirmPassword.Show();
            lbl_dot1.Show();
            lbl_dot2.Show();
            txt_newPassword.Show();
            txt_confirmPassword.Show();
            checkBox_newPassword.Show();
            checkBox_condirmPassword.Show();
            lbl_redStar.Show();

            btn_resetPassword.Show();
            btn_Cancel.Show();
        }
    }
}
