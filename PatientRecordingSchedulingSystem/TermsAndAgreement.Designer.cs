namespace PatientRecordingSchedulingSystem
{
    partial class TermsAndAgreement
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
            this.roundedPanel1 = new PatientRecordingSchedulingSystem.RoundedPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.roundedButton2 = new PatientRecordingSchedulingSystem.RoundedButton();
            this.roundedButton1 = new PatientRecordingSchedulingSystem.RoundedButton();
            this.lblconsentHeader = new System.Windows.Forms.Label();
            this.consentContent = new System.Windows.Forms.Label();
            this.roundedPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel1.BorderRadius = 25;
            this.roundedPanel1.ContentColor = System.Drawing.Color.White;
            this.roundedPanel1.Controls.Add(this.tableLayoutPanel2);
            this.roundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel1.Location = new System.Drawing.Point(10, 10);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.roundedPanel1.Size = new System.Drawing.Size(431, 359);
            this.roundedPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblconsentHeader, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.consentContent, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.29964F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.70036F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(421, 349);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.roundedButton2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.roundedButton1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 297);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(415, 49);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // roundedButton2
            // 
            this.roundedButton2.BorderRadius = 15;
            this.roundedButton2.ButtonText = "ACCEPT";
            this.roundedButton2.ContentColor = System.Drawing.SystemColors.ActiveCaption;
            this.roundedButton2.HighlightColor = System.Drawing.Color.DarkOrange;
            this.roundedButton2.InactiveColor = System.Drawing.SystemColors.ActiveCaption;
            this.roundedButton2.Location = new System.Drawing.Point(210, 3);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(104, 43);
            this.roundedButton2.TabIndex = 1;
            this.roundedButton2.Click += new System.EventHandler(this.roundedButton2_Click);
            // 
            // roundedButton1
            // 
            this.roundedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButton1.BorderRadius = 15;
            this.roundedButton1.ButtonText = "DECLINE";
            this.roundedButton1.ContentColor = System.Drawing.SystemColors.ActiveCaption;
            this.roundedButton1.HighlightColor = System.Drawing.Color.DarkOrange;
            this.roundedButton1.InactiveColor = System.Drawing.SystemColors.ActiveCaption;
            this.roundedButton1.Location = new System.Drawing.Point(100, 3);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(104, 43);
            this.roundedButton1.TabIndex = 0;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // lblconsentHeader
            // 
            this.lblconsentHeader.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblconsentHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblconsentHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconsentHeader.ForeColor = System.Drawing.Color.White;
            this.lblconsentHeader.Location = new System.Drawing.Point(3, 0);
            this.lblconsentHeader.Name = "lblconsentHeader";
            this.lblconsentHeader.Size = new System.Drawing.Size(415, 62);
            this.lblconsentHeader.TabIndex = 0;
            this.lblconsentHeader.Text = "CONSENT HEADER";
            this.lblconsentHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // consentContent
            // 
            this.consentContent.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.consentContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consentContent.Location = new System.Drawing.Point(3, 62);
            this.consentContent.Name = "consentContent";
            this.consentContent.Size = new System.Drawing.Size(415, 232);
            this.consentContent.TabIndex = 1;
            this.consentContent.Text = "CONSENT CONTENT";
            this.consentContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TermsAndAgreement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 379);
            this.Controls.Add(this.roundedPanel1);
            this.Name = "TermsAndAgreement";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "TermsAndAgreement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TermsAndAgreement_FormClosed);
            this.roundedPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label consentContent;
        private System.Windows.Forms.Label lblconsentHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RoundedButton roundedButton2;
        private RoundedButton roundedButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}