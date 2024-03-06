using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    public interface IDepth
    {
        void IncreaseDepth();

        void DecreaseDepth();

        int Depth {  get; }

    }
}
