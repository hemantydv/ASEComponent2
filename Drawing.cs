using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Component2
{

    
    public class Drawing
    {
     
        public Graphics g;
        public commandCheck commandCheck;
        public Pen p;
        public SolidBrush Brush;
        public int xposition;
        public int yposition;
        public bool fill = false;
        public bool error = false;
        public Variable v;
        public methods m;

        
        public Drawing(Graphics g)
        {
            this.g = g;
            v = new Variable();
            m = new methods();
            commandCheck = new commandCheck();
            xposition = yposition = 0;
            p = new Pen(Color.Black, 1);
            Brush = new SolidBrush(Color.Black);
            
        }

       
        public void moveTo(int xpoint , int ypoint)
        {
            xposition = xpoint;
            yposition = ypoint;
        }
       

       
        public void set_penColor(Color c)
        {
            p = new Pen(c, 1);
            Brush = new SolidBrush(c);
        }

      
        public void drawTo(int xposition , int yposition)
        {
            g.DrawLine(p, this.xposition, this.yposition, xposition, yposition);
        }

      
        public void reset()
        {
            xposition = yposition = 0;
            p = new Pen(Color.Black, 1);
            fill = false;
            error = false;
            g.Clear(SystemColors.Control);
        }

       
        public void clear()
        {
            g.Clear(SystemColors.Control);
        }

    }
}
