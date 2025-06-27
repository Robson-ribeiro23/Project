using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

    public class CircularPanel : Panel
    {
    public int BorderSize { get; set; } = 2;
    public Color BorderColor { get; set; } = Color.Black;

    public CircularPanel()
    {
        this.DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        int diametro = Math.Min(this.Width, this.Height);
        int raio = diametro / 2;

        using (GraphicsPath path = new GraphicsPath())
        {

            path.AddEllipse(0, 0, diametro - 1, diametro - 1);

            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            if (BorderSize > 0)
            {
                using (Pen pen = new Pen(BorderColor, BorderSize))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }

            this.Region = new Region(path);
        }
    }
}

