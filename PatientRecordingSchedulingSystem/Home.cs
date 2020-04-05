using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PatientRecordingSchedulingSystem
{
    public partial class Home : Form
    {
        private DBInterface dbi = new DBInterface("PersonList");
        public Home()
        {
            InitializeComponent();
            UIController.Initialize(pnlBody);
            pnlHeader.Click += (obj, e) => { UIController.clearFields(); };
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        { 
            UIController.ShowUI(UIPart.HOME);
        }
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            UIController.ShowUI(UIPart.ADD_PATIENT);
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            UIController.ShowUI(UIPart.ADD_APPOINTMENT);
        }

        private void btnAccountSettings_Click(object sender, EventArgs e)
        {
            Account_LoginVerification accloginverification = new Account_LoginVerification();
            accloginverification.ShowDialog();
        }



    }
}
