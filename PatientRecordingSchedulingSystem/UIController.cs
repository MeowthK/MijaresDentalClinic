using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

public enum UIPart
{
    HOME,
    ADD_PATIENT,
    ADD_PATIENT2,
    ADD_PATIENT3,
    ADD_PATIENT4,
    ADD_APPOINTMENT,
    APPOINTMENT_WALKIN,
    ACCOUNT_SETTINGS
};

namespace PatientRecordingSchedulingSystem
{
    public static class UIController
    {
        private static HomeUI homeui;
        private static AddPatient addpatient;
        private static AddPatient2 addpatient2;
        private static AddPatient3 addpatient3;
        private static AddPatient4 addpatient4;
        private static AddAppointment addappointment;
        private static Appointment_Walkin appointmentwalkin;
        private static Account_Settings accountsettings;

        public static void Initialize(Control container)
        {
            homeui = new HomeUI();
            addpatient = new AddPatient();
            addpatient2 = new AddPatient2();
            addpatient3 = new AddPatient3();
            addpatient4 = new AddPatient4();
            addappointment = new AddAppointment();
            appointmentwalkin = new Appointment_Walkin();
            accountsettings = new Account_Settings();

            homeui.Dock = DockStyle.Fill;
            addpatient.Dock = DockStyle.Fill;
            addpatient2.Dock = DockStyle.Fill;
            addpatient3.Dock = DockStyle.Fill;
            addpatient4.Dock = DockStyle.Fill;
            addappointment.Dock = DockStyle.Fill;
            appointmentwalkin.Dock = DockStyle.Fill;
            accountsettings.Dock = DockStyle.Fill;

            homeui.Show();
            addpatient.Hide();
            addpatient2.Hide();
            addpatient3.Hide();
            addpatient4.Hide();
            addappointment.Hide();
            appointmentwalkin.Hide();
            accountsettings.Hide();

            container.Controls.Add(homeui);
            container.Controls.Add(addpatient);
            container.Controls.Add(addpatient2);
            container.Controls.Add(addpatient3);
            container.Controls.Add(addpatient4);
            container.Controls.Add(addappointment);
            container.Controls.Add(appointmentwalkin);
            container.Controls.Add(accountsettings);
        }

        public static void ShowUI(UIPart uipart)
        {
            switch (uipart)
            {
                case UIPart.HOME:
                    homeui.Show();
                    addpatient.Hide();
                    addpatient2.Hide();
                    break;

                case UIPart.ADD_PATIENT:
                    addpatient.Show();
                    homeui.Hide();
                    addpatient2.Hide();
                    break;
                
                case UIPart.ADD_PATIENT2:
                    addpatient2.Show();
                    homeui.Hide();
                    addpatient.Hide();
                    break;

                case UIPart.ADD_PATIENT3:
                    addpatient3.Show();
                    homeui.Hide();
                    addpatient.Hide();
                    addpatient2.Hide();
                    break;

                case UIPart.ADD_PATIENT4:
                    addpatient4.Show();
                    homeui.Hide();
                    addpatient.Hide();
                    addpatient2.Hide();
                    addpatient3.Hide();
                    break;


                case UIPart.ADD_APPOINTMENT:
                    addappointment.Show();
                    homeui.Hide();
                    addpatient.Hide();
                    addpatient2.Hide();
                    addpatient3.Hide();
                    addpatient4.Hide();
                    break;
                
                case UIPart.APPOINTMENT_WALKIN:
                    appointmentwalkin.Show();
                    homeui.Hide();
                    addpatient.Hide();
                    addpatient2.Hide();
                    addpatient3.Hide();
                    addpatient4.Hide();
                    addappointment.Hide();
                    break;
                    
                case UIPart.ACCOUNT_SETTINGS:
                    accountsettings.Show();
                    homeui.Hide();
                    addpatient.Hide();
                    addpatient2.Hide();
                    addpatient3.Hide();
                    addpatient4.Hide();
                    addappointment.Hide();
                    appointmentwalkin.Hide();
                    break;
                    
            }
        }

        public static Control getUIControl(UIPart controltoget)
        {
            switch (controltoget)
            { 
                case UIPart.ACCOUNT_SETTINGS:
                    return accountsettings;
                    
                case UIPart.ADD_APPOINTMENT:
                    return addappointment;

                case UIPart.ADD_PATIENT:
                    return addpatient;
                    
                case UIPart.ADD_PATIENT2:
                    return addpatient2;
    
                case UIPart.ADD_PATIENT3:
                    return addpatient3;

                case UIPart.ADD_PATIENT4:
                    return addpatient4;

                case UIPart.APPOINTMENT_WALKIN:
                    return appointmentwalkin;

                case UIPart.HOME:
                    return homeui;
            }
            return null;
        }
        public static void fillFields(Patient p)
        {
            addpatient.rtbFirstName.Text = p.firstName;
            addpatient.rtbMiddleName.Text = p.middleName;
            addpatient.rtbLastName.Text = p.lastName;
            addpatient.rtbNickName.Text = p.nickName;
            addpatient.dtpBirthDate.Value = p.birthDate;
            addpatient.ppnlNationality.SelectedText = p.nationality;
            addpatient.ppnlReligion.SelectedText = p.religion;
            addpatient.ppnlGender.SelectedText = p.gender.ToString();
            addpatient.rtbOccupation.Text = p.patient_Occupation;
            addpatient.rtbHomeBldgStNo.Text = p.address.address_Home;
            addpatient.rtbZone.Text = p.address.address_Zone;
            addpatient.rtbBrgySubdivision.Text = p.address.address_Barangay;
            addpatient.rtbStreet.Text = p.address.address_Street;
            addpatient.rtbStateProvince.Text = p.address.address_Province;
            addpatient.rtbCityMunicipality.Text = p.address.address_City;
            addpatient.rtbGuardianContactNumber.Text = p.patient_GuardianContactNumber;
            addpatient.rtbGuardianName.Text = p.patient_GuardianName;
            addpatient.dtpExpiredDate.Value = p.patient_DentalInsuranceEffective;

            addpatient2.rtbHomeNumber.Text = p.patient_HomeNo;
            addpatient2.rtbFaxNumber.Text = p.patient_FaxNo;
            addpatient2.rtbOfficeNumber.Text = p.patient_OfficeNo;
            addpatient2.rtbMobileNumber.Text = p.contactNum;
            addpatient2.rtbEmailAddress.Text = p.emailAdd;
            addpatient2.rtbReferralName.Text = p.patient_Referrer;
            addpatient2.rtbReasonforDentalConsultation.Text = p.patient_ConsultationReason;
            addpatient2.rtbPreviousDentist.Text = p.patient_PreviousDentist;
            addpatient2.dtpLastDentalVisit.Value = p.patient_LastDentalVisit;
            addpatient2.rtbNameOfPhysician.Text = p.patient_PhysicianName;
            addpatient2.rtbOfficeAddress.Text = p.patient_PhysicianOfficeAddress;
            addpatient2.rtbOfficeNumber.Text = p.patient_PhysicianOfficeNo;
            addpatient2.rtbSpecialty.Text = p.patient_PhysicianSpecialty;

            addpatient3.yesGoodHealth.Checked = p.patient_BoolInGoodHealth;
            addpatient3.yesHospitalized.Checked = p.patient_HospitalizedWhenandWhere.Length > 0;
            addpatient3.rtbHospitalizedWhenWhy.Text = p.patient_HospitalizedWhenandWhere;
            addpatient3.yesMedicalTreatment.Checked = p.patient_UnderMedicalTreatment.Length > 0;
            addpatient3.rtbMedicalTreatment.Text = p.patient_UnderMedicalTreatment;
            addpatient3.yesIllnessSurgical.Checked = p.patient_SeriousIllnessName.Length > 0;
            addpatient3.rtbIlnessOperation.Text = p.patient_SeriousIllnessName;
            addpatient3.yesPrescription.Checked = p.patient_TakingPrescription.Length > 0;
            addpatient3.rtbPrescription.Text = p.patient_TakingPrescription;
            addpatient3.yesTobacco.Checked = p.patient_BoolUsingTobacco;
            addpatient3.yesAlchol.Checked = p.patient_BoolUsingAlcohol;

            addpatient4.LocalAnaesthetic.Checked = p.patient_LocalAnaesthetic;
            addpatient4.SulfraDrugs.Checked = p.patient_SulfraDrugs;
            addpatient4.PenicillinAntibiotics.Checked = p.patient_PenicillinAntibiotics;
            addpatient4.Aspirin.Checked = p.patient_Aspirin;
            addpatient4.latex.Checked = p.patient_Latex;
            addpatient4.Other.Checked = p.patient_AllergicOthersTextBox.Length > 0;
            addpatient4.OtherTextBox.Text = p.patient_AllergicOthersTextBox;

            addpatient4.nudMin.Value = int.Parse(p.patient_BleedingTime.Split()[0]);
            addpatient4.nudSec.Value = int.Parse(p.patient_BleedingTime.Split()[1]);
            addpatient4.yesPregnant.Checked = p.patient_WomenBoolNursing;
            addpatient4.yesNursing.Checked = p.patient_WomenBoolNursing;
            addpatient4.yesBirthCtrl.Checked = p.patient_WomenBoolTakingBirth;
            addpatient4.ppnlBloodType.SelectedText = p.patient_BloodType;
            addpatient4.nudBPfirst.Value = int.Parse(p.patient_BloodPressure.Split()[0]);
            addpatient4.nudBPlast.Value = int.Parse(p.patient_BloodPressure.Split()[1]);

            addpatient4.HighBloodPressure.Checked = p.patient_fkSickness.sickness_HighBloodPressure;
            addpatient4.LowBloodPressure.Checked = p.patient_fkSickness.sickness_LowBLoodPressure;
            addpatient4.EpilepsyConvulsions.Checked = p.patient_fkSickness.sickness_EpilepsyConvulsions;
            addpatient4.AidsHIV.Checked = p.patient_fkSickness.sickness_AidsHiv;
            addpatient4.SexuallyTransmitted.Checked = p.patient_fkSickness.sickness_SexuallyTransmitted;
            addpatient4.StomachTroublesUlcer.Checked = p.patient_fkSickness.sickness_StomachTroubles;
            addpatient4.FaintingSeizure.Checked = p.patient_fkSickness.sickness_FaintingSeizure;
            addpatient4.RapidWeightLoss.Checked = p.patient_fkSickness.sickness_RapidWeightLoss;
            addpatient4.RadiationTheraphy.Checked = p.patient_fkSickness.sickness_RadiationTheraphy;
            addpatient4.JoinReplacement.Checked = p.patient_fkSickness.sickness_JointReplacement;
            addpatient4.HeartSurgery.Checked = p.patient_fkSickness.sickness_HeartSurgery;
            addpatient4.HeartAttack.Checked = p.patient_fkSickness.sickness_HeartAttack;
            addpatient4.ThyroidProblem.Checked = p.patient_fkSickness.sickness_ThyroidProblem;
            addpatient4.HeartDisease.Checked = p.patient_fkSickness.sickness_HeartDisease;
            addpatient4.HeartMumur.Checked = p.patient_fkSickness.sickness_HeartMumur;
            addpatient4.HepatitisLiverDisease.Checked = p.patient_fkSickness.sickness_HepatitisLiver;
            addpatient4.RheumaticFever.Checked = p.patient_fkSickness.sickness_RheumaticFever;
            addpatient4.HayFeverAllergies.Checked = p.patient_fkSickness.sickness_HayFeverAllergies;
            addpatient4.RespiratoryProblems.Checked = p.patient_fkSickness.sickness_RespiratoryProblems;
            addpatient4.HepatitisJaundice.Checked = p.patient_fkSickness.sickness_HepatitisJaundice;
            addpatient4.Tubercolosis.Checked = p.patient_fkSickness.sickness_Tubercolosis;
            addpatient4.SwollenAnkles.Checked = p.patient_fkSickness.sickness_SwollenAnkles;
            addpatient4.KidneyDisease.Checked = p.patient_fkSickness.sickness_KidneyDisease;
            addpatient4.Diabetes.Checked = p.patient_fkSickness.sickness_Diabetes;
            addpatient4.ChestPain.Checked = p.patient_fkSickness.sickness_ChestPain;
            addpatient4.Stroke.Checked = p.patient_fkSickness.sickness_Stroke;
            addpatient4.CancerTumors.Checked = p.patient_fkSickness.sickness_CancerTumors;
            addpatient4.Anemia.Checked = p.patient_fkSickness.sickness_Anemia;
            addpatient4.Angina.Checked = p.patient_fkSickness.sickness_Angina;
            addpatient4.Asthma.Checked = p.patient_fkSickness.sickness_Asthma;
            addpatient4.Emphysema.Checked = p.patient_fkSickness.sickness_Emphysema;
            addpatient4.BleedingProblems.Checked = p.patient_fkSickness.sickness_BleedingProblems;
            addpatient4.BloodDiseases.Checked = p.patient_fkSickness.sickness_BloodDiseases;
            addpatient4.HeadInjuries.Checked = p.patient_fkSickness.sickness_HeadInjuries;
            addpatient4.ArthritisRheumatism.Checked = p.patient_fkSickness.sickness_ArthritisRheumatism;
            addpatient4.Other.Checked = p.patient_fkSickness.sickness_Other.Length > 0;
            addpatient4.OtherTextBox.Text = p.patient_fkSickness.sickness_Other;
        }


