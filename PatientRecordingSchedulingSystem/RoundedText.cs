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
    public partial class RoundedText : UserControl
    {
        public RoundedText()
        {
            InitializeComponent();
        }

        private Color highlightcolor = Color.DarkOrange;
        private Color inactive = Color.Black;
        private Color contentcolor = Color.White;

        public event EventHandler TxtChanged
        {
            add {
                txtUserctrlText.TextChanged += value;
            }
            remove {
                txtUserctrlText.TextChanged -= value;
            }
        }
        public bool IsRequired { get; set; }
        public char PasswordChar { get { return txtUserctrlText.PasswordChar; } set { txtUserctrlText.PasswordChar = value; } }
        public string Text { get { return txtUserctrlText.Text; } set { txtUserctrlText.Text = value; } }
        public Color HighlightColor { get { return highlightcolor; } set { highlightcolor = value; } }
        public Color InactiveColor { get { return inactive; } set { inactive = value; } }
        public Color ContentColor { get { return contentcolor; } set { contentcolor = value; txtUserctrlText.BackColor = value; this.Invalidate(); } }
        public string Watermark { get { return  lblWaterMark.Text; } set { lblWaterMark.Text = value; } }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath g = new GraphicsPath();

            Color bordercolor;
            int borderwidth;

            if (txtUserctrlText.Focused)
            {
                borderwidth = 2;
                bordercolor = highlightcolor;
            }
            else 
            {
                borderwidth = 1;
                bordercolor = inactive;
            }

            int bwidth = borderwidth / 2 + borderwidth;

            g.AddArc( borderwidth, txtUserctrlText.Top - 10, 15, 15, 180, 90);
            g.AddArc(this.Width - 15 - bwidth, txtUserctrlText.Top - 10, 15, 15, 270, 90);
            g.AddArc(this.Width - 15 - bwidth, this.Height - 15 - bwidth, 15, 15, 0, 90);
            g.AddArc(borderwidth, this.Height - 15 - bwidth, 15, 15, 90, 90);

            g.CloseFigure();
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            if (IsRequired && txtUserctrlText.TextLength == 0)
            {
                bordercolor = Color.Red;
                
            }
            
            e.Graphics.DrawPath(new Pen(bordercolor, borderwidth), g);
            e.Graphics.FillPath(new SolidBrush(contentcolor), g);

            if (lblWaterMark.Top < txtUserctrlText.Top - 10)
            {
                int top = txtUserctrlText.Top - 9 - bwidth;

                e.Graphics.FillRectangle(new SolidBrush(contentcolor), lblWaterMark.Left, top, lblWaterMark.Width, bwidth);
                //e.Graphics.DrawLine(Pens.White, lblWaterMark.Left, txtUserctrlText.Top - 10, lblWaterMark.Right, txtUserctrlText.Top - 10);
            }
            
        }
        protected override void OnSizeChanged(EventArgs e)
        {  
            base.OnSizeChanged(e);
            this.Invalidate();
        }

        private void watermarkscroller_Tick(object sender, EventArgs e)
        {
            if (txtUserctrlText.Top - 12 < lblWaterMark.Top + lblWaterMark.Height / 2)
            {
                lblWaterMark.Top--;
                this.Invalidate();
            }

            
        }

        private void txtUserctrlText_TextChanged(object sender, EventArgs e)
        {
            if (IsRequired && txtUserctrlText.TextLength == 0)
            {
                toolTip1.Show("Area must be filled up", txtUserctrlText, 1000);
            }

            if (txtUserctrlText.TextLength > 0)
            {
                watermarkscroller.Start();
            }
            
        }

        private void txtUserctrlText_Enter(object sender, EventArgs e)
        {
            this.Invalidate();
            watermarkscroller.Start();

        }

        private void txtUserctrlText_Leave(object sender, EventArgs e)
        {
            this.Invalidate();
            if (txtUserctrlText.TextLength == 0)
            {
                watermarkscroller.Stop();
                lblWaterMark.Top = txtUserctrlText.Top - 7 + txtUserctrlText.Height / 2;
            }

        }
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                lblWaterMark.Font = new Font(base.Font.FontFamily, base.Font.Size, FontStyle.Bold);
                base.Font = value;
            }
        }

        private void lblWaterMark_Click(object sender, EventArgs e)
        {
            txtUserctrlText.Focus();
        }
    }
}
