using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Component2
{
   
    public class commandCheck
    {
        
      
        public void Commands_Check(Drawing newDrawing,int n, int x)
        {
          

            Font Font = new Font("Arial", 10);
            SolidBrush brush = new SolidBrush(Color.Red);
            n++;

            if(n != 0)
            {
                if(x == 0)
                {
                    newDrawing.reset();
                }
                newDrawing.g.DrawString("Command on line " + (n) + " doesn't exists", Font, brush, 0, 0 + x);

            }
            else
            {
                newDrawing.g.DrawString("Command doesn't exist ", Font, brush, 0, 0 + x);
            }
            newDrawing.error = true;
        }
      
        public void Parameterscheck(bool parameter, String data, int n, Drawing newDrawing, int x)
        {


            if (!parameter)
            {
                Font Font = new Font("Arial", 10);
                SolidBrush brush = new SolidBrush(Color.Red);
                if (x == 0)
                {
                    newDrawing.reset();
                }
                if ((n + 1) == 0)
                {
                    newDrawing.g.DrawString("Invalid Parameters " + data, Font, brush, 0, 0 + x);
                }
                else
                {
                    newDrawing.g.DrawString("Parameter Invalid ", Font, brush, 0, 0 + x);
                }
                newDrawing.error = true;
            }
        }
        
        public void Parameterscheck(Exception e, Drawing newDrawing , int n , int x)
        {
            Font Font = new Font("TimesNewRoman", 10);
            SolidBrush brush = new SolidBrush(Color.Red);
            if (x == 0)
            {
                newDrawing.reset();
            }
            if((n+1) == 0)
            {
                newDrawing.g.DrawString("Wrong number of Parameters ", Font, brush, 0, 0 + x);
            }
            else
            {
                newDrawing.g.DrawString("Wrong number of Parameters inserted "+ (n+1), Font, brush, 0, 0 + x);
            }

            newDrawing.error = true;
        }
    }


    
}
