using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    public class Submarine: ISpeed, IDepth
    {
        private static int submarineCount = 0;

        private static string name = "Submarine";

        private int id = 0;

        private const int minDepth = 0;

        private int maxDepth;

        private int minSpeed;

        private int maxSpeed;

        private int speed;

        private int depth;

        public Submarine(int maxDepth = 20, int minSpeed = -10, int maxSpeed = 15)
        {
            this.maxDepth = maxDepth;
            this.minSpeed = minSpeed;
            this.maxSpeed = maxSpeed;
            speed = 0;
            depth = 0;
            id = submarineCount++;
        }

        public void IncreaseSpeed()
        {
            if (speed < maxSpeed)
            {
                ++speed;
            }
        }

        public void DecreaseSpeed()
        {
            if (speed > minSpeed)
            {
                --speed;
            }
        }

        public void IncreaseDepth()
        {
            if (depth < maxDepth)
            {
                ++depth;
            }
        }

        public void DecreaseDepth()
        {
            if (depth > minDepth)
            {
                --depth;
            }
        }

        public override string ToString()
        {
            return string.Concat(name, id);
        }
    } 
}
