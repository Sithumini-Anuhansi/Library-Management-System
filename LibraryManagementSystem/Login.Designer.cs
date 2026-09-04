namespace LibraryManagementSystem
{
    partial class Login
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
            this.lblUN = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.lblUT = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUN
            // 
            this.lblUN.AutoSize = true;
            this.lblUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUN.Location = new System.Drawing.Point(28, 26);
            this.lblUN.Name = "lblUN";
            this.lblUN.Size = new System.Drawing.Size(132, 29);
            this.lblUN.TabIndex = 0;
            this.lblUN.Text = "Username";
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPW.Location = new System.Drawing.Point(28, 82);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(128, 29);
            this.lblPW.TabIndex = 1;
            this.lblPW.Text = "Password";
            // 
            // lblUT
            // 
            this.lblUT.AutoSize = true;
            this.lblUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUT.Location = new System.Drawing.Point(28, 142);
            this.lblUT.Name = "lblUT";
            this.lblUT.Size = new System.Drawing.Size(134, 29);
            this.lblUT.TabIndex = 2;
            this.lblUT.Text = "User Type";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(214, 26);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(223, 34);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(214, 82);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(223, 34);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // cmbUserType
            // 
            this.cmbUserType.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmbUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.cmbUserType.Location = new System.Drawing.Point(214, 142);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(223, 37);
            this.cmbUserType.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(121, 203);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(154, 44);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(281, 203);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 44);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(471, 277);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cmbUserType);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUT);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.lblUN);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUN;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.Label lblUT;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClose;
    }
}