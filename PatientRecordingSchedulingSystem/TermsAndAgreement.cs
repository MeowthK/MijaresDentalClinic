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
    public partial class TermsAndAgreement : Form
    {
        

        public bool isAgreed = true;
        private int Page = 0;
        private string[] consentHeader =
        {
          "TREATMENT TO BE DONE",
          "DRUGS & MEDICATIONS",
          "CHANGES IN TREATMENT PLAN",
          "RADIOGRAPH",
          "REMOVAL OF TEETH",
          "CROWNS (CAPS) & BRIDGES",
          "ENDODONTICS (ROOT CANAL)",
          "PERIODONTAL DISEASE",
          "FILLINGS",
          "DENTURES",
          "I understand that dentistry is not an exact science and that no dentist can properly guarantee accurate results all the time",
          ""};

        private string[] consentContents = 
        { "I understand and consent to have any treatment done by the dentist after the procedure, the risks & benefits & cost have been fully explained. These treatments include, but are not limited to, x-rays,  cleanings, periodotal, treatments, fillings, crowns, bridges, all types of extraction, rootcanals, & / or dentures, local anesthetics & surgical cases.",
          "I understand that antibiotics, analgesics & other medications can cause allergic reactions like redness & swelling of tissues, pain , itching , vomiting, & / or anaphlyclastic shock.",
          "I understand that during treatment if may be necessary to change / add procedures because of conditions found while working on the teeth that was not discovered during examination. For example, root canal therapy may be needed following routine restorative procedures. I give my permission to the dentist to make any / all changes and additions as necessary w/ my responsibility to pay all the costs agreed.",
          "I understand that an x-ray shot or a radigraph may be necessary as part of diagnostic aid to come up with tentative diagnostics of my Dental problem and to make a good treatment plan, but this will not give me a 100% assurance for the accuracy of the treatment since all dental treatments are subject to unpredictable complications that later on may lead to sudden changes and additions as necessary w/ my resposibility to pay all the costs agreed.",
          "I understand that alternatvies to tooth removal( root canal therapy, crown &periodontal surgery, etc.) & I completely understand these alternatives, including their risk & beneits prior to authorizing the dentist to remove teeth & any other structures necessary for reasons above. I understand that removing teeth does not always remove all the infections, if present, & it may be necessary to have further treatment. I understand the risk involved in having teeth removed, such as pain swelling, spread of infection, dry socket, fractured jaw, loss of feeling on the teeth, lips, tounge & sorrounding tissue that can last for an indefinite period of time. I understand that I may need further treatment under a specialist if complications arise during or following treatment.",
          "Preparing a tooth may irritate the nerve tissue in the center of the tooth, leaving the tooth extra sensitive to heat, cold & pressure. treating such irritation may invovle using special toothpastes, mouth rinses or root canal theraphy. I understand that sometimes it is not possible to match the color of natural teeth exactly with artificial teeth. I further understand that i may be wearing temporary crowns, which may come off easily & that imust be careful to ensure that they are kept on until the permanent crowns are delivered. It is my responsibility to return for permanent cementation within 20 days from tooth preparation, as excessove daus delay may allow for tooth movement, which may necessiate  a remake of the crown, bridge/cap. I understand there will be additional charges for remakes due to my delaying of permanent cementation, & I realize that final oportunity to make changes in my new crown, bridges or cap(including shape, fit size, & color) will be before permanent cementation.",
          "I understand there is no guarantee that a root canal treatment will save a tooth & that complications can occur from the treatment & that occasionally root canal filling material may extend through the tooth which does not necessarily effect the success of the treatment. I understand that endodontic files & drills are very fine instruments & stresses vented in their manufacture & calcifications present in teeth can cause them to break during use. I understand that referral to the endodontist for additional treatments may be necessary following any root canal treatment & I agree that I am responsible for any additional cost for treatment performed by the endodontist . I understad that a tooth may required removal in spite of all efforts to save it.",
          "I understand that periodontal disease is a serious condition causing gum & bone inflammation &/ or loss & that can lead eventually to the loss of my teeth. I understand the alternative treatment plans to correct periodontal disease, including gum surgery tooth extractions with or without replacement. I understand that undertaking any dental procedures may have future adverse effect on my periodontal conditions.",
          "I understand that care must be exercised in chewing on fillings, especially during the first 24 hours to avoid breakage. I understand that a more extensive filling or a crown may be required , a additional decay or fracture may become evident after initial excavation. I understand that significant sensitivity is a common, but usually temporary, after-effect of a newly place filling. I further understand that filling a tooth may irritate the nerve tissue creating sensitivity &  treating such sensitivity could require root canal therapy or extractions.",
          "I understand that wearing of dentures can be difficult. Sore spots, altered speech & dificulty in eating are common problems. Immediate  dentures (placement of denture immediately after extractions) may be painful. Immedate dentures may require considerable adjusting & several relines. I understand that it is my resposibility to retun for delivery of dentures. I understand that failure to keep my delivery appointment may result in poorly itted dentures. If a remake is required due to my delays of more than 30 days, there will be additional charges. A permanent reline will be needed laterm which is not included in the initial fee. I understand that all adjustment or alternation of any kind this initial period is subject to charges.",
          "I hereby authorize any of the doctors/ dental auxiliaries to proceed with & perform the dental restration & treatments as explained to me. I understand that these are subject to modification depending on undiagnosable circumstances that may arise during the course of treatment. I understand that regardless of any dental insurance coverage I ma have, I am responsible for payment of dental fees. I agree to pay any attorney's fees, collection fee, or court costs that may be incurred to satisfy any obligation to this office. All treatment were properly explained to me & any untoward circumstances that may arise during the procedure, the attending dentist will no be held liable since it is my free will, with full trust & confidence in him/her, to undergo dental treatment under his/her care.",
          ""};


        public TermsAndAgreement()
        {
            InitializeComponent();

            lblconsentHeader.Text = consentHeader[0];
            consentContent.Text = consentContents[0];
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            if (++Page >= consentContents.Length - 1)
                this.Close();

            lblconsentHeader.Text = consentHeader[Page];
            consentContent.Text = consentContents[Page];
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            isAgreed = false;
            this.Close();
        }
        private CheckBox getSickness(Control c, string ctrlname)
        {
            return c.Controls.Find(ctrlname, true)[0] as CheckBox;
        }

        private Control getControl(Control c, string ctrlname)
        {
            return c.Controls.Find(ctrlname, true)[0];
        }


        private void TermsAndAgreement_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure, you want to register?", "Confirm to Register Patient", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                DBInterface addpatient = new DBInterface("SE_PatientRecordSchedulingSystem");

                AddPatient p1 = UIController.getUIControl(UIPart.ADD_PATIENT) as AddPatient;
                AddPatient2 p2 = UIController.getUIControl(UIPart.ADD_PATIENT2) as AddPatient2;
                AddPatient3 p3 = UIController.getUIControl(UIPart.ADD_PATIENT3) as AddPatient3;
                AddPatient4 p4 = UIController.getUIControl(UIPart.ADD_PATIENT4) as AddPatient4;

                generalAddress g = new generalAddress();
                g.address_Home = p1.rtbHomeBldgStNo.Text;
                g.address_Zone = p1.rtbZone.Text;
                g.address_Street = p1.rtbStreet.Text;
                g.address_City = p1.rtbCityMunicipality.Text;
                g.address_Province = p1.rtbStateProvince.Text;
                g.address_Barangay = p1.rtbBrgySubdivision.Text;

                Sickness s = new Sickness();

                s.sickness_HighBloodPressure = p4.HighBloodPressure.Checked; //getSickness(p4, "HighBloodPressure").Checked;
                s.sickness_LowBLoodPressure = p4.LowBloodPressure.Checked;//getSickness(p4, "LowBloodPressure").Checked;
                s.sickness_EpilepsyConvulsions = p4.EpilepsyConvulsions.Checked;
                s.sickness_AidsHiv = p4.AidsHIV.Checked;
                s.sickness_SexuallyTransmitted = p4.SexuallyTransmitted.Checked;
                s.sickness_StomachTroubles = p4.StomachTroublesUlcer.Checked;
                s.sickness_FaintingSeizure = p4.FaintingSeizure.Checked;
                s.sickness_RapidWeightLoss = p4.RapidWeightLoss.Checked;
                s.sickness_RadiationTheraphy = p4.RadiationTheraphy.Checked;
                s.sickness_JointReplacement = p4.JoinReplacement.Checked;
                s.sickness_HeartSurgery = p4.HeartSurgery.Checked;
                s.sickness_HeartAttack = p4.HeartAttack.Checked;
                s.sickness_ThyroidProblem = p4.ThyroidProblem.Checked;
                s.sickness_HeartDisease = p4.HeartDisease.Checked;
                s.sickness_HeartMumur = p4.HeartMumur.Checked;
                s.sickness_HepatitisLiver = p4.HepatitisLiverDisease.Checked;
                s.sickness_RheumaticFever = p4.RheumaticFever.Checked;
                s.sickness_HayFeverAllergies = p4.HayFeverAllergies.Checked;
                s.sickness_RespiratoryProblems = p4.RespiratoryProblems.Checked;
                s.sickness_HepatitisJaundice = p4.HepatitisJaundice.Checked;
                s.sickness_Tubercolosis = p4.Tubercolosis.Checked;
                s.sickness_SwollenAnkles = p4.SwollenAnkles.Checked;
                s.sickness_KidneyDisease = p4.KidneyDisease.Checked;
                s.sickness_Diabetes = p4.Diabetes.Checked;
                s.sickness_ChestPain = p4.ChestPain.Checked;
                s.sickness_Stroke = p4.Stroke.Checked;
                s.sickness_CancerTumors = p4.CancerTumors.Checked;
                s.sickness_Anemia = p4.Anemia.Checked;
                s.sickness_Angina = p4.Angina.Checked;
                s.sickness_Asthma = p4.Asthma.Checked;
                s.sickness_Emphysema = p4.Emphysema.Checked;
                s.sickness_BleedingProblems = p4.BleedingProblems.Checked;
                s.sickness_BloodDiseases = p4.BloodDiseases.Checked;
                s.sickness_HeadInjuries = p4.HeadInjuries.Checked;
                s.sickness_ArthritisRheumatism = p4.ArthritisRheumatism.Checked;
                s.sickness_Other = p4.OtherTextBox.Text;

                Patient p = new Patient();
                p.firstName = p1.rtbFirstName.Text;
                p.lastName = p1.rtbLastName.Text;
                p.middleName = p1.rtbMiddleName.Text;
                p.nickName = p1.rtbNickName.Text;
                p.gender = p1.ppnlGender.SelectedText[0];
                p.birthDate = p1.dtpBirthDate.Value;
                p.contactNum = p2.rtbMobileNumber.Text;
                p.nationality = p1.ppnlNationality.SelectedText;
                p.religion = p1.ppnlReligion.SelectedText;
                p.emailAdd = p2.rtbEmailAddress.Text;
                p.patient_Occupation = p1.rtbOccupation.Text;
                p.address = g;
                p.patient_fkSickness = s;
                p.patient_GuardianName = p1.rtbGuardianName.Text;
                p.patient_GuardianContactNumber = p1.rtbGuardianContactNumber.Text;
                p.patient_DentalInsurance = p1.ppnlNA.SelectedText;
                p.patient_DentalInsuranceEffective = p1.dtpExpiredDate.Value;
                
                p.patient_HomeNo = p2.rtbHomeNumber.Text;
                p.patient_OfficeNo = p2.rtbOfficeNumber.Text;
                p.patient_FaxNo = p2.rtbFaxNumber.Text;
                p.patient_Referrer = p2.rtbReferralName.Text;
                p.patient_ConsultationReason = p2.rtbReasonforDentalConsultation.Text;
                p.patient_PreviousDentist = p2.rtbPreviousDentist.Text;
                p.patient_LastDentalVisit = p2.dtpLastDentalVisit.Value;
                p.patient_PhysicianName = p2.rtbNameOfPhysician.Text;
                p.patient_PhysicianSpecialty = p2.rtbSpecialty.Text;
                p.patient_PhysicianOfficeAddress = p2.rtbOfficeAddress.Text;
                p.patient_OfficeNo = p2.rtbOfficeNumber.Text;
                
                p.patient_UnderMedicalTreatment = p3.rtbMedicalTreatment.Text;
                p.patient_SeriousIllnessName = p3.rtbIlnessOperation.Text;
                p.patient_HospitalizedWhenandWhere = p3.rtbHospitalizedWhenWhy.Text;
                p.patient_TakingPrescription = p3.rtbPrescription.Text;
                p.patient_BoolUsingTobacco = p3.yesTobacco.Checked;
                p.patient_BoolUsingAlcohol = p3.yesAlchol.Checked;

                p.patient_LocalAnaesthetic = p4.LocalAnaesthetic.Checked;
                p.patient_SulfraDrugs = p4.SulfraDrugs.Checked;
                p.patient_PenicillinAntibiotics = p4.PenicillinAntibiotics.Checked;
                p.patient_Aspirin = p4.Aspirin.Checked;
                p.patient_AllergicOthersTextBox = p4.AllergicOthersTextBox.Text;
                p.patient_Latex = p4.latex.Checked;
                int first = (int)p4.nudMin.Value;
                int last = (int)p4.nudSec.Value;
                p.patient_BleedingTime = (first +" " + last);
                p.patient_WomenBoolPregnant = p4.yesPregnant.Checked;
                p.patient_WomenBoolNursing =p4.yesNursing.Checked;
                p.patient_WomenBoolTakingBirth = p4.yesBirthCtrl.Checked;
                p.patient_BloodType = p4.ppnlBloodType.SelectedText;
                int systolic = (int)p4.nudBPfirst.Value;
                int diastolic = (int)p4.nudBPlast.Value;
                p.patient_BloodPressure = (systolic + " " + diastolic);

                addpatient.Patient(p);
            }
        }
    }
}
