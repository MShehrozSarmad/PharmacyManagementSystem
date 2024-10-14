namespace PharmacyManagementSystem.PharmacistUC
{
    partial class UC_AddMedicine
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AddMedicine));
            this.btnAddMdcn = new Guna.UI2.WinForms.Guna2Button();
            this.txtMFG = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMedId = new Guna.UI2.WinForms.Guna2TextBox();
            this.name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMedName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMedNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExp = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPricePU = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // btnAddMdcn
            // 
            this.btnAddMdcn.Animated = true;
            this.btnAddMdcn.AutoRoundedCorners = true;
            this.btnAddMdcn.BorderRadius = 25;
            this.btnAddMdcn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMdcn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMdcn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddMdcn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddMdcn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAddMdcn.ForeColor = System.Drawing.Color.White;
            this.btnAddMdcn.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMdcn.Image")));
            this.btnAddMdcn.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddMdcn.IndicateFocus = true;
            this.btnAddMdcn.Location = new System.Drawing.Point(833, 696);
            this.btnAddMdcn.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMdcn.Name = "btnAddMdcn";
            this.btnAddMdcn.Size = new System.Drawing.Size(155, 53);
            this.btnAddMdcn.TabIndex = 18;
            this.btnAddMdcn.Text = "Add";
            this.btnAddMdcn.Click += new System.EventHandler(this.btnAddMdcn_Click);
            // 
            // txtMFG
            // 
            this.txtMFG.Animated = true;
            this.txtMFG.AutoRoundedCorners = true;
            this.txtMFG.BackColor = System.Drawing.Color.Transparent;
            this.txtMFG.BorderColor = System.Drawing.Color.Silver;
            this.txtMFG.BorderRadius = 26;
            this.txtMFG.Checked = true;
            this.txtMFG.FillColor = System.Drawing.Color.White;
            this.txtMFG.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMFG.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtMFG.IndicateFocus = true;
            this.txtMFG.Location = new System.Drawing.Point(161, 694);
            this.txtMFG.Margin = new System.Windows.Forms.Padding(4);
            this.txtMFG.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtMFG.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtMFG.Name = "txtMFG";
            this.txtMFG.Size = new System.Drawing.Size(471, 54);
            this.txtMFG.TabIndex = 17;
            this.txtMFG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMFG.UseTransparentBackground = true;
            this.txtMFG.Value = new System.DateTime(2024, 10, 11, 15, 8, 48, 912);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 648);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "MFG Date";
            // 
            // txtMedId
            // 
            this.txtMedId.AcceptsReturn = true;
            this.txtMedId.AcceptsTab = true;
            this.txtMedId.Animated = true;
            this.txtMedId.AutoRoundedCorners = true;
            this.txtMedId.BorderRadius = 26;
            this.txtMedId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedId.DefaultText = "";
            this.txtMedId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMedId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMedId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedId.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtMedId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedId.Location = new System.Drawing.Point(161, 224);
            this.txtMedId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMedId.Name = "txtMedId";
            this.txtMedId.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.txtMedId.PasswordChar = '\0';
            this.txtMedId.PlaceholderText = "";
            this.txtMedId.SelectedText = "";
            this.txtMedId.Size = new System.Drawing.Size(471, 54);
            this.txtMedId.TabIndex = 15;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(157, 178);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(141, 29);
            this.name.TabIndex = 20;
            this.name.Text = "Medicine ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 43);
            this.label1.TabIndex = 16;
            this.label1.Text = "Add User";
            // 
            // txtMedName
            // 
            this.txtMedName.AcceptsReturn = true;
            this.txtMedName.AcceptsTab = true;
            this.txtMedName.Animated = true;
            this.txtMedName.AutoRoundedCorners = true;
            this.txtMedName.BorderRadius = 26;
            this.txtMedName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedName.DefaultText = "";
            this.txtMedName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMedName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMedName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedName.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtMedName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedName.Location = new System.Drawing.Point(162, 375);
            this.txtMedName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMedName.Name = "txtMedName";
            this.txtMedName.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.txtMedName.PasswordChar = '\0';
            this.txtMedName.PlaceholderText = "";
            this.txtMedName.SelectedText = "";
            this.txtMedName.Size = new System.Drawing.Size(471, 54);
            this.txtMedName.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 329);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Medicine Name";
            // 
            // txtMedNo
            // 
            this.txtMedNo.AcceptsReturn = true;
            this.txtMedNo.AcceptsTab = true;
            this.txtMedNo.Animated = true;
            this.txtMedNo.AutoRoundedCorners = true;
            this.txtMedNo.BorderRadius = 26;
            this.txtMedNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedNo.DefaultText = "";
            this.txtMedNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMedNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMedNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedNo.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtMedNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedNo.Location = new System.Drawing.Point(161, 544);
            this.txtMedNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMedNo.Name = "txtMedNo";
            this.txtMedNo.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.txtMedNo.PasswordChar = '\0';
            this.txtMedNo.PlaceholderText = "";
            this.txtMedNo.SelectedText = "";
            this.txtMedNo.Size = new System.Drawing.Size(471, 54);
            this.txtMedNo.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 498);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Medicine No";
            // 
            // txtExp
            // 
            this.txtExp.Animated = true;
            this.txtExp.AutoRoundedCorners = true;
            this.txtExp.BackColor = System.Drawing.Color.Transparent;
            this.txtExp.BorderColor = System.Drawing.Color.Silver;
            this.txtExp.BorderRadius = 26;
            this.txtExp.Checked = true;
            this.txtExp.FillColor = System.Drawing.Color.White;
            this.txtExp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtExp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtExp.IndicateFocus = true;
            this.txtExp.Location = new System.Drawing.Point(765, 224);
            this.txtExp.Margin = new System.Windows.Forms.Padding(4);
            this.txtExp.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtExp.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(471, 54);
            this.txtExp.TabIndex = 26;
            this.txtExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtExp.UseTransparentBackground = true;
            this.txtExp.Value = new System.DateTime(2024, 10, 11, 15, 8, 48, 912);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(760, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "Expiry Date";
            // 
            // txtQuantity
            // 
            this.txtQuantity.AcceptsReturn = true;
            this.txtQuantity.AcceptsTab = true;
            this.txtQuantity.Animated = true;
            this.txtQuantity.AutoRoundedCorners = true;
            this.txtQuantity.BorderRadius = 26;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Location = new System.Drawing.Point(765, 375);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(471, 54);
            this.txtQuantity.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(761, 329);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 29);
            this.label6.TabIndex = 29;
            this.label6.Text = "Quantity";
            // 
            // txtPricePU
            // 
            this.txtPricePU.AcceptsReturn = true;
            this.txtPricePU.AcceptsTab = true;
            this.txtPricePU.Animated = true;
            this.txtPricePU.AutoRoundedCorners = true;
            this.txtPricePU.BorderRadius = 26;
            this.txtPricePU.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPricePU.DefaultText = "";
            this.txtPricePU.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPricePU.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPricePU.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPricePU.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPricePU.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPricePU.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtPricePU.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPricePU.Location = new System.Drawing.Point(765, 544);
            this.txtPricePU.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPricePU.Name = "txtPricePU";
            this.txtPricePU.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.txtPricePU.PasswordChar = '\0';
            this.txtPricePU.PlaceholderText = "";
            this.txtPricePU.SelectedText = "";
            this.txtPricePU.Size = new System.Drawing.Size(471, 54);
            this.txtPricePU.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(761, 498);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 29);
            this.label7.TabIndex = 31;
            this.label7.Text = "Price Per Unit";
            // 
            // btnReset
            // 
            this.btnReset.Animated = true;
            this.btnReset.AutoRoundedCorners = true;
            this.btnReset.BorderRadius = 25;
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageSize = new System.Drawing.Size(26, 26);
            this.btnReset.IndicateFocus = true;
            this.btnReset.Location = new System.Drawing.Point(1026, 696);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(155, 53);
            this.btnReset.TabIndex = 32;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_AddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtPricePU);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtExp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMedNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMedName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddMdcn);
            this.Controls.Add(this.txtMFG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMedId);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "UC_AddMedicine";
            this.Size = new System.Drawing.Size(1412, 947);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnAddMdcn;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtMFG;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtMedId;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtMedName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtMedNo;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtExp;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtPricePU;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
