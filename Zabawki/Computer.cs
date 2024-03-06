using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    public class Computer : Toy
    {

        private static int computerCounter = 0;

        public Computer() : base("Computer", computerCounter++) {}
    }
}
