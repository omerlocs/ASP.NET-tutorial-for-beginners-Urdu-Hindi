namespace Library.WinUI
{
    partial class frmMainScreen
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutLibraryManagementSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitLibraryManagementSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recieveBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBooksListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewIssuedBooksListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookReturnDelayListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fineCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tasksToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutLibraryManagementSystemToolStripMenuItem,
            this.exitLibraryManagementSystemToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutLibraryManagementSystemToolStripMenuItem
            // 
            this.aboutLibraryManagementSystemToolStripMenuItem.Name = "aboutLibraryManagementSystemToolStripMenuItem";
            this.aboutLibraryManagementSystemToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.aboutLibraryManagementSystemToolStripMenuItem.Text = "About Library Management System";
            // 
            // exitLibraryManagementSystemToolStripMenuItem
            // 
            this.exitLibraryManagementSystemToolStripMenuItem.Name = "exitLibraryManagementSystemToolStripMenuItem";
            this.exitLibraryManagementSystemToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.exitLibraryManagementSystemToolStripMenuItem.Text = "Exit Library Management System";
            // 
            // tasksToolStripMenuItem
            // 
            this.tasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageBooksToolStripMenuItem,
            this.manageMembersToolStripMenuItem,
            this.issueBooksToolStripMenuItem,
            this.recieveBooksToolStripMenuItem,
            this.fineCalculatorToolStripMenuItem});
            this.tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            this.tasksToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.tasksToolStripMenuItem.Text = "Tasks";
            // 
            // manageBooksToolStripMenuItem
            // 
            this.manageBooksToolStripMenuItem.Name = "manageBooksToolStripMenuItem";
            this.manageBooksToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.manageBooksToolStripMenuItem.Text = "Manage Books";
            this.manageBooksToolStripMenuItem.Click += new System.EventHandler(this.manageBooksToolStripMenuItem_Click);
            // 
            // manageMembersToolStripMenuItem
            // 
            this.manageMembersToolStripMenuItem.Name = "manageMembersToolStripMenuItem";
            this.manageMembersToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.manageMembersToolStripMenuItem.Text = "Manage Members";
            this.manageMembersToolStripMenuItem.Click += new System.EventHandler(this.manageMembersToolStripMenuItem_Click);
            // 
            // issueBooksToolStripMenuItem
            // 
            this.issueBooksToolStripMenuItem.Name = "issueBooksToolStripMenuItem";
            this.issueBooksToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.issueBooksToolStripMenuItem.Text = "Issue Books";
            // 
            // recieveBooksToolStripMenuItem
            // 
            this.recieveBooksToolStripMenuItem.Name = "recieveBooksToolStripMenuItem";
            this.recieveBooksToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.recieveBooksToolStripMenuItem.Text = "Recieve Books";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewBooksListToolStripMenuItem,
            this.viewIssuedBooksListToolStripMenuItem,
            this.viewBookReturnDelayListToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // viewBooksListToolStripMenuItem
            // 
            this.viewBooksListToolStripMenuItem.Name = "viewBooksListToolStripMenuItem";
            this.viewBooksListToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.viewBooksListToolStripMenuItem.Text = "View Books List";
            // 
            // viewIssuedBooksListToolStripMenuItem
            // 
            this.viewIssuedBooksListToolStripMenuItem.Name = "viewIssuedBooksListToolStripMenuItem";
            this.viewIssuedBooksListToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.viewIssuedBooksListToolStripMenuItem.Text = "View Issued Books List";
            // 
            // viewBookReturnDelayListToolStripMenuItem
            // 
            this.viewBookReturnDelayListToolStripMenuItem.Name = "viewBookReturnDelayListToolStripMenuItem";
            this.viewBookReturnDelayListToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.viewBookReturnDelayListToolStripMenuItem.Text = "View Book Return Delay List";
            // 
            // fineCalculatorToolStripMenuItem
            // 
            this.fineCalculatorToolStripMenuItem.Name = "fineCalculatorToolStripMenuItem";
            this.fineCalculatorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.fineCalculatorToolStripMenuItem.Text = "Fine Calculator";
            this.fineCalculatorToolStripMenuItem.Click += new System.EventHandler(this.fineCalculatorToolStripMenuItem_Click);
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutLibraryManagementSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitLibraryManagementSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recieveBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBooksListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewIssuedBooksListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBookReturnDelayListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fineCalculatorToolStripMenuItem;
    }
}

