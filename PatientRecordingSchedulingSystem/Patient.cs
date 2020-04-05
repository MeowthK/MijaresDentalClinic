using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientRecordingSchedulingSystem
{
    public class Patient:Person
    {
        public int patient_id;
        public string patient_Active = "";
        public string patient_Occupation = "";
        public string patient_Referrer = "";
        public string patient_DentalInsurance = "";
        public DateTime patient_DentalInsuranceEffective;
        public string patient_GuardianName = "";
        public string patient_GuardianContactNumber = "";
        public string patient_HomeNo = "";
        public string patient_OfficeNo = "";
        public string patient_FaxNo = "";
        public string patient_ConsultationReason = "";
        public string patient_PreviousDentist = "";
        public DateTime patient_LastDentalVisit;
        public string patient_PhysicianName = "";
        public string patient_PhysicianSpecialty = "";
        public string patient_PhysicianOfficeNo = "";
        public string patient_PhysicianOfficeAddress = "";
        public bool patient_BoolInGoodHealth;
        public string patient_UnderMedicalTreatment = "";
        public string patient_SeriousIllnessName = "";
        public string patient_HospitalizedWhenandWhere = "";
        public string patient_TakingPrescription = "";
        public bool patient_BoolUsingTobacco;
        public bool patient_BoolUsingAlcohol;
        public string patient_AllergicToSubstance = "";
        public string patient_BleedingTime = "";
        public bool patient_WomenBoolPregnant;
        public bool patient_WomenBoolNursing;
        public bool patient_WomenBoolTakingBirth;
        public string patient_BloodType = "";
        public string patient_BloodPressure = "";
        public string patient_Ailments = "";
        public Sickness patient_fkSickness = new Sickness();
        public bool patient_LocalAnaesthetic;
        public bool patient_SulfraDrugs;
        public bool patient_PenicillinAntibiotics;
        public bool patient_Aspirin;
        public bool patient_Latex;
        public string patient_AllergicOthersTextBox = "";
    }
}
