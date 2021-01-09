using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component2
{

   public class Variable
    {
        Dictionary<string, int> variable = new Dictionary<string, int>();
        
      
        public void storeData(String name , int value)
        {
            variable.Add(name, value);
        }

        
        public int pullData(String name)
        {
            int x;
            variable.TryGetValue(name, out x);
            return x;
        }


     
        public bool exisitingVariable(String name)
        {
            int x;
            return variable.TryGetValue(name, out x);
        }


      
        public void UpdateVariable(String name , int value)
        {
            variable[name] = value;
        }

       
        public void reset()
        {
            variable.Clear();
        }

    }
}
