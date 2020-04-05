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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection("SE_PatientRecordSchedulingSystem");

            if (conn.VerifyAccount(rtbUsername.Text, rtbPassword.Text, cmbAccountType.SelectedText))
            {
                MessageBox.Show("Successfully Signed In");
                this.Hide();
                new Home().ShowDialog();
            }

            else
            {
                MessageBox.Show("Username or Password error");
            }
        }

        
    }
}
