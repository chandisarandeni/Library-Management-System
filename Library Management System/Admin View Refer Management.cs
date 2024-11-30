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
    public partial class Admin_View_Refer_Management : Form
    {
        bool slidebarExpand;
        public Admin_View_Refer_Management()
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
        }

        private void Admin_View_Refer_Management_Load(object sender, EventArgs e)
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



            lbl_returnHover.Hide();
            lbl_returnHover.Text = "";

            pnl_Instructions.Show();
            pnl_bookDetails.Hide();
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

        private void Admin_View_Refer_Management_MouseClick(object sender, MouseEventArgs e)
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

        private void btn_returnBook_Click(object sender, EventArgs e)
        {
            Admin_View_Refer_Returns adminViewReferReturns = new Admin_View_Refer_Returns();
            adminViewReferReturns.Show();
            this.Hide();
        }

        Timer textTimer = new Timer { Interval = 30 };
        int textPosition = 0;
        string hoverText = "";
        private void btn_returnBook_MouseHover(object sender, EventArgs e)
        {
            textTimer.Tick += (s, args) =>
            {
                if (textPosition < hoverText.Length)
                {
                    lbl_returnHover.Text += hoverText[textPosition];
                    textPosition++;
                }
                else
                {
                    textTimer.Stop();
                }
            };
            textPosition = 0;
            lbl_returnHover.Text = "Return";
            textTimer.Start();
        }

        private void btn_returnBook_MouseLeave(object sender, EventArgs e)
        {
            lbl_returnHover.Text = "";
            textTimer.Stop(); // Stop if the cursor leaves
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Admin_View_Refer_Management adminViewReferManagement = new Admin_View_Refer_Management();
            adminViewReferManagement.Show();
            this.Hide();
        }

        private void btn_searchMember_Click(object sender, EventArgs e)
        {
            string visitorNIC = txt_searchVisitorNIC.Text.Trim();  // Get NIC from input
            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";

            if (string.IsNullOrEmpty(visitorNIC))
            {
                MessageBox.Show("Please enter Visitor NIC.");
                return;
            }

            string query = @"
        SELECT visitorFullName, visitorNIC 
        FROM referBook 
        WHERE visitorNIC = @visitorNIC";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@visitorNIC", visitorNIC);

                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Display visitor data
                        txt_visitorFullName.Text = reader["visitorFullName"].ToString();
                        txt_visitorNIC.Text = reader["visitorNIC"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Visitor not found.");
                        txt_visitorFullName.Clear();
                        txt_visitorNIC.Clear();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_searchBook_Click(object sender, EventArgs e)
        {
            string bookID = txt_bookID.Text.Trim();  // Get Book ID from input
            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";

            if (string.IsNullOrEmpty(bookID))
            {
                MessageBox.Show("Please enter a Book ID.");
                return;
            }

            string query = @"
        SELECT bookTitle, bookAuthor, bookType 
        FROM Book 
        WHERE bookID = @bookID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    pnl_Instructions.Hide();
                    pnl_bookDetails.Show();
                    pnl_memberDetails.Show();

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@bookID", bookID);

                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Display book details
                        lbl_showBookTitle.Text = reader["bookTitle"].ToString();
                        lbl_showBookAuthor.Text = reader["bookAuthor"].ToString();
                        lbl_showBookType.Text = reader["bookType"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Book not found.");
                        lbl_showBookTitle.Text = "";
                        lbl_showBookAuthor.Text = "";
                        lbl_showBookType.Text = "";
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_referBook_Click(object sender, EventArgs e)
        {
            string bookID = txt_bookID.Text.Trim();            // Get Book ID from input
            string visitorNIC = txt_visitorNIC.Text.Trim();     // Get Visitor NIC from input
            string visitorFullName = txt_visitorFullName.Text.Trim(); // Get Visitor Full Name from input
            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";

            if (string.IsNullOrEmpty(bookID) || string.IsNullOrEmpty(visitorNIC) || string.IsNullOrEmpty(visitorFullName))
            {
                MessageBox.Show("Please provide Book ID, Visitor NIC, and Visitor Full Name.");
                return;
            }

            string insertQuery = @"
INSERT INTO referBook (referID, bookID, visitorNIC, visitorFullName, referedDate, isReturned)
VALUES (NEWID(), @bookID, @visitorNIC, @visitorFullName, GETDATE(), 'false')";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmdInsert = new SqlCommand(insertQuery, connection);
                    cmdInsert.Parameters.AddWithValue("@bookID", bookID);
                    cmdInsert.Parameters.AddWithValue("@visitorNIC", visitorNIC);
                    cmdInsert.Parameters.AddWithValue("@visitorFullName", visitorFullName);

                    connection.Open();
                    int rowsAffected = cmdInsert.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Book referred successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to refer the book.");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
