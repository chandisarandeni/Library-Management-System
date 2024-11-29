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
    public partial class Admin_Forgot_Password : Form
    {
        public Admin_Forgot_Password()
        {
            InitializeComponent();
            btn_Verify.TabStop = false;
            btn_Back.TabStop = false;
            btn_resetPassword.TabStop = false;
            btn_Cancel.TabStop = false;
            checkBox_newPassword.TabStop = false;
            checkBox_condirmPassword.TabStop = false;

            txt_adminUsername.TabIndex = 0;
            txt_adminNIC.TabIndex = 1;
            txt_newPassword.TabIndex = 2;
            txt_confirmPassword.TabIndex = 3;
        }

        private void Admin_Forgot_Password_Load(object sender, EventArgs e)
        {
            //Showing feilds
            lbl_passwordResetInstructions.Show();

            //Hiding feilds
            lbl_Star.Hide();
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

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_passwordResetInstructions.Show();

            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";
            string adminUsername = txt_adminUsername.Text;
            string adminNIC = txt_adminNIC.Text;

            string verifyQuery = "SELECT COUNT(*) FROM adminData WHERE adminUsername = @adminUsername AND adminNIC = @adminNIC";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand verifyCmd = new SqlCommand(verifyQuery, connection);
                    verifyCmd.Parameters.Add("@adminUsername", SqlDbType.NVarChar).Value = adminUsername;
                    verifyCmd.Parameters.Add("@adminNIC", SqlDbType.NVarChar).Value = adminNIC;

                    connection.Open();
                    int result = (int)verifyCmd.ExecuteScalar();

                    if (result > 0)
                    {
                        lbl_passwordResetInstructions.Hide();

                        lbl_Star.Show();
                        lbl_verifiedSuccessfully.Show();
                        lbl_newPassword.Show();
                        lbl_confirmPassword.Show();
                        lbl_dot1.Show();
                        lbl_dot2.Show();
                        txt_newPassword.Show();
                        txt_confirmPassword.Show();
                        checkBox_newPassword.Show();
                        checkBox_condirmPassword.Show();
                        btn_resetPassword.Show();
                        btn_Cancel.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or NIC. Please check again!");
                        
                        txt_adminUsername.Clear();
                        txt_adminNIC.Clear();
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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Admin_Forgot_Password admin_Forgot_Password = new Admin_Forgot_Password();
            admin_Forgot_Password.Show();
            this.Hide();
        }

        private void btn_resetPassword_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";
            string adminUsername = txt_adminUsername.Text;
            string adminNIC = txt_adminNIC.Text;
            string newPassword = txt_newPassword.Text;
            string confirmPassword = txt_confirmPassword.Text;

            if (newPassword == confirmPassword)
            {
                string updateQuery = "UPDATE adminData SET adminPassword = @newPassword WHERE adminUsername = @adminUsername AND adminNIC = @adminNIC";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand updateCmd = new SqlCommand(updateQuery, connection);
                        updateCmd.Parameters.Add("@newPassword", SqlDbType.NVarChar).Value = newPassword;
                        updateCmd.Parameters.Add("@adminUsername", SqlDbType.NVarChar).Value = adminUsername;
                        updateCmd.Parameters.Add("@adminNIC", SqlDbType.NVarChar).Value = adminNIC;

                        connection.Open();
                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully!");
                            
                            AdminLogin adminLogin = new AdminLogin();
                            adminLogin.Show();
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
