using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrawClasses;

namespace Paint
{
    public partial class Paint : Form
    {
        //Bitmap canvas;
        protected List<ShapePoint> shapes;
        public Paint()
        {
            InitializeComponent();
            //canvas = new Bitmap(1920,1080);
        }

        private void ButtonDraw_Click(object sender, EventArgs e)
        {
            //Graphics g = Graphics.FromImage(canvas);
            //g.Clear(Color.White);
            //pictureBoxGraphics.Image = canvas;
            Graphics g = pictureBoxGraphics.CreateGraphics();
            pictureBoxGraphics.Refresh();
            Random random = new Random();
            shapes = null;
            if (shapes == null)
            {
                shapes = new List<ShapePoint>();
            }
            for (int i = 0; i <trackBarAmount.Value; i++)
            {
                int q = random.Next(0, 5);
                switch (q)
                {
                    case 0:
                        shapes.Add(new DrawClasses.Dot(Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)), random.Next(0, pictureBoxGraphics.Width), random.Next(0, pictureBoxGraphics.Width)));
                        shapes[i].Draw(g);
                        break;
                    case 1:
                        shapes.Add(new DrawClasses.Line(Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)), random.Next(0, pictureBoxGraphics.Width), random.Next(0, pictureBoxGraphics.Height), random.Next(0, pictureBoxGraphics.Width), random.Next(0, pictureBoxGraphics.Height)));
                        shapes[i].Draw(g);
                        break;
                    case 2:
                        shapes.Add(new DrawClasses.Rectangle(Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)), random.Next(0, pictureBoxGraphics.Width/2), random.Next(0, pictureBoxGraphics.Height/2), random.Next(0, pictureBoxGraphics.Width / 2), random.Next(0, pictureBoxGraphics.Height / 2)));
                        shapes[i].Draw(g);
                        break;
                    case 3:
                        shapes.Add(new DrawClasses.Circle(Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)), random.Next(0, pictureBoxGraphics.Width/2), random.Next(0,pictureBoxGraphics.Height/2), random.Next(0, pictureBoxGraphics.Height/2)));
                        shapes[i].Draw(g);
                        break;
                    case 4:
                        shapes.Add(new DrawClasses.Ellipse(Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)), random.Next(0, pictureBoxGraphics.Width/2), random.Next(0, pictureBoxGraphics.Height/2), random.Next(0,pictureBoxGraphics.Width/2), random.Next(0, pictureBoxGraphics.Height/2)));
                        shapes[i].Draw(g);
                        break;
                }
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            shapes = null;
            pictureBoxGraphics.Refresh();
        }

        private void ButtonClear1_Click(object sender, EventArgs e)
        {
            int num = (int)numericUpDownNumber.Value;
            if (num >=0 && num < shapes.Count)
            {
                shapes.RemoveAt(num);
            }
            pictureBoxGraphics.Refresh();
        }

        private void PictureBoxGraphics_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            if (shapes !=null)
            {
                for (int count = 0; count < shapes.Count;count++)
                {
                    shapes[count].Draw(graphics);
                }
            }
        }
    }
}
