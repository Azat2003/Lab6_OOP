using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR2
{
    public abstract class Figure
    {
        public Figure(int x, int y, int a, int b)
        {
            this.x = x; this.y = y;
            this.a = a; this.b = b;
        }
        public int x { get; set; }
        public int y { get; set; }
        public int a { get; set; }
        public int b { get; set; }
    }
}
