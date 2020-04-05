namespace PatientRecordingSchedulingSystem
{
    partial class HomeUI
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rpnlPatientList = new PatientRecordingSchedulingSystem.RoundedPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rtbSearchPatient = new PatientRecordingSchedulingSystem.RoundedText();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rpnlPendingAppointments = new PatientRecordingSchedulingSystem.RoundedPanel();
            this.roundedButton1 = new PatientRecordingSchedulingSystem.RoundedButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbSearchAppointment = new PatientRecordingSchedulingSystem.RoundedText();
            this.rpnlAppointmentList = new PatientRecordingSchedulingSystem.RoundedPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.rpnlPatientList.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 597);
            this.splitContainer1.SplitterDistance = 397;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.rpnlPatientList);
            this.panel1.Controls.Add(this.rtbSearchPatient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.Size = new System.Drawing.Size(397, 597);
            this.panel1.TabIndex = 0;
            // 
            // rpnlPatientList
            // 
            this.rpnlPatientList.BorderColor = System.Drawing.Color.Black;
            this.rpnlPatientList.BorderRadius = 15;
            this.rpnlPatientList.ContentColor = System.Drawing.Color.White;
            this.rpnlPatientList.Controls.Add(this.panel4);
            this.rpnlPatientList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rpnlPatientList.Location = new System.Drawing.Point(15, 78);
            this.rpnlPatientList.Name = "rpnlPatientList";
            this.rpnlPatientList.Padding = new System.Windows.Forms.Padding(15);
            this.rpnlPatientList.Size = new System.Drawing.Size(367, 504);
            this.rpnlPatientList.TabIndex = 1;
            this.rpnlPatientList.VisibleChanged += new System.EventHandler(this.rpnlPatientList_VisibleChanged);
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(15, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(337, 474);
            this.panel4.TabIndex = 0;
            this.panel4.VisibleChanged += new System.EventHandler(this.panel4_VisibleChanged);
            // 
            // rtbSearchPatient
            // 
            this.rtbSearchPatient.BackColor = System.Drawing.Color.Transparent;
            this.rtbSearchPatient.ContentColor = System.Drawing.Color.White;
            this.rtbSearchPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbSearchPatient.HighlightColor = System.Drawing.Color.DarkOrange;
            this.rtbSearchPatient.InactiveColor = System.Drawing.Color.Black;
            this.rtbSearchPatient.IsRequired = false;
            this.rtbSearchPatient.Location = new System.Drawing.Point(15, 15);
            this.rtbSearchPatient.MinimumSize = new System.Drawing.Size(0, 57);
            this.rtbSearchPatient.Name = "rtbSearchPatient";
            this.rtbSearchPatient.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.rtbSearchPatient.PasswordChar = '\0';
            this.rtbSearchPatient.Size = new System.Drawing.Size(367, 57);
            this.rtbSearchPatient.TabIndex = 0;
            this.rtbSearchPatient.Watermark = "Search Patient";
            this.rtbSearchPatient.TxtChanged += new System.EventHandler(this.rtbSearchPatient_TxtChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.rpnlPendingAppointments);
            this.panel3.Controls.Add(this.roundedButton1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 298);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15);
            this.panel3.Size = new System.Drawing.Size(399, 299);
            this.panel3.TabIndex = 5;
            // 
            // rpnlPendingAppointments
            // 
            this.rpnlPendingAppointments.BorderColor = System.Drawing.Color.Black;
            this.rpnlPendingAppointments.BorderRadius = 15;
            this.rpnlPendingAppointments.ContentColor = System.Drawing.Color.White;
            this.rpnlPendingAppointments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rpnlPendingAppointments.Location = new System.Drawing.Point(15, 69);
            this.rpnlPendingAppointments.Name = "rpnlPendingAppointments";
            this.rpnlPendingAppointments.Padding = new System.Windows.Forms.Padding(15);
            this.rpnlPendingAppointments.Size = new System.Drawing.Size(369, 215);
            this.rpnlPendingAppointments.TabIndex = 4;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BorderRadius = 15;
            this.roundedButton1.ButtonText = "Pending Appointments";
            this.roundedButton1.ContentColor = System.Drawing.Color.White;
            this.roundedButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundedButton1.HighlightColor = System.Drawing.Color.DarkOrange;
            this.roundedButton1.InactiveColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(15, 15);
            this.roundedButton1.Margin = new System.Windows.Forms.Padding(0);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(369, 48);
            this.roundedButton1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.rtbSearchAppointment);
            this.panel2.Controls.Add(this.rpnlAppointmentList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(399, 298);
            this.panel2.TabIndex = 0;
            // 
            // rtbSearchAppointment
            // 
            this.rtbSearchAppointment.BackColor = System.Drawing.Color.Transparent;
            this.rtbSearchAppointment.ContentColor = System.Drawing.Color.White;
            this.rtbSearchAppointment.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbSearchAppointment.HighlightColor = System.Drawing.Color.DarkOrange;
            this.rtbSearchAppointment.InactiveColor = System.Drawing.Color.Black;
            this.rtbSearchAppointment.IsRequired = false;
            this.rtbSearchAppointment.Location = new System.Drawing.Point(15, 15);
            this.rtbSearchAppointment.MinimumSize = new System.Drawing.Size(0, 57);
            this.rtbSearchAppointment.Name = "rtbSearchAppointment";
            this.rtbSearchAppointment.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.rtbSearchAppointment.PasswordChar = '\0';
            this.rtbSearchAppointment.Size = new System.Drawing.Size(369, 57);
            this.rtbSearchAppointment.TabIndex = 1;
            this.rtbSearchAppointment.Watermark = "Search Appointment";
            // 
            // rpnlAppointmentList
            // 
            this.rpnlAppointmentList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rpnlAppointmentList.BorderColor = System.Drawing.Color.Black;
            this.rpnlAppointmentList.BorderRadius = 15;
            this.rpnlAppointmentList.ContentColor = System.Drawing.Color.White;
            this.rpnlAppointmentList.Location = new System.Drawing.Point(15, 78);
            this.rpnlAppointmentList.Name = "rpnlAppointmentList";
            this.rpnlAppointmentList.Padding = new System.Windows.Forms.Padding(15);
            this.rpnlAppointmentList.Size = new System.Drawing.Size(369, 202);
            this.rpnlAppointmentList.TabIndex = 2;
            // 
            // HomeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Name = "HomeUI";
            this.Size = new System.Drawing.Size(800, 597);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.rpnlPatientList.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private RoundedPanel rpnlPatientList;
        private RoundedText rtbSearchPatient;
        private System.Windows.Forms.Panel panel3;
        private RoundedPanel rpnlPendingAppointments;
        private RoundedButton roundedButton1;
        private System.Windows.Forms.Panel panel2;
        private RoundedText rtbSearchAppointment;
        private RoundedPanel rpnlAppointmentList;
        private System.Windows.Forms.Panel panel4;

    }
}
