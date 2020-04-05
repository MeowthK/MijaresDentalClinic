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
    public partial class Account_LoginVerification : Form
    {
        public Account_LoginVerification()
        {
            InitializeComponent();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UIController.ShowUI(UIPart.ACCOUNT_SETTINGS);
        }

        private void Account_LoginVerification_Load(object sender, EventArgs e)
        {

        }

        
    }
}
