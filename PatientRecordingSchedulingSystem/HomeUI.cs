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
    public partial class HomeUI : UserControl
    {
        public HomeUI()
        {
            InitializeComponent();
        }

        private void rpnlPatientList_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void panel4_VisibleChanged(object sender, EventArgs e)
        {

            DBInterface dbi = new DBInterface("SE_PatientRecordSchedulingSystem");
            Person[] persons = dbi.getAllPerson();

            panel4.Controls.Clear();
            foreach (Person person in persons)
            {
                PatientList plist = new PatientList();
                plist.Dock = DockStyle.Top;
                plist.person = person;
                panel4.Controls.Add(plist);
                plist.DoubleClick +=new EventHandler(plist_DoubleClick);

            }
        }
        private void plist_DoubleClick(object sender, EventArgs e)
        {
            Person p = (sender as PatientList).person;
            
            // added
            DBInterface dbi = new DBInterface("SE_PatientRecordSchedulingSystem");
            Patient pt = dbi.getPatientByPersonId(p.personId);

            new PatientInfo(pt).ShowDialog();
        }
        private void rtbSearchPatient_TxtChanged(object sender, EventArgs e)
        {
            foreach (PatientList plist in panel4.Controls)
            { 
                string concatname = plist.person.firstName + " " + plist.person.lastName + " " + plist.person.middleName;
                concatname = concatname.ToLower();
                if (!concatname.Contains(rtbSearchPatient.Text.ToLower()))
                {
                    plist.Hide();
                }
                else
                    plist.Show();
            }
        }
    }
}
