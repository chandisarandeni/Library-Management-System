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
    public partial class Admin_View_Book_Registration : Form
    {
        bool slidebarExpand;
        public Admin_View_Book_Registration()
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
            btn_registerBook.TabStop = false;
            btn_Cancel.TabStop = false;

            txt_bookTitle.TabIndex = 0;
            txt_bookAuthor.TabIndex = 1;
            txt_bookISBN.TabIndex = 2;
            txt_bookCategory.TabIndex = 3;
            txt_bookPublisher.TabIndex = 4;
            txt_bookType.TabIndex = 5;
            txt_bookLanguage.TabIndex = 6;
            txt_bookAdditional.TabIndex = 7;
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Admin_View_Book_Management adminViewBookManagement = new Admin_View_Book_Management();
            adminViewBookManagement.Show();
            this.Hide();
        }

        private void Admin_View_Book_Registration_Load(object sender, EventArgs e)
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

        private void Admin_View_Book_Registration_MouseClick(object sender, MouseEventArgs e)
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

        private void btn_registerBook_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";

            // Collect the book details from the form
            string bookTitle = txt_bookTitle.Text;
            string bookAuthor = txt_bookAuthor.Text;
            string bookISBN = txt_bookISBN.Text;
            string bookCategory = txt_bookCategory.Text;
            string bookPublisher = txt_bookPublisher.Text;
            string bookType = txt_bookType.Text;
            string bookLanguage = txt_bookLanguage.Text;
            string bookAdditional = txt_bookAdditional.Text;

            // Get the latest book ID from the database and generate the new one
            string newBookID = GenerateBookID();

            // Get the current date for the book registration
            DateTime currentDate = DateTime.Now;

            // Set isAvailable to 'true' (can be passed explicitly or derived from frontend)
            string isAvailable = "true";  // Pass 'true' explicitly from the frontend

            // SQL query to insert a new book record into the database
            string query = "INSERT INTO Book (bookID, bookTitle, bookAuthor, bookISBN, bookCategory, bookPublisher, bookType, bookLanguage, bookAdditional, bookRegistrationDate, isAvailable) " +
                           "VALUES (@bookID, @bookTitle, @bookAuthor, @bookISBN, @bookCategory, @bookPublisher, @bookType, @bookLanguage, @bookAdditional, @bookRegistrationDate, @isAvailable)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);

                    // Add parameters to the query
                    cmd.Parameters.Add("@bookID", SqlDbType.NVarChar).Value = newBookID;
                    cmd.Parameters.Add("@bookTitle", SqlDbType.NVarChar).Value = bookTitle;
                    cmd.Parameters.Add("@bookAuthor", SqlDbType.VarChar).Value = bookAuthor;
                    cmd.Parameters.Add("@bookISBN", SqlDbType.NVarChar).Value = bookISBN;
                    cmd.Parameters.Add("@bookCategory", SqlDbType.VarChar).Value = bookCategory;
                    cmd.Parameters.Add("@bookPublisher", SqlDbType.VarChar).Value = bookPublisher;
                    cmd.Parameters.Add("@bookType", SqlDbType.VarChar).Value = bookType;
                    cmd.Parameters.Add("@bookLanguage", SqlDbType.VarChar).Value = bookLanguage;
                    cmd.Parameters.Add("@bookAdditional", SqlDbType.NVarChar).Value = bookAdditional;
                    cmd.Parameters.Add("@bookRegistrationDate", SqlDbType.Date).Value = currentDate;
                    cmd.Parameters.Add("@isAvailable", SqlDbType.VarChar).Value = isAvailable;  // Pass the 'true' value explicitly

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book registered successfully.");

                    // Optionally, clear the form fields after registration
                    ClearForm();

                    Admin_View_Book_Management adminViewBookManagement = new Admin_View_Book_Management();
                    adminViewBookManagement.Show();
                    this.Hide();
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

        private string GenerateBookID()
        {
            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";
            string query = "SELECT TOP 1 bookID FROM Book ORDER BY bookID DESC";

            string lastBookID = string.Empty;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lastBookID = reader["bookID"].ToString();
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Error: " + sqlEx.Message);
            }

            // Generate new book ID based on the last one (e.g., B-0001 -> B-0002)
            if (!string.IsNullOrEmpty(lastBookID))
            {
                string lastIDNumber = lastBookID.Substring(2);  // Remove "B-" part
                int nextIDNumber = int.Parse(lastIDNumber) + 1;
                return "B-" + nextIDNumber.ToString("D4");  // Format as B-0001, B-0002, etc.
            }

            // If no book ID exists, start with B-0001
            return "B-0001";
        }

        private void ClearForm()
        {
            txt_bookTitle.Clear();
            txt_bookAuthor.Clear();
            txt_bookISBN.Clear();
            txt_bookCategory.ResetText();
            txt_bookPublisher.Clear();
            txt_bookType.ResetText();
            txt_bookLanguage.ResetText();
            txt_bookAdditional.Clear();
        }
    }
}
