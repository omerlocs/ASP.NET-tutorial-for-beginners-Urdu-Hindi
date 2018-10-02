namespace Library.WinUI
{
    partial class frmManageMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageMembers));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoadPhoto = new System.Windows.Forms.Button();
            this.txtMembershipID = new System.Windows.Forms.TextBox();
            this.txtCNIC = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.rbxfemale = new System.Windows.Forms.RadioButton();
            this.rbxmale = new System.Windows.Forms.RadioButton();
            this.chbGuest = new System.Windows.Forms.CheckBox();
            this.chbTemporary = new System.Windows.Forms.CheckBox();
            this.chbPermanent = new System.Windows.Forms.CheckBox();
            this.gbxGender = new System.Windows.Forms.GroupBox();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.pbxMemberPhoto = new System.Windows.Forms.PictureBox();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.lbxMemberType = new System.Windows.Forms.ListBox();
            this.lblMembershipID = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.lblCNIC = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblMemberType = new System.Windows.Forms.Label();
            this.tsmMembers = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tsbLoadPhoto = new System.Windows.Forms.ToolStripButton();
            this.gbxGender.SuspendLayout();
            this.gbxCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMemberPhoto)).BeginInit();
            this.tsmMembers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(276, 330);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(195, 330);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(111, 330);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(30, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnLoadPhoto
            // 
            this.btnLoadPhoto.Location = new System.Drawing.Point(305, 133);
            this.btnLoadPhoto.Name = "btnLoadPhoto";
            this.btnLoadPhoto.Size = new System.Drawing.Size(75, 23);
            this.btnLoadPhoto.TabIndex = 12;
            this.btnLoadPhoto.Text = "Load Photo";
            this.btnLoadPhoto.UseVisualStyleBackColor = true;
            this.btnLoadPhoto.Click += new System.EventHandler(this.btnLoadPhoto_Click);
            // 
            // txtMembershipID
            // 
            this.txtMembershipID.Location = new System.Drawing.Point(111, 69);
            this.txtMembershipID.Name = "txtMembershipID";
            this.txtMembershipID.Size = new System.Drawing.Size(171, 20);
            this.txtMembershipID.TabIndex = 1;
            // 
            // txtCNIC
            // 
            this.txtCNIC.Location = new System.Drawing.Point(111, 147);
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(171, 20);
            this.txtCNIC.TabIndex = 7;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(111, 121);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(171, 20);
            this.txtFatherName.TabIndex = 5;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(111, 95);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(171, 20);
            this.txtMemberName.TabIndex = 3;
            // 
            // rbxfemale
            // 
            this.rbxfemale.AutoSize = true;
            this.rbxfemale.Location = new System.Drawing.Point(6, 37);
            this.rbxfemale.Name = "rbxfemale";
            this.rbxfemale.Size = new System.Drawing.Size(56, 17);
            this.rbxfemale.TabIndex = 1;
            this.rbxfemale.Text = "female";
            this.rbxfemale.UseVisualStyleBackColor = true;
            // 
            // rbxmale
            // 
            this.rbxmale.AutoSize = true;
            this.rbxmale.Checked = true;
            this.rbxmale.Location = new System.Drawing.Point(6, 19);
            this.rbxmale.Name = "rbxmale";
            this.rbxmale.Size = new System.Drawing.Size(47, 17);
            this.rbxmale.TabIndex = 0;
            this.rbxmale.TabStop = true;
            this.rbxmale.Text = "male";
            this.rbxmale.UseVisualStyleBackColor = true;
            // 
            // chbGuest
            // 
            this.chbGuest.AutoSize = true;
            this.chbGuest.Location = new System.Drawing.Point(11, 56);
            this.chbGuest.Name = "chbGuest";
            this.chbGuest.Size = new System.Drawing.Size(54, 17);
            this.chbGuest.TabIndex = 2;
            this.chbGuest.Text = "Guest";
            this.chbGuest.UseVisualStyleBackColor = true;
            // 
            // chbTemporary
            // 
            this.chbTemporary.AutoSize = true;
            this.chbTemporary.Location = new System.Drawing.Point(11, 38);
            this.chbTemporary.Name = "chbTemporary";
            this.chbTemporary.Size = new System.Drawing.Size(76, 17);
            this.chbTemporary.TabIndex = 1;
            this.chbTemporary.Text = "Temporary";
            this.chbTemporary.UseVisualStyleBackColor = true;
            // 
            // chbPermanent
            // 
            this.chbPermanent.AutoSize = true;
            this.chbPermanent.Location = new System.Drawing.Point(11, 19);
            this.chbPermanent.Name = "chbPermanent";
            this.chbPermanent.Size = new System.Drawing.Size(77, 17);
            this.chbPermanent.TabIndex = 0;
            this.chbPermanent.Text = "Permanent";
            this.chbPermanent.UseVisualStyleBackColor = true;
            // 
            // gbxGender
            // 
            this.gbxGender.Controls.Add(this.rbxmale);
            this.gbxGender.Controls.Add(this.rbxfemale);
            this.gbxGender.Location = new System.Drawing.Point(286, 250);
            this.gbxGender.Name = "gbxGender";
            this.gbxGender.Size = new System.Drawing.Size(112, 70);
            this.gbxGender.TabIndex = 14;
            this.gbxGender.TabStop = false;
            this.gbxGender.Text = "Gender.";
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.chbPermanent);
            this.gbxCategory.Controls.Add(this.chbTemporary);
            this.gbxCategory.Controls.Add(this.chbGuest);
            this.gbxCategory.Location = new System.Drawing.Point(288, 162);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(112, 82);
            this.gbxCategory.TabIndex = 13;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Category.";
            // 
            // pbxMemberPhoto
            // 
            this.pbxMemberPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxMemberPhoto.Location = new System.Drawing.Point(297, 67);
            this.pbxMemberPhoto.Name = "pbxMemberPhoto";
            this.pbxMemberPhoto.Size = new System.Drawing.Size(92, 60);
            this.pbxMemberPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMemberPhoto.TabIndex = 0;
            this.pbxMemberPhoto.TabStop = false;
            // 
            // cbxCity
            // 
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Items.AddRange(new object[] {
            "Multan",
            "Bahawalpur",
            "Rahim Yar Khan",
            "Khanewal",
            "Muzafar Garh",
            "Lahore",
            "Karachi",
            "Islamabad",
            "Peshawar",
            "Quetta"});
            this.cbxCity.Location = new System.Drawing.Point(111, 173);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(171, 21);
            this.cbxCity.TabIndex = 9;
            // 
            // lbxMemberType
            // 
            this.lbxMemberType.FormattingEnabled = true;
            this.lbxMemberType.Items.AddRange(new object[] {
            "Student",
            "Goverment Employee",
            "Private Employee",
            "Teacher",
            "Employee"});
            this.lbxMemberType.Location = new System.Drawing.Point(111, 200);
            this.lbxMemberType.Name = "lbxMemberType";
            this.lbxMemberType.Size = new System.Drawing.Size(169, 95);
            this.lbxMemberType.TabIndex = 11;
            // 
            // lblMembershipID
            // 
            this.lblMembershipID.AutoSize = true;
            this.lblMembershipID.Location = new System.Drawing.Point(27, 72);
            this.lblMembershipID.Name = "lblMembershipID";
            this.lblMembershipID.Size = new System.Drawing.Size(81, 13);
            this.lblMembershipID.TabIndex = 0;
            this.lblMembershipID.Text = "Membership ID.";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(27, 95);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(79, 13);
            this.lblMemberName.TabIndex = 2;
            this.lblMemberName.Text = "Member Name.";
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Location = new System.Drawing.Point(27, 121);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(71, 13);
            this.lblFatherName.TabIndex = 4;
            this.lblFatherName.Text = "Father Name.";
            // 
            // lblCNIC
            // 
            this.lblCNIC.AutoSize = true;
            this.lblCNIC.Location = new System.Drawing.Point(27, 147);
            this.lblCNIC.Name = "lblCNIC";
            this.lblCNIC.Size = new System.Drawing.Size(35, 13);
            this.lblCNIC.TabIndex = 6;
            this.lblCNIC.Text = "CNIC.";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(27, 173);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "City.";
            // 
            // lblMemberType
            // 
            this.lblMemberType.AutoSize = true;
            this.lblMemberType.Location = new System.Drawing.Point(27, 200);
            this.lblMemberType.Name = "lblMemberType";
            this.lblMemberType.Size = new System.Drawing.Size(75, 13);
            this.lblMemberType.TabIndex = 10;
            this.lblMemberType.Text = "Member Type.";
            // 
            // tsmMembers
            // 
            this.tsmMembers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbSearch,
            this.tsbDelete,
            this.tsbClose,
            this.tsbLoadPhoto});
            this.tsmMembers.Location = new System.Drawing.Point(0, 0);
            this.tsmMembers.Name = "tsmMembers";
            this.tsmMembers.Size = new System.Drawing.Size(407, 25);
            this.tsmMembers.TabIndex = 19;
            this.tsmMembers.Text = "toolStrip1";
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(51, 22);
            this.tsbSave.Text = "Save";
            // 
            // tsbSearch
            // 
            this.tsbSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearch.Image")));
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(62, 22);
            this.tsbSearch.Text = "Search";
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(60, 22);
            this.tsbDelete.Text = "Delete";
            // 
            // tsbClose
            // 
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(56, 22);
            this.tsbClose.Text = "Close";
            // 
            // tsbLoadPhoto
            // 
            this.tsbLoadPhoto.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoadPhoto.Image")));
            this.tsbLoadPhoto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadPhoto.Name = "tsbLoadPhoto";
            this.tsbLoadPhoto.Size = new System.Drawing.Size(88, 22);
            this.tsbLoadPhoto.Text = "Load Photo";
            // 
            // frmManageMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 362);
            this.Controls.Add(this.tsmMembers);
            this.Controls.Add(this.lblMemberType);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblCNIC);
            this.Controls.Add(this.lblFatherName);
            this.Controls.Add(this.lblMemberName);
            this.Controls.Add(this.lblMembershipID);
            this.Controls.Add(this.lbxMemberType);
            this.Controls.Add(this.cbxCity);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.pbxMemberPhoto);
            this.Controls.Add(this.gbxGender);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.txtCNIC);
            this.Controls.Add(this.txtMembershipID);
            this.Controls.Add(this.btnLoadPhoto);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Name = "frmManageMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Members";
            this.gbxGender.ResumeLayout(false);
            this.gbxGender.PerformLayout();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMemberPhoto)).EndInit();
            this.tsmMembers.ResumeLayout(false);
            this.tsmMembers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoadPhoto;
        private System.Windows.Forms.TextBox txtMembershipID;
        private System.Windows.Forms.TextBox txtCNIC;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.RadioButton rbxfemale;
        private System.Windows.Forms.RadioButton rbxmale;
        private System.Windows.Forms.CheckBox chbGuest;
        private System.Windows.Forms.CheckBox chbTemporary;
        private System.Windows.Forms.CheckBox chbPermanent;
        private System.Windows.Forms.GroupBox gbxGender;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.PictureBox pbxMemberPhoto;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.ListBox lbxMemberType;
        private System.Windows.Forms.Label lblMembershipID;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.Label lblCNIC;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblMemberType;
        private System.Windows.Forms.ToolStrip tsmMembers;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton tsbLoadPhoto;
    }
}