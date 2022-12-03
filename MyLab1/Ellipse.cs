using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR2
{
    public class Ellipse : Figure
    {
        public Ellipse(int x, int y, int a, int b) : base(x,y,a,b) { }

        public void show(Graphics gc, Color color)
        {
            Pen pen = new Pen(color, 5);
            gc.DrawEllipse(pen, x , y , a, b);
        }

        public void moveTo(int x, int y)
        {
            this.x += x;
            this.y += y;
        }

        public int[] get()
        {
            int[] sizes = { this.x, this.y, this.a, this.b };
            return sizes;
        }
    }
}
