namespace Library_Management_System
{
    partial class Member_Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member_Dashboard));
            this.slidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_dot2 = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.PictureBox();
            this.lbl_dot1 = new System.Windows.Forms.Label();
            this.lbl_showMemberName = new System.Windows.Forms.Label();
            this.btn_Menu = new System.Windows.Forms.PictureBox();
            this.lbl_showMemberID = new System.Windows.Forms.Label();
            this.lbl_memberID = new System.Windows.Forms.Label();
            this.lbl_memberName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_myBooks = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Borrow = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_searchBook = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_Reservation = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_Inquiries = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.slidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.slidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // slidebar
            // 
            this.slidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(85)))), ((int)(((byte)(44)))));
            this.slidebar.Controls.Add(this.panel1);
            this.slidebar.Controls.Add(this.panel2);
            this.slidebar.Controls.Add(this.panel3);
            this.slidebar.Controls.Add(this.panel4);
            this.slidebar.Controls.Add(this.panel5);
            this.slidebar.Controls.Add(this.panel6);
            this.slidebar.Controls.Add(this.panel8);
            this.slidebar.Controls.Add(this.panel7);
            this.slidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidebar.Location = new System.Drawing.Point(0, 0);
            this.slidebar.MaximumSize = new System.Drawing.Size(281, 662);
            this.slidebar.MinimumSize = new System.Drawing.Size(73, 653);
            this.slidebar.Name = "slidebar";
            this.slidebar.Size = new System.Drawing.Size(281, 662);
            this.slidebar.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_dot2);
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.lbl_dot1);
            this.panel1.Controls.Add(this.lbl_showMemberName);
            this.panel1.Controls.Add(this.btn_Menu);
            this.panel1.Controls.Add(this.lbl_showMemberID);
            this.panel1.Controls.Add(this.lbl_memberID);
            this.panel1.Controls.Add(this.lbl_memberName);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 138);
            this.panel1.TabIndex = 1;
            // 
            // lbl_dot2
            // 
            this.lbl_dot2.AutoSize = true;
            this.lbl_dot2.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dot2.Location = new System.Drawing.Point(68, 93);
            this.lbl_dot2.Name = "lbl_dot2";
            this.lbl_dot2.Size = new System.Drawing.Size(19, 20);
            this.lbl_dot2.TabIndex = 6;
            this.lbl_dot2.Text = ":";
            this.lbl_dot2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Image")));
            this.btn_Logout.Location = new System.Drawing.Point(235, 11);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(33, 33);
            this.btn_Logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Logout.TabIndex = 1;
            this.btn_Logout.TabStop = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_dot1
            // 
            this.lbl_dot1.AutoSize = true;
            this.lbl_dot1.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dot1.Location = new System.Drawing.Point(158, 48);
            this.lbl_dot1.Name = "lbl_dot1";
            this.lbl_dot1.Size = new System.Drawing.Size(19, 20);
            this.lbl_dot1.TabIndex = 7;
            this.lbl_dot1.Text = ":";
            this.lbl_dot1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_showMemberName
            // 
            this.lbl_showMemberName.AutoSize = true;
            this.lbl_showMemberName.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_showMemberName.Location = new System.Drawing.Point(93, 93);
            this.lbl_showMemberName.Name = "lbl_showMemberName";
            this.lbl_showMemberName.Size = new System.Drawing.Size(169, 20);
            this.lbl_showMemberName.TabIndex = 8;
            this.lbl_showMemberName.Text = "Saman Gunasekara";
            this.lbl_showMemberName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Menu
            // 
            this.btn_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Menu.Image")));
            this.btn_Menu.Location = new System.Drawing.Point(17, 9);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(33, 28);
            this.btn_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Menu.TabIndex = 1;
            this.btn_Menu.TabStop = false;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // lbl_showMemberID
            // 
            this.lbl_showMemberID.AutoSize = true;
            this.lbl_showMemberID.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_showMemberID.Location = new System.Drawing.Point(93, 68);
            this.lbl_showMemberID.Name = "lbl_showMemberID";
            this.lbl_showMemberID.Size = new System.Drawing.Size(109, 20);
            this.lbl_showMemberID.TabIndex = 9;
            this.lbl_showMemberID.Text = "M-00-12351";
            this.lbl_showMemberID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_memberID
            // 
            this.lbl_memberID.AutoSize = true;
            this.lbl_memberID.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_memberID.Location = new System.Drawing.Point(13, 48);
            this.lbl_memberID.Name = "lbl_memberID";
            this.lbl_memberID.Size = new System.Drawing.Size(139, 20);
            this.lbl_memberID.TabIndex = 11;
            this.lbl_memberID.Text = "Membership ID";
            this.lbl_memberID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_memberName
            // 
            this.lbl_memberName.AutoSize = true;
            this.lbl_memberName.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_memberName.Location = new System.Drawing.Point(13, 93);
            this.lbl_memberName.Name = "lbl_memberName";
            this.lbl_memberName.Size = new System.Drawing.Size(49, 20);
            this.lbl_memberName.TabIndex = 10;
            this.lbl_memberName.Text = "Name";
            this.lbl_memberName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Dashboard);
            this.panel2.Location = new System.Drawing.Point(3, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 60);
            this.panel2.TabIndex = 1;
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(93)))), ((int)(((byte)(16)))));
            this.btn_Dashboard.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("btn_Dashboard.Image")));
            this.btn_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dashboard.Location = new System.Drawing.Point(3, 0);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_Dashboard.Size = new System.Drawing.Size(336, 60);
            this.btn_Dashboard.TabIndex = 2;
            this.btn_Dashboard.Text = "    Dashboard";
            this.btn_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dashboard.UseVisualStyleBackColor = false;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_myBooks);
            this.panel3.Location = new System.Drawing.Point(3, 213);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 60);
            this.panel3.TabIndex = 3;
            // 
            // btn_myBooks
            // 
            this.btn_myBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(93)))), ((int)(((byte)(16)))));
            this.btn_myBooks.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_myBooks.Image = ((System.Drawing.Image)(resources.GetObject("btn_myBooks.Image")));
            this.btn_myBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_myBooks.Location = new System.Drawing.Point(3, 0);
            this.btn_myBooks.Name = "btn_myBooks";
            this.btn_myBooks.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_myBooks.Size = new System.Drawing.Size(336, 60);
            this.btn_myBooks.TabIndex = 2;
            this.btn_myBooks.Text = "    My Books";
            this.btn_myBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_myBooks.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_Borrow);
            this.panel4.Location = new System.Drawing.Point(3, 279);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(278, 60);
            this.panel4.TabIndex = 4;
            // 
            // btn_Borrow
            // 
            this.btn_Borrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(93)))), ((int)(((byte)(16)))));
            this.btn_Borrow.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Borrow.Image = ((System.Drawing.Image)(resources.GetObject("btn_Borrow.Image")));
            this.btn_Borrow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Borrow.Location = new System.Drawing.Point(3, 0);
            this.btn_Borrow.Name = "btn_Borrow";
            this.btn_Borrow.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_Borrow.Size = new System.Drawing.Size(336, 60);
            this.btn_Borrow.TabIndex = 2;
            this.btn_Borrow.Text = "    Borrow";
            this.btn_Borrow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Borrow.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_searchBook);
            this.panel5.Location = new System.Drawing.Point(3, 345);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(278, 60);
            this.panel5.TabIndex = 5;
            // 
            // btn_searchBook
            // 
            this.btn_searchBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(93)))), ((int)(((byte)(16)))));
            this.btn_searchBook.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchBook.Image = ((System.Drawing.Image)(resources.GetObject("btn_searchBook.Image")));
            this.btn_searchBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_searchBook.Location = new System.Drawing.Point(3, 0);
            this.btn_searchBook.Name = "btn_searchBook";
            this.btn_searchBook.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_searchBook.Size = new System.Drawing.Size(336, 60);
            this.btn_searchBook.TabIndex = 2;
            this.btn_searchBook.Text = "    Search Book";
            this.btn_searchBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_searchBook.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_Reservation);
            this.panel6.Location = new System.Drawing.Point(3, 411);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(278, 60);
            this.panel6.TabIndex = 6;
            // 
            // btn_Reservation
            // 
            this.btn_Reservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(93)))), ((int)(((byte)(16)))));
            this.btn_Reservation.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reservation.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reservation.Image")));
            this.btn_Reservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reservation.Location = new System.Drawing.Point(3, 0);
            this.btn_Reservation.Name = "btn_Reservation";
            this.btn_Reservation.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_Reservation.Size = new System.Drawing.Size(336, 60);
            this.btn_Reservation.TabIndex = 2;
            this.btn_Reservation.Text = "    Reservation";
            this.btn_Reservation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reservation.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_Inquiries);
            this.panel8.Location = new System.Drawing.Point(3, 477);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(278, 60);
            this.panel8.TabIndex = 6;
            // 
            // btn_Inquiries
            // 
            this.btn_Inquiries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(93)))), ((int)(((byte)(16)))));
            this.btn_Inquiries.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inquiries.Image = ((System.Drawing.Image)(resources.GetObject("btn_Inquiries.Image")));
            this.btn_Inquiries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inquiries.Location = new System.Drawing.Point(3, 0);
            this.btn_Inquiries.Name = "btn_Inquiries";
            this.btn_Inquiries.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_Inquiries.Size = new System.Drawing.Size(336, 60);
            this.btn_Inquiries.TabIndex = 2;
            this.btn_Inquiries.Text = "    Inquiries";
            this.btn_Inquiries.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inquiries.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(3, 543);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(278, 119);
            this.panel7.TabIndex = 2;
            // 
            // slidebarTimer
            // 
            this.slidebarTimer.Tick += new System.EventHandler(this.slidebarTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Member Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Member_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 662);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Member_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System";
            this.Load += new System.EventHandler(this.Member_Dashboard_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Member_Dashboard_MouseClick);
            this.slidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel slidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_Menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_myBooks;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_Borrow;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_searchBook;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_Reservation;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox btn_Logout;
        private System.Windows.Forms.Timer slidebarTimer;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_Inquiries;
        private System.Windows.Forms.Label lbl_dot2;
        private System.Windows.Forms.Label lbl_dot1;
        private System.Windows.Forms.Label lbl_showMemberName;
        private System.Windows.Forms.Label lbl_showMemberID;
        private System.Windows.Forms.Label lbl_memberID;
        private System.Windows.Forms.Label lbl_memberName;
        private System.Windows.Forms.Label label1;
    }
}