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
        }

        private void Member_Dashboard_Load(object sender, EventArgs e)
        {

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
            }
        }
    }
}
