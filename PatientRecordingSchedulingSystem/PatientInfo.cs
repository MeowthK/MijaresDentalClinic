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
    public partial class PatientInfo : Form
    {
        public PatientInfo()
        {
            InitializeComponent();
        }
        private Patient p;
        public PatientInfo(Patient p)
        {
            InitializeComponent();

            lblName.Text = p.firstName + " " + p.lastName + " " + p.middleName;
            lblBirthDate.Text = p.birthDate.ToShortDateString();
            lblAddress.Text = p.address.address_Zone + " " + p.address.address_Street + " " + p.address.address_Barangay + " " + p.address.address_City;
            lblContactNumber.Text = p.contactNum;
            lblGender.Text = p.gender.ToString();
            lblNationality.Text = p.nationality;
            lblReligion.Text = p.religion;
            lblNickname.Text = p.nickName;
            lblEmailAddress.Text = p.emailAdd;

            this.p = p;
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            UIController.clearFields();
            UIController.fillFields(p);
            this.Close();
            UIController.ShowUI(UIPart.ADD_PATIENT);
            //UIController.disableFields(UIController.getUIControl(UIPart.ADD_PATIENT).Controls);
        }

    }
}
