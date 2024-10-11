namespace PharmacyManagementSystem
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.addUsrBtn = new Guna.UI2.WinForms.Guna2Button();
            this.lgoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.prflBtn = new Guna.UI2.WinForms.Guna2Button();
            this.viewUsrBtn = new Guna.UI2.WinForms.Guna2Button();
            this.dshbrdBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uC_Dashboard1 = new PharmacyManagementSystem.AdminUC.UC_Dashboard();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_Adduser1 = new PharmacyManagementSystem.AdminUC.UC_Adduser();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.addUsrBtn);
            this.panel1.Controls.Add(this.lgoutBtn);
            this.panel1.Controls.Add(this.prflBtn);
            this.panel1.Controls.Add(this.viewUsrBtn);
            this.panel1.Controls.Add(this.dshbrdBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 770);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(128, 730);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "username";
            // 
            // addUsrBtn
            // 
            this.addUsrBtn.Animated = true;
            this.addUsrBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.addUsrBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addUsrBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addUsrBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addUsrBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addUsrBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addUsrBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.addUsrBtn.ForeColor = System.Drawing.Color.White;
            this.addUsrBtn.Image = ((System.Drawing.Image)(resources.GetObject("addUsrBtn.Image")));
            this.addUsrBtn.ImageSize = new System.Drawing.Size(26, 26);
            this.addUsrBtn.Location = new System.Drawing.Point(66, 375);
            this.addUsrBtn.Name = "addUsrBtn";
            this.addUsrBtn.Size = new System.Drawing.Size(300, 45);
            this.addUsrBtn.TabIndex = 6;
            this.addUsrBtn.Text = "Add User";
            this.addUsrBtn.Click += new System.EventHandler(this.addUsrBtn_Click);
            // 
            // lgoutBtn
            // 
            this.lgoutBtn.Animated = true;
            this.lgoutBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.lgoutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.lgoutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.lgoutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.lgoutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.lgoutBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lgoutBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lgoutBtn.ForeColor = System.Drawing.Color.White;
            this.lgoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("lgoutBtn.Image")));
            this.lgoutBtn.Location = new System.Drawing.Point(66, 630);
            this.lgoutBtn.Name = "lgoutBtn";
            this.lgoutBtn.Size = new System.Drawing.Size(300, 45);
            this.lgoutBtn.TabIndex = 5;
            this.lgoutBtn.Text = "Logout";
            this.lgoutBtn.Click += new System.EventHandler(this.lgoutBtn_Click);
            // 
            // prflBtn
            // 
            this.prflBtn.Animated = true;
            this.prflBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.prflBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.prflBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.prflBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.prflBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.prflBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prflBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.prflBtn.ForeColor = System.Drawing.Color.White;
            this.prflBtn.Image = ((System.Drawing.Image)(resources.GetObject("prflBtn.Image")));
            this.prflBtn.Location = new System.Drawing.Point(66, 545);
            this.prflBtn.Name = "prflBtn";
            this.prflBtn.Size = new System.Drawing.Size(300, 45);
            this.prflBtn.TabIndex = 4;
            this.prflBtn.Text = "Profile";
            // 
            // viewUsrBtn
            // 
            this.viewUsrBtn.Animated = true;
            this.viewUsrBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.viewUsrBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewUsrBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewUsrBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewUsrBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewUsrBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewUsrBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.viewUsrBtn.ForeColor = System.Drawing.Color.White;
            this.viewUsrBtn.Image = ((System.Drawing.Image)(resources.GetObject("viewUsrBtn.Image")));
            this.viewUsrBtn.ImageSize = new System.Drawing.Size(22, 22);
            this.viewUsrBtn.Location = new System.Drawing.Point(66, 462);
            this.viewUsrBtn.Name = "viewUsrBtn";
            this.viewUsrBtn.Size = new System.Drawing.Size(300, 45);
            this.viewUsrBtn.TabIndex = 3;
            this.viewUsrBtn.Text = "View User";
            this.viewUsrBtn.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // dshbrdBtn
            // 
            this.dshbrdBtn.Animated = true;
            this.dshbrdBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.dshbrdBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dshbrdBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dshbrdBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dshbrdBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dshbrdBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dshbrdBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.dshbrdBtn.ForeColor = System.Drawing.Color.White;
            this.dshbrdBtn.Image = ((System.Drawing.Image)(resources.GetObject("dshbrdBtn.Image")));
            this.dshbrdBtn.ImageSize = new System.Drawing.Size(19, 19);
            this.dshbrdBtn.Location = new System.Drawing.Point(66, 291);
            this.dshbrdBtn.Name = "dshbrdBtn";
            this.dshbrdBtn.Size = new System.Drawing.Size(300, 45);
            this.dshbrdBtn.TabIndex = 2;
            this.dshbrdBtn.Text = "Dashboard";
            this.dshbrdBtn.Click += new System.EventHandler(this.dshbrdBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(115, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.uC_Adduser1);
            this.panel3.Controls.Add(this.uC_Dashboard1);
            this.panel3.Location = new System.Drawing.Point(365, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1022, 769);
            this.panel3.TabIndex = 2;
            // 
            // uC_Dashboard1
            // 
            this.uC_Dashboard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_Dashboard1.BackColor = System.Drawing.Color.White;
            this.uC_Dashboard1.Location = new System.Drawing.Point(2, -1);
            this.uC_Dashboard1.Name = "uC_Dashboard1";
            this.uC_Dashboard1.Size = new System.Drawing.Size(1016, 770);
            this.uC_Dashboard1.TabIndex = 0;
            this.uC_Dashboard1.Load += new System.EventHandler(this.uC_Dashboard1_Load);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel3;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel3;
            // 
            // uC_Adduser1
            // 
            this.uC_Adduser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_Adduser1.BackColor = System.Drawing.Color.White;
            this.uC_Adduser1.Location = new System.Drawing.Point(1, 0);
            this.uC_Adduser1.Name = "uC_Adduser1";
            this.uC_Adduser1.Size = new System.Drawing.Size(1017, 769);
            this.uC_Adduser1.TabIndex = 1;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 768);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button dshbrdBtn;
        private Guna.UI2.WinForms.Guna2Button addUsrBtn;
        private Guna.UI2.WinForms.Guna2Button lgoutBtn;
        private Guna.UI2.WinForms.Guna2Button prflBtn;
        private Guna.UI2.WinForms.Guna2Button viewUsrBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private AdminUC.UC_Dashboard uC_Dashboard1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private AdminUC.UC_Adduser uC_Adduser1;
    }
}