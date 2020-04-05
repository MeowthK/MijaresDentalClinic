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
    public partial class ParentPanel : UserControl
    {
        public ParentPanel()
        {
            InitializeComponent();
        }
        private Color highlightcolor = Color.DarkOrange;
        private Color inactive = Color.Black;

        public string SelectedText { get { return parentCMB1.Text; } set { parentCMB1.Text = value; } }
        public Color HighlightColor { get { return highlightcolor; } set { highlightcolor = value; } }
        public Color InactiveColor { get { return inactive; } set { inactive = value; } }
        public string[] ComboBoxItems {
            get {
                List<string> items = new List<string>();

                foreach ( object item in parentCMB1.Items )
                    items.Add( item.ToString() );

                return items.ToArray();
            }
            set {
                parentCMB1.Items.Clear();
                parentCMB1.Items.AddRange( value );
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            rdPanel.BorderColor = highlightcolor;
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            rdPanel.BorderColor = inactive;
        }

       
    }
}
