namespace Library_Management_System
{
    partial class Admin_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Dashboard));
            this.slidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
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
            this.btn_Refer = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.PictureBox();
            this.slidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.slidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Logout)).BeginInit();
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
            this.slidebar.Controls.Add(this.panel7);
            this.slidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidebar.Location = new System.Drawing.Point(0, 0);
            this.slidebar.MaximumSize = new System.Drawing.Size(281, 662);
            this.slidebar.MinimumSize = new System.Drawing.Size(73, 653);
            this.slidebar.Name = "slidebar";
            this.slidebar.Size = new System.Drawing.Size(281, 653);
            this.slidebar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_Menu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 115);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Menu";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Dashboard);
            this.panel2.Location = new System.Drawing.Point(3, 124);
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
            this.panel3.Controls.Add(this.btn_Books);
            this.panel3.Location = new System.Drawing.Point(3, 190);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 60);
            this.panel3.TabIndex = 3;
            // 
            // btn_Books
            // 
            this.btn_Books.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(93)))), ((int)(((byte)(16)))));
            this.btn_Books.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Books.Image = ((System.Drawing.Image)(resources.GetObject("btn_Books.Image")));
            this.btn_Books.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Books.Location = new System.Drawing.Point(3, 0);
            this.btn_Books.Name = "btn_Books";
            this.btn_Books.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_Books.Size = new System.Drawing.Size(336, 60);
            this.btn_Books.TabIndex = 2;
            this.btn_Books.Text = "    Books";
            this.btn_Books.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Books.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_Members);
            this.panel4.Location = new System.Drawing.Point(3, 256);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(278, 60);
            this.panel4.TabIndex = 4;
            // 
            // btn_Members
            // 
            this.btn_Members.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(93)))), ((int)(((byte)(16)))));
            this.btn_Members.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Members.Image = ((System.Drawing.Image)(resources.GetObject("btn_Members.Image")));
            this.btn_Members.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Members.Location = new System.Drawing.Point(3, 0);
            this.btn_Members.Name = "btn_Members";
            this.btn_Members.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_Members.Size = new System.Drawing.Size(336, 60);
            this.btn_Members.TabIndex = 2;
            this.btn_Members.Text = "    Members";
            this.btn_Members.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Members.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_Borrow);
            this.panel5.Location = new System.Drawing.Point(3, 322);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(278, 60);
            this.panel5.TabIndex = 5;
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
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_Refer);
            this.panel6.Location = new System.Drawing.Point(3, 388);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(278, 60);
            this.panel6.TabIndex = 6;
            // 
            // btn_Refer
            // 
            this.btn_Refer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(93)))), ((int)(((byte)(16)))));
            this.btn_Refer.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refer.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refer.Image")));
            this.btn_Refer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Refer.Location = new System.Drawing.Point(3, 0);
            this.btn_Refer.Name = "btn_Refer";
            this.btn_Refer.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_Refer.Size = new System.Drawing.Size(336, 60);
            this.btn_Refer.TabIndex = 2;
            this.btn_Refer.Text = "    Refer";
            this.btn_Refer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Refer.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_Logout);
            this.panel7.Location = new System.Drawing.Point(3, 454);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(278, 199);
            this.panel7.TabIndex = 2;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Image")));
            this.btn_Logout.Location = new System.Drawing.Point(17, 133);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(33, 33);
            this.btn_Logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Logout.TabIndex = 1;
            this.btn_Logout.TabStop = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // slidebarTimer
            // 
            this.slidebarTimer.Tick += new System.EventHandler(this.sliderbarTimber_Tick);
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 653);
            this.Controls.Add(this.slidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Admin_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System";
            this.Load += new System.EventHandler(this.Admin_Dashboard_Load);
            this.slidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Logout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel slidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.PictureBox btn_Menu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer slidebarTimer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Books;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_Members;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_Borrow;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_Refer;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox btn_Logout;
    }
}