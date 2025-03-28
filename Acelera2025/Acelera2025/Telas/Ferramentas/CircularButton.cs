using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class CircularButton : Button
{
    public int BorderSize { get; set; } = 2;
    public Color BorderColor { get; set; } = Color.Black;

    public CircularButton()
    {
        this.DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        int diametro = Math.Min(this.Width, this.Height);

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

            
            e.Graphics.SetClip(path);

            
            if (this.Image != null)
            {
               
                float scale = Math.Min((float)diametro / this.Image.Width, (float)diametro / this.Image.Height);

                int imageWidth = (int)(this.Image.Width * scale);
                int imageHeight = (int)(this.Image.Height * scale);

                Rectangle rect = new Rectangle(
                    (this.Width - imageWidth) / 2,  
                    (this.Height - imageHeight) / 2, 
                    imageWidth,
                    imageHeight
                );

                
                e.Graphics.DrawImage(
                    this.Image,
                    rect,
                    new Rectangle(0, 0, this.Image.Width, this.Image.Height),
                    GraphicsUnit.Pixel
                );
            }

            e.Graphics.ResetClip();


            this.Region = new Region(path);
        }
    }

}

