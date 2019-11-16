using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawClasses
{
    public class Dot : ShapePoint
    {
        Random random = new Random();
        public Dot(Color color, int x, int y) : base(color, x, y)
        {

        }
        public override void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(color);
            g.FillEllipse(brush, x1, y1, 5,5);
        }
    }
}
