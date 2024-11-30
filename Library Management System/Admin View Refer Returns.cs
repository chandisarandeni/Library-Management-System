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
    public partial class Admin_View_Refer_Returns : Form
    {
        bool slidebarExpand;
        public Admin_View_Refer_Returns()
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

        private void Admin_View_Refer_Returns_Load(object sender, EventArgs e)
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

        private void Admin_View_Refer_Returns_MouseClick(object sender, MouseEventArgs e)
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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Admin_View_Refer_Management adminViewReferManagement = new Admin_View_Refer_Management();
            adminViewReferManagement.Show();
            this.Hide();
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
            string visitorNIC = txt_visitorNIC.Text.Trim();  // Get Visitor NIC from input
            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";

            if (string.IsNullOrEmpty(visitorNIC))
            {
                MessageBox.Show("Please provide a valid Visitor NIC.");
                return;
            }

            // SQL query to update the isReturned field for the latest reference
            string updateReferQuery = @"
UPDATE referBook 
SET isReturned = 'true', referedDate = GETDATE() 
WHERE visitorNIC = @visitorNIC AND isReturned = 'false'";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand cmdUpdateRefer = new SqlCommand(updateReferQuery, connection);
                    cmdUpdateRefer.Parameters.AddWithValue("@visitorNIC", visitorNIC);

                    int rowsAffected = cmdUpdateRefer.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("Return failed. No unreturned book found for this Visitor NIC.");
                    }
                    else
                    {
                        MessageBox.Show("Referred book returned successfully.");
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

        private void btn_searchMember_Click(object sender, EventArgs e)
        {
            string visitorNIC = txt_visitorNIC.Text.Trim();  // Get Visitor NIC from input
            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";

            if (string.IsNullOrEmpty(visitorNIC))
            {
                MessageBox.Show("Please provide a valid Visitor NIC.");
                return;
            }

            // SQL queries to get visitor details and referred books
            string queryVisitor = @"
SELECT visitorNIC, visitorFullName 
FROM referBook 
WHERE visitorNIC = @visitorNIC";

            string queryReferredBooks = @"
SELECT bookID 
FROM referBook 
WHERE visitorNIC = @visitorNIC AND isReturned = 'false'";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Retrieve visitor details
                    SqlCommand cmdVisitor = new SqlCommand(queryVisitor, connection);
                    cmdVisitor.Parameters.AddWithValue("@visitorNIC", visitorNIC);
                    SqlDataReader reader = cmdVisitor.ExecuteReader();

                    if (reader.Read())
                    {
                        lbl_showVisitorNIC.Text = reader["visitorNIC"].ToString();
                        lbl_showVisitorFullName.Text = reader["visitorFullName"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Visitor not found.");
                        return;
                    }

                    reader.Close();  // Close the reader before the next query

                    // Retrieve referred books
                    SqlCommand cmdReferredBooks = new SqlCommand(queryReferredBooks, connection);
                    cmdReferredBooks.Parameters.AddWithValue("@visitorNIC", visitorNIC);
                    SqlDataReader booksReader = cmdReferredBooks.ExecuteReader();

                    txt_refferedBooks.Items.Clear();  // Clear existing items

                    while (booksReader.Read())
                    {
                        string bookID = booksReader["bookID"].ToString();
                        txt_refferedBooks.Items.Add(bookID);  // Add book ID to the combo box
                    }

                    if (txt_refferedBooks.Items.Count > 0)
                    {
                        txt_refferedBooks.SelectedIndex = 0;  // Select the first item by default
                    }
                    else
                    {
                        MessageBox.Show("No referred books to return.");
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
            string bookID = txt_refferedBooks.Text.Trim();  // Get Book ID from txt_refferedBooks input
            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";

            if (string.IsNullOrEmpty(bookID))
            {
                MessageBox.Show("Please provide a Book ID.");
                return;
            }

            string queryBook = @"
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

                    SqlCommand cmdBook = new SqlCommand(queryBook, connection);
                    cmdBook.Parameters.AddWithValue("@bookID", bookID);

                    connection.Open();
                    SqlDataReader reader = cmdBook.ExecuteReader();

                    if (reader.Read())
                    {
                        lbl_showBookTitle.Text = reader["bookTitle"].ToString();
                        lbl_showBookAuthor.Text = reader["bookAuthor"].ToString();
                        lbl_showBookType.Text = reader["bookType"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Book not found.");
                        lbl_showBookTitle.Text = string.Empty;
                        lbl_showBookAuthor.Text = string.Empty;
                        lbl_showBookType.Text = string.Empty;
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
