using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Component2
{
    
    class DrawPolygon : Shape
    {
        PointF[] points;

        
        public DrawPolygon(int [] point) : base(point[0], point[1])
        {
            int i = 0;
            PointF[] p = new PointF[point.Length];
            while(point.Length > i)
            {
                if((i + 1) == point.Length)
                {
                    p[i] = new PointF(point[i], point[0]);
                }
                else
                {
                    p[i] = new PointF(point[i], point[i + 1]);
                }

                i++;
            }
            points = p;
        }
       
        public override void draw(Drawing newDrawing)
        {
            newDrawing.g.DrawPolygon(newDrawing.p, points);

            if (newDrawing.fill)
            {
                newDrawing.g.FillPolygon(newDrawing.Brush, points);
            }
        }
    }
}
