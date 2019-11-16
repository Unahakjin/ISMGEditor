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

namespace GEditor
{
    public partial class Form1 : Form
    {
        protected List<ShapePoint> shapes;
        public Mode Mode;
        protected int MouseX, MouseY;
        public void AddShape(ShapePoint shape)
        {
            shapes.Add(shape);
            listBoxShapes.Items.Add(shape);
            pictureBox1.Refresh();
        }
        public void DeleteShape(int number)
        {
            shapes.RemoveAt(listBoxShapes.SelectedIndex);
            listBoxShapes.Items.RemoveAt(listBoxShapes.SelectedIndex);
            pictureBox1.Refresh();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                buttonColor.BackColor = colorDialog.Color;
        }
     

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonColor.BackColor = Color.Black;
            shapes = new List<ShapePoint>();
        }

        private void ButtonTest_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            AddShape(new DrawClasses.Dot(Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)), random.Next(0, pictureBox1.Width), random.Next(0, pictureBox1.Height)));

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listBoxShapes.Items.Count;i++)
            {
                if (listBoxShapes.GetSelected(i))
                {
                    DeleteShape(i);
                    i--;
                }
            }
            if (listBoxShapes.Items.Count > 0)
                listBoxShapes.SetSelected(0, true);
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            for (int i =0; i < shapes.Count;i++)
            {
                shapes[i].Draw(e.Graphics);
            }
        }

        private void ButtonDrawDot_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawDot;
        }

        private void ButtonDrawLine_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawLine;
        }

        private void ButtonDrawCircle_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawCircle;
        }

        private void PictureBox1_Move(object sender, EventArgs e)
        {

        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (Mode)
            {
                case Mode.DrawLine:
                    ShapePoint line = new Line(Color.FromArgb(buttonColor.BackColor.R, buttonColor.BackColor.G, buttonColor.BackColor.B),MouseX, MouseY, e.X, e.Y);
                    AddShape(line);
                    break;
                case Mode.DrawCircle:
                    ShapePoint circle = new Circle(Color.FromArgb(buttonColor.BackColor.R, buttonColor.BackColor.G, buttonColor.BackColor.B), MouseX, MouseY,(e.X-MouseX));
                    AddShape(circle);
                    break;

            }
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            switch (Mode)
            {
                case Mode.DrawLine:
                    if(e.Button == MouseButtons.Left)
                    {
                        pictureBox1.Refresh();
                        ShapePoint shape = new Line(Color.FromArgb(buttonColor.BackColor.R, buttonColor.BackColor.G, buttonColor.BackColor.B), MouseX, MouseY, e.X, e.Y);
                        shape.Draw(g);
                    }
                    break;
                case Mode.DrawCircle:
                    if (e.Button == MouseButtons.Left)
                    {
                        pictureBox1.Refresh();
                        ShapePoint shape = new Circle(Color.FromArgb(buttonColor.BackColor.R, buttonColor.BackColor.G, buttonColor.BackColor.B), MouseX, MouseY, (e.X-MouseX));
                        shape.Draw(g);
                    }
                    break;
            }
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            switch (Mode)
            {
                case Mode.DrawDot:
                   ShapePoint dot = new DrawClasses.Dot(Color.FromArgb(buttonColor.BackColor.R, buttonColor.BackColor.G, buttonColor.BackColor.B),e.X, e.Y);
                    dot.Draw(g);
                    AddShape(dot);
                    break;
                case Mode.DrawLine:
                   MouseX = e.X;
                   MouseY = e.Y;
                    break;
                case Mode.DrawCircle:
                    MouseX = e.X;
                    MouseY = e.Y;
                    break;
            }
        }
    }
}
