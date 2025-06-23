using System.Drawing;
using System.Drawing.Drawing2D;

public static class Arredondar
{
    public static GraphicsPath GetRoundedPath(Rectangle rect, int borderRadius)
    {
        GraphicsPath path = new GraphicsPath();
        int arcSize = borderRadius * 2;

        path.StartFigure();
        path.AddArc(new Rectangle(rect.X, rect.Y, arcSize, arcSize), 180, 90);
        path.AddArc(new Rectangle(rect.Right - arcSize, rect.Y, arcSize, arcSize), 270, 90);
        path.AddArc(new Rectangle(rect.Right - arcSize, rect.Bottom - arcSize, arcSize, arcSize), 0, 90);
        path.AddArc(new Rectangle(rect.X, rect.Bottom - arcSize, arcSize, arcSize), 90, 90);
        path.CloseFigure();

        return path;
    }

    public static void DrawRoundedControl(Graphics graphics, Rectangle rect, Color backColor, Color borderColor, int borderSize, int borderRadius)
    {
        using (GraphicsPath path = GetRoundedPath(rect, borderRadius))
        {
            using (SolidBrush brush = new SolidBrush(backColor))
            {
                graphics.FillPath(brush, path);
            }

            if (borderSize > 0)
            {
                using (Pen pen = new Pen(borderColor, borderSize))
                {
                    graphics.DrawPath(pen, path);
                }
            }
        }
    }
}
