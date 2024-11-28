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
        public Admin_View_Member_Management()
        {
            InitializeComponent();
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
    }
}
