﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawClasses
{
    public class Line : Dot
    {
        protected int x2;
        protected int y2;
        public Line(Color color, int x1, int y1, int x2, int y2) : base(color, x1, y1)
        {
            this.x2 = x2;
            this.y2 = y2;
        }
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(color, 2);
            g.DrawLine(pen, x1, y1, x2, y2);
        }
    }
}
