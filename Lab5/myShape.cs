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
    

        public virtual void Draw(myShape s)
        {

        }



    }
    public class Line : myShape
    {
        Point point1;
        Point point2;
        Brush BrushColor;
        float penwidth;
        Graphics mygraphic;
        public Line(Point in_point1, Point in_point2, Brush in_BrushColor, float in_penwidth, Graphics in_mygraphic)
        {
            point1 = in_point1;
            point2 = in_point2;
            BrushColor = in_BrushColor;
            penwidth = in_penwidth;
            mygraphic = in_mygraphic;
        }
        public override void Draw(myShape s)
        {
            base.Draw(s);
            Pen thispen = new Pen(BrushColor, penwidth);
            mygraphic.DrawLine(thispen, point1, point2);
        }

    }
}
