namespace PatientRecordingSchedulingSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBoxBanner = new System.Windows.Forms.PictureBox();
            this.cmbAccountType = new PatientRecordingSchedulingSystem.ParentPanel();
            this.roundedButton1 = new PatientRecordingSchedulingSystem.RoundedButton();
            this.rtbPassword = new PatientRecordingSchedulingSystem.RoundedText();
            this.rtbUsername = new PatientRecordingSchedulingSystem.RoundedText();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBanner
            // 
            this.pictureBoxBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxBanner.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBanner.Image")));
            this.pictureBoxBanner.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBanner.Name = "pictureBoxBanner";
            this.pictureBoxBanner.Size = new System.Drawing.Size(334, 60);
            this.pictureBoxBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBanner.TabIndex = 12;
            this.pictureBoxBanner.TabStop = false;
            // 
            // cmbAccountType
            // 
            this.cmbAccountType.ComboBoxItems = new string[] {
        "Admin",
        "Dental Staff",
        "Dentist"};
            this.cmbAccountType.HighlightColor = System.Drawing.Color.DarkOrange;
            this.cmbAccountType.InactiveColor = System.Drawing.Color.Black;
            this.cmbAccountType.Location = new System.Drawing.Point(82, 269);
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.SelectedText = "Admin";
            this.cmbAccountType.Size = new System.Drawing.Size(170, 30);
            this.cmbAccountType.TabIndex = 2;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BorderRadius = 25;
            this.roundedButton1.ButtonText = "Sign In";
            this.roundedButton1.ContentColor = System.Drawing.SystemColors.ActiveCaption;
            this.roundedButton1.ForeColor = System.Drawing.Color.Transparent;
            this.roundedButton1.HighlightColor = System.Drawing.Color.DarkOrange;
            this.roundedButton1.InactiveColor = System.Drawing.SystemColors.ActiveCaption;
            this.roundedButton1.Location = new System.Drawing.Point(86, 324);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(162, 39);
            this.roundedButton1.TabIndex = 3;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // rtbPassword
            // 
            this.rtbPassword.BackColor = System.Drawing.Color.Transparent;
            this.rtbPassword.ContentColor = System.Drawing.Color.White;
            this.rtbPassword.HighlightColor = System.Drawing.Color.DarkOrange;
            this.rtbPassword.InactiveColor = System.Drawing.Color.Black;
            this.rtbPassword.IsRequired = true;
            this.rtbPassword.Location = new System.Drawing.Point(31, 181);
            this.rtbPassword.MinimumSize = new System.Drawing.Size(0, 57);
            this.rtbPassword.Name = "rtbPassword";
            this.rtbPassword.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.rtbPassword.PasswordChar = '•';
            this.rtbPassword.Size = new System.Drawing.Size(273, 57);
            this.rtbPassword.TabIndex = 1;
            this.rtbPassword.Watermark = "Password";
            // 
            // rtbUsername
            // 
            this.rtbUsername.BackColor = System.Drawing.Color.Transparent;
            this.rtbUsername.ContentColor = System.Drawing.Color.White;
            this.rtbUsername.HighlightColor = System.Drawing.Color.DarkOrange;
            this.rtbUsername.InactiveColor = System.Drawing.Color.Black;
            this.rtbUsername.IsRequired = true;
            this.rtbUsername.Location = new System.Drawing.Point(31, 109);
            this.rtbUsername.MinimumSize = new System.Drawing.Size(0, 57);
            this.rtbUsername.Name = "rtbUsername";
            this.rtbUsername.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.rtbUsername.PasswordChar = '\0';
            this.rtbUsername.Size = new System.Drawing.Size(273, 57);
            this.rtbUsername.TabIndex = 0;
            this.rtbUsername.Watermark = "Username";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.cmbAccountType);
            this.Controls.Add(this.pictureBoxBanner);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.rtbPassword);
            this.Controls.Add(this.rtbUsername);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedText rtbUsername;
        private RoundedText rtbPassword;
        private RoundedButton roundedButton1;
        private System.Windows.Forms.PictureBox pictureBoxBanner;
        private ParentPanel cmbAccountType;




    }
}

