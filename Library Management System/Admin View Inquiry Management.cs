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
    public partial class Admin_View_Inquiry_Management : Form
    {
        public Admin_View_Inquiry_Management()
        {
            InitializeComponent();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            Admin_Dashboard adminDashboard = new Admin_Dashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void btn_Books_Click(object sender, EventArgs e)
        {
            Admin_View_Book_Management adminViewBookManagemnet = new Admin_View_Book_Management();
            adminViewBookManagemnet.Show();
            this.Hide();
        }

        private void btn_Members_Click(object sender, EventArgs e)
        {
            Admin_View_Member_Management adminViewMemberManagement = new Admin_View_Member_Management();
            adminViewMemberManagement.Show();
            this.Hide();
        }

        private void btn_Borrow_Click(object sender, EventArgs e)
        {
            Admin_View_Borrow_Management adminViewBorrowManagement = new Admin_View_Borrow_Management();
            adminViewBorrowManagement.Show();
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
            Admin_View_Reservation_Management adminVIewReservationManagement = new Admin_View_Reservation_Management();
            adminVIewReservationManagement.Show();
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
            Admin_View_Inquiry_Management adminViewInquiryManagement = new Admin_View_Inquiry_Management();
            adminViewInquiryManagement.Show();
            this.Hide();
        }

        private void Admin_View_Inquiry_Management_Load(object sender, EventArgs e)
        {
            lbl_adminID.Hide();
            lbl_adminName.Hide();
            lbl_dot1.Hide();
            lbl_dot2.Hide();
            lbl_showAdminID.Hide();
            lbl_showAdminName.Hide();
        }
    }
}
