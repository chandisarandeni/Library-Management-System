namespace Library_Management_System
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_getHelp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_memberUsername = new System.Windows.Forms.TextBox();
            this.txt_memberPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_forgotPassword = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBox_showPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 523);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(513, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 92);
            this.label1.TabIndex = 1;
            this.label1.Text = "Library\r\nManagement System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(513, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "___________";
            // 
            // lbl_getHelp
            // 
            this.lbl_getHelp.AutoSize = true;
            this.lbl_getHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_getHelp.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_getHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_getHelp.Location = new System.Drawing.Point(978, 610);
            this.lbl_getHelp.Name = "lbl_getHelp";
            this.lbl_getHelp.Size = new System.Drawing.Size(99, 20);
            this.lbl_getHelp.TabIndex = 3;
            this.lbl_getHelp.Text = "Get Help?";
            this.lbl_getHelp.Click += new System.EventHandler(this.lbl_getHelp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(517, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(629, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = ":";
            // 
            // txt_memberUsername
            // 
            this.txt_memberUsername.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_memberUsername.Location = new System.Drawing.Point(663, 301);
            this.txt_memberUsername.Name = "txt_memberUsername";
            this.txt_memberUsername.Size = new System.Drawing.Size(312, 30);
            this.txt_memberUsername.TabIndex = 6;
            this.txt_memberUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_memberUsername_KeyDown);
            // 
            // txt_memberPassword
            // 
            this.txt_memberPassword.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_memberPassword.Location = new System.Drawing.Point(663, 359);
            this.txt_memberPassword.Name = "txt_memberPassword";
            this.txt_memberPassword.Size = new System.Drawing.Size(312, 30);
            this.txt_memberPassword.TabIndex = 9;
            this.txt_memberPassword.UseSystemPasswordChar = true;
            this.txt_memberPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_memberPassword_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(629, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(517, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(662, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Forgot Password?";
            // 
            // lbl_forgotPassword
            // 
            this.lbl_forgotPassword.AutoSize = true;
            this.lbl_forgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_forgotPassword.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_forgotPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_forgotPassword.Location = new System.Drawing.Point(822, 414);
            this.lbl_forgotPassword.Name = "lbl_forgotPassword";
            this.lbl_forgotPassword.Size = new System.Drawing.Size(95, 16);
            this.lbl_forgotPassword.TabIndex = 11;
            this.lbl_forgotPassword.Text = "Click here.";
            this.lbl_forgotPassword.Click += new System.EventHandler(this.lbl_forgotPassword_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Login.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Login.Location = new System.Drawing.Point(686, 457);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(111, 41);
            this.btn_Login.TabIndex = 12;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseCompatibleTextRendering = true;
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            this.btn_Login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Login_KeyDown);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Cancel.Location = new System.Drawing.Point(825, 457);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(111, 41);
            this.btn_Cancel.TabIndex = 13;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseCompatibleTextRendering = true;
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(518, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(399, 48);
            this.label10.TabIndex = 14;
            this.label10.Text = "To create an accessible library management system\r\nthat connects readers\r\nwith bo" +
    "oks effortlessly.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(37, 541);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(692, 46);
            this.label11.TabIndex = 15;
            this.label11.Text = "____________________________";
            // 
            // checkBox_showPassword
            // 
            this.checkBox_showPassword.AutoSize = true;
            this.checkBox_showPassword.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_showPassword.Location = new System.Drawing.Point(981, 366);
            this.checkBox_showPassword.Name = "checkBox_showPassword";
            this.checkBox_showPassword.Size = new System.Drawing.Size(61, 20);
            this.checkBox_showPassword.TabIndex = 16;
            this.checkBox_showPassword.Text = "Show";
            this.checkBox_showPassword.UseVisualStyleBackColor = true;
            this.checkBox_showPassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 653);
            this.Controls.Add(this.checkBox_showPassword);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_forgotPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_memberPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_memberUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_getHelp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_getHelp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_memberUsername;
        private System.Windows.Forms.TextBox txt_memberPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_forgotPassword;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox_showPassword;
    }
}