namespace LibraryManagementSystem
{
    partial class LMS
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
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAuthorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookLendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lendingReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberLendingReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(557, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 35);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(224, 36);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 36);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBooksToolStripMenuItem,
            this.viewBooksToolStripMenuItem,
            this.addAuthorsToolStripMenuItem,
            this.bookLendingToolStripMenuItem});
            this.manageToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(112, 35);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // addBooksToolStripMenuItem
            // 
            this.addBooksToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addBooksToolStripMenuItem.Name = "addBooksToolStripMenuItem";
            this.addBooksToolStripMenuItem.Size = new System.Drawing.Size(245, 36);
            this.addBooksToolStripMenuItem.Text = "Add Books";
            this.addBooksToolStripMenuItem.Click += new System.EventHandler(this.addBooksToolStripMenuItem_Click);
            // 
            // viewBooksToolStripMenuItem
            // 
            this.viewBooksToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            this.viewBooksToolStripMenuItem.Size = new System.Drawing.Size(245, 36);
            this.viewBooksToolStripMenuItem.Text = "View Books";
            this.viewBooksToolStripMenuItem.Click += new System.EventHandler(this.viewBooksToolStripMenuItem_Click);
            // 
            // addAuthorsToolStripMenuItem
            // 
            this.addAuthorsToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addAuthorsToolStripMenuItem.Name = "addAuthorsToolStripMenuItem";
            this.addAuthorsToolStripMenuItem.Size = new System.Drawing.Size(245, 36);
            this.addAuthorsToolStripMenuItem.Text = "Add Authors";
            this.addAuthorsToolStripMenuItem.Click += new System.EventHandler(this.addAuthorsToolStripMenuItem_Click);
            // 
            // bookLendingToolStripMenuItem
            // 
            this.bookLendingToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bookLendingToolStripMenuItem.Name = "bookLendingToolStripMenuItem";
            this.bookLendingToolStripMenuItem.Size = new System.Drawing.Size(245, 36);
            this.bookLendingToolStripMenuItem.Text = "Book Lending";
            this.bookLendingToolStripMenuItem.Click += new System.EventHandler(this.bookLendingToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookReportToolStripMenuItem,
            this.lendingReportToolStripMenuItem,
            this.memberLendingReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(109, 35);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // bookReportToolStripMenuItem
            // 
            this.bookReportToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bookReportToolStripMenuItem.Name = "bookReportToolStripMenuItem";
            this.bookReportToolStripMenuItem.Size = new System.Drawing.Size(356, 36);
            this.bookReportToolStripMenuItem.Text = "Book Report";
            this.bookReportToolStripMenuItem.Click += new System.EventHandler(this.bookReportToolStripMenuItem_Click);
            // 
            // lendingReportToolStripMenuItem
            // 
            this.lendingReportToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lendingReportToolStripMenuItem.Name = "lendingReportToolStripMenuItem";
            this.lendingReportToolStripMenuItem.Size = new System.Drawing.Size(356, 36);
            this.lendingReportToolStripMenuItem.Text = "Lending Report";
            this.lendingReportToolStripMenuItem.Click += new System.EventHandler(this.lendingReportToolStripMenuItem_Click);
            // 
            // memberLendingReportToolStripMenuItem
            // 
            this.memberLendingReportToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.memberLendingReportToolStripMenuItem.Name = "memberLendingReportToolStripMenuItem";
            this.memberLendingReportToolStripMenuItem.Size = new System.Drawing.Size(356, 36);
            this.memberLendingReportToolStripMenuItem.Text = "Member Lending Report";
            this.memberLendingReportToolStripMenuItem.Click += new System.EventHandler(this.memberLendingReportToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(557, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            this.statusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip_ItemClicked);
            // 
            // LMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LMS";
            this.Text = "Library Management System";
            this.Load += new System.EventHandler(this.LMS_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAuthorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookLendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lendingReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberLendingReportToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
    }
}