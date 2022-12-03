using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR2
{
    public class Ring : Ellipse
    {
        public Ring(int x, int y, int a) : base(x, y, a, a){ }
        public new void show(Graphics gc, Color color)
        {
            Pen pen = new Pen(color, 2);
            gc.DrawEllipse(pen, x, y, a, a);
        }

        public new void moveTo(int x, int y)
        {
            this.x += x;
            this.y += y;
        }

        public new int[] get()
        {
            int[] sizes = {x, y, a};
            return sizes;
        }
        public void changeRing(int a)
        {
            this.a = a;
        }
    }
}
