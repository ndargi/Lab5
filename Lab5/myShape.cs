using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.ComponentModel;

namespace Lab5
{
    public class myShape
    {
        
        public myShape()
        {
        }
    

        public virtual void Draw(Graphics g)
        {

        }



    }
    public class Line : myShape
    {
        Point point1;
        Point point2;
        SolidBrush BrushColor;
        int penwidth;
        public Line(Point in_point1, Point in_point2, SolidBrush in_BrushColor, Int32 in_penwidth)
        {
            point1 = in_point1;
            point2 = in_point2;
            BrushColor = in_BrushColor;
            penwidth = in_penwidth;
            
        }
        public override void Draw(Graphics g)
        {
            base.Draw(g);
            Pen thispen = new Pen(BrushColor, penwidth);
            g.DrawLine(thispen, point1, point2);
        }

    }
    public class Rectangle : myShape
    {
        Point point1;
        Point point2;
        SolidBrush BrushColor;
        bool fill;
        SolidBrush FillColor;
        int penwidth;
        public Rectangle(Point in_point1,Point in_point2,SolidBrush in_BrushColor,bool in_fill,SolidBrush in_FillColor, int in_penwidth)
        {
            point1 = in_point1;
            point2 = in_point2;
            BrushColor = in_BrushColor;
            fill = in_fill;
            FillColor = in_FillColor;
            penwidth = in_penwidth;
        }
        public override void Draw(Graphics g)
        {
            base.Draw(g);
            Pen thispen = new Pen(BrushColor, penwidth);
            Point placeholder = point1;
            if (point1.X > point2.X)
            {
                point1.X = point2.X;
                point2.X = placeholder.X;
            }
            if (point1.Y > point2.Y)
            {
                point1.Y = point2.Y;
                point2.Y = placeholder.Y;
            }
           
                if (fill)
                {
                    g.FillRectangle(FillColor, point1.X, point1.Y, point2.X - point1.X, point2.Y - point1.Y);
                }
                g.DrawRectangle(thispen, point1.X, point1.Y, point2.X - point1.X, point2.Y - point1.Y);
           
        }
    }
    public class Ellipse : myShape
    {
        Point point1;
        Point point2;
        SolidBrush BrushColor;
        bool fill;
        SolidBrush FillColor;
        int penwidth;
        public Ellipse(Point in_point1, Point in_point2, SolidBrush in_BrushColor, bool in_fill, SolidBrush in_FillColor, int in_penwidth)
        {
            point1 = in_point1;
            point2 = in_point2;
            BrushColor = in_BrushColor;
            fill = in_fill;
            FillColor = in_FillColor;
            penwidth = in_penwidth;
        }
        public override void Draw(Graphics g)
        {
            base.Draw(g);
            Pen thispen = new Pen(BrushColor, penwidth);
            Point placeholder = point1;
            if (point1.X > point2.X)
            {
                point1.X = point2.X;
                point2.X = placeholder.X;
            }
            if (point1.Y > point2.Y)
            {
                point1.Y = point2.Y;
                point2.Y = placeholder.Y;
            }

            if (fill)
            {
                g.FillEllipse(FillColor, point1.X, point1.Y, point2.X - point1.X, point2.Y - point1.Y);
            }
            g.DrawEllipse(thispen, point1.X, point1.Y, point2.X - point1.X, point2.Y - point1.Y);
        }
        
    }
    public class Text : myShape
    {
        Point point1;
        Point point2;
        SolidBrush BrushColor;
        string mystring;
        public Text(Point in_point1, Point in_point2, SolidBrush in_BrushColor,string in_mystring)
        {
            point1 = in_point1;
            point2 = in_point2;
            BrushColor = in_BrushColor;
            mystring = in_mystring;
        }
        public override void Draw(Graphics g)
        {
            base.Draw(g);
            Point placeholder = point1;
            if (point1.X > point2.X)
            {
                point1.X = point2.X;
                point2.X = placeholder.X;
            }
            if (point1.Y > point2.Y)
            {
                point1.Y = point2.Y;
                point2.Y = placeholder.Y;
            }
            SizeF mysize = new SizeF(point2.X - point1.X, point2.Y - point1.Y);
            RectangleF myrect = new RectangleF(point1, mysize);
            Font myfont = new Font("Times New Roman", 10);
            g.DrawString(mystring, myfont, BrushColor, myrect);
        }
    }
}
