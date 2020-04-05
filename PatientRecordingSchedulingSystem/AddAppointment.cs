using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PatientRecordingSchedulingSystem
{
    public partial class AddAppointment : UserControl
    {
        public AddAppointment()
        {
            InitializeComponent();
        }

        private void rdbConfirmAddAppointment1_Click(object sender, EventArgs e)
        {
            UIController.ShowUI(UIPart.APPOINTMENT_WALKIN);
        }

        private void rdbCreateAppointment_Click(object sender, EventArgs e)
        {
            UIController.ShowUI(UIPart.APPOINTMENT_WALKIN);
        }


        
    }
}
