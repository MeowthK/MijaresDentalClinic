namespace PatientRecordingSchedulingSystem
{
    partial class ParentPanel
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
            this.rdPanel = new PatientRecordingSchedulingSystem.RoundedPanel();
            this.parentCMB1 = new PatientRecordingSchedulingSystem.ParentCMB();
            this.rdPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdPanel
            // 
            this.rdPanel.BorderColor = System.Drawing.Color.Black;
            this.rdPanel.BorderRadius = 15;
            this.rdPanel.ContentColor = System.Drawing.Color.White;
            this.rdPanel.Controls.Add(this.parentCMB1);
            this.rdPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdPanel.Location = new System.Drawing.Point(0, 0);
            this.rdPanel.Name = "rdPanel";
            this.rdPanel.Padding = new System.Windows.Forms.Padding(15);
            this.rdPanel.Size = new System.Drawing.Size(220, 77);
            this.rdPanel.TabIndex = 0;
            // 
            // parentCMB1
            // 
            this.parentCMB1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.parentCMB1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.parentCMB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parentCMB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parentCMB1.FormattingEnabled = true;
            this.parentCMB1.Location = new System.Drawing.Point(9, 28);
            this.parentCMB1.Name = "parentCMB1";
            this.parentCMB1.Size = new System.Drawing.Size(202, 21);
            this.parentCMB1.TabIndex = 0;
            this.parentCMB1.Enter += new System.EventHandler(this.comboBox1_Enter);
            this.parentCMB1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // ParentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rdPanel);
            this.DoubleBuffered = true;
            this.Name = "ParentPanel";
            this.Size = new System.Drawing.Size(220, 77);
            this.rdPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel rdPanel;
        private ParentCMB parentCMB1;
    }
}
