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
        private bool firstclick = true; //True if the next click will be the first click, false otherwise
        private Point savedpoint = new Point();//first point that is clicked that needs to be saved
        public Graphics myGraphic;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Sets the Initial Selected Index's for the Lists 
            PencolorlistBox.SelectedIndex = 0;
            PenWidthListBox.SelectedIndex = 0;
            FillcolorListbox.SelectedIndex = 0;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Changes the Size of the panel if the window is resized, designed to work the same way as the example
            panel1.Width = ClientRectangle.Width;
            drawpanel.Location = new System.Drawing.Point(0,23+panel1.Height);
            drawpanel.Width = ClientRectangle.Width;
            drawpanel.Height = ClientRectangle.Height - 23 - panel1.Height;
            
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e) //Method to clear all of the objects
        {
            shapes.Clear();
            drawpanel.Invalidate();
            firstclick = true;
        }

        private void drawpanel_Paint(object sender, PaintEventArgs e)//Paint Method for the drawing panel, contains the foreach loop as is specified in the assignment
        {
            myGraphic = e.Graphics;

            foreach(myShape s in shapes)
            {
                s.Draw(myGraphic); 
            }
        }

        private void drawpanel_MouseClick(object sender, MouseEventArgs e)//The click method for the drawing panel
        {
            //Starts by getting all the user entered parameters
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
            else//Sees what object to create, then creates the object and saves it to the List
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

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)//Undo the last Shape, does not error is there are no shapes drawn
        {
            if (shapes.Count > 0)
            {
                shapes.RemoveAt(shapes.Count - 1);
            }
            drawpanel.Invalidate();
            firstclick = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)//Closes out the Program
        {
            this.Close();
        }
    }
}