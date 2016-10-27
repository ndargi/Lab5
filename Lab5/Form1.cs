using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //This will be for Lab5
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Width = ClientRectangle.Width;
            drawpanel.Location = new System.Drawing.Point(0,23+panel1.Height);
            drawpanel.Width = ClientRectangle.Width;
            drawpanel.Height = ClientRectangle.Height - 23 - panel1.Height;
            
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void drawpanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics mygraphic = e.Graphics;
            Point point1 = new Point(100, 100);
            Point point2 = new Point(300, 300);
            float myfloat = 1;
            myShape firstshape = new Line(point1, point2, Brushes.Blue, myfloat, mygraphic);
            firstshape.Draw(firstshape);
        }
    }
}
