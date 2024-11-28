using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Admin_View_Book_Management : Form
    {
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
        bool slidebarExpand;

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
            // Ensure the state is consistent with the collapsed slide bar
            slidebar.Width = slidebar.MinimumSize.Width;
            slidebarExpand = false;

            lbl_adminID.Hide();
            lbl_adminName.Hide();
            lbl_dot1.Hide();
            lbl_dot2.Hide();
            lbl_showAdminID.Hide();
            lbl_showAdminName.Hide();

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
            if (txt_bookID.Text == "")
            {
                MessageBox.Show("Please Search Book Before Edit!");
            }

            
        }

        private void btn_addBook_Click(object sender, EventArgs e)
        {
            Admin_View_Book_Registration adminViewBookRegistration = new Admin_View_Book_Registration();
            adminViewBookRegistration.Show();
            this.Hide();
        }
    }
}
