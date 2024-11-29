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
    public partial class Admin_View_Member_Management : Form
    {
        bool slidebarExpand;
        public Admin_View_Member_Management()
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

        Timer textTimer = new Timer { Interval = 30 };
        int textPosition = 0;
        string hoverText = "";

        private void btn_addMember_MouseHover(object sender, EventArgs e)
        {
            textTimer.Tick += (s, args) =>
            {
                if (textPosition < hoverText.Length)
                {
                    lbl_addMemberHover.Text += hoverText[textPosition];
                    textPosition++;
                }
                else
                {
                    textTimer.Stop();
                }
            };
            textPosition = 0;
            lbl_addMemberHover.Text = "Add Member";
            textTimer.Start();
        }

        private void btn_addMember_MouseLeave(object sender, EventArgs e)
        {
            lbl_addMemberHover.Text = "";
            textTimer.Stop();
        }

        private void btn_editMember_MouseHover(object sender, EventArgs e)
        {
            textTimer.Tick += (s, args) =>
            {
                if (textPosition < hoverText.Length)
                {
                    lbl_editMemberHover.Text += hoverText[textPosition];
                    textPosition++;
                }
                else
                {
                    textTimer.Stop();
                }
            };
            textPosition = 0;
            lbl_editMemberHover.Text = "Edit Member";
            textTimer.Start();
        }

        private void btn_editMember_MouseLeave(object sender, EventArgs e)
        {
            lbl_editMemberHover.Text = "";
            textTimer.Stop();
        }

        private void btn_deleteMember_MouseHover(object sender, EventArgs e)
        {
            textTimer.Tick += (s, args) =>
            {
                if (textPosition < hoverText.Length)
                {
                    lbl_deleteMemberHover.Text += hoverText[textPosition];
                    textPosition++;
                }
                else
                {
                    textTimer.Stop();
                }
            };
            textPosition = 0;
            lbl_deleteMemberHover.Text = "Delete Member";
            textTimer.Start();
        }

        private void btn_deleteMember_MouseLeave(object sender, EventArgs e)
        {
            lbl_deleteMemberHover.Text = "";
            textTimer.Stop();
        }

        private void Admin_View_Member_Management_Load(object sender, EventArgs e)
        {
            lbl_addMemberHover.Text = "";
            lbl_editMemberHover.Text = "";
            lbl_deleteMemberHover.Text = "";

            pnl_memberDetails.Visible = false;
            pnl_instructions.Visible = true;

            btn_Dashboard.TabStop = false;
            btn_Books.TabStop = false;
            btn_Members.TabStop = false;
            btn_Borrow.TabStop = false;
            btn_Refer.TabStop = false;
            btn_Reservation.TabStop = false;
            btn_Inventory.TabStop = false;
            btn_Inquiries.TabStop = false;
        }

        private void btn_addMember_Click(object sender, EventArgs e)
        {
            Admin_View_Member_Registration adminViewMemberRegistration = new Admin_View_Member_Registration();
            adminViewMemberRegistration.Show();
            this.Hide();
        }

        private void btn_editMember_Click(object sender, EventArgs e)
        {
            Admin_View_Member_Edit adminViewMemberEdit = new Admin_View_Member_Edit();
            adminViewMemberEdit.Show();
            this.Hide();
        }

        private void btn_deleteMember_Click(object sender, EventArgs e)
        {
            Admin_View_Member_Delete adminViewMemberDelete = new Admin_View_Member_Delete();
            adminViewMemberDelete.Show();
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

        private void Admin_View_Member_Management_MouseClick(object sender, MouseEventArgs e)
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
    }
}
