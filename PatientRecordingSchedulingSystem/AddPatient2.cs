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
    public partial class AddPatient2 : UserControl
    {
        public AddPatient2()
        {
            InitializeComponent();
        }

        private void rdbPrevious_Click(object sender, EventArgs e)
        {
            UIController.ShowUI(UIPart.ADD_PATIENT);
        }

        private void rdbNext2_Click(object sender, EventArgs e)
        {
            if (rtbMobileNumber.Text.Length == 0)

                MessageBox.Show("Please Fill-up the required field!");
            else if (rtbMobileNumber.Text.Length != 11)
                MessageBox.Show("Contact number must be 11 digit!");
            else
                UIController.ShowUI(UIPart.ADD_PATIENT3);
        }

        private void rtbOfficeNumber_Load(object sender, EventArgs e)
        {

        }

        private void roundedText2_Load(object sender, EventArgs e)
        {

        }

    }
}