        public static void clearFields()
        {
            /*addpatient.rtbFirstName.Text = "";
            addpatient.rtbLastName.Text = "";
            addpatient.rtbMiddleName.Text = "";
            addpatient.rtbNickName.Text = "";
            addpatient.rtbOccupation.Text = "";
            addpatient.rtbHomeBldgStNo.Text = "";
            addpatient.rtbZone.Text = "";
            addpatient.rtbStreet.Text = "";
            addpatient.rtbBrgySubdivision.Text = "";
            addpatient.rtbCityMunicipality.Text = "";
            addpatient.rtbStateProvince.Text = "";
            addpatient.rtbGuardianContactNumber.Text = "";
            addpatient.rtbGuardianName.Text = "";

            addpatient2.rtbHomeNumber.Text = "";
            addpatient2.rtbFaxNumber.Text = "";
            addpatient2.rtbOfficeNumber.Text = "";
            addpatient2.rtbMobileNumber.Text = "";
            addpatient2.rtbEmailAddress.Text = "";
            addpatient2.rtbReferralName.Text = "";
            addpatient2.rtbReasonforDentalConsultation.Text = "";
            addpatient2.rtbPreviousDentist.Text = "";
            addpatient2.rtbNameOfPhysician.Text = "";
            addpatient2.rtbSpecialty.Text = "";
            addpatient2.rtbOfficeAddress.Text = "";
            addpatient2.rtbOfficeNumberPhysician.Text = "";
            
            addpatient3.rtbMedicalTreatment.Text = "";
            addpatient3.rtbIlnessOperation.Text = "";
            addpatient3.rtbHospitalizedWhenWhy.Text = "";
            addpatient3.rtbPrescription.Text = "";

            addpatient4.LocalAnaesthetic.Checked = false;
            addpatient4.latex.Checked = false;
            addpatient4.SulfraDrugs.Checked = false;
            addpatient4.PenicillinAntibiotics.Checked = false;
            addpatient4.Aspirin.Checked = false;
            addpatient4.Other.Checked = false;
            addpatient4.OtherTextBox.Text = "";
            addpatient4.nudMin.Value = 0;
            addpatient4.nudSec.Value = 0;*/

            defaultUnchecked(addpatient.Controls);
            defaultUnchecked(addpatient2.Controls);
            defaultUnchecked(addpatient3.Controls);
            defaultUnchecked(addpatient4.Controls);

            addpatient3.noGoodHealth.Checked = true;
            addpatient3.noAlcohol.Checked = true;
            addpatient3.noHospitalized.Checked = true;
            addpatient3.noIllnessSurgical.Checked = true;
            addpatient3.noMedicaltreatment.Checked = true;
            addpatient3.noPrescription.Checked = true;
            addpatient3.noTobacco.Checked = true;

        }
        public static void disableFields(Control.ControlCollection c)
        {
            foreach (Control ctl in c)
            {
                if (ctl.HasChildren)
                    defaultUnchecked(ctl.Controls);

                else if (ctl is RoundedButton)
                    (ctl as RoundedButton).Enabled = true;
                else
                    ctl.Enabled = false;
            }
        }

        private static void defaultUnchecked(Control.ControlCollection c)
        {
            foreach (Control ctl in c)
            {
                if (ctl is CheckBox)
                    (ctl as CheckBox).Checked = false;

                else if (ctl is RadioButton)
                    (ctl as RadioButton).Checked = false;

                else if (ctl is RoundedText)
                    (ctl as RoundedText).Text = "";

                else if (ctl is TextBox)
                    (ctl as TextBox).Text = "";

                if (ctl.HasChildren)
                    defaultUnchecked(ctl.Controls);
            }
        }
    }
}
