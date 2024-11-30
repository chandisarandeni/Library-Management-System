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
    public partial class Member_Dashboard : Form
    {
        bool slidebarExpand;
        public Member_Dashboard()
        {
            InitializeComponent();

            btn_Dashboard.TabStop = false;
            btn_myBooks.TabStop = false;
            btn_Borrow.TabStop = false;
            btn_searchBook.TabStop = false;
            btn_Reservation.TabStop = false;
            btn_Inquiries.TabStop = false;
        }

        private void Member_Dashboard_Load(object sender, EventArgs e)
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
            LoadRecentlyBorrowedBooks();
            LoadOverdueBorrowedBooks();
        }
        private void LoadOverdueBorrowedBooks()
        {
            string memberID = lbl_showMemberID.Text.Trim(); // Get the Member ID
            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";

            if (string.IsNullOrEmpty(memberID))
            {
                MessageBox.Show("Member ID is missing.");
                return;
            }

            string query = @"
                SELECT b.bookID, bk.bookTitle, b.borrowedDate, DATEDIFF(DAY, b.borrowedDate, GETDATE()) AS DaysOverdue
                FROM borrowBook b
                INNER JOIN Book bk ON b.bookID = bk.bookID
                WHERE b.memberID = @memberID AND DATEDIFF(DAY, b.borrowedDate, GETDATE()) > 30";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@memberID", memberID);

                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    listView_borrowedOverDueBooks.Items.Clear();

                    while (reader.Read())
                    {
                        string bookID = reader["bookID"].ToString();
                        string bookTitle = reader["bookTitle"].ToString();
                        string borrowedDate = reader["borrowedDate"].ToString();
                        string daysOverdue = reader["DaysOverdue"].ToString();

                        ListViewItem item = new ListViewItem(bookID);
                        item.SubItems.Add(bookTitle);
                        item.SubItems.Add(borrowedDate);
                        item.SubItems.Add(daysOverdue + " days");

                        listView_borrowedOverDueBooks.Items.Add(item);
                    }

                    reader.Close();

                    if (listView_borrowedOverDueBooks.Items.Count == 0)
                    {
                        lbl_overdue.Show();
                        listView_borrowedOverDueBooks.Hide();
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

        private void LoadRecentlyBorrowedBooks()
        {
            string memberID = lbl_showMemberID.Text.Trim(); // Get the Member ID
            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";

            if (string.IsNullOrEmpty(memberID))
            {
                MessageBox.Show("Member ID is missing.");
                return;
            }

            string query = @"
    SELECT b.bookID, bk.bookTitle, b.borrowedDate 
    FROM borrowBook b
    INNER JOIN Book bk ON b.bookID = bk.bookID
    WHERE b.memberID = @memberID
    ORDER BY b.borrowedDate DESC";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@memberID", memberID);

                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    listView_recentlyBorrowedBooks.Items.Clear();

                    while (reader.Read())
                    {
                        string bookID = reader["bookID"].ToString();
                        string bookTitle = reader["bookTitle"].ToString();
                        string borrowedDate = reader["borrowedDate"].ToString();

                        ListViewItem item = new ListViewItem(bookID);
                        item.SubItems.Add(bookTitle);
                        item.SubItems.Add(borrowedDate);

                        listView_recentlyBorrowedBooks.Items.Add(item);
                    }

                    reader.Close();

                    if (listView_recentlyBorrowedBooks.Items.Count == 0)
                    {
                        MessageBox.Show("No recently borrowed books found.");
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

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            Member_Dashboard member_Dashboard = new Member_Dashboard();
            member_Dashboard.Show();
            this.Hide();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            slidebarTimer.Start();
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
        private void Member_Dashboard_MouseClick(object sender, MouseEventArgs e)
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
            Member_View_Search_Book memberViewSearchBooks = new Member_View_Search_Book();
            memberViewSearchBooks.Show();
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
