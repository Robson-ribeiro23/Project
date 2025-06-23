using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

    public class SuperiorRoundedPic : PictureBox
    {
    public int BorderSize { get; set; } = 2;
    public Color BorderColor { get; set; } = Color.Black;
    public int BorderRadius { get; set; } = 20;

    public SuperiorRoundedPic()
    {
        this.DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        using (GraphicsPath path = new GraphicsPath())
        {
            int arcSize = BorderRadius * 2;
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

            path.StartFigure();
            path.AddArc(new Rectangle(rect.X, rect.Y, arcSize, arcSize), 180, 90);
            path.AddArc(new Rectangle(rect.Right - arcSize, rect.Y, arcSize, arcSize), 270, 90);
            path.AddLine(new Point(rect.Right, rect.Y + arcSize), new Point(rect.Right, rect.Bottom)); // Linha direita
            path.AddLine(new Point(rect.X, rect.Bottom), new Point(rect.X, rect.Y + arcSize)); // Linha esquerda

            path.CloseFigure();

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

            if (this.Image != null)
            {
                Rectangle imageRect = new Rectangle(
                    BorderSize, // Margem à esquerda
                    BorderSize, // Margem acima
                    this.Width - 2 * BorderSize, // Largura restante
                    this.Height - 2 * BorderSize // Altura restante
                );

                //corte da imagem
                e.Graphics.SetClip(path);
                e.Graphics.DrawImage(
                    this.Image,
                    imageRect,
                    new Rectangle(0, 0, this.Image.Width, this.Image.Height),
                    GraphicsUnit.Pixel
                );
                e.Graphics.ResetClip();
            }
        }
    }
}

