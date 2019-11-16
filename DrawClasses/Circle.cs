using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawClasses
{
    public class Circle : Dot
    {
        protected int rad;
        public Circle(Color color, int x1, int y1, int rad) : base(color, x1, y1)
        {
            this.rad = rad;
        }
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(color, 2);
            g.DrawEllipse(pen, x1 - 1, y1 - 1, rad, rad);
        }
    }
}
