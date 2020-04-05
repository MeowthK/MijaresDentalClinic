using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientRecordingSchedulingSystem
{
    public class Person
    {
        public int personId;
        public string firstName = "";
        public string lastName = "";
        public string middleName = "";
        public string nickName = "";
        public char gender = 'M';
        public DateTime birthDate;
        public string emailAdd = "";
        public string contactNum = "";
        public string nationality = "";
        public string religion = "";
        public generalAddress address = new generalAddress();
    }
}
