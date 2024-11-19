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
            // Ensure the state is consistent with the collapsed slide bar
            slidebar.Width = slidebar.MinimumSize.Width;
            slidebarExpand = false;

            lbl_memberID.Hide();
            lbl_memberName.Hide();
            lbl_dot1.Hide();
            lbl_dot2.Hide();
            lbl_showMemberID.Hide();
            lbl_showMemberName.Hide();
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
            // set the minimum

            if (slidebarExpand)
            {
                //if the slidebar is expanded
                slidebar.Width -= 60;
                if (slidebar.Width == slidebar.MinimumSize.Width)
                {
                    slidebarExpand = false;
                    slidebarTimer.Stop();
                }

                lbl_memberID.Hide();
                lbl_memberName.Hide();
                lbl_dot1.Hide();
                lbl_dot2.Hide();
                lbl_showMemberID.Hide();
                lbl_showMemberName.Hide();
            }
            else
            {
                //if the slidebar is collapsed
                slidebar.Width += 60;
                if (slidebar.Width == slidebar.MaximumSize.Width)
                {
                    slidebarExpand = true;
                    slidebarTimer.Stop();
                }

                lbl_memberID.Show();
                lbl_memberName.Show();
                lbl_dot1.Show();
                lbl_dot2.Show();
                lbl_showMemberID.Show();
                lbl_showMemberName.Show();
            }
        }
    }
}
