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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();

            txt_adminUsername.TabIndex = 0;
            txt_adminPassword.TabIndex = 1;

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
            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";
            string adminUsername = txt_adminUsername.Text;
            string adminPassword = txt_adminPassword.Text;

            string query = "SELECT COUNT(*) FROM adminData WHERE adminUsername = @adminUsername AND adminPassword = @password";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@adminUsername", SqlDbType.NVarChar).Value = adminUsername;
                    cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = adminPassword;

                    connection.Open();
                    int result = (int)cmd.ExecuteScalar();

                    if (result > 0)
                    {
                        Admin_Dashboard adminDashboard = new Admin_Dashboard();
                        adminDashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                        txt_adminUsername.Clear();
                        txt_adminPassword.Clear();
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
