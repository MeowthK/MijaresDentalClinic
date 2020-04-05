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
    public partial class PatientList : UserControl
    {
        public Person person = new Person();
        public PatientList()
        {
            InitializeComponent();

        }
        private Color highlightcolor = Color.DarkOrange;
        private Color inactive = Color.White;
        private Color contentcolor = Color.White;

        public Color HighlightColor { get { return highlightcolor; } set { highlightcolor = value; } }
        public Color InactiveColor { get { return inactive; } set { inactive = value; } }
        public Color ContentColor { get { return contentcolor; } set { contentcolor = value; this.Invalidate(); } }
        private void PatientList_Paint(object sender, PaintEventArgs e)
        {
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            e.Graphics.FillRectangle(new SolidBrush(contentcolor), this.ClientRectangle);
            e.Graphics.DrawString(person.firstName + " " +person.lastName + " " + person.middleName, this.Font, Brushes.Black, this.ClientRectangle, sf);
            
            e.Graphics.DrawLine(Pens.Black, 0, this.Height - 1, this.Width, this.Height - 1);

            
        }

        private void PatientList_MouseDown(object sender, MouseEventArgs e)
        {
            contentcolor = highlightcolor;
            this.Invalidate();
        }

        private void PatientList_MouseUp(object sender, MouseEventArgs e)
        {
            contentcolor = inactive;
            this.Invalidate();
        }
    }
}
