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
    public partial class Admin_View_Book_Management : Form
    {
        bool slidebarExpand;
        public Admin_View_Book_Management()
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

        private void Admin_View_Book_Management_Load(object sender, EventArgs e)
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




            lbl_addBookHover.Text = "";
            lbl_editBookHover.Text = "";
            lbl_deleteBookHover.Text = "";

            pnl_instructions.Show();
            pnl_bookDetails.Hide();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            slidebarTimer.Start();
        }

        private void btn_Books_Click(object sender, EventArgs e)
        {
            Admin_View_Book_Management adminViewBookManagement = new Admin_View_Book_Management();
            adminViewBookManagement.Show();
            this.Hide();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            Admin_Dashboard adminDashboard = new Admin_Dashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void btn_Borrow_Click(object sender, EventArgs e)
        {
            Admin_View_Borrow_Management adminViewBorrowManagement = new Admin_View_Borrow_Management();
            adminViewBorrowManagement.Show();
            this.Hide();
        }

        private void Admin_View_Book_Management_MouseClick(object sender, MouseEventArgs e)
        {
            if (!slidebar.ClientRectangle.Contains(e.Location))
            {
                if (slidebarExpand)
                {
                    slidebarTimer.Start();
                }
            }
        }

        /// <summary>
        /// This is hover area for the txt btns
        /// </summary>
        /// 
        Timer textTimer = new Timer { Interval = 30 };
        int textPosition = 0;
        string hoverText = "";

        private void btn_addBook_MouseHover(object sender, EventArgs e)
        {
            textTimer.Tick += (s, args) =>
            {
                if (textPosition < hoverText.Length)
                {
                    lbl_addBookHover.Text += hoverText[textPosition];
                    textPosition++;
                }
                else
                {
                    textTimer.Stop();
                }
            };
            textPosition = 0;
            lbl_addBookHover.Text = "Add Book";
            textTimer.Start();
        }
        private void btn_addBook_MouseLeave(object sender, EventArgs e)
        {
            lbl_addBookHover.Text = "";
            textTimer.Stop(); // Stop if the cursor leaves
        }

        private void btn_editBook_MouseHover(object sender, EventArgs e)
        {
            textTimer.Tick += (s, args) =>
            {
                if (textPosition < hoverText.Length)
                {
                    lbl_editBookHover.Text += hoverText[textPosition];
                    textPosition++;
                }
                else
                {
                    textTimer.Stop();
                }
            };
            textPosition = 0;
            lbl_editBookHover.Text = "Edit Book";
            textTimer.Start();
        }

        private void btn_editBook_MouseLeave(object sender, EventArgs e)
        {
            lbl_editBookHover.Text = "";
            textTimer.Stop();
        }

        private void btn_deleteBook_MouseHover(object sender, EventArgs e)
        {
            textTimer.Tick += (s, args) =>
            {
                if (textPosition < hoverText.Length)
                {
                    lbl_deleteBookHover.Text += hoverText[textPosition];
                    textPosition++;
                }
                else
                {
                    textTimer.Stop();
                }
            };
            textPosition = 0;
            lbl_deleteBookHover.Text = "Delete Book";
            textTimer.Start();
        }

        private void btn_deleteBook_MouseLeave(object sender, EventArgs e)
        {
            lbl_deleteBookHover.Text = "";
            textTimer.Stop();
        }

        private void btn_editBook_Click(object sender, EventArgs e)
        {

        }

        private void btn_addBook_Click(object sender, EventArgs e)
        {
            Admin_View_Book_Registration adminViewBookRegistration = new Admin_View_Book_Registration();
            adminViewBookRegistration.Show();
            this.Hide();
        }

        private void btn_editBook_Click_1(object sender, EventArgs e)
        {
            Admin_View_Book_Edit adminViewBookEdit = new Admin_View_Book_Edit();
            adminViewBookEdit.Show();
            this.Hide();
        }

        private void btn_deleteBook_Click(object sender, EventArgs e)
        {
            Admin_View_Book_Delete adminViewBookDelete = new Admin_View_Book_Delete();
            adminViewBookDelete.Show();
            this.Hide();
        }

        private void btn_Members_Click(object sender, EventArgs e)
        {
            Admin_View_Member_Management adminViewMemberManagement = new Admin_View_Member_Management();
            adminViewMemberManagement.Show();
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
            Admin_View_Inquiry_Management adminViewInquiryManagement  = new Admin_View_Inquiry_Management();
            adminViewInquiryManagement.Show();
            this.Hide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";
            string bookID = txt_bookID.Text;

            string query = "SELECT * FROM Book WHERE bookID = @bookID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@bookID", SqlDbType.NVarChar).Value = bookID;

                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    pnl_bookDetails.Show();

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
                        lbl_showBookRegistrationDate.Text = reader["bookRegistrationDate"].ToString();

                        if (reader["isAvailable"].ToString().ToLower() != "true")
                        {
                            pnl_instructions.Show();
                            MessageBox.Show("This book is currently not available.");
                        }
                        else
                        {
                            pnl_instructions.Hide();
                        }
                    }
                    else
                    {
                        pnl_instructions.Show();
                        MessageBox.Show("Book not found. Please check the Book ID.");
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
    }
}
