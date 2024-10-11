namespace PharmacyManagementSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exitbtn = new Guna.UI2.WinForms.Guna2Button();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.usrnameinput = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.signin = new System.Windows.Forms.Label();
            this.signinbtn = new Guna.UI2.WinForms.Guna2Button();
            this.resetbtn = new Guna.UI2.WinForms.Guna2Button();
            this.pswrdinput = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 770);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 363);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 311);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 195);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pharmacy\r\nManagement\r\nSystem";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitbtn.Animated = true;
            this.exitbtn.AutoRoundedCorners = true;
            this.exitbtn.BackColor = System.Drawing.Color.Transparent;
            this.exitbtn.BorderColor = System.Drawing.Color.Transparent;
            this.exitbtn.BorderRadius = 14;
            this.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitbtn.FillColor = System.Drawing.Color.Transparent;
            this.exitbtn.FocusedColor = System.Drawing.Color.Transparent;
            this.exitbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitbtn.ForeColor = System.Drawing.Color.Transparent;
            this.exitbtn.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.exitbtn.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.exitbtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.exitbtn.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.exitbtn.Image = ((System.Drawing.Image)(resources.GetObject("exitbtn.Image")));
            this.exitbtn.ImageSize = new System.Drawing.Size(30, 30);
            this.exitbtn.IndicateFocus = true;
            this.exitbtn.Location = new System.Drawing.Point(1345, 5);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(34, 31);
            this.exitbtn.TabIndex = 1;
            this.exitbtn.UseTransparentBackground = true;
            this.exitbtn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(707, 320);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(105, 24);
            this.username.TabIndex = 2;
            this.username.Text = "User Name";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(706, 444);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(92, 24);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(851, 153);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // usrnameinput
            // 
            this.usrnameinput.AcceptsReturn = true;
            this.usrnameinput.AcceptsTab = true;
            this.usrnameinput.Animated = true;
            this.usrnameinput.AutoRoundedCorners = true;
            this.usrnameinput.BorderRadius = 20;
            this.usrnameinput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usrnameinput.DefaultText = "";
            this.usrnameinput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usrnameinput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usrnameinput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usrnameinput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usrnameinput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usrnameinput.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.usrnameinput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usrnameinput.Location = new System.Drawing.Point(710, 357);
            this.usrnameinput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usrnameinput.Name = "usrnameinput";
            this.usrnameinput.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.usrnameinput.PasswordChar = '\0';
            this.usrnameinput.PlaceholderText = "";
            this.usrnameinput.SelectedText = "";
            this.usrnameinput.Size = new System.Drawing.Size(407, 42);
            this.usrnameinput.TabIndex = 0;
            this.usrnameinput.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(927, 847);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(465, 64);
            this.guna2TextBox2.TabIndex = 5;
            // 
            // signin
            // 
            this.signin.AutoSize = true;
            this.signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin.Location = new System.Drawing.Point(854, 249);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(85, 25);
            this.signin.TabIndex = 6;
            this.signin.Text = "Sign In";
            // 
            // signinbtn
            // 
            this.signinbtn.BorderRadius = 20;
            this.signinbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signinbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signinbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signinbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signinbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.signinbtn.ForeColor = System.Drawing.Color.White;
            this.signinbtn.Image = ((System.Drawing.Image)(resources.GetObject("signinbtn.Image")));
            this.signinbtn.ImageSize = new System.Drawing.Size(35, 35);
            this.signinbtn.IndicateFocus = true;
            this.signinbtn.Location = new System.Drawing.Point(762, 556);
            this.signinbtn.Name = "signinbtn";
            this.signinbtn.Size = new System.Drawing.Size(116, 43);
            this.signinbtn.TabIndex = 2;
            this.signinbtn.Text = "Sign In";
            this.signinbtn.Click += new System.EventHandler(this.signinbtn_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.BorderRadius = 20;
            this.resetbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resetbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resetbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resetbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resetbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.resetbtn.ForeColor = System.Drawing.Color.White;
            this.resetbtn.Image = ((System.Drawing.Image)(resources.GetObject("resetbtn.Image")));
            this.resetbtn.ImageSize = new System.Drawing.Size(27, 27);
            this.resetbtn.IndicateFocus = true;
            this.resetbtn.Location = new System.Drawing.Point(888, 556);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(116, 43);
            this.resetbtn.TabIndex = 3;
            this.resetbtn.Text = "Reset";
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // pswrdinput
            // 
            this.pswrdinput.AcceptsReturn = true;
            this.pswrdinput.AcceptsTab = true;
            this.pswrdinput.Animated = true;
            this.pswrdinput.AutoRoundedCorners = true;
            this.pswrdinput.BorderRadius = 20;
            this.pswrdinput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pswrdinput.DefaultText = "";
            this.pswrdinput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pswrdinput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pswrdinput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pswrdinput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pswrdinput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pswrdinput.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.pswrdinput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pswrdinput.Location = new System.Drawing.Point(711, 482);
            this.pswrdinput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pswrdinput.Name = "pswrdinput";
            this.pswrdinput.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pswrdinput.PasswordChar = '*';
            this.pswrdinput.PlaceholderText = "";
            this.pswrdinput.SelectedText = "";
            this.pswrdinput.Size = new System.Drawing.Size(407, 42);
            this.pswrdinput.TabIndex = 1;
            this.pswrdinput.TextChanged += new System.EventHandler(this.pswrdinput_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1383, 768);
            this.Controls.Add(this.pswrdinput);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.signinbtn);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.usrnameinput);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button exitbtn;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox usrnameinput;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.Label signin;
        private Guna.UI2.WinForms.Guna2Button signinbtn;
        private Guna.UI2.WinForms.Guna2Button resetbtn;
        private Guna.UI2.WinForms.Guna2TextBox pswrdinput;
    }
}

