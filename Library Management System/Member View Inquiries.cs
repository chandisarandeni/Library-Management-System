﻿using System;
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
    public partial class Member_View_Inquiries : Form
    {
        bool slidebarExpand;
        public Member_View_Inquiries()
        {
            InitializeComponent();

            btn_Dashboard.TabStop = false;
            btn_myBooks.TabStop = false;
            btn_Borrow.TabStop = false;
            btn_searchBook.TabStop = false;
            btn_Reservation.TabStop = false;
            btn_Inquiries.TabStop = false;
            btn_Submit.TabStop = false;
            btn_Cancel.TabStop = false;

            txt_memberFullName.TabIndex = 0;
            txt_memberEmail.TabIndex = 1;
            txt_memberContact.TabIndex = 2;
            txt_memberDescription.TabIndex = 3;
        }

        private void Member_View_Inquiries_Load(object sender, EventArgs e)
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

        private void Member_View_Inquiries_MouseClick(object sender, MouseEventArgs e)
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

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";
            string inquiryID = GenerateInquiryID();
            string memberFullName = txt_memberFullName.Text.Trim();
            string memberContact = txt_memberContact.Text.Trim();
            string memberDescription = txt_memberDescription.Text.Trim();

            if (string.IsNullOrEmpty(memberFullName) || string.IsNullOrEmpty(memberContact) || string.IsNullOrEmpty(memberDescription))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            string query = @"INSERT INTO Inquires (inquiryID, memberFullName, memberContact, memberDescription) 
                     VALUES (@inquiryID, @memberFullName, @memberContact, @memberDescription)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@inquiryID", inquiryID);
                    cmd.Parameters.AddWithValue("@memberFullName", memberFullName);
                    cmd.Parameters.AddWithValue("@memberContact", memberContact);
                    cmd.Parameters.AddWithValue("@memberDescription", memberDescription);

                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Inquiry submitted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to submit the inquiry.");
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

        private string GenerateInquiryID()
        {
            string connectionString = "Server=CHANDISA; Database=LibraryManagementSystem; Integrated Security=True;";
            string query = "SELECT COUNT(*) FROM Inquires";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return $"I-{(count + 1).ToString("D3")}";
                }
            }
            catch
            {
                return "I-001"; // Default ID if an error occurs
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_memberFullName.Clear();
            txt_memberEmail.Clear();
            txt_memberContact.Clear();
            txt_memberDescription.Clear();
        }
    }
}
