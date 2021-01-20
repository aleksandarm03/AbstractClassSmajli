using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AbstractClassSmajli2
{
    class Smajli3 : Smajli
    {
        public Smajli3(int x, int y)
            : base(x, y)
        {
        }
        public override void Crtaj(Graphics g)
        {
            Pen olovka = new Pen(Color.Black, 15);
            SolidBrush cetka1 = new SolidBrush(Color.Black);
            SolidBrush cetka2 = new SolidBrush(Color.Yellow);
            g.FillEllipse(cetka2, x - a / 2, y - a / 2, a, a);
            g.FillRectangle(cetka1, x - a / 4, y - 3 * a / 16, a / 2, a / 16);
            g.FillRectangle(cetka1, x - 3 * a / 8, y - a / 4, 5 * a / 16, a / 4);
            g.FillRectangle(cetka1, x + a / 16, y - a / 4, 5 * a / 16, a / 4);
            g.DrawArc(olovka, x - 3 * a / 10, y - 3 * a / 10, 120, 120, 30, 120);
        }
    }
}
