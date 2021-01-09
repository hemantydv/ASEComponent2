using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component2
{
   
    public abstract class Shape
    {

        int width;
        int height;


       
        public Shape(int width , int height)
        {
            this.width = width;
            this.height = height;
        }

        public abstract void draw(Drawing newDrawing);

    }
}
