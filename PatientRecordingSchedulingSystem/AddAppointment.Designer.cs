namespace PatientRecordingSchedulingSystem
{
    partial class AddAppointment
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grbOnlineQueues = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCreateAppointment = new PatientRecordingSchedulingSystem.RoundedButton();
            this.grbAppointmentDetails = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ConfirmAddAppointment2 = new PatientRecordingSchedulingSystem.RoundedButton();
            this.roundedButton4 = new PatientRecordingSchedulingSystem.RoundedButton();
            this.roundedPanel3 = new PatientRecordingSchedulingSystem.RoundedPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rdbConfirmAddAppointment1 = new PatientRecordingSchedulingSystem.RoundedButton();
            this.roundedButton1 = new PatientRecordingSchedulingSystem.RoundedButton();
            this.roundedPanel2 = new PatientRecordingSchedulingSystem.RoundedPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grbOnlineQueues.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbAppointmentDetails.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel1.BorderRadius = 25;
            this.roundedPanel1.ContentColor = System.Drawing.Color.White;
            this.roundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel1.Location = new System.Drawing.Point(3, 19);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Padding = new System.Windows.Forms.Padding(29);
            this.roundedPanel1.Size = new System.Drawing.Size(360, 541);
            this.roundedPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grbOnlineQueues);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(17);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.grbAppointmentDetails);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(17);
            this.splitContainer1.Size = new System.Drawing.Size(800, 597);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            // 
            // grbOnlineQueues
            // 
            this.grbOnlineQueues.Controls.Add(this.roundedPanel1);
            this.grbOnlineQueues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbOnlineQueues.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOnlineQueues.Location = new System.Drawing.Point(17, 17);
            this.grbOnlineQueues.Name = "grbOnlineQueues";
            this.grbOnlineQueues.Size = new System.Drawing.Size(366, 563);
            this.grbOnlineQueues.TabIndex = 0;
            this.grbOnlineQueues.TabStop = false;
            this.grbOnlineQueues.Text = "ONLINE APPOINTMENT QUEUES";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbCreateAppointment);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(17, 520);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WALK-IN APPOINTMENTS";
            // 
            // rdbCreateAppointment
            // 
            this.rdbCreateAppointment.BorderRadius = 25;
            this.rdbCreateAppointment.ButtonText = "CREATE APPOINTMENT";
            this.rdbCreateAppointment.ContentColor = System.Drawing.SystemColors.ActiveCaption;
            this.rdbCreateAppointment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbCreateAppointment.HighlightColor = System.Drawing.Color.DarkOrange;
            this.rdbCreateAppointment.InactiveColor = System.Drawing.SystemColors.ActiveCaption;
            this.rdbCreateAppointment.Location = new System.Drawing.Point(3, 19);
            this.rdbCreateAppointment.Name = "rdbCreateAppointment";
            this.rdbCreateAppointment.Size = new System.Drawing.Size(359, 38);
            this.rdbCreateAppointment.TabIndex = 0;
            this.rdbCreateAppointment.Click += new System.EventHandler(this.rdbCreateAppointment_Click);
            // 
            // grbAppointmentDetails
            // 
            this.grbAppointmentDetails.Controls.Add(this.tableLayoutPanel2);
            this.grbAppointmentDetails.Controls.Add(this.tableLayoutPanel1);
            this.grbAppointmentDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbAppointmentDetails.Location = new System.Drawing.Point(17, 17);
            this.grbAppointmentDetails.Name = "grbAppointmentDetails";
            this.grbAppointmentDetails.Size = new System.Drawing.Size(365, 448);
            this.grbAppointmentDetails.TabIndex = 0;
            this.grbAppointmentDetails.TabStop = false;
            this.grbAppointmentDetails.Text = "ONLINE APPOINTMENT DETAILS";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ConfirmAddAppointment2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.roundedButton4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.roundedPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 245);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(359, 200);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // ConfirmAddAppointment2
            // 
            this.ConfirmAddAppointment2.BorderRadius = 25;
            this.ConfirmAddAppointment2.ButtonText = "CONFIRM and ADD APPOINTMENT";
            this.ConfirmAddAppointment2.ContentColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConfirmAddAppointment2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfirmAddAppointment2.HighlightColor = System.Drawing.Color.DarkOrange;
            this.ConfirmAddAppointment2.InactiveColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConfirmAddAppointment2.Location = new System.Drawing.Point(0, 162);
            this.ConfirmAddAppointment2.Margin = new System.Windows.Forms.Padding(0);
            this.ConfirmAddAppointment2.Name = "ConfirmAddAppointment2";
            this.ConfirmAddAppointment2.Size = new System.Drawing.Size(359, 38);
            this.ConfirmAddAppointment2.TabIndex = 3;
            // 
            // roundedButton4
            // 
            this.roundedButton4.BorderRadius = 15;
            this.roundedButton4.ButtonText = "Patient Name";
            this.roundedButton4.ContentColor = System.Drawing.SystemColors.ControlDarkDark;
            this.roundedButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedButton4.HighlightColor = System.Drawing.SystemColors.ControlDarkDark;
            this.roundedButton4.InactiveColor = System.Drawing.SystemColors.ControlDarkDark;
            this.roundedButton4.Location = new System.Drawing.Point(0, 0);
            this.roundedButton4.Margin = new System.Windows.Forms.Padding(0);
            this.roundedButton4.Name = "roundedButton4";
            this.roundedButton4.Size = new System.Drawing.Size(359, 30);
            this.roundedButton4.TabIndex = 1;
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel3.BorderRadius = 25;
            this.roundedPanel3.ContentColor = System.Drawing.Color.White;
            this.roundedPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel3.Location = new System.Drawing.Point(0, 30);
            this.roundedPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Padding = new System.Windows.Forms.Padding(25);
            this.roundedPanel3.Size = new System.Drawing.Size(359, 132);
            this.roundedPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rdbConfirmAddAppointment1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.roundedButton1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.roundedPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(356, 200);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // rdbConfirmAddAppointment1
            // 
            this.rdbConfirmAddAppointment1.BorderRadius = 25;
            this.rdbConfirmAddAppointment1.ButtonText = "CONFIRM and ADD APPOINTMENT";
            this.rdbConfirmAddAppointment1.ContentColor = System.Drawing.SystemColors.ActiveCaption;
            this.rdbConfirmAddAppointment1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbConfirmAddAppointment1.HighlightColor = System.Drawing.Color.DarkOrange;
            this.rdbConfirmAddAppointment1.InactiveColor = System.Drawing.SystemColors.ActiveCaption;
            this.rdbConfirmAddAppointment1.Location = new System.Drawing.Point(0, 162);
            this.rdbConfirmAddAppointment1.Margin = new System.Windows.Forms.Padding(0);
            this.rdbConfirmAddAppointment1.Name = "rdbConfirmAddAppointment1";
            this.rdbConfirmAddAppointment1.Size = new System.Drawing.Size(356, 38);
            this.rdbConfirmAddAppointment1.TabIndex = 3;
            this.rdbConfirmAddAppointment1.Click += new System.EventHandler(this.rdbConfirmAddAppointment1_Click);
            // 
            // roundedButton1
            // 
            this.roundedButton1.BorderRadius = 15;
            this.roundedButton1.ButtonText = "Patient Name";
            this.roundedButton1.ContentColor = System.Drawing.SystemColors.ControlDarkDark;
            this.roundedButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedButton1.HighlightColor = System.Drawing.SystemColors.ControlDarkDark;
            this.roundedButton1.InactiveColor = System.Drawing.SystemColors.ControlDarkDark;
            this.roundedButton1.Location = new System.Drawing.Point(0, 0);
            this.roundedButton1.Margin = new System.Windows.Forms.Padding(0);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(356, 30);
            this.roundedButton1.TabIndex = 1;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel2.BorderRadius = 25;
            this.roundedPanel2.ContentColor = System.Drawing.Color.White;
            this.roundedPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel2.Location = new System.Drawing.Point(0, 30);
            this.roundedPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Padding = new System.Windows.Forms.Padding(25);
            this.roundedPanel2.Size = new System.Drawing.Size(356, 132);
            this.roundedPanel2.TabIndex = 0;
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddAppointment";
            this.Size = new System.Drawing.Size(800, 597);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grbOnlineQueues.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grbAppointmentDetails.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grbOnlineQueues;
        private System.Windows.Forms.GroupBox grbAppointmentDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RoundedButton rdbConfirmAddAppointment1;
        private RoundedButton roundedButton1;
        private RoundedPanel roundedPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private RoundedButton rdbCreateAppointment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private RoundedButton ConfirmAddAppointment2;
        private RoundedButton roundedButton4;
        private RoundedPanel roundedPanel3;
    }
}
