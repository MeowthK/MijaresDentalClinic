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
    public partial class AddPatient : UserControl
    {
        public AddPatient()
        {
            InitializeComponent();

        }
        private void roundedButton1_Click(object sender, EventArgs e)
        {
            if (rtbFirstName.Text.Length == 0 || rtbLastName.Text.Length == 0 || ppnlGender.SelectedText == "" 
                || ppnlNationality.SelectedText == "" || ppnlReligion.SelectedText == "" || ((rtbGuardianName.Text.Length == 0 
                || rtbGuardianContactNumber.Text.Length == 0) && grbForMinor.Enabled) 
                || rtbCityMunicipality.Text.Length == 0 || rtbBrgySubdivision.Text.Length == 0)
            {
                MessageBox.Show("Please Fill-up the required field");
            }
            else if (dtpBirthDate.Value.Year >= DateTime.Now.Year)
            {
                MessageBox.Show("Birth Year must be earlier than the current year");
            }

            else
            UIController.ShowUI(UIPart.ADD_PATIENT2);
        }

       private void dtpBirthDate_OnValueChange(object sender, EventArgs e)
       {
           if (DateTime.Now.Year - dtpBirthDate.Value.Year < 18 || dtpBirthDate.Value.Year >= DateTime.Now.Year)
               grbForMinor.Enabled = true;
           else
           {
               rtbGuardianName.Text = "";
               rtbGuardianContactNumber.Text = "";
               grbForMinor.Enabled = false;
           }
       }

       private void rtbLastName_Load(object sender, EventArgs e)
       {

       }

       private void rtbFirstName_Load(object sender, EventArgs e)
       {

       }     
    }
}
