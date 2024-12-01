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
    public partial class Admin_View_Borrow_Management : Form
    {
        bool slidebarExpand;
        public Admin_View_Borrow_Management()
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

        private void btn_checkoutBook_Click(object sender, EventArgs e)
        {
            int numberOfBooks = 0;
            if (int.TryParse(lbl_showNumberOfBooks.Text, out numberOfBooks) && numberOfBooks <= 5)
            {
                Admin_View_Borrow_Assign_Book adminViewBorrowAssignBook = new Admin_View_Borrow_Assign_Book(txt_memberNIC.Text);
                adminViewBorrowAssignBook.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Member has reached the maximum number of books that can be borrowed.");
            }
        }

        private void Admin_View_Borrow_Management_Load(object sender, EventArgs e)
        {
            lbl_checkoutBookHover.Text = "";
            lbl_returnBookHover.Text = "";

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

            pnl_instructions.Show();
            pnl_memberDetails.Hide();
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

        private void Admin_View_Borrow_Management_MouseClick(object sender, MouseEventArgs e)
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

        private void btn_returnBook_Click(object sender, EventArgs e)
        {
            Admin_View_Return_Book adminViewReturnBook = new Admin_View_Return_Book(txt_memberNIC.Text);
            adminViewReturnBook.Show();
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string memberNIC = txt_memberNIC.Text.Trim(); // Get NIC from the input
            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";

            // Query to get memberID and memberFullName based on NIC
            string queryMember = @"SELECT memberID, memberFullName, memberNIC 
                       FROM libraryMember 
                       WHERE memberNIC = @memberNIC";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    pnl_instructions.Hide();
                    pnl_memberDetails.Show();

                    SqlCommand cmdMember = new SqlCommand(queryMember, connection);
                    cmdMember.Parameters.AddWithValue("@memberNIC", memberNIC);

                    connection.Open();
                    SqlDataReader reader = cmdMember.ExecuteReader();

                    if (reader.Read())
                    {
                        // Retrieve and display member details
                        string memberID = reader["memberID"].ToString();
                        lbl_showMemberFullName.Text = reader["memberFullName"].ToString();
                        lbl_showMemberNIC.Text = reader["memberNIC"].ToString();

                        // After retrieving memberID, get borrow details for the member where books are unavailable (isAvailable = 'false')
                        string queryBorrow = @"
    SELECT b.borrowID, b.bookID, b.borrowedDate, b.returnDate, bk.isAvailable 
    FROM borrowBook b
    INNER JOIN Book bk ON b.bookID = bk.bookID
    WHERE b.memberID = @memberID AND bk.isAvailable = 'false'"; // 'false' as string

                        SqlCommand cmdBorrow = new SqlCommand(queryBorrow, connection);
                        cmdBorrow.Parameters.AddWithValue("@memberID", memberID);

                        reader.Close(); // Close the previous reader

                        SqlDataReader borrowReader = cmdBorrow.ExecuteReader();

                        // Clear previous data from the listView
                        listView_borrowDetails.Items.Clear();

                        int numberOfBooks = 0;

                        while (borrowReader.Read())
                        {
                            string bookID = borrowReader["bookID"].ToString();
                            string borrowedDate = borrowReader["borrowedDate"].ToString();
                            string returnDate = borrowReader["returnDate"].ToString();
                            string isAvailable = borrowReader["isAvailable"].ToString();

                            // Add each borrowed book to the listView
                            ListViewItem item = new ListViewItem(bookID);
                            item.SubItems.Add(borrowedDate);
                            item.SubItems.Add(returnDate);

                            // Check if the book is available
                            if (isAvailable == "false")
                            {
                                item.SubItems.Add("Not Available");
                            }
                            else
                            {
                                item.SubItems.Add("Available");
                            }

                            listView_borrowDetails.Items.Add(item);
                            numberOfBooks++; // Count the number of books
                        }

                        // Show the number of books borrowed
                        lbl_showNumberOfBooks.Text = numberOfBooks.ToString();

                        // If no books are found, hide the listView
                        if (numberOfBooks == 0)
                        {
                            listView_borrowDetails.Visible = false;
                        }
                        else
                        {
                            listView_borrowDetails.Visible = true;
                        }
                    }
                    else
                    {
                        pnl_memberDetails.Hide();
                        pnl_instructions.Show();

                        MessageBox.Show("Member not found.");
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

        private void LoadBorrowedBooks(string memberID)
        {
            listView_borrowDetails.Items.Clear();
            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";
            string query = @"SELECT b.bookID, b.bookTitle 
                     FROM borrowBook bb 
                     INNER JOIN Book b ON bb.bookID = b.bookID 
                     WHERE bb.memberID = @memberID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@memberID", memberID);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        listView_borrowDetails.Show(); // Show the list if there are borrowed books
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["bookID"].ToString());
                            item.SubItems.Add(reader["bookTitle"].ToString());
                            listView_borrowDetails.Items.Add(item);
                        }
                    }
                    else
                    {
                        listView_borrowDetails.Hide(); // Hide the list if no borrowed books
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


        Timer textTimer = new Timer { Interval = 30 };
        int textPosition = 0;
        string hoverText = "";
        private void btn_checkoutBook_MouseHover(object sender, EventArgs e)
        {
            textTimer.Tick += (s, args) =>
            {
                if (textPosition < hoverText.Length)
                {
                    lbl_checkoutBookHover.Text += hoverText[textPosition];
                    textPosition++;
                }
                else
                {
                    textTimer.Stop();
                }
            };
            textPosition = 0;
            lbl_checkoutBookHover.Text = "Checkout";
            textTimer.Start();
        }

        private void btn_checkoutBook_MouseLeave(object sender, EventArgs e)
        {
            lbl_checkoutBookHover.Text = "";
            textTimer.Stop(); // Stop if the cursor leaves
        }

        private void btn_returnBook_MouseHover(object sender, EventArgs e)
        {
            textTimer.Tick += (s, args) =>
            {
                if (textPosition < hoverText.Length)
                {
                    lbl_returnBookHover.Text += hoverText[textPosition];
                    textPosition++;
                }
                else
                {
                    textTimer.Stop();
                }
            };
            textPosition = 0;
            lbl_returnBookHover.Text = "Checkout";
            textTimer.Start();
        }

        private void btn_returnBook_MouseLeave(object sender, EventArgs e)
        {
            lbl_returnBookHover.Text = "";
            textTimer.Stop(); // Stop if the cursor leaves
        }
    }
}
