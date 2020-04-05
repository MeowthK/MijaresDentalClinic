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
    public partial class RoundedPanel : Panel
    {
        public RoundedPanel()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        private int borderradius = 15;
        private Color contentcolor = Color.White;
        private Color bordercolor = Color.Black;

        public int BorderRadius { get { return borderradius; } set { if (value > 0) borderradius = value; this.Padding = new Padding(borderradius); this.Invalidate(); } }
        public Color ContentColor { get { return contentcolor; } set { contentcolor = value; this.Invalidate(); } }
        public Color BorderColor { get { return bordercolor; } set { bordercolor = value; this.Invalidate(); } }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath g = new GraphicsPath();

            g.AddArc(0, 0, borderradius, borderradius, 180, 90);
            g.AddArc(this.Width - (borderradius + 1), 0, borderradius, borderradius, 270, 90);
            g.AddArc(this.Width - (borderradius + 1), this.Height - (borderradius + 1), borderradius, borderradius, 0, 90);
            g.AddArc(0, this.Height - (borderradius + 1), borderradius, borderradius, 90, 90);
            g.CloseFigure();

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; 
            e.Graphics.DrawPath(new Pen(bordercolor), g);
            e.Graphics.FillPath(new SolidBrush(contentcolor), g);
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Invalidate();
        }
    }
}
