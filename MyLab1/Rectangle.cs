using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR2
{
    public class Rectangle : Figure
    {
        public Rectangle(int x, int y, int a, int b) : base(x, y, a ,b){}
        public void Show(Graphics gc, Color color)
        {
            Pen pen = new Pen(color, 3);
            gc.DrawRectangle(pen, x, y, a, b);
        }
        public void moveTo(int x, int y)
        {
            this.x += x;
            this.y += y;
        }
        public void changeRectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int[] get()
        {
            int[] sizes = { x, y, a, b};
            return sizes;
        }
    }
}
