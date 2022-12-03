using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR2
{
    public class Square : Rectangle
    {
        public PictureBox pictureBox;
        public Square(int x, int y, int a) : base(x,y,a,a) { }
        public void show(Graphics gc, Color color)
        {

            Pen pen = new Pen(color, 5);
            gc.DrawRectangle(pen, x, y, a, a);
        }
        public new void moveTo(int x, int y)
        {
            this.x += x;
            this.y += y;
        }
        public new int[] get()
        {
            int[] sizes = { x, y, a};
            return sizes;
        }
    }
}
