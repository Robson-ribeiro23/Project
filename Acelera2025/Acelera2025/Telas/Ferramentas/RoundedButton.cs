using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

    public class RoundedButton : Button
    {
    public int BorderSize { get; set; } = 2;
    public Color BorderColor { get; set; } = Color.Black;
    public int BorderRadius { get; set; } = 20;

    public RoundedButton()
    {
        this.DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; //reduz serrilhados

        Arredondar.DrawRoundedControl(e.Graphics, this.ClientRectangle, this.BackColor, BorderColor, BorderSize, BorderRadius);
        this.Region = new Region(Arredondar.GetRoundedPath(this.ClientRectangle, BorderRadius));

        TextRenderer.DrawText(e.Graphics, this.Text, this.Font, this.ClientRectangle, this.ForeColor,
        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);


    }

}

