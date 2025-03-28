using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Acelera2025.Ferramentas
{
public class RoundedPicture : PictureBox
{
    public int BorderRadius { get; set; } = 20;
    public int BorderSize { get; set; } = 2;
    public Color BorderColor { get; set; } = Color.Black;

    public RoundedPicture()
    {
        this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

            using (GraphicsPath path = Arredondar.GetRoundedPath(rect, BorderRadius))
            {
                using (SolidBrush brush = new SolidBrush(this.BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                
                e.Graphics.SetClip(path);
                if (this.Image != null)
                {
                    e.Graphics.DrawImage(
                        this.Image,
                        rect, 
                        new Rectangle(0, 0, this.Image.Width, this.Image.Height), 
                        GraphicsUnit.Pixel
                    );
                }
                e.Graphics.ResetClip();

                if (BorderSize > 0)
                {
                    Arredondar.DrawRoundedControl(
                        e.Graphics,
                        rect,
                        Color.Transparent, 
                        BorderColor,
                        BorderSize,
                        BorderRadius
                    );
                }

             
                this.Region = new Region(path);
            }
        }
    }
}


