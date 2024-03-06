using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    public class Toy
    {
        private string name;

        private int id;

        public Toy (string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public override string ToString()
        {
            return $"{name} {id + 1}";
        }

    }
}
