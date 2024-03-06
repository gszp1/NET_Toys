using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    public class Computer
    {
        private static string name = "Computer";
        
        private static int computerCounter = 0;

        private int id;

        public Computer() 
        {
            id = computerCounter++;
        }

        public override string ToString()
        {
            return string.Concat(name, id);
        }

    }
}
