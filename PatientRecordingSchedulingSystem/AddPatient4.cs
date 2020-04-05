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
    public partial class AddPatient4 : UserControl
    {
        public AddPatient4()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdbPrevious3_Click(object sender, EventArgs e)
        {
            UIController.ShowUI(UIPart.ADD_PATIENT3);
        }

        private void rdbRegister_Click(object sender, EventArgs e)
        {
            TermsAndAgreement terms = new TermsAndAgreement();
            terms.ShowDialog();
        }

        private void Other_CheckedChanged(object sender, EventArgs e)
        {
            if (Other.Checked)
                OtherTextBox.Enabled = true;

            else
                OtherTextBox.Enabled = false;

        }
    }
}
