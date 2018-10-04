namespace Library.WinUI
{
    partial class frmIssueBooks
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
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.txtIssueNo = new System.Windows.Forms.TextBox();
            this.txtBookCode = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtMemberCode = new System.Windows.Forms.TextBox();
            this.lblIssueNo = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblMemberCode = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.lblBookCode = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvIssueBooks = new System.Windows.Forms.DataGridView();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.btnSearchBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.CustomFormat = "dd/MM/yyyy";
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssueDate.Location = new System.Drawing.Point(295, 52);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(100, 20);
            this.dtpIssueDate.TabIndex = 0;
            // 
            // txtIssueNo
            // 
            this.txtIssueNo.Location = new System.Drawing.Point(29, 55);
            this.txtIssueNo.Name = "txtIssueNo";
            this.txtIssueNo.Size = new System.Drawing.Size(100, 20);
            this.txtIssueNo.TabIndex = 1;
            // 
            // txtBookCode
            // 
            this.txtBookCode.Location = new System.Drawing.Point(12, 189);
            this.txtBookCode.Name = "txtBookCode";
            this.txtBookCode.Size = new System.Drawing.Size(100, 20);
            this.txtBookCode.TabIndex = 2;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(155, 188);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(261, 188);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(128, 20);
            this.txtAuthor.TabIndex = 4;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(395, 188);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 5;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(161, 134);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(234, 20);
            this.txtMemberName.TabIndex = 6;
            // 
            // txtMemberCode
            // 
            this.txtMemberCode.Location = new System.Drawing.Point(12, 134);
            this.txtMemberCode.Name = "txtMemberCode";
            this.txtMemberCode.Size = new System.Drawing.Size(100, 20);
            this.txtMemberCode.TabIndex = 7;
            this.txtMemberCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMemberCode_KeyPress);
            this.txtMemberCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMemberCode_KeyUp);
            // 
            // lblIssueNo
            // 
            this.lblIssueNo.AutoSize = true;
            this.lblIssueNo.Location = new System.Drawing.Point(26, 39);
            this.lblIssueNo.Name = "lblIssueNo";
            this.lblIssueNo.Size = new System.Drawing.Size(42, 13);
            this.lblIssueNo.TabIndex = 8;
            this.lblIssueNo.Text = "Issue#.";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Location = new System.Drawing.Point(292, 36);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(61, 13);
            this.lblIssueDate.TabIndex = 9;
            this.lblIssueDate.Text = "Issue Date.";
            // 
            // lblMemberCode
            // 
            this.lblMemberCode.AutoSize = true;
            this.lblMemberCode.Location = new System.Drawing.Point(12, 118);
            this.lblMemberCode.Name = "lblMemberCode";
            this.lblMemberCode.Size = new System.Drawing.Size(76, 13);
            this.lblMemberCode.TabIndex = 10;
            this.lblMemberCode.Text = "Member Code.";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(158, 118);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(79, 13);
            this.lblMemberName.TabIndex = 11;
            this.lblMemberName.Text = "Member Name.";
            // 
            // lblBookCode
            // 
            this.lblBookCode.AutoSize = true;
            this.lblBookCode.Location = new System.Drawing.Point(12, 173);
            this.lblBookCode.Name = "lblBookCode";
            this.lblBookCode.Size = new System.Drawing.Size(63, 13);
            this.lblBookCode.TabIndex = 12;
            this.lblBookCode.Text = "Book Code.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(152, 172);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(58, 13);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Book Title.";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(264, 173);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblAuthor.TabIndex = 14;
            this.lblAuthor.Text = "Author.";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(392, 172);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(26, 13);
            this.lblQty.TabIndex = 15;
            this.lblQty.Text = "Qty.";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(68, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(313, 420);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(230, 420);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(149, 420);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvIssueBooks
            // 
            this.dgvIssueBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssueBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colTitle,
            this.colAuthor,
            this.colQty});
            this.dgvIssueBooks.Location = new System.Drawing.Point(12, 215);
            this.dgvIssueBooks.Name = "dgvIssueBooks";
            this.dgvIssueBooks.Size = new System.Drawing.Size(483, 150);
            this.dgvIssueBooks.TabIndex = 20;
            // 
            // colCode
            // 
            this.colCode.HeaderText = "Code";
            this.colCode.Name = "colCode";
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "Title";
            this.colTitle.Name = "colTitle";
            // 
            // colAuthor
            // 
            this.colAuthor.HeaderText = "Author";
            this.colAuthor.Name = "colAuthor";
            // 
            // colQty
            // 
            this.colQty.HeaderText = "Qty";
            this.colQty.Name = "colQty";
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(501, 186);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(47, 23);
            this.btnLine.TabIndex = 21;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Location = new System.Drawing.Point(118, 131);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(37, 23);
            this.btnSearchMember.TabIndex = 22;
            this.btnSearchMember.Text = "...";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(118, 186);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(37, 23);
            this.btnSearchBook.TabIndex = 23;
            this.btnSearchBook.Text = "...";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // frmIssueBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 455);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.btnSearchMember);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.dgvIssueBooks);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBookCode);
            this.Controls.Add(this.lblMemberName);
            this.Controls.Add(this.lblMemberCode);
            this.Controls.Add(this.lblIssueDate);
            this.Controls.Add(this.lblIssueNo);
            this.Controls.Add(this.txtMemberCode);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtBookCode);
            this.Controls.Add(this.txtIssueNo);
            this.Controls.Add(this.dtpIssueDate);
            this.Name = "frmIssueBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Books to Memebers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.TextBox txtIssueNo;
        private System.Windows.Forms.TextBox txtBookCode;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtMemberCode;
        private System.Windows.Forms.Label lblIssueNo;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblMemberCode;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label lblBookCode;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvIssueBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.Button btnSearchBook;
    }
}