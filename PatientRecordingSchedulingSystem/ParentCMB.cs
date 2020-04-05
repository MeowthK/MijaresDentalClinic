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
    public partial class ParentCMB : ComboBox
    {
        public ParentCMB()
        {
            InitializeComponent();
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
        }

        private void ParentCMB_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1) return;
            int index = e.Index >= 0 ? e.Index : 0;
            e.DrawBackground();
            e.DrawFocusRectangle();

            e.Graphics.DrawString(this.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds.X, e.Bounds.Y);
        }
    }
}
