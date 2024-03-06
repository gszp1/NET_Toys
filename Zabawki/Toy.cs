using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    public class Toy
    {
        string name;

        int id;

        public override string ToString()
        {
            return $"{name}{id + 1}";
        }
    }
}
