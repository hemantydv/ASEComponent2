using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component2
{
   
   public class methods
    {
        Dictionary<string, string> method = new Dictionary<string, string>();

       
        public void storeMethod(String name, string value)
        {
            method.Add(name, value);            
        }

       
        public string getMethod(String name)
        {
            string n;
            method.TryGetValue(name, out n);
            return n;
        }

        public bool existingMethod(String name)
        {
            string n;
            return method.TryGetValue(name , out n);
        }

        public void reset()
        {
            method.Clear();
        }

    }
}
