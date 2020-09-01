using System;
using System.Windows.Forms;
using System.Drawing;

class Sampla1 : Form
{
    private Image im;
    public static void Main()
    {
        Application.Run(new Sampla1());
    }
    public Sampla1()
    {
        this.Text = "アレ";
        this.Width = 250; this.Height = 200;

        im = Image.FromFile("F:\\car.bmp");

        this.Click += new EventHandler(fm_Clikc);
        this.Paint += new PaintEventHandler(fm_Paint);
    }
    public void fm_Clikc(Object sender, EventArgs e)
    {
        im.RotateFlip(RotateFlipType.Rotate90FlipNone);
        this.Invalidate();
    }
    public void fm_Paint(Object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;

        g.DrawImage(im, 0, 0);
    }

}