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

            btn_Dashboard.TabIndex = 0;
            btn_Books.TabIndex = 1;
            btn_Members.TabIndex = 2;
            btn_Borrow.TabIndex = 3;
            btn_Refer.TabIndex = 4;
        }

        //private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        //{
        //}

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {

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
