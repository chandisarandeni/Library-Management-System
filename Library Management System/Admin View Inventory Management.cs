using Guna.UI2.WinForms;
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
    public partial class Admin_View_Inventory_Management : Form
    {
        bool slidebarExpand;
        public Admin_View_Inventory_Management()
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

        private void Admin_View_Inventory_Management_Load(object sender, EventArgs e)
        {
            // Load the login state from the JSON file
            LoginState loginState = LoginStateManager.LoadLoginState();

            // Check if the admin is logged in
            if (!loginState.IsLoggedIn)
            {
                AdminLogin adminLogin = new AdminLogin();
                adminLogin.Show();
                this.Hide();
                return; // Exit the method if not logged in
            }

            // Ensure the state is consistent with the collapsed slide bar
            slidebar.Width = slidebar.MinimumSize.Width;
            slidebarExpand = false;

            // Hide unnecessary labels initially
            lbl_adminID.Hide();
            lbl_adminName.Hide();
            lbl_dot1.Hide();
            lbl_dot2.Hide();
            lbl_showAdminID.Hide();
            lbl_showAdminName.Hide();

            string adminUsername = loginState.AdminUsername;

            // Retrieve Admin ID and Name from the database using the saved adminUsername
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
                        string adminID = reader["adminID"].ToString();
                        string adminName = reader["adminName"].ToString();

                        lbl_showAdminID.Text = adminID;
                        lbl_showAdminName.Text = adminName;

                        // Show admin details if needed
                        lbl_adminID.Show();
                        lbl_adminName.Show();
                        lbl_dot1.Show();
                        lbl_dot2.Show();
                        lbl_showAdminID.Show();
                        lbl_showAdminName.Show();
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

            // Ensure the correct panel is shown
            pnl_bookDetails.Hide();
            guna2Panel2.Hide();

            // Set TabStop for buttons
            btn_Dashboard.TabStop = false;
            btn_Books.TabStop = false;
            btn_Members.TabStop = false;
            btn_Borrow.TabStop = false;
            btn_Refer.TabStop = false;
            btn_Reservation.TabStop = false;
            btn_Inventory.TabStop = false;
            btn_Inquiries.TabStop = false;

            LoadBookData();
        }

        private void LoadBookData()
        {
            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";
            string query = "SELECT bookID, bookTitle, bookAuthor FROM Book";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //pnl_instructions.Hide();
                    pnl_bookDetails.Show();

                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    listView_loadBookData.Items.Clear();  // Clear existing items

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["bookID"].ToString());
                        item.SubItems.Add(reader["bookTitle"].ToString());
                        item.SubItems.Add(reader["bookAuthor"].ToString());

                        listView_loadBookData.Items.Add(item);
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

        private void Admin_View_Inventory_Management_MouseClick(object sender, MouseEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string bookCategory = txt_bookCategory.Text.Trim();  // Get book category input
            string bookLanguage = txt_BookLanguage.Text.Trim();  // Get book language input
            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";

            if (string.IsNullOrEmpty(bookCategory) && string.IsNullOrEmpty(bookLanguage))
            {
                MessageBox.Show("Please enter a category or language to filter.");
                return;
            }

            string query = "SELECT bookID, bookTitle, bookAuthor FROM Book WHERE 1 = 1";

            if (!string.IsNullOrEmpty(bookCategory))
            {
                query += " AND bookCategory = @bookCategory";
            }

            if (!string.IsNullOrEmpty(bookLanguage))
            {
                query += " AND bookLanguage = @bookLanguage";
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);

                    if (!string.IsNullOrEmpty(bookCategory))
                    {
                        cmd.Parameters.AddWithValue("@bookCategory", bookCategory);
                    }

                    if (!string.IsNullOrEmpty(bookLanguage))
                    {
                        cmd.Parameters.AddWithValue("@bookLanguage", bookLanguage);
                    }

                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    listView_loadBookData.Items.Clear();  // Clear existing items

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["bookID"].ToString());
                        item.SubItems.Add(reader["bookTitle"].ToString());
                        item.SubItems.Add(reader["bookAuthor"].ToString());
                        listView_loadBookData.Items.Add(item);
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

        private void listView_loadBookData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_loadBookData.SelectedItems.Count > 0)
            {
                string bookID = listView_loadBookData.SelectedItems[0].SubItems[0].Text;

                string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";
                string query = "SELECT * FROM Book WHERE bookID = @bookID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        //pnl_instructions.Hide();
                        pnl_bookDetails.Show();
                        guna2Panel2.Show();

                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@bookID", bookID);
                        connection.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            lbl_showBookID.Text = reader["bookID"].ToString();
                            lbl_showBookTitle.Text = reader["bookTitle"].ToString();
                            lbl_showBookAuthor.Text = reader["bookAuthor"].ToString();
                            lbl_showBookISBN.Text = reader["bookISBN"].ToString();
                            lbl_showBookCategory.Text = reader["bookCategory"].ToString();
                            lbl_showBookType.Text = reader["bookType"].ToString();
                            lbl_showBookLanguage.Text = reader["bookLanguage"].ToString();
                            lbl_showBookAdditional.Text = reader["bookAdditional"].ToString();
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string searchQuery = txt_detail.Text.Trim(); // Input for search
            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";
            string query = @"SELECT bookID, bookTitle, bookAuthor 
                     FROM Book 
                     WHERE bookID LIKE @search OR bookTitle LIKE @search";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@search", "%" + searchQuery + "%");
                    connection.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    listView_loadBookData.Items.Clear(); // Clear existing data

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["bookID"].ToString());
                        item.SubItems.Add(reader["bookTitle"].ToString());
                        item.SubItems.Add(reader["bookAuthor"].ToString());
                        listView_loadBookData.Items.Add(item);
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
