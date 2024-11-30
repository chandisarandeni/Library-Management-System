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
using static Library_Management_System.Home;

namespace Library_Management_System
{
    public partial class Member_View_Search_Book : Form
    {
        bool slidebarExpand;
        public Member_View_Search_Book()
        {
            InitializeComponent();

            btn_Dashboard.TabStop = false;
            btn_myBooks.TabStop = false;
            btn_Borrow.TabStop = false;
            btn_searchBook.TabStop = false;
            btn_Reservation.TabStop = false;
            btn_Inquiries.TabStop = false;
        }

        private void Member_View_Search_Book_Load(object sender, EventArgs e)
        {
            // Load the member login state
            MemberLoginState loginState = MemberLoginStateManager.LoadLoginState();

            if (!loginState.IsLoggedIn)
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                // Ensure the state is consistent with the collapsed slide bar
                slidebar.Width = slidebar.MinimumSize.Width;
                slidebarExpand = false;

                lbl_memberID.Hide();
                lbl_memberName.Hide();
                lbl_dot1.Hide();
                lbl_dot2.Hide();
                lbl_showMemberID.Hide();
                lbl_showMemberName.Hide();

                string memberEmail = loginState.MemberEmail;
                string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";
                string query = "SELECT memberID, memberFullName FROM libraryMember WHERE memberEmail = @memberEmail";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@memberEmail", memberEmail);

                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string memberID = reader["memberID"].ToString();
                            string memberFullName = reader["memberFullName"].ToString();

                            lbl_showMemberID.Text = memberID;
                            lbl_showMemberName.Text = memberFullName;

                            // Display fetched Member ID and Name
                            lbl_showMemberID.Show();
                            lbl_showMemberName.Show();
                        }
                        else
                        {
                            MessageBox.Show("Member details not found.");
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

            pnl_bookDetails.Hide();
            pnl_instructions.Show();

            LoadAllBooks();
        }


        private void LoadAllBooks()
        {
            listView_BookDetails.Items.Clear(); // Clear existing items

            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";
            string query = "SELECT bookID, bookTitle, bookAuthor FROM Book";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["bookID"].ToString());
                        item.SubItems.Add(reader["bookTitle"].ToString());
                        item.SubItems.Add(reader["bookAuthor"].ToString());

                        listView_BookDetails.Items.Add(item);
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
                    slidebar.Width = slidebar.MinimumSize.Width;
                    slidebarExpand = false;
                    slidebarTimer.Stop();

                    lbl_memberID.Hide();
                    lbl_memberName.Hide();
                    lbl_dot1.Hide();
                    lbl_dot2.Hide();
                    lbl_showMemberID.Hide();
                    lbl_showMemberName.Hide();
                }
            }
            else
            {
                // If the slidebar is collapsed
                slidebar.Width += 10; // Small step for smoother effect
                if (slidebar.Width >= slidebar.MaximumSize.Width)
                {
                    slidebar.Width = slidebar.MaximumSize.Width;
                    slidebarExpand = true;
                    slidebarTimer.Stop();

                    lbl_memberID.Show();
                    lbl_memberName.Show();
                    lbl_dot1.Show();
                    lbl_dot2.Show();
                    lbl_showMemberID.Show();
                    lbl_showMemberName.Show();
                }
            }
        }

        private void Member_View_Search_Book_MouseClick(object sender, MouseEventArgs e)
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

        private void btn_filter_Click(object sender, EventArgs e)
        {
            string bookCategory = txt_bookCategory.Text.Trim();
            string bookLanguage = txt_bookLanguage.Text.Trim();
            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";

            string query = "SELECT bookID, bookTitle, bookAuthor FROM Book WHERE 1=1";

            if (!string.IsNullOrEmpty(bookCategory))
                query += " AND bookCategory = @bookCategory";

            if (!string.IsNullOrEmpty(bookLanguage))
                query += " AND bookLanguage = @bookLanguage";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);

                    if (!string.IsNullOrEmpty(bookCategory))
                        cmd.Parameters.AddWithValue("@bookCategory", bookCategory);

                    if (!string.IsNullOrEmpty(bookLanguage))
                        cmd.Parameters.AddWithValue("@bookLanguage", bookLanguage);

                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    listView_BookDetails.Items.Clear();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["bookID"].ToString());
                        item.SubItems.Add(reader["bookTitle"].ToString());
                        item.SubItems.Add(reader["bookAuthor"].ToString());
                        listView_BookDetails.Items.Add(item);
                    }

                    if (listView_BookDetails.Items.Count == 0)
                    {
                        MessageBox.Show("No books found matching the criteria.");
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
                    listView_BookDetails.Items.Clear(); // Clear existing data

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["bookID"].ToString());
                        item.SubItems.Add(reader["bookTitle"].ToString());
                        item.SubItems.Add(reader["bookAuthor"].ToString());
                        listView_BookDetails.Items.Add(item);
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

        private void listView_BookDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_BookDetails.SelectedItems.Count > 0)
            {
                string bookID = listView_BookDetails.SelectedItems[0].SubItems[0].Text;

                string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";
                string query = "SELECT * FROM Book WHERE bookID = @bookID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        pnl_instructions.Hide();
                        pnl_bookDetails.Show();

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

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            Member_Dashboard memberDashboard = new Member_Dashboard();
            memberDashboard.Show();
            this.Hide();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            slidebarTimer.Start();
        }

        private void btn_myBooks_Click(object sender, EventArgs e)
        {
            Member_View_My_Books memberViewMyBooks = new Member_View_My_Books();
            memberViewMyBooks.Show();
            this.Hide();
        }

        private void btn_Borrow_Click(object sender, EventArgs e)
        {
            Member_View_Borow_Books memberViewBorrowBooks = new Member_View_Borow_Books();
            memberViewBorrowBooks.Show();
            this.Hide();
        }

        private void btn_searchBook_Click(object sender, EventArgs e)
        {
            Member_View_Search_Book memberViewSearchBook = new Member_View_Search_Book();
            memberViewSearchBook.Show();
            this.Hide();
        }

        private void btn_Reservation_Click(object sender, EventArgs e)
        {
            Member_View_Reservation memberViewReservation = new Member_View_Reservation();
            memberViewReservation.Show();
            this.Hide();
        }

        private void btn_Inquiries_Click(object sender, EventArgs e)
        {
            Member_View_Inquiries memberViewInquiries = new Member_View_Inquiries();
            memberViewInquiries.Show();
            this.Hide();
        }
    }
}
