﻿namespace Library_Management_System
{
    partial class Admin_View_Inquiry_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_View_Inquiry_Management));
            this.btn_Reservation = new System.Windows.Forms.Button();
            this.listView_recentInquiries = new System.Windows.Forms.ListView();
            this.memberFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memberContact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memberDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel9 = new System.Windows.Forms.Panel();
            this.btn_Inventory = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btn_Inquiries = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.slidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_Refer = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_showMemberDescription = new System.Windows.Forms.Label();
            this.lbl_showMemberContact = new System.Windows.Forms.Label();
            this.lbl_showMemberName = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.slidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_adminName = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.PictureBox();
            this.lbl_dot2 = new System.Windows.Forms.Label();
            this.lbl_dot1 = new System.Windows.Forms.Label();
            this.lbl_showAdminName = new System.Windows.Forms.Label();
            this.lbl_showAdminID = new System.Windows.Forms.Label();
            this.lbl_adminID = new System.Windows.Forms.Label();
            this.btn_Menu = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Books = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Members = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_Borrow = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.slidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Reservation
            // 
            this.btn_Reservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(93)))), ((int)(((byte)(16)))));
            this.btn_Reservation.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reservation.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reservation.Image")));
            this.btn_Reservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reservation.Location = new System.Drawing.Point(0, 0);
            this.btn_Reservation.Name = "btn_Reservation";
            this.btn_Reservation.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_Reservation.Size = new System.Drawing.Size(306, 58);
            this.btn_Reservation.TabIndex = 2;
            this.btn_Reservation.Text = "    Reservations";
            this.btn_Reservation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reservation.UseVisualStyleBackColor = false;
            this.btn_Reservation.Click += new System.EventHandler(this.btn_Reservation_Click);
            // 
            // listView_recentInquiries
            // 
            this.listView_recentInquiries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.memberFullName,
            this.memberContact,
            this.memberDescription});
            this.listView_recentInquiries.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_recentInquiries.HideSelection = false;
            this.listView_recentInquiries.Location = new System.Drawing.Point(21, 58);
            this.listView_recentInquiries.Name = "listView_recentInquiries";
            this.listView_recentInquiries.Size = new System.Drawing.Size(483, 433);
            this.listView_recentInquiries.TabIndex = 7;
            this.listView_recentInquiries.UseCompatibleStateImageBehavior = false;
            this.listView_recentInquiries.View = System.Windows.Forms.View.Details;
            this.listView_recentInquiries.SelectedIndexChanged += new System.EventHandler(this.listView_recentInquiries_SelectedIndexChanged);
            // 
            // memberFullName
            // 
            this.memberFullName.Text = "Name";
            this.memberFullName.Width = 81;
            // 
            // memberContact
            // 
            this.memberContact.Text = "Contact";
            this.memberContact.Width = 97;
            // 
            // memberDescription
            // 
            this.memberDescription.Text = "Description";
            this.memberDescription.Width = 113;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btn_Inventory);
            this.panel9.Location = new System.Drawing.Point(3, 508);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(297, 58);
            this.panel9.TabIndex = 3;
            // 
            // btn_Inventory
            // 
            this.btn_Inventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(93)))), ((int)(((byte)(16)))));
            this.btn_Inventory.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inventory.Image = ((System.Drawing.Image)(resources.GetObject("btn_Inventory.Image")));
            this.btn_Inventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inventory.Location = new System.Drawing.Point(0, 0);
            this.btn_Inventory.Name = "btn_Inventory";
            this.btn_Inventory.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_Inventory.Size = new System.Drawing.Size(306, 58);
            this.btn_Inventory.TabIndex = 2;
            this.btn_Inventory.Text = "    Inventory";
            this.btn_Inventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inventory.UseVisualStyleBackColor = false;
            this.btn_Inventory.Click += new System.EventHandler(this.btn_Inventory_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btn_Inquiries);
            this.panel10.Location = new System.Drawing.Point(3, 572);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(297, 58);
            this.panel10.TabIndex = 3;
            // 
            // btn_Inquiries
            // 
            this.btn_Inquiries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(93)))), ((int)(((byte)(16)))));
            this.btn_Inquiries.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inquiries.Image = ((System.Drawing.Image)(resources.GetObject("btn_Inquiries.Image")));
            this.btn_Inquiries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inquiries.Location = new System.Drawing.Point(0, 0);
            this.btn_Inquiries.Name = "btn_Inquiries";
            this.btn_Inquiries.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_Inquiries.Size = new System.Drawing.Size(306, 58);
            this.btn_Inquiries.TabIndex = 2;
            this.btn_Inquiries.Text = "    Inquiries";
            this.btn_Inquiries.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inquiries.UseVisualStyleBackColor = false;
            this.btn_Inquiries.Click += new System.EventHandler(this.btn_Inquiries_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Recent Inquiries";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 46);
            this.label1.TabIndex = 14;
            this.label1.Text = "Inquiries";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 6;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.listView_recentInquiries);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Location = new System.Drawing.Point(136, 124);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(531, 506);
            this.guna2Panel1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(499, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "_________________________________________________";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_Reservation);
            this.panel8.Location = new System.Drawing.Point(3, 444);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(297, 58);
            this.panel8.TabIndex = 3;
            // 
            // slidebarTimer
            // 
            this.slidebarTimer.Tick += new System.EventHandler(this.slidebarTimer_Tick);
            // 
            // btn_Refer
            // 
            this.btn_Refer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(93)))), ((int)(((byte)(16)))));
            this.btn_Refer.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refer.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refer.Image")));
            this.btn_Refer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Refer.Location = new System.Drawing.Point(-1, 0);
            this.btn_Refer.Name = "btn_Refer";
            this.btn_Refer.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_Refer.Size = new System.Drawing.Size(307, 58);
            this.btn_Refer.TabIndex = 2;
            this.btn_Refer.Text = "    Refer";
            this.btn_Refer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Refer.UseVisualStyleBackColor = false;
            this.btn_Refer.Click += new System.EventHandler(this.btn_Refer_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(349, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "__________________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderRadius = 6;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.label32);
            this.guna2Panel2.Controls.Add(this.label12);
            this.guna2Panel2.Controls.Add(this.label8);
            this.guna2Panel2.Controls.Add(this.lbl_showMemberDescription);
            this.guna2Panel2.Controls.Add(this.lbl_showMemberContact);
            this.guna2Panel2.Controls.Add(this.lbl_showMemberName);
            this.guna2Panel2.Controls.Add(this.label30);
            this.guna2Panel2.Controls.Add(this.label10);
            this.guna2Panel2.Controls.Add(this.label6);
            this.guna2Panel2.Controls.Add(this.pictureBox2);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Location = new System.Drawing.Point(673, 124);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(411, 506);
            this.guna2Panel2.TabIndex = 16;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(182, 163);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(22, 23);
            this.label32.TabIndex = 40;
            this.label32.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(181, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 23);
            this.label12.TabIndex = 42;
            this.label12.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(179, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 23);
            this.label8.TabIndex = 43;
            this.label8.Text = ":";
            // 
            // lbl_showMemberDescription
            // 
            this.lbl_showMemberDescription.AutoSize = true;
            this.lbl_showMemberDescription.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_showMemberDescription.Location = new System.Drawing.Point(43, 210);
            this.lbl_showMemberDescription.Name = "lbl_showMemberDescription";
            this.lbl_showMemberDescription.Size = new System.Drawing.Size(142, 22);
            this.lbl_showMemberDescription.TabIndex = 44;
            this.lbl_showMemberDescription.Text = "Sample Data";
            // 
            // lbl_showMemberContact
            // 
            this.lbl_showMemberContact.AutoSize = true;
            this.lbl_showMemberContact.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_showMemberContact.Location = new System.Drawing.Point(218, 103);
            this.lbl_showMemberContact.Name = "lbl_showMemberContact";
            this.lbl_showMemberContact.Size = new System.Drawing.Size(142, 22);
            this.lbl_showMemberContact.TabIndex = 46;
            this.lbl_showMemberContact.Text = "Sample Data";
            // 
            // lbl_showMemberName
            // 
            this.lbl_showMemberName.AutoSize = true;
            this.lbl_showMemberName.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_showMemberName.Location = new System.Drawing.Point(216, 64);
            this.lbl_showMemberName.Name = "lbl_showMemberName";
            this.lbl_showMemberName.Size = new System.Drawing.Size(142, 22);
            this.lbl_showMemberName.TabIndex = 47;
            this.lbl_showMemberName.Text = "Sample Data";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(18, 163);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(142, 23);
            this.label30.TabIndex = 48;
            this.label30.Text = "Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 23);
            this.label10.TabIndex = 50;
            this.label10.Text = "Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 51;
            this.label6.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Inquiry Details";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.slidebar.Controls.Add(this.panel9);
            this.slidebar.Controls.Add(this.panel10);
            this.slidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidebar.Location = new System.Drawing.Point(0, 0);
            this.slidebar.MaximumSize = new System.Drawing.Size(300, 662);
            this.slidebar.MinimumSize = new System.Drawing.Size(73, 653);
            this.slidebar.Name = "slidebar";
            this.slidebar.Size = new System.Drawing.Size(300, 662);
            this.slidebar.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_adminName);
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.lbl_dot2);
            this.panel1.Controls.Add(this.lbl_dot1);
            this.panel1.Controls.Add(this.lbl_showAdminName);
            this.panel1.Controls.Add(this.lbl_showAdminID);
            this.panel1.Controls.Add(this.lbl_adminID);
            this.panel1.Controls.Add(this.btn_Menu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 115);
            this.panel1.TabIndex = 1;
            // 
            // lbl_adminName
            // 
            this.lbl_adminName.AutoSize = true;
            this.lbl_adminName.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adminName.Location = new System.Drawing.Point(13, 80);
            this.lbl_adminName.Name = "lbl_adminName";
            this.lbl_adminName.Size = new System.Drawing.Size(49, 20);
            this.lbl_adminName.TabIndex = 5;
            this.lbl_adminName.Text = "Name";
            this.lbl_adminName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Image")));
            this.btn_Logout.Location = new System.Drawing.Point(251, 9);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(31, 28);
            this.btn_Logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Logout.TabIndex = 1;
            this.btn_Logout.TabStop = false;
            // 
            // lbl_dot2
            // 
            this.lbl_dot2.AutoSize = true;
            this.lbl_dot2.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dot2.Location = new System.Drawing.Point(68, 80);
            this.lbl_dot2.Name = "lbl_dot2";
            this.lbl_dot2.Size = new System.Drawing.Size(19, 20);
            this.lbl_dot2.TabIndex = 5;
            this.lbl_dot2.Text = ":";
            this.lbl_dot2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_dot1
            // 
            this.lbl_dot1.AutoSize = true;
            this.lbl_dot1.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dot1.Location = new System.Drawing.Point(108, 53);
            this.lbl_dot1.Name = "lbl_dot1";
            this.lbl_dot1.Size = new System.Drawing.Size(19, 20);
            this.lbl_dot1.TabIndex = 5;
            this.lbl_dot1.Text = ":";
            this.lbl_dot1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_showAdminName
            // 
            this.lbl_showAdminName.AutoSize = true;
            this.lbl_showAdminName.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_showAdminName.Location = new System.Drawing.Point(93, 80);
            this.lbl_showAdminName.Name = "lbl_showAdminName";
            this.lbl_showAdminName.Size = new System.Drawing.Size(169, 20);
            this.lbl_showAdminName.TabIndex = 5;
            this.lbl_showAdminName.Text = "Saman Gunasekara";
            this.lbl_showAdminName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_showAdminID
            // 
            this.lbl_showAdminID.AutoSize = true;
            this.lbl_showAdminID.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_showAdminID.Location = new System.Drawing.Point(133, 55);
            this.lbl_showAdminID.Name = "lbl_showAdminID";
            this.lbl_showAdminID.Size = new System.Drawing.Size(89, 20);
            this.lbl_showAdminID.TabIndex = 5;
            this.lbl_showAdminID.Text = "A-00-003";
            this.lbl_showAdminID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_adminID
            // 
            this.lbl_adminID.AutoSize = true;
            this.lbl_adminID.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adminID.Location = new System.Drawing.Point(13, 55);
            this.lbl_adminID.Name = "lbl_adminID";
            this.lbl_adminID.Size = new System.Drawing.Size(89, 20);
            this.lbl_adminID.TabIndex = 5;
            this.lbl_adminID.Text = "Admin ID";
            this.lbl_adminID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Dashboard);
            this.panel2.Location = new System.Drawing.Point(3, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 58);
            this.panel2.TabIndex = 3;
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(93)))), ((int)(((byte)(16)))));
            this.btn_Dashboard.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("btn_Dashboard.Image")));
            this.btn_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dashboard.Location = new System.Drawing.Point(0, 0);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_Dashboard.Size = new System.Drawing.Size(306, 58);
            this.btn_Dashboard.TabIndex = 2;
            this.btn_Dashboard.Text = "    Dashboard";
            this.btn_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dashboard.UseVisualStyleBackColor = false;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Books);
            this.panel3.Location = new System.Drawing.Point(3, 188);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(297, 58);
            this.panel3.TabIndex = 3;
            // 
            // btn_Books
            // 
            this.btn_Books.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(93)))), ((int)(((byte)(16)))));
            this.btn_Books.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Books.Image = ((System.Drawing.Image)(resources.GetObject("btn_Books.Image")));
            this.btn_Books.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Books.Location = new System.Drawing.Point(0, 1);
            this.btn_Books.Name = "btn_Books";
            this.btn_Books.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_Books.Size = new System.Drawing.Size(306, 58);
            this.btn_Books.TabIndex = 2;
            this.btn_Books.Text = "    Books";
            this.btn_Books.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Books.UseVisualStyleBackColor = false;
            this.btn_Books.Click += new System.EventHandler(this.btn_Books_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_Members);
            this.panel4.Location = new System.Drawing.Point(3, 252);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(297, 58);
            this.panel4.TabIndex = 3;
            // 
            // btn_Members
            // 
            this.btn_Members.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(93)))), ((int)(((byte)(16)))));
            this.btn_Members.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Members.Image = ((System.Drawing.Image)(resources.GetObject("btn_Members.Image")));
            this.btn_Members.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Members.Location = new System.Drawing.Point(0, 0);
            this.btn_Members.Name = "btn_Members";
            this.btn_Members.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_Members.Size = new System.Drawing.Size(306, 58);
            this.btn_Members.TabIndex = 2;
            this.btn_Members.Text = "    Members";
            this.btn_Members.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Members.UseVisualStyleBackColor = false;
            this.btn_Members.Click += new System.EventHandler(this.btn_Members_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_Borrow);
            this.panel5.Location = new System.Drawing.Point(3, 316);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(297, 58);
            this.panel5.TabIndex = 3;
            // 
            // btn_Borrow
            // 
            this.btn_Borrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(93)))), ((int)(((byte)(16)))));
            this.btn_Borrow.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Borrow.Image = ((System.Drawing.Image)(resources.GetObject("btn_Borrow.Image")));
            this.btn_Borrow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Borrow.Location = new System.Drawing.Point(0, 0);
            this.btn_Borrow.Name = "btn_Borrow";
            this.btn_Borrow.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_Borrow.Size = new System.Drawing.Size(306, 58);
            this.btn_Borrow.TabIndex = 2;
            this.btn_Borrow.Text = "    Borrow";
            this.btn_Borrow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Borrow.UseVisualStyleBackColor = false;
            this.btn_Borrow.Click += new System.EventHandler(this.btn_Borrow_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_Refer);
            this.panel6.Location = new System.Drawing.Point(3, 380);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(297, 58);
            this.panel6.TabIndex = 3;
            // 
            // Admin_View_Inquiry_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 662);
            this.Controls.Add(this.slidebar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_View_Inquiry_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System";
            this.Load += new System.EventHandler(this.Admin_View_Inquiry_Management_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Admin_View_Inquiry_Management_MouseClick);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Reservation;
        private System.Windows.Forms.ListView listView_recentInquiries;
        private System.Windows.Forms.ColumnHeader memberFullName;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btn_Inventory;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btn_Inquiries;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Timer slidebarTimer;
        private System.Windows.Forms.Button btn_Refer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel slidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_adminName;
        private System.Windows.Forms.PictureBox btn_Logout;
        private System.Windows.Forms.Label lbl_dot2;
        private System.Windows.Forms.Label lbl_dot1;
        private System.Windows.Forms.Label lbl_showAdminName;
        private System.Windows.Forms.Label lbl_showAdminID;
        private System.Windows.Forms.Label lbl_adminID;
        private System.Windows.Forms.PictureBox btn_Menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Books;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_Members;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_Borrow;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ColumnHeader memberContact;
        private System.Windows.Forms.ColumnHeader memberDescription;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_showMemberDescription;
        private System.Windows.Forms.Label lbl_showMemberContact;
        private System.Windows.Forms.Label lbl_showMemberName;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
    }
}