using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Lab5
{
    public partial class Form1 : Form
        
    {
        private List<myShape> shapes = new List<myShape>();
        private bool firstclick = true;
        private Point savedpoint = new Point();
        public Graphics myGraphic;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //This will be for Lab5
            PencolorlistBox.SelectedIndex = 0;
            PenWidthListBox.SelectedIndex = 0;
            FillcolorListbox.SelectedIndex = 0;
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
            shapes.Clear();
            drawpanel.Invalidate();
        }

        private void drawpanel_Paint(object sender, PaintEventArgs e)
        {
            myGraphic = e.Graphics;

            foreach(myShape s in shapes)
            {
                s.Draw(myGraphic); 
            }
            //Below is how to draw a line commented out because some of the variables have been removed
            //myShape firstshape = new Line(point1, point2, Brushes.Blue, myfloat, mygraphic);
            //firstshape.Draw(firstshape);
        }

        private void drawpanel_MouseClick(object sender, MouseEventArgs e)
        {
            
            Point mypoint = new Point(e.X, e.Y);
            string pencolor;
            string fillcolor;
            int penwidth;
            bool fill = false;
            string penwidth_ = PenWidthListBox.SelectedItem.ToString();
            Int32.TryParse(penwidth_, out penwidth);
            pencolor = PencolorlistBox.SelectedItem.ToString();
            fillcolor = FillcolorListbox.SelectedItem.ToString();
            Color mycolor = Color.FromName(pencolor);
            SolidBrush mybrush = new SolidBrush(mycolor);
            mycolor = Color.FromName(fillcolor);
            SolidBrush myfillbrush = new SolidBrush(mycolor);
            string mystring = textBox.Text;
            if (firstclick)
            {
                //Save the first point to create the object later
                savedpoint = mypoint;
                firstclick = false;
            }
            else
            {
                //Do this if rectangle should be drawn
                if(RectangleradioButton.Checked)
                {
                    firstclick = true;
                    if (OutlinecheckBox.Checked)
                    {
                        if (Fillcheckbox.Checked)
                        {
                            fill = true;
                        }
                        myShape rectangleshape = new Rectangle(savedpoint, mypoint, mybrush, fill, myfillbrush, penwidth);
                        shapes.Add(rectangleshape);
                        
                    }       
                }
                //Do this if line should be drawn
                else if(Lineradiobutton.Checked)
                {
                                       
                    myShape lineshape = new Line(savedpoint, mypoint, mybrush, penwidth);
                    shapes.Add(lineshape);
                    firstclick = true;
                }
                //Do this if Ellipse should be drawn
                else if(EllipseradioButton.Checked)
                {
                    firstclick = true;
                    if (OutlinecheckBox.Checked)
                    {
                        if (Fillcheckbox.Checked)
                        {
                            fill = true;
                        }
                        myShape ellipseshape = new Ellipse(savedpoint, mypoint, mybrush, fill, myfillbrush, penwidth);
                        shapes.Add(ellipseshape);

                    }
                }
                //Do this if text should be drawn
                else if(TextradioButton.Checked)
                {
                    firstclick = true;
                    myShape textshape = new Text(savedpoint, mypoint, mybrush, mystring);
                    shapes.Add(textshape);

                }
            }
            drawpanel.Invalidate();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shapes.RemoveAt(shapes.Count - 1);
            drawpanel.Invalidate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}