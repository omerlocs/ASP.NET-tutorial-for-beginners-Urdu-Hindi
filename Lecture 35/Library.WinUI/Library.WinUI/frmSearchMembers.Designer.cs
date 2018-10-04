namespace Library.WinUI
{
    partial class frmSearchMembers
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
            this.dgvSearchMember = new System.Windows.Forms.DataGridView();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtSearchMember = new System.Windows.Forms.TextBox();
            this.lblSearchMember = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchMember)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSearchMember
            // 
            this.dgvSearchMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchMember.Location = new System.Drawing.Point(12, 62);
            this.dgvSearchMember.Name = "dgvSearchMember";
            this.dgvSearchMember.Size = new System.Drawing.Size(544, 301);
            this.dgvSearchMember.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(400, 369);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(481, 369);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // txtSearchMember
            // 
            this.txtSearchMember.Location = new System.Drawing.Point(12, 36);
            this.txtSearchMember.Name = "txtSearchMember";
            this.txtSearchMember.Size = new System.Drawing.Size(544, 20);
            this.txtSearchMember.TabIndex = 3;
            this.txtSearchMember.TextChanged += new System.EventHandler(this.txtSearchMember_TextChanged);
            // 
            // lblSearchMember
            // 
            this.lblSearchMember.AutoSize = true;
            this.lblSearchMember.Location = new System.Drawing.Point(12, 20);
            this.lblSearchMember.Name = "lblSearchMember";
            this.lblSearchMember.Size = new System.Drawing.Size(91, 13);
            this.lblSearchMember.TabIndex = 4;
            this.lblSearchMember.Text = "Search a Member";
            // 
            // frmSearchMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 421);
            this.Controls.Add(this.lblSearchMember);
            this.Controls.Add(this.txtSearchMember);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dgvSearchMember);
            this.Name = "frmSearchMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search a Member";
            this.Load += new System.EventHandler(this.frmSearchMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSearchMember;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtSearchMember;
        private System.Windows.Forms.Label lblSearchMember;
    }
}