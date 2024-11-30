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
    public partial class Member_View_Reservation : Form
    {
        private String memberID;
        bool slidebarExpand;
        public Member_View_Reservation()
        {
            InitializeComponent();

            btn_Dashboard.TabStop = false;
            btn_myBooks.TabStop = false;
            btn_Borrow.TabStop = false;
            btn_searchBook.TabStop = false;
            btn_Reservation.TabStop = false;
            btn_Inquiries.TabStop = false;

            memberID = string.Empty;
        }

        private void Member_View_Reservation_Load(object sender, EventArgs e)
        {
            MemberLoginState loginState = MemberLoginStateManager.LoadLoginState();

            if (!loginState.IsLoggedIn)
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
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
                            memberID = reader["memberID"].ToString(); // Correct assignment
                            string memberFullName = reader["memberFullName"].ToString();

                            lbl_showMemberID.Text = memberID;
                            lbl_showMemberName.Text = memberFullName;

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
            pnl_reservationForm.Hide();
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

        private void Member_View_Reservation_MouseClick(object sender, MouseEventArgs e)
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

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            slidebarTimer.Start();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string bookID = txt_bookID.Text.Trim(); // Get bookID from input
            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";
            string query = @"SELECT bookID, bookTitle, bookAuthor, bookCategory, 
                            bookType, bookLanguage, bookRegistrationDate 
                     FROM Book 
                     WHERE bookID = @bookID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    pnl_instructions.Hide(); // Hide the instructions panel
                    pnl_reservationForm.Show(); // Show the reservation form panel
                    pnl_bookDetails.Show(); // Show the book details panel

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@bookID", bookID);

                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Retrieve and display book details
                        lbl_showBookID.Text = reader["bookID"].ToString();
                        lbl_showBookTitle.Text = reader["bookTitle"].ToString();
                        lbl_showBookAuthor.Text = reader["bookAuthor"].ToString();
                        lbl_showBookCategory.Text = reader["bookCategory"].ToString();
                        lbl_showBookType.Text = reader["bookType"].ToString();
                        lbl_showBookLanguage.Text = reader["bookLanguage"].ToString();
                        lbl_showBookRegisterationDate.Text = Convert.ToDateTime(reader["bookRegistrationDate"]).ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        pnl_bookDetails.Hide(); // Hide the book details panel
                        pnl_instructions.Show(); // Show the instructions panel
                        pnl_reservationForm.Hide(); // Hide the reservation form panel

                        MessageBox.Show("Book not found.");
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

        private void btn_addReservation_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";
            string reservationID = GenerateReservationID();
            string bookID = lbl_showBookID.Text.Trim();
            string memberID = lbl_showMemberID.Text.Trim(); // Fix: Use lbl_showMemberID
            string reservationDescription = txt_reservationDescription.Text.Trim();
            string reservationDate = DateTime.Now.ToString("yyyy-MM-dd");

            if (string.IsNullOrEmpty(bookID) || string.IsNullOrEmpty(memberID))
            {
                MessageBox.Show("Please provide both Book ID and Member ID.");
                return;
            }

            string query = @"INSERT INTO Reservations 
                     (reservationID, bookID, memberID, reservationDescription, reservationDate) 
                     VALUES (@reservationID, @bookID, @memberID, @reservationDescription, @reservationDate)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@reservationID", reservationID);
                    cmd.Parameters.AddWithValue("@bookID", bookID);
                    cmd.Parameters.AddWithValue("@memberID", memberID); // Fixed parameter
                    cmd.Parameters.AddWithValue("@reservationDescription", reservationDescription);
                    cmd.Parameters.AddWithValue("@reservationDate", reservationDate);

                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Reservation added successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add reservation.");
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

        private string GenerateReservationID()
        {
            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";
            string query = "SELECT COUNT(*) FROM Reservations";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return $"R-{(count + 1).ToString("D3")}";
                }
            }
            catch
            {
                return "R-001"; // Default ID if error occurs
            }
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            Member_Dashboard memberDashboard = new Member_Dashboard();
            memberDashboard.Show();
            this.Hide();
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
