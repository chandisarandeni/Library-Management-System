using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Library_Management_System.AdminLogin;

namespace Library_Management_System
{
    public partial class Admin_View_Return_Book : Form
    {
        bool slidebarExpand;
        private string memberNIC;

        public Admin_View_Return_Book(string memberNIC)
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

            lbl_adminID.Hide();
            lbl_adminName.Hide();
            lbl_dot1.Hide();
            lbl_dot2.Hide();
            lbl_showAdminID.Hide();
            lbl_showAdminName.Hide();

            this.memberNIC = memberNIC;
        }

        private void Admin_View_Return_Book_Load(object sender, EventArgs e)
        {
            pnl_bookDetails.Hide();

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


            LoadMemberDetails();
            LoadBorrowedBooks();
        }

        private void LoadBorrowedBooks()
        {
            string memberID = lbl_showMemberID.Text.Trim();  // Get the Member ID
            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";

            if (string.IsNullOrEmpty(memberID))
            {
                MessageBox.Show("Member ID is missing.");
                return;
            }

            string query = @"
        SELECT b.bookID 
        FROM borrowBook bb
        JOIN Book b ON bb.bookID = b.bookID
        WHERE bb.memberID = @memberID AND b.isAvailable = 'false'";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@memberID", memberID);

                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    txt_borrowedBooks.Items.Clear();  // Clear existing items in the combo box

                    while (reader.Read())
                    {
                        string bookID = reader["bookID"].ToString();
                        txt_borrowedBooks.Items.Add(bookID);  // Add bookID to combo box
                    }

                    reader.Close();

                    if (txt_borrowedBooks.Items.Count > 0)
                    {
                        txt_borrowedBooks.SelectedIndex = 0;  // Select the first item by default
                    }
                    else
                    {
                        MessageBox.Show("No borrowed books to return.");
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


        private void Admin_View_Borrow_Assign_Book_Load(object sender, EventArgs e)
        {
            LoadBorrowedBooks();  // Call the function when the form loads
        }



        private void LoadMemberDetails()
        {
            // Retrieve memberNIC (assuming it's provided in a TextBox)
            //string memberNIC = txt_memberNIC.Text.Trim();

            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";

            // Query to get member details (FullName, NIC, ID)
            string queryMember = @"SELECT memberID, memberFullName, memberNIC 
                           FROM libraryMember 
                           WHERE memberNIC = @memberNIC";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmdMember = new SqlCommand(queryMember, connection);
                    cmdMember.Parameters.AddWithValue("@memberNIC", memberNIC);

                    connection.Open();
                    SqlDataReader reader = cmdMember.ExecuteReader();

                    if (reader.Read())
                    {
                        // Retrieve and display member details
                        lbl_showMemberFullName.Text = reader["memberFullName"].ToString();
                        lbl_showMemberNIC.Text = reader["memberNIC"].ToString();
                        lbl_showMemberID.Text = reader["memberID"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Member not found.");
                    }

                    reader.Close();
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

        private void Admin_View_Return_Book_MouseClick(object sender, MouseEventArgs e)
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
            Admin_View_Inquiry_Management adminViewInventoryManagement = new Admin_View_Inquiry_Management();
            adminViewInventoryManagement.Show();
            this.Hide();
        }

        private void btn_Inquiries_Click(object sender, EventArgs e)
        {
            Admin_View_Inquiry_Management adminViewInquiryManagement = new Admin_View_Inquiry_Management();
            adminViewInquiryManagement.Show();
            this.Hide();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Admin_View_Borrow_Management adminViewBorrowManagement = new Admin_View_Borrow_Management();
            adminViewBorrowManagement.Show();
            this.Hide();
        }

        private void btn_AssignBook_Click(object sender, EventArgs e)
        {
            string memberID = lbl_showMemberID.Text.Trim();  // Get the Member ID
            string bookID = txt_borrowedBooks.Text.Trim();   // Get the selected Book ID from the combo box
            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";

            if (string.IsNullOrEmpty(memberID) || string.IsNullOrEmpty(bookID))
            {
                MessageBox.Show("Please select a book to return.");
                return;
            }

            // SQL queries
            string updateReturnQuery = @"
        UPDATE borrowBook 
        SET returnedDate = GETDATE() 
        WHERE memberID = @memberID AND bookID = @bookID";

            string updateBookAvailabilityQuery = @"
        UPDATE Book 
        SET isAvailable = 'true' 
        WHERE bookID = @bookID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Begin transaction
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // Step 1: Update borrowBook table to set the return date
                        SqlCommand cmdUpdateReturn = new SqlCommand(updateReturnQuery, connection, transaction);
                        cmdUpdateReturn.Parameters.AddWithValue("@memberID", memberID);
                        cmdUpdateReturn.Parameters.AddWithValue("@bookID", bookID);
                        int rowsAffected = cmdUpdateReturn.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Return failed. The book may have already been returned or was not borrowed.");
                            return;
                        }

                        // Step 2: Update Book table to set isAvailable to true
                        SqlCommand cmdUpdateBook = new SqlCommand(updateBookAvailabilityQuery, connection, transaction);
                        cmdUpdateBook.Parameters.AddWithValue("@bookID", bookID);
                        cmdUpdateBook.ExecuteNonQuery();

                        // Commit transaction
                        transaction.Commit();
                        MessageBox.Show("Book returned successfully.");

                        Admin_View_Borrow_Management adminViewBorrowManagement = new Admin_View_Borrow_Management();
                        adminViewBorrowManagement.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        // Rollback on error
                        transaction.Rollback();
                        MessageBox.Show("Error during return: " + ex.Message);
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
            string bookID = txt_borrowedBooks.Text.Trim();

            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";

            string query = @"
                    SELECT b.bookTitle, b.bookAuthor, b.bookType, bb.borrowedDate
                    FROM borrowBook bb
                    JOIN Book b ON bb.bookID = b.bookID
                    WHERE bb.bookID = @bookID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    pnl_bookDetails.Show();

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@bookID", bookID);

                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lbl_showBookTitle.Text = reader["bookTitle"].ToString();
                        lbl_showBookAuthor.Text = reader["bookAuthor"].ToString();
                        lbl_showBookType.Text = reader["bookType"].ToString();

                        // Calculate overdue status
                        DateTime borrowedDate = (DateTime)reader["borrowedDate"];
                        int overdueDays = (DateTime.Now - borrowedDate).Days;
                        if (overdueDays > 0)
                        {
                            lbl_isOverDue.Text = $"Overdue by {overdueDays} days";
                        }
                        else
                        {
                            lbl_isOverDue.Text = "Not Overdue";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Book details not found.");
                    }

                    reader.Close();
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
