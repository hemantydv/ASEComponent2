using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Component2
{
    
    class DrawRectangle : Shape
    {
        public int width;
        public int height;

       
        public DrawRectangle(int width , int height) : base(width, height)
        {
            this.width = width;
            this.height = height;
        }

       
        public override void draw(Drawing newDrawing)
        {
            newDrawing.g.DrawRectangle(newDrawing.p, newDrawing.xposition, newDrawing.yposition, width, height);

            if (newDrawing.fill)
            {
                newDrawing.g.FillRectangle(newDrawing.Brush, newDrawing.xposition,newDrawing.yposition,width,height);
            }
        }
    }
}
