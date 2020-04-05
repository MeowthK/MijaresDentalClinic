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
    public partial class AddPatient3 : UserControl
    {
        public AddPatient3()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdbNext3_Click(object sender, EventArgs e)
        {
            UIController.ShowUI(UIPart.ADD_PATIENT4);
        }

        private void rdbPrevious2_Click(object sender, EventArgs e)
        {
            UIController.ShowUI(UIPart.ADD_PATIENT2);
        }

        

    }
}
