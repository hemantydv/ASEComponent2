using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component2
{
   
    public class DrawCircle : Shape
    {
        
        public int radius;

       
        public DrawCircle(int r) : base(r, 0)
        {
            this.radius = r;
        }

      
        public override void draw(Drawing newDrawing)
        {
            newDrawing.g.DrawEllipse(newDrawing.p, newDrawing.xposition, newDrawing.yposition, (radius * 2), (radius * 2));

            if (newDrawing.fill)
            {
                newDrawing.g.FillEllipse(newDrawing.Brush, newDrawing.xposition,newDrawing.yposition,(radius * 2), (radius * 2));
            }
        }

    }
}
