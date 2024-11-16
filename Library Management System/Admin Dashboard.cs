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
    public partial class Admin_Dashboard : Form
    {
        bool slidebarExpand;
        public Admin_Dashboard()
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

        private void Admin_Dashboard_Load(object sender, EventArgs e)
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
        }

        private void sliderbarTimber_Tick(object sender, EventArgs e)
        {
            //set the minimum

            if (slidebarExpand)
            {
                //if the slidebar is expanded
                slidebar.Width -= 60;
                if (slidebar.Width == slidebar.MinimumSize.Width)
                { 
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
                //if the slidebar is collapsed
                slidebar.Width += 60;
                if (slidebar.Width == slidebar.MaximumSize.Width)
                {
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

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            Admin_Dashboard admin_Dashboard = new Admin_Dashboard();
            admin_Dashboard.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
