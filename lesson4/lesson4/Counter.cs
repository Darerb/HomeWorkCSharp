using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    public class Counter
    {
        public delegate void Counter50();

        public event Counter50 Now50;

        public void Count50()
        { 
            for (int i = 0; i<100; i++)
            {
               if (i == 50)
               {
                    Now50?.Invoke();
               }
            }
        }
    }
}
