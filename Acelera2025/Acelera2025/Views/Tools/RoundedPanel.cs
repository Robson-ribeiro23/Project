using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedPanel : Panel
{
    public int BorderRadius { get; set; } = 20;
    public Color BorderColor { get; set; } = Color.Black;

    public int BorderSize { get; set; } = 2;

    public RoundedPanel()
    {
        this.DoubleBuffered = true; //Reduz Flickering
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; //reduz serrilhados

        Arredondar.DrawRoundedControl(e.Graphics, this.ClientRectangle, this.BackColor, BorderColor, BorderSize, BorderRadius);
        this.Region = new Region(Arredondar.GetRoundedPath(this.ClientRectangle, BorderRadius));
    }
}

    

