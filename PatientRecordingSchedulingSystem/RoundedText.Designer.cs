namespace PatientRecordingSchedulingSystem
{
    partial class RoundedText
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
            this.components = new System.ComponentModel.Container();
            this.txtUserctrlText = new System.Windows.Forms.TextBox();
            this.lblWaterMark = new System.Windows.Forms.Label();
            this.watermarkscroller = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtUserctrlText
            // 
            this.txtUserctrlText.BackColor = System.Drawing.Color.White;
            this.txtUserctrlText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserctrlText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtUserctrlText.Location = new System.Drawing.Point(15, 34);
            this.txtUserctrlText.Name = "txtUserctrlText";
            this.txtUserctrlText.Size = new System.Drawing.Size(230, 13);
            this.txtUserctrlText.TabIndex = 0;
            this.txtUserctrlText.TextChanged += new System.EventHandler(this.txtUserctrlText_TextChanged);
            this.txtUserctrlText.Enter += new System.EventHandler(this.txtUserctrlText_Enter);
            this.txtUserctrlText.Leave += new System.EventHandler(this.txtUserctrlText_Leave);
            // 
            // lblWaterMark
            // 
            this.lblWaterMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblWaterMark.AutoSize = true;
            this.lblWaterMark.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaterMark.Location = new System.Drawing.Point(18, 34);
            this.lblWaterMark.Name = "lblWaterMark";
            this.lblWaterMark.Size = new System.Drawing.Size(55, 13);
            this.lblWaterMark.TabIndex = 1;
            this.lblWaterMark.Text = "label1hjh";
            this.lblWaterMark.Click += new System.EventHandler(this.lblWaterMark_Click);
            // 
            // watermarkscroller
            // 
            this.watermarkscroller.Interval = 1;
            this.watermarkscroller.Tick += new System.EventHandler(this.watermarkscroller_Tick);
            // 
            // RoundedText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblWaterMark);
            this.Controls.Add(this.txtUserctrlText);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(0, 42);
            this.Name = "RoundedText";
            this.Padding = new System.Windows.Forms.Padding(15, 0, 15, 10);
            this.Size = new System.Drawing.Size(260, 57);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserctrlText;
        private System.Windows.Forms.Label lblWaterMark;
        private System.Windows.Forms.Timer watermarkscroller;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
