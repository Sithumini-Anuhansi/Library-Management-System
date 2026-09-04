namespace LibraryManagementSystem
{
    partial class BookLending
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
            this.lblTxnID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblMemName = new System.Windows.Forms.Label();
            this.lblBName = new System.Windows.Forms.Label();
            this.lblRetDate = new System.Windows.Forms.Label();
            this.txtTxnID = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
            this.cmbBookName = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTxnID
            // 
            this.lblTxnID.AutoSize = true;
            this.lblTxnID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxnID.Location = new System.Drawing.Point(33, 33);
            this.lblTxnID.Name = "lblTxnID";
            this.lblTxnID.Size = new System.Drawing.Size(88, 29);
            this.lblTxnID.TabIndex = 0;
            this.lblTxnID.Text = "Txn ID";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(33, 83);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(67, 29);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // lblMemName
            // 
            this.lblMemName.AutoSize = true;
            this.lblMemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemName.Location = new System.Drawing.Point(33, 135);
            this.lblMemName.Name = "lblMemName";
            this.lblMemName.Size = new System.Drawing.Size(185, 29);
            this.lblMemName.TabIndex = 2;
            this.lblMemName.Text = "Member Name";
            // 
            // lblBName
            // 
            this.lblBName.AutoSize = true;
            this.lblBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBName.Location = new System.Drawing.Point(33, 191);
            this.lblBName.Name = "lblBName";
            this.lblBName.Size = new System.Drawing.Size(149, 29);
            this.lblBName.TabIndex = 3;
            this.lblBName.Text = "Book Name";
            // 
            // lblRetDate
            // 
            this.lblRetDate.AutoSize = true;
            this.lblRetDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetDate.Location = new System.Drawing.Point(33, 245);
            this.lblRetDate.Name = "lblRetDate";
            this.lblRetDate.Size = new System.Drawing.Size(151, 29);
            this.lblRetDate.TabIndex = 4;
            this.lblRetDate.Text = "Return Date";
            // 
            // txtTxnID
            // 
            this.txtTxnID.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtTxnID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTxnID.Location = new System.Drawing.Point(282, 33);
            this.txtTxnID.Name = "txtTxnID";
            this.txtTxnID.ReadOnly = true;
            this.txtTxnID.Size = new System.Drawing.Size(241, 34);
            this.txtTxnID.TabIndex = 5;
            // 
            // txtMemberName
            // 
            this.txtMemberName.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberName.Location = new System.Drawing.Point(282, 135);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(241, 34);
            this.txtMemberName.TabIndex = 6;
            // 
            // date
            // 
            this.date.CalendarMonthBackground = System.Drawing.Color.LightSkyBlue;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(282, 83);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(241, 34);
            this.date.TabIndex = 7;
            // 
            // returnDate
            // 
            this.returnDate.CalendarMonthBackground = System.Drawing.Color.LightSkyBlue;
            this.returnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDate.Location = new System.Drawing.Point(282, 252);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(241, 34);
            this.returnDate.TabIndex = 8;
            // 
            // cmbBookName
            // 
            this.cmbBookName.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmbBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBookName.FormattingEnabled = true;
            this.cmbBookName.Location = new System.Drawing.Point(282, 191);
            this.cmbBookName.Name = "cmbBookName";
            this.cmbBookName.Size = new System.Drawing.Size(241, 37);
            this.cmbBookName.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(282, 321);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 39);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(407, 321);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 39);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BookLending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(560, 386);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbBookName);
            this.Controls.Add(this.returnDate);
            this.Controls.Add(this.date);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtTxnID);
            this.Controls.Add(this.lblRetDate);
            this.Controls.Add(this.lblBName);
            this.Controls.Add(this.lblMemName);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTxnID);
            this.Name = "BookLending";
            this.Text = "Lending Books";
            this.Load += new System.EventHandler(this.BookLending_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTxnID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblMemName;
        private System.Windows.Forms.Label lblBName;
        private System.Windows.Forms.Label lblRetDate;
        private System.Windows.Forms.TextBox txtTxnID;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.DateTimePicker returnDate;
        private System.Windows.Forms.ComboBox cmbBookName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}