using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PatientRecordingSchedulingSystem
{
    public partial class RoundedButton : UserControl
    {
        public RoundedButton()
        {
            InitializeComponent();
            contentcolor = inactive;
        }
        private string btxt = "Lorenipsum";
        private int borderradius = 15;
        private Color highlightcolor = Color.DarkOrange;
        private Color inactive = Color.White;
        private Color contentcolor = Color.White;

        public string ButtonText { get { return btxt; } set { btxt = value; this.Invalidate(); } }
        public int BorderRadius { get { return borderradius; } set { if (value > 0) borderradius = value; this.Invalidate(); } }
        public Color HighlightColor { get { return highlightcolor; } set { highlightcolor = value; } }
        public Color InactiveColor { get { return inactive; } set { inactive = value; } }
        public Color ContentColor { get { return contentcolor; } set { contentcolor = value; this.Invalidate(); } }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath g = new GraphicsPath();

            g.AddArc(0, 0,borderradius, borderradius, 180, 90);
            g.AddArc(this.Width - (borderradius + 1), 0, borderradius, borderradius, 270, 90);
            g.AddArc(this.Width - (borderradius + 1), this.Height - (borderradius + 1), borderradius, borderradius, 0, 90);
            g.AddArc(0, this.Height - (borderradius + 1), borderradius, borderradius, 90, 90);
            g.CloseFigure();

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(Pens.Black, g);
            e.Graphics.FillPath(new SolidBrush(contentcolor), g);

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(btxt, this.Font,Brushes.Black,this.ClientRectangle,sf);
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Invalidate();
        }

        private void RoundedButton_Click(object sender, EventArgs e)
        {

        }

        private void RoundedButton_MouseDown(object sender, MouseEventArgs e)
        {
            contentcolor = highlightcolor;
            this.Invalidate();
        }

        private void RoundedButton_MouseUp(object sender, MouseEventArgs e)
        {
            contentcolor = inactive;
            this.Invalidate();
        }
    }
}
