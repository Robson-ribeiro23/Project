using System;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

    public class GradientPanel : Panel
    {
        public Color StartColor { get; set; } = Color.FromArgb(20, 97, 153); 
        public Color EndColor { get; set; } = Color.FromArgb(251, 136, 107);
        public LinearGradientMode GradientMode { get; set; } = LinearGradientMode.Horizontal;

        public GradientPanel()
        {
            this.DoubleBuffered = true; // Reduz flickering
            this.Resize += (s, e) => this.Invalidate(); 
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle, StartColor, EndColor, GradientMode))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }

