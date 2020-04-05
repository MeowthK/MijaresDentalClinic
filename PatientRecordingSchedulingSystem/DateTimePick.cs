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
    public partial class DateTimePick : UserControl
    {
        public DateTimePick()
        {
            InitializeComponent();
        }
        public bool IsStrict { get; set; }
        public DateTime Value { get { return dateTimePicker1.Value; } set { dateTimePicker1.Value = value; } }
        public event EventHandler OnValueChange
        {
            add{
                dateTimePicker1.ValueChanged += value;
            }

            remove{
                dateTimePicker1.ValueChanged -= value;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > DateTime.Now && IsStrict)
            {
                roundedPanel1.BorderColor = Color.Red;
                toolTip1.Show("Birthdate must be lower than the current date", dateTimePicker1, 1000);
            }
            else
            {
                roundedPanel1.BorderColor = Color.Black;
            }
        }

        

    }
}
