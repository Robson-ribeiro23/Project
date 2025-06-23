using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

    public class SuperiorRoundedPanel : Panel
    {
    public int BorderSize { get; set; } = 2;
    public Color BorderColor { get; set; } = Color.Black;
    public int BorderRadius { get; set; } = 20;

    public SuperiorRoundedPanel()
    {
        this.DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        using ( GraphicsPath path = new GraphicsPath())
        {
            int arcSize = BorderRadius * 2;
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

            path.StartFigure();
            path.AddArc(new Rectangle(rect.X, rect.Y, arcSize, arcSize),180, 90);
            path.AddArc(new Rectangle(rect.Right - arcSize, rect.Y, arcSize, arcSize), 270, 90);
            path.AddLine(new Point(rect.Right, rect.Y + arcSize), new Point(rect.Right, rect.Bottom)); // Linha reta para o lado direito
            path.AddLine(new Point(rect.X, rect.Bottom), new Point(rect.X, rect.Y + arcSize)); // Linha reta para o lado esquerdo

            path.CloseFigure();

            using(SolidBrush brush = new SolidBrush(this.BackColor))
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

