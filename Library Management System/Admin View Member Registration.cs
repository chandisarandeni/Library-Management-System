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
using static Library_Management_System.AdminLogin;

namespace Library_Management_System
{
    public partial class Admin_View_Member_Registration : Form
    {
        bool slidebarExpand;
        public Admin_View_Member_Registration()
        {
            InitializeComponent();

            btn_Dashboard.TabStop = false;
            btn_Books.TabStop = false;
            btn_Members.TabStop = false;
            btn_Borrow.TabStop = false;
            btn_Refer.TabStop = false;
            btn_Reservation.TabStop = false;
            btn_Inventory.TabStop = false;
            btn_Inquiries.TabStop = false;
            btn_registerMember.TabStop = false;
            btn_Cancel.TabStop = false;

            txt_memberFullName.TabIndex = 0;
            txt_memberNIC.TabIndex = 1;
            txt_memberAddress.TabIndex = 2;
            txt_memberGender.TabIndex = 3;
            txt_memberContact.TabIndex = 4;
            txt_memberEmail.TabIndex = 5;
            txt_memberPassword.TabIndex = 6;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Admin_View_Member_Management adminViewMemberManagement = new Admin_View_Member_Management();
            adminViewMemberManagement.Show();
            this.Hide();
        }

        private void Admin_View_Member_Registration_Load(object sender, EventArgs e)
        {
            // Load the login state from the JSON file
            LoginState loginState = LoginStateManager.LoadLoginState();

            // Check if the admin is logged in
            if (!loginState.IsLoggedIn)
            {
                // If not logged in, redirect to the login form
                AdminLogin adminLogin = new AdminLogin();
                adminLogin.Show();
                this.Hide();
            }
            else
            {
                // Ensure the state is consistent with the collapsed slide bar
                slidebar.Width = slidebar.MinimumSize.Width;
                slidebarExpand = false;

                lbl_adminID.Hide();
                lbl_adminName.Hide();
                lbl_dot1.Hide();
                lbl_dot2.Hide();
                lbl_showAdminID.Hide();
                lbl_showAdminName.Hide();

                string adminUsername = loginState.AdminUsername;

                // Now retrieve the Admin ID and Name from the database using the saved adminUsername
                string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";
                string query = "SELECT adminID, adminName FROM adminData WHERE adminUsername = @adminUsername";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.Add("@adminUsername", SqlDbType.NVarChar).Value = adminUsername;

                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // Fetch Admin ID and Name from the database
                            string adminID = reader["adminID"].ToString();
                            string adminName = reader["adminName"].ToString();

                            // Update the labels with Admin ID and Name
                            lbl_showAdminID.Text = adminID;
                            lbl_showAdminName.Text = adminName;

                            lbl_adminID.Hide();
                            lbl_adminName.Hide();
                            lbl_dot1.Hide();
                            lbl_dot2.Hide();
                            lbl_showAdminID.Hide();
                            lbl_showAdminName.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Admin details not found.");
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

            btn_Dashboard.TabStop = false;
            btn_Books.TabStop = false;
            btn_Members.TabStop = false;
            btn_Borrow.TabStop = false;
            btn_Refer.TabStop = false;
            btn_Reservation.TabStop = false;
            btn_Inventory.TabStop = false;
            btn_Inquiries.TabStop = false;

            lbl_adminID.Hide();
            lbl_adminName.Hide();
            lbl_dot1.Hide();
            lbl_dot2.Hide();
            lbl_showAdminID.Hide();
            lbl_showAdminName.Hide();
        }

        private void slidebarTimer_Tick(object sender, EventArgs e)
        {
            // Adjust slide speed with timer's interval
            slidebarTimer.Interval = 10; // Faster update rate for smoother animation

            if (slidebarExpand)
            {
                // If the slidebar is expanded
                slidebar.Width -= 10; // Small step for smoother effect
                if (slidebar.Width <= slidebar.MinimumSize.Width)
                {
                    slidebar.Width = slidebar.MinimumSize.Width; // Snap to minimum
                    slidebarExpand = false;
                    slidebarTimer.Stop();

                    lbl_adminID.Hide();
                    lbl_adminName.Hide();
                    lbl_dot1.Hide();
                    lbl_dot2.Hide();
                    lbl_showAdminID.Hide();
                    lbl_showAdminName.Hide();
                }
            }
            else
            {
                // If the slidebar is collapsed
                slidebar.Width += 10; // Small step for smoother effect
                if (slidebar.Width >= slidebar.MaximumSize.Width)
                {
                    slidebar.Width = slidebar.MaximumSize.Width; // Snap to maximum
                    slidebarExpand = true;
                    slidebarTimer.Stop();

                    lbl_adminID.Show();
                    lbl_adminName.Show();
                    lbl_dot1.Show();
                    lbl_dot2.Show();
                    lbl_showAdminID.Show();
                    lbl_showAdminName.Show();
                }
            }
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            slidebarTimer.Start();
        }

        private void Admin_View_Member_Registration_MouseClick(object sender, MouseEventArgs e)
        {
            // Check if the click is outside the slidebar area
            if (!slidebar.ClientRectangle.Contains(e.Location))
            {
                if (slidebarExpand)
                {
                    slidebarTimer.Start(); // Start the timer to collapse the slidebar
                }
            }
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            Admin_Dashboard adminDashboard = new Admin_Dashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void btn_Books_Click(object sender, EventArgs e)
        {
            Admin_View_Book_Management adminViewBookManagement = new Admin_View_Book_Management();
            adminViewBookManagement.Show();
            this.Hide();
        }

        private void btn_Members_Click(object sender, EventArgs e)
        {
            Admin_View_Member_Management adminViewMemberManagement = new Admin_View_Member_Management();
            adminViewMemberManagement.Show();
            this.Hide();
        }

        private void btn_Borrow_Click(object sender, EventArgs e)
        {
            Admin_View_Borrow_Management adminViewBorrowManagement = new Admin_View_Borrow_Management();
            adminViewBorrowManagement.Show();
            this.Hide();
        }

        private void btn_Refer_Click(object sender, EventArgs e)
        {
            Admin_View_Refer_Management adminViewReferManagement = new Admin_View_Refer_Management();
            adminViewReferManagement.Show();
            this.Hide();
        }

        private void btn_Reservation_Click(object sender, EventArgs e)
        {
            Admin_View_Reservation_Management adminViewReservationManagement = new Admin_View_Reservation_Management();
            adminViewReservationManagement.Show();
            this.Hide();
        }

        private void btn_Inventory_Click(object sender, EventArgs e)
        {
            Admin_View_Inventory_Management adminViewInventoryManagement = new Admin_View_Inventory_Management();
            adminViewInventoryManagement.Show();
            this.Hide();
        }

        private void btn_Inquiries_Click(object sender, EventArgs e)
        {
            Admin_View_Inquiry_Management adminViewInquiryManagement = new Admin_View_Inquiry_Management();
            adminViewInquiryManagement.Show();
            this.Hide();
        }

        private void btn_registerMember_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";

            // Collect member details from the form
            string memberFullName = txt_memberFullName.Text;
            string memberNIC = txt_memberNIC.Text;
            string memberAddress = txt_memberAddress.Text;
            string memberGender = txt_memberGender.Text;
            string memberContact = txt_memberContact.Text;
            string memberEmail = txt_memberEmail.Text;
            string memberPassword = txt_memberPassword.Text;

            // Generate a unique member ID (e.g., M-0001, M-0002, etc.)
            string newMemberID = GenerateMemberID();

            // Get the current date for registration
            DateTime registrationDate = DateTime.Now;

            // SQL query to insert a new member record into the database
            string query = "INSERT INTO libraryMember (memberID, memberFullName, memberNIC, memberAddress, memberGender, memberContact, memberEmail, memberPassword, memberRegistrationDate) " +
                           "VALUES (@memberID, @memberFullName, @memberNIC, @memberAddress, @memberGender, @memberContact, @memberEmail, @memberPassword, @memberRegistrationDate)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);

                    // Add parameters to the query
                    cmd.Parameters.Add("@memberID", SqlDbType.NVarChar).Value = newMemberID;
                    cmd.Parameters.Add("@memberFullName", SqlDbType.NVarChar).Value = memberFullName;
                    cmd.Parameters.Add("@memberNIC", SqlDbType.NVarChar).Value = memberNIC;
                    cmd.Parameters.Add("@memberAddress", SqlDbType.NVarChar).Value = memberAddress;
                    cmd.Parameters.Add("@memberGender", SqlDbType.NVarChar).Value = memberGender;
                    cmd.Parameters.Add("@memberContact", SqlDbType.NVarChar).Value = memberContact;
                    cmd.Parameters.Add("@memberEmail", SqlDbType.NVarChar).Value = memberEmail;
                    cmd.Parameters.Add("@memberPassword", SqlDbType.NVarChar).Value = memberPassword;
                    cmd.Parameters.Add("@memberRegistrationDate", SqlDbType.Date).Value = registrationDate;

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member registered successfully.");

                    Admin_View_Member_Management adminViewMemberManagement = new Admin_View_Member_Management();
                    adminViewMemberManagement.Show();
                    this.Hide();

                    // Clear the form fields after successful registration
                    ClearFormFields();
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

        // Method to generate unique member ID (e.g., M-0001, M-0002)
        private string GenerateMemberID()
        {
            string prefix = "M-";
            int newIDNumber = 1;

            // Fetch the latest memberID from the database to calculate the next ID
            string query = "SELECT TOP 1 memberID FROM libraryMember ORDER BY memberID DESC";
            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    string latestID = result.ToString();
                    newIDNumber = int.Parse(latestID.Split('-')[1]) + 1;
                }
            }

            return prefix + newIDNumber.ToString("D4");
        }

        // Method to clear form fields after registration
        private void ClearFormFields()
        {
            txt_memberFullName.Clear();
            txt_memberNIC.Clear();
            txt_memberAddress.Clear();
            txt_memberGender.ResetText();
            txt_memberContact.Clear();
            txt_memberEmail.Clear();
            txt_memberPassword.Clear();
        }
    }
}
