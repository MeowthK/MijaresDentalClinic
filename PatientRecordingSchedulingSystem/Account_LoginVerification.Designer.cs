namespace PatientRecordingSchedulingSystem
{
    partial class Account_LoginVerification
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
            this.roundedPanel1 = new PatientRecordingSchedulingSystem.RoundedPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.roundedText1 = new PatientRecordingSchedulingSystem.RoundedText();
            this.roundedButton1 = new PatientRecordingSchedulingSystem.RoundedButton();
            this.roundedButton2 = new PatientRecordingSchedulingSystem.RoundedButton();
            this.roundedText2 = new PatientRecordingSchedulingSystem.RoundedText();
            this.roundedPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel1.BorderRadius = 15;
            this.roundedPanel1.ContentColor = System.Drawing.Color.White;
            this.roundedPanel1.Controls.Add(this.tableLayoutPanel1);
            this.roundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.roundedPanel1.Size = new System.Drawing.Size(301, 241);
            this.roundedPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.roundedText1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.roundedButton1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.roundedButton2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.roundedText2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.95238F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.04762F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(271, 211);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // roundedText1
            // 
            this.roundedText1.BackColor = System.Drawing.Color.Transparent;
            this.roundedText1.ContentColor = System.Drawing.Color.White;
            this.roundedText1.HighlightColor = System.Drawing.Color.DarkOrange;
            this.roundedText1.InactiveColor = System.Drawing.Color.Black;
            this.roundedText1.IsRequired = false;
            this.roundedText1.Location = new System.Drawing.Point(3, 40);
            this.roundedText1.MinimumSize = new System.Drawing.Size(0, 57);
            this.roundedText1.Name = "roundedText1";
            this.roundedText1.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.roundedText1.PasswordChar = '\0';
            this.roundedText1.Size = new System.Drawing.Size(263, 57);
            this.roundedText1.TabIndex = 2;
            this.roundedText1.Watermark = "Username";
            // 
            // roundedButton1
            // 
            this.roundedButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedButton1.BorderRadius = 15;
            this.roundedButton1.ButtonText = "PROCEED";
            this.roundedButton1.ContentColor = System.Drawing.SystemColors.ActiveCaption;
            this.roundedButton1.HighlightColor = System.Drawing.Color.DarkOrange;
            this.roundedButton1.InactiveColor = System.Drawing.SystemColors.ActiveCaption;
            this.roundedButton1.Location = new System.Drawing.Point(76, 163);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(118, 42);
            this.roundedButton1.TabIndex = 2;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // roundedButton2
            // 
            this.roundedButton2.BorderRadius = 15;
            this.roundedButton2.ButtonText = "ACCOUNT VERIFICATION";
            this.roundedButton2.ContentColor = System.Drawing.SystemColors.ControlDarkDark;
            this.roundedButton2.HighlightColor = System.Drawing.SystemColors.ControlDarkDark;
            this.roundedButton2.InactiveColor = System.Drawing.SystemColors.ControlDarkDark;
            this.roundedButton2.Location = new System.Drawing.Point(3, 3);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(263, 25);
            this.roundedButton2.TabIndex = 3;
            // 
            // roundedText2
            // 
            this.roundedText2.BackColor = System.Drawing.Color.Transparent;
            this.roundedText2.ContentColor = System.Drawing.Color.White;
            this.roundedText2.HighlightColor = System.Drawing.Color.DarkOrange;
            this.roundedText2.InactiveColor = System.Drawing.Color.Black;
            this.roundedText2.IsRequired = false;
            this.roundedText2.Location = new System.Drawing.Point(3, 94);
            this.roundedText2.MinimumSize = new System.Drawing.Size(0, 57);
            this.roundedText2.Name = "roundedText2";
            this.roundedText2.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.roundedText2.PasswordChar = '\0';
            this.roundedText2.Size = new System.Drawing.Size(263, 57);
            this.roundedText2.TabIndex = 1;
            this.roundedText2.Watermark = "Password";
            // 
            // Account_LoginVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 241);
            this.Controls.Add(this.roundedPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Account_LoginVerification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Account_LoginVerification_Load);
            this.roundedPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel roundedPanel1;
        private RoundedButton roundedButton1;
        private RoundedText roundedText2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RoundedText roundedText1;
        private RoundedButton roundedButton2;
    }
}
