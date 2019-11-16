using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawClasses
{
    public abstract class ShapePoint
    {
        protected Color color;
        protected int x1;
        protected int y1;
        public ShapePoint(Color color, int x, int y)
        {
            this.color = color;
            x1 = x;
            y1 = y;
        }
        public abstract void Draw(Graphics g);
    }
}
