using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

enum ConnectionStatus
{ 
    SUCCEEDED,
    FAILED
};

enum DBTransactMode
{
    STORE,
    RETRIEVE
}

namespace PatientRecordingSchedulingSystem
{
    class DBInterface
    {
        private SqlConnection conn;
        public DBInterface(string dbname)
        {
            conn = new SqlConnection(@"Server=.\SQLEXPRESS;Integrated Security=SSPI;Database=" + dbname);
        }
        private ConnectionStatus OpenConnection()
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

                conn.Open();
                return ConnectionStatus.SUCCEEDED;
            }
            catch
            {
                return ConnectionStatus.FAILED;
            }
        }
        
        public Person[] getAllPerson()
        {
            if (OpenConnection() == ConnectionStatus.SUCCEEDED)
            {
                List<Person> persons = new List<Person>();

                SqlParameters _param = new SqlParameters(conn, "GetAllPersons", DBTransactMode.RETRIEVE);

                SqlDataReader reader = _param.ProcessCommand();
                while (reader.Read())
                {
                    Person p = new Person();

                    p.personId = reader.GetInt32(reader.GetOrdinal("Person_Id"));
                    p.firstName = reader.GetString(reader.GetOrdinal("Fname"));
                    p.lastName = reader.GetString(reader.GetOrdinal("Lname"));
                    p.middleName = reader.GetString(reader.GetOrdinal("Mname"));
                    p.nickName = reader.GetString(reader.GetOrdinal("Nickname"));
                    p.gender = reader.GetString(reader.GetOrdinal("Gender"))[0];
                    p.birthDate = reader.GetDateTime(reader.GetOrdinal("Birthdate"));
                    p.emailAdd = reader.GetString(reader.GetOrdinal("EmailAdd"));
                    p.contactNum = reader.GetString(reader.GetOrdinal("ContactNumber"));
                    p.nationality = reader.GetString(reader.GetOrdinal("Nationality"));
                    p.religion = reader.GetString(reader.GetOrdinal("religion"));
                    p.address.address_Id = reader.GetInt32(reader.GetOrdinal("Person_Address"));
                    
                    persons.Add( p);

                }
                reader.Close();

                foreach (var person in persons)
                    person.address = getGeneralAddress(person.address.address_Id);

                return persons.ToArray();

            }
            return new Person [0];
        }
   
        public Patient getPatientByPersonId(int pId)
        {
            if (OpenConnection() == ConnectionStatus.SUCCEEDED)
            {
                SqlParameters _params = new SqlParameters(conn, "getPatientByPersonId", DBTransactMode.RETRIEVE);
                _params.AddParam("@Person_Id", pId);
                SqlDataReader read = _params.ProcessCommand();

                Patient p = null;

                if (read.Read())
                {
                    p = new Patient();

                    p.patient_Occupation = read.GetString(read.GetOrdinal("Patient_Occupation"));
                    p.patient_Referrer = read.GetString(read.GetOrdinal("Patient_Referrer"));
                    p.patient_DentalInsurance = read.GetString(read.GetOrdinal("Dental_Insurance"));
                    p.patient_DentalInsuranceEffective = read.GetDateTime(read.GetOrdinal("Dental_Insurance_EffectiveDate"));
                    p.patient_GuardianName = read.GetString(read.GetOrdinal("Guardian_Name"));
                    p.patient_GuardianContactNumber = read.GetString(read.GetOrdinal("Guardian_ContactNumber"));
                    p.patient_HomeNo = read.GetString(read.GetOrdinal("Home_No"));
                    p.patient_OfficeNo = read.GetString(read.GetOrdinal("Office_No"));
                    p.patient_FaxNo = read.GetString(read.GetOrdinal("Fax_No"));
                    p.patient_ConsultationReason = read.GetString(read.GetOrdinal("Consultation_Reason"));
                    p.patient_PreviousDentist = read.GetString(read.GetOrdinal("Previous_Dentist"));
                    p.patient_LastDentalVisit = read.GetDateTime(read.GetOrdinal("Last_DentalVisit"));
                    p.patient_PhysicianName = read.GetString(read.GetOrdinal("Physician_Name"));
                    p.patient_PhysicianOfficeAddress = read.GetString(read.GetOrdinal("Physician_OfficeAddress"));
                    p.patient_PhysicianOfficeNo = read.GetString(read.GetOrdinal("Physician_OfficeNo"));
                    p.patient_BoolInGoodHealth = read.GetBoolean(read.GetOrdinal("Bool_InGoodHealth"));
                    p.patient_UnderMedicalTreatment = read.GetString(read.GetOrdinal("UnderMedicalTreatmentCondition"));
                    p.patient_SeriousIllnessName = read.GetString(read.GetOrdinal("SeriousIllnessName"));
                    p.patient_HospitalizedWhenandWhere = read.GetString(read.GetOrdinal("HospitalizedWhenAndWhy"));
                    p.patient_TakingPrescription = read.GetString(read.GetOrdinal("TakingPrescriptionName"));
                    p.patient_BoolUsingTobacco = read.GetBoolean(read.GetOrdinal("Bool_UsingTobacco"));
                    p.patient_BoolUsingAlcohol = read.GetBoolean(read.GetOrdinal("Bool_UsingAlcoholEtc"));
                    p.patient_AllergicToSubstance = read.GetString(read.GetOrdinal("AllergicToSubstance"));
                    p.patient_BleedingTime = read.GetString(read.GetOrdinal("Bleeding_Time"));
                    p.patient_WomenBoolPregnant = read.GetBoolean(read.GetOrdinal("WomenBool_Pregnant"));
                    p.patient_WomenBoolNursing = read.GetBoolean(read.GetOrdinal("WomenBool_Nursing"));
                    p.patient_WomenBoolTakingBirth = read.GetBoolean(read.GetOrdinal("WomenBool_TakingBirthControl"));
                    p.patient_BloodType = read.GetString(read.GetOrdinal("Blood_Type"));
                    p.patient_BloodPressure = read.GetString(read.GetOrdinal("Blood_Pressure"));
                    p.patient_Ailments = read.GetString(read.GetOrdinal("Ailements"));
                    p.patient_LocalAnaesthetic = read.GetBoolean(read.GetOrdinal("Bool_LocalAnaesthetic"));
                    p.patient_SulfraDrugs = read.GetBoolean(read.GetOrdinal("Bool_SulfraDrugs"));
                    p.patient_PenicillinAntibiotics = read.GetBoolean(read.GetOrdinal("Bool_PenicillinAntibiotics"));
                    p.patient_Aspirin = read.GetBoolean(read.GetOrdinal("Bool_Aspirin"));
                    p.patient_Latex = read.GetBoolean(read.GetOrdinal("Bool_Latex"));
                    p.patient_AllergicOthersTextBox = read.GetString(read.GetOrdinal("AllergicTextBoxOthers"));
                    p.patient_fkSickness.sickness_Id = read.GetInt32(read.GetOrdinal("Patient_Sickness"));

                    read.Close();

                    // added
                    p.patient_fkSickness = getSickness(p.patient_fkSickness.sickness_Id);

                    Person pp = getPerson(pId);

                    p.address = pp.address;
                    p.firstName = pp.firstName;
                    p.lastName = pp.lastName;
                    p.middleName = pp.middleName;
                    p.nationality = pp.nationality;
                    p.nickName = pp.nickName;
                    p.religion = pp.religion;
                    p.emailAdd = pp.emailAdd;
                    p.contactNum = pp.contactNum;
                    p.birthDate = pp.birthDate;

                }
                return p;
            }
            else
                throw new Exception("cant get patient Id");
        }
        public generalAddress getGeneralAddress(int addId)
        {
            if (OpenConnection() == ConnectionStatus.SUCCEEDED)
            {
                SqlParameters _params = new SqlParameters(conn, "GetGeneralAddress", DBTransactMode.RETRIEVE);
                _params.AddParam("@Address_Id", addId);
                SqlDataReader read = _params.ProcessCommand();

                generalAddress gAdd = null;
                if (read.Read())
                {
                    gAdd = new generalAddress();

                    gAdd.address_Barangay = read.GetString(read.GetOrdinal("address_Barangay"));
                    gAdd.address_City = read.GetString(read.GetOrdinal("address_City"));
                    gAdd.address_Home = read.GetString(read.GetOrdinal("address_Home"));
                    gAdd.address_Id = addId;
                    gAdd.address_Province = read.GetString(read.GetOrdinal("address_Province"));
                    gAdd.address_Street = read.GetString(read.GetOrdinal("address_Street"));
                    gAdd.address_Zone = read.GetString(read.GetOrdinal("address_Zone"));

                    read.Close();
                }

                return gAdd;
            }

            else
                throw new Exception("cant get Address Id");
        }
        
        public Sickness getSickness(int sId)
        {
            if (OpenConnection() == ConnectionStatus.SUCCEEDED)
            {
                SqlParameters _params = new SqlParameters(conn, "getSicknessbyId", DBTransactMode.RETRIEVE);
                _params.AddParam("@Sickness_Id", sId);
                
                SqlDataReader read = _params.ProcessCommand();


                Sickness s = null;
                if (read.Read())
                {
                    s = new Sickness();

                    s.sickness_AidsHiv = read.GetBoolean(read.GetOrdinal("sickness_AidsHiv"));
                    s.sickness_Anemia = read.GetBoolean(read.GetOrdinal("sickness_Anemia"));
                    s.sickness_Angina = read.GetBoolean(read.GetOrdinal("sickness_Angina"));
                    s.sickness_ArthritisRheumatism = read.GetBoolean(read.GetOrdinal("sickness_ArthritisRheumatism"));
                    s.sickness_Asthma = read.GetBoolean(read.GetOrdinal("sickness_Asthma"));
                    s.sickness_BleedingProblems = read.GetBoolean(read.GetOrdinal("sickness_BleedingProblems"));
                    s.sickness_BloodDiseases = read.GetBoolean(read.GetOrdinal("sickness_BloodDiseases"));
                    s.sickness_CancerTumors = read.GetBoolean(read.GetOrdinal("sickness_CancerTumors"));
                    s.sickness_ChestPain = read.GetBoolean(read.GetOrdinal("sickness_ChestPain"));
                    s.sickness_Diabetes = read.GetBoolean(read.GetOrdinal("sickness_Diabetes"));
                    s.sickness_Emphysema = read.GetBoolean(read.GetOrdinal("sickness_Emphysema"));
                    s.sickness_EpilepsyConvulsions = read.GetBoolean(read.GetOrdinal("sickness_EpilepsyConvulsions"));
                    s.sickness_FaintingSeizure = read.GetBoolean(read.GetOrdinal("sickness_FaintingSeizure"));
                    s.sickness_HayFeverAllergies = read.GetBoolean(read.GetOrdinal("sickness_HayFeverAllergies"));
                    s.sickness_HeadInjuries = read.GetBoolean(read.GetOrdinal("sickness_HeadInjuries"));
                    s.sickness_HeartAttack = read.GetBoolean(read.GetOrdinal("sickness_HeartAttack"));
                    s.sickness_HeartDisease = read.GetBoolean(read.GetOrdinal("sickness_HeartDisease"));
                    s.sickness_HeartMumur = read.GetBoolean(read.GetOrdinal("sickness_HeartMumur"));
                    s.sickness_HeartSurgery = read.GetBoolean(read.GetOrdinal("sickness_HeartSurgery"));
                    s.sickness_HepatitisJaundice = read.GetBoolean(read.GetOrdinal("sickness_HepatitisJaundice"));
                    s.sickness_HepatitisLiver = read.GetBoolean(read.GetOrdinal("sickness_HepatitisLiver"));
                    s.sickness_HighBloodPressure = read.GetBoolean(read.GetOrdinal("sickness_HighBloodPressure"));
                    s.sickness_Id = sId;
                    s.sickness_JointReplacement = read.GetBoolean(read.GetOrdinal("sickness_JointReplacement"));
                    s.sickness_KidneyDisease = read.GetBoolean(read.GetOrdinal("sickness_KidneyDisease"));
                    s.sickness_LowBLoodPressure = read.GetBoolean(read.GetOrdinal("sickness_LowBloodPressure"));
                    s.sickness_Other = read.GetString(read.GetOrdinal("sickness_Other"));
                    s.sickness_RadiationTheraphy = read.GetBoolean(read.GetOrdinal("sickness_RadiationTheraphy"));
                    s.sickness_RapidWeightLoss = read.GetBoolean(read.GetOrdinal("sickness_RapidWeightLoss"));
                    s.sickness_RespiratoryProblems = read.GetBoolean(read.GetOrdinal("sickness_RespiratoryProblems"));
                    s.sickness_RheumaticFever = read.GetBoolean(read.GetOrdinal("sickness_RheumaticFever"));
                    s.sickness_SexuallyTransmitted = read.GetBoolean(read.GetOrdinal("sickness_SexuallyTransmitted"));
                    s.sickness_StomachTroubles = read.GetBoolean(read.GetOrdinal("sickness_StomachTroubles"));
                    s.sickness_Stroke = read.GetBoolean(read.GetOrdinal("sickness_Stroke"));
                    s.sickness_SwollenAnkles = read.GetBoolean(read.GetOrdinal("sickness_SwollenAnkles"));
                    s.sickness_ThyroidProblem = read.GetBoolean(read.GetOrdinal("sickness_ThyroidProblem"));
                    s.sickness_Tubercolosis = read.GetBoolean(read.GetOrdinal("sickness_Tubercolosis"));

                    read.Close();
                }
                return s;
            }
            else
                throw new Exception("cant get Sickness Id");
        }
    
        public void Patient(Patient patient)
        {
            if (OpenConnection() == ConnectionStatus.SUCCEEDED)
            {
                SqlParameters _params = new SqlParameters(conn, "AddPerson", DBTransactMode.STORE);
                int personID = getPersonTopIndex() == -1 ? 0 : getPersonTopIndex() + 1;

                _params.AddParam("@Person_Id", personID);
                _params.AddParam("@Fname", patient.firstName);
                _params.AddParam("@Lname", patient.lastName);
                _params.AddParam("@Mname", patient.middleName);
                _params.AddParam("@Nickname", patient.nickName);
                _params.AddParam("@Gender", patient.gender);
                _params.AddParam("@Birthdate", patient.birthDate);
                _params.AddParam("@EmailAdd", patient.emailAdd);
                _params.AddParam("@ContactNumber", patient.contactNum);
                _params.AddParam("@Nationality", patient.nationality);
                _params.AddParam("@religion", patient.religion);

                AddAddress(patient.address);

                _params.ProcessCommand();

                _params = new SqlParameters(conn, "AddPatient", DBTransactMode.STORE);

                AddSickness(patient.patient_fkSickness);
                
                _params.AddParam("@Patient_Occupation", patient.patient_Occupation);
                _params.AddParam("@Patient_Referrer", patient.patient_Referrer);
                _params.AddParam("@Patient_DentalInsurance", patient.patient_DentalInsurance);
                _params.AddParam("@Patient_DentalInsuranceEffectiveDate", patient.patient_DentalInsuranceEffective);
                _params.AddParam("@Patient_GuardianName", patient.patient_GuardianName);
                _params.AddParam("@Patient_GuardianContactNumber", patient.patient_GuardianContactNumber);
                _params.AddParam("@Patient_HomeNo", patient.patient_HomeNo);
                _params.AddParam("@Patient_OfficeNo", patient.patient_OfficeNo);
                _params.AddParam("@Patient_FaxNo", patient.patient_FaxNo);
                _params.AddParam("@Patient_ConsultationReason", patient.patient_ConsultationReason);
                _params.AddParam("@Patient_PreviousDentist", patient.patient_PreviousDentist);
                _params.AddParam("@Patient_LastDentalVisit", patient.patient_LastDentalVisit);
                _params.AddParam("@Patient_PhysicianName", patient.patient_PhysicianName);
                _params.AddParam("@Patient_PhysicianSpecialty", patient.patient_PhysicianSpecialty);
                _params.AddParam("@Patient_PhysicianOfficeNo", patient.patient_PhysicianOfficeNo);
                _params.AddParam("@Patient_PhysicianOfficeAddress", patient.patient_PhysicianOfficeAddress);
                _params.AddParam("@Patient_BoolInGoodHealth", patient.patient_BoolInGoodHealth);
                _params.AddParam("@Patient_UnderMedicalTreatment", patient.patient_UnderMedicalTreatment);
                _params.AddParam("@Patient_SeriousIllnessName", patient.patient_SeriousIllnessName);
                _params.AddParam("@Patient_HospitalizedWhenAndWhy", patient.patient_HospitalizedWhenandWhere);
                _params.AddParam("@Patient_TakingPrescriptionName", patient.patient_TakingPrescription);
                _params.AddParam("@Patient_BoolUsingTobacco", patient.patient_BoolUsingTobacco);
                _params.AddParam("@Patient_BoolUsingAlcoholic", patient.patient_BoolUsingAlcohol);
                _params.AddParam("@Patient_AllergicToSubstance", patient.patient_AllergicToSubstance);
                _params.AddParam("@Patient_BleedingTime", patient.patient_BleedingTime);
                _params.AddParam("@Patient_WomenBoolPregnant", patient.patient_WomenBoolPregnant);
                _params.AddParam("@Patient_WomenBoolNursing", patient.patient_WomenBoolNursing);
                _params.AddParam("@Patient_WomenBoolTakingBirthControl", patient.patient_WomenBoolTakingBirth);
                _params.AddParam("@Patient_BloodType", patient.patient_BloodType);
                _params.AddParam("@Patient_BloodPressure", patient.patient_BloodPressure);
                _params.AddParam("@Patient_Ailements", patient.patient_Ailments);
                _params.AddParam("@Bool_LocalAnaesthetic", patient.patient_LocalAnaesthetic);
                _params.AddParam("@Bool_SulfraDrugs", patient.patient_SulfraDrugs);
                _params.AddParam("@Bool_PenicillinAntibiotics", patient.patient_PenicillinAntibiotics);
                _params.AddParam("@Bool_Aspirin", patient.patient_Aspirin);
                _params.AddParam("@Bool_Latex", patient.patient_Latex);
                _params.AddParam("@AllergicTextBoxOthers", patient.patient_AllergicOthersTextBox);

                _params.ProcessCommand();

                conn.Close();
            }
            else
                throw new Exception("Cannot add this person: " + patient.firstName + patient.lastName);
        }
        public int getAddressTopId()
        {
            int index = -1;
            if (OpenConnection() == ConnectionStatus.SUCCEEDED)
            {
                SqlParameters _params = new SqlParameters(conn, "getAddressTopId", DBTransactMode.RETRIEVE);
                SqlDataReader read = _params.ProcessCommand();

                if (read.Read())
                    index = read.GetInt32(0);

                read.Close();
            }
            return index; 
        }

        public void AddAddress(generalAddress address)
        {
            if (OpenConnection() == ConnectionStatus.SUCCEEDED)
            {
                var _params = new SqlParameters(conn, "AddAddress", DBTransactMode.STORE);
                _params.AddParam(@"address_Zone",address.address_Zone);
                _params.AddParam(@"address_Street", address.address_Street);
                _params.AddParam(@"address_Barangay", address.address_Barangay);
                _params.AddParam(@"address_City", address.address_City);
                _params.AddParam(@"address_Municipality", address.address_Home);
                _params.AddParam(@"address_Province", address.address_Province);

                _params.ProcessCommand();
            }
        }

        public void AddSickness(Sickness sickshit)
        {
            if (OpenConnection() == ConnectionStatus.SUCCEEDED)
            {
                var _params = new SqlParameters(conn, "AddSickness", DBTransactMode.STORE);
                _params.AddParam(@"sickness_HighBloodPressure",sickshit.sickness_HighBloodPressure);
	            _params.AddParam(@"sickness_LowBLoodPressure",sickshit.sickness_LowBLoodPressure);
	            _params.AddParam(@"sickness_EpilepsyConvulsions",sickshit.sickness_EpilepsyConvulsions);
	            _params.AddParam(@"sickness_AidsHiv",sickshit.sickness_AidsHiv);
	            _params.AddParam(@"sickness_SexuallyTransmitted",sickshit.sickness_SexuallyTransmitted);
	            _params.AddParam(@"sickness_StomachTroubles",sickshit.sickness_StomachTroubles);
	            _params.AddParam(@"sickness_FaintingSeizure",sickshit.sickness_FaintingSeizure);
	            _params.AddParam(@"sickness_RapidWeightLoss",sickshit.sickness_RapidWeightLoss);
	            _params.AddParam(@"sickness_RadiationTheraphy",sickshit.sickness_RadiationTheraphy);
	            _params.AddParam(@"sickness_JointReplacement",sickshit.sickness_JointReplacement);
	            _params.AddParam(@"sickness_HeartSurgery",sickshit.sickness_HeartSurgery);
                _params.AddParam(@"sickness_HeartAttack", sickshit.sickness_HeartAttack);
	            _params.AddParam(@"sickness_ThyroidProblem",sickshit.sickness_ThyroidProblem);
	            _params.AddParam(@"sickness_HeartDisease",sickshit.sickness_HeartDisease);
	            _params.AddParam(@"sickness_HeartMumur",sickshit.sickness_HeartMumur);
	            _params.AddParam(@"sickness_HepatitisLiver",sickshit.sickness_HepatitisLiver);
	            _params.AddParam(@"sickness_RheumaticFever",sickshit.sickness_RheumaticFever);
	            _params.AddParam(@"sickness_HayFeverAllergies",sickshit.sickness_HayFeverAllergies);
	            _params.AddParam(@"sickness_RespiratoryProblems",sickshit.sickness_RespiratoryProblems);
	            _params.AddParam(@"sickness_HepatitisJaundice",sickshit.sickness_HepatitisJaundice);
	            _params.AddParam(@"sickness_Tubercolosis",sickshit.sickness_Tubercolosis);
	            _params.AddParam(@"sickness_SwollenAnkles",sickshit.sickness_SwollenAnkles);
	            _params.AddParam(@"sickness_KidneyDisease",sickshit.sickness_KidneyDisease);
	            _params.AddParam(@"sickness_Diabetes",sickshit.sickness_Diabetes);
	            _params.AddParam(@"sickness_ChestPain",sickshit.sickness_ChestPain);
	            _params.AddParam(@"sickness_Stroke",sickshit.sickness_Stroke);
	            _params.AddParam(@"sickness_CancerTumors",sickshit.sickness_CancerTumors);
	            _params.AddParam(@"sickness_Anemia",sickshit.sickness_Anemia);
	            _params.AddParam(@"sickness_Angina",sickshit.sickness_Angina);
	            _params.AddParam(@"sickness_Asthma",sickshit.sickness_Asthma);
	            _params.AddParam(@"sickness_Emphysema",sickshit.sickness_Emphysema);
	            _params.AddParam(@"sickness_BleedingProblems",sickshit.sickness_BleedingProblems);
	            _params.AddParam(@"sickness_BloodDiseases",sickshit.sickness_BloodDiseases);
	            _params.AddParam(@"sickness_HeadInjuries",sickshit.sickness_HeadInjuries);
	            _params.AddParam(@"sickness_ArthritisRheumatism",sickshit.sickness_ArthritisRheumatism);
	            _params.AddParam(@"sickness_Other", sickshit.sickness_Other);
      
                _params.ProcessCommand();
            }
        }

        public int getPersonTopIndex()
        {
            int index = -1;

            if (OpenConnection() == ConnectionStatus.SUCCEEDED)
            {
                SqlParameters _params = new SqlParameters(conn, "getPersonTopId", DBTransactMode.RETRIEVE);
                SqlDataReader reader = _params.ProcessCommand();

                if (reader.Read())
                    index = reader.GetInt32(0);

                reader.Close();
            }

            return index;
        }

        /*public SqlCommand CommandProcessor(string StoredProc, SqlParameterCollection sqlParams)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = StoredProc;
            command.CommandType = System.Data.CommandType.StoredProcedure;

            foreach (var param in sqlParams)
                command.Parameters.Add(param);

            return command;
        }*/

        public Person getPerson(int patient_Id)
        {
            if (OpenConnection() == ConnectionStatus.SUCCEEDED)
            {
                Person p = null;

                var _params = new SqlParameters(conn, "GetPersonById", DBTransactMode.RETRIEVE);
                _params.AddParam("@Person_Id", patient_Id);

                SqlDataReader reader = _params.ProcessCommand();

                if (reader.Read())
                {
                    p = new Person();

                    p.personId = reader.GetInt32(reader.GetOrdinal("Person_Id"));
                    p.firstName = reader.GetString(reader.GetOrdinal("Fname"));
                    p.lastName = reader.GetString(reader.GetOrdinal("Lname"));
                    p.middleName = reader.GetString(reader.GetOrdinal("Mname"));
                    p.nickName = reader.GetString(reader.GetOrdinal("Nickname"));
                    p.gender = reader.GetString(reader.GetOrdinal("Gender"))[0];
                    p.birthDate = reader.GetDateTime(reader.GetOrdinal("Birthdate"));
                    p.emailAdd = reader.GetString(reader.GetOrdinal("EmailAdd"));
                    p.contactNum = reader.GetString(reader.GetOrdinal("ContactNumber"));
                    p.nationality = reader.GetString(reader.GetOrdinal("Nationality"));
                    p.religion = reader.GetString(reader.GetOrdinal("religion"));
                    p.address.address_Id = reader.GetInt32(reader.GetOrdinal("Person_Address"));
                }

                reader.Close();

                p.address = getGeneralAddress(p.address.address_Id);

                return p;
            }
            else
                throw new Exception("Cannot retrieve PERSON data!");
        }
    }

    class SqlParameters
    {
        private SqlCommand command;
        private DBTransactMode mode;

        public SqlParameters( SqlConnection connection, string procedureName, DBTransactMode mode )
        {
            this.mode = mode;

            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = procedureName;
            command.CommandType = System.Data.CommandType.StoredProcedure;
        }

        public void AddParam(string parameterName, object value)
        {
            command.Parameters.AddWithValue(parameterName, value);
        }

        public SqlDataReader ProcessCommand()
        {
            if ( mode == DBTransactMode.RETRIEVE )
                return command.ExecuteReader();
            else
                command.ExecuteNonQuery();

            return null;
        }
    }
}
