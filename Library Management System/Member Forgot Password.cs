using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            checkBox_confirmPassword.Hide();
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
            if (checkBox_confirmPassword.Checked)
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
            lbl_passwordResetInstructions.Show();

            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";
            string memberEmail = txt_memberUsername.Text;
            string memberNIC = txt_memberNIC.Text;

            string verifyQuery = "SELECT COUNT(*) FROM libraryMember WHERE memberEmail = @memberEmail AND memberNIC = @memberNIC";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand verifyCmd = new SqlCommand(verifyQuery, connection);
                    verifyCmd.Parameters.Add("@memberEmail", SqlDbType.NVarChar).Value = memberEmail;
                    verifyCmd.Parameters.Add("@memberNIC", SqlDbType.NVarChar).Value = memberNIC;

                    connection.Open();
                    int result = (int)verifyCmd.ExecuteScalar();

                    if (result > 0)
                    {
                        lbl_passwordResetInstructions.Hide();

                        lbl_redStar.Show();
                        lbl_verifiedSuccessfully.Show();
                        lbl_newPassword.Show();
                        lbl_confirmPassword.Show();
                        lbl_dot1.Show();
                        lbl_dot2.Show();
                        txt_newPassword.Show();
                        txt_confirmPassword.Show();
                        checkBox_newPassword.Show();
                        checkBox_confirmPassword.Show();
                        btn_resetPassword.Show();
                        btn_Cancel.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or NIC. Please check again!");
                        txt_memberUsername.Clear();
                        txt_memberNIC.Clear();
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_resetPassword_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";
            string memberEmail = txt_memberUsername.Text;
            string memberNIC = txt_memberNIC.Text;
            string newPassword = txt_newPassword.Text;
            string confirmPassword = txt_confirmPassword.Text;

            if (newPassword == confirmPassword)
            {
                string updateQuery = "UPDATE libraryMember SET memberPassword = @newPassword WHERE memberEmail = @memberEmail AND memberNIC = @memberNIC";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand updateCmd = new SqlCommand(updateQuery, connection);
                        updateCmd.Parameters.Add("@newPassword", SqlDbType.NVarChar).Value = newPassword;
                        updateCmd.Parameters.Add("@memberEmail", SqlDbType.NVarChar).Value = memberEmail;
                        updateCmd.Parameters.Add("@memberNIC", SqlDbType.NVarChar).Value = memberNIC;

                        connection.Open();
                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully!");
                            
                            Home home = new Home();
                            home.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Password update failed.");
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("SQL Error: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match.");
                txt_newPassword.Clear();
                txt_confirmPassword.Clear();
            }
        }
    }
}
