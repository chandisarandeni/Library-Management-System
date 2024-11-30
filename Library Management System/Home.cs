using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

            btn_Cancel.TabStop = false;
            lbl_forgotPassword.TabStop = false;
            lbl_getHelp.TabStop = false;
            checkBox_showPassword.TabStop = false;
            btn_Login.TabStop = false;
        }

        public class MemberLoginState
        {
            public bool IsLoggedIn { get; set; }
            public string MemberEmail { get; set; }
        }

        public static class MemberLoginStateManager
        {
            private static string filePath = "memberLoginState.json";

            public static void SaveLoginState(MemberLoginState state)
            {
                string json = JsonConvert.SerializeObject(state, Formatting.Indented);
                File.WriteAllText(filePath, json);
            }

            public static MemberLoginState LoadLoginState()
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    return JsonConvert.DeserializeObject<MemberLoginState>(json);
                }
                return new MemberLoginState { IsLoggedIn = false };
            }
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

            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";
            string memberEmail = txt_memberUsername.Text;
            string memberPassword = txt_memberPassword.Text;

            string query = "SELECT COUNT(*) FROM libraryMember WHERE memberEmail = @memberEmail AND memberPassword = @memberPassword";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@memberEmail", memberEmail);
                    cmd.Parameters.AddWithValue("@memberPassword", memberPassword);

                    connection.Open();
                    int result = (int)cmd.ExecuteScalar();

                    if (result > 0)
                    {
                        // Save login state
                        MemberLoginState loginState = new MemberLoginState
                        {
                            IsLoggedIn = true,
                            MemberEmail = memberEmail
                        };
                        MemberLoginStateManager.SaveLoginState(loginState);


                        Member_Dashboard memberDashboard = new Member_Dashboard();
                        memberDashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password.");
                        txt_memberUsername.Clear();
                        txt_memberPassword.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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

        private void txt_memberPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
