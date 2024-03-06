using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    public class Submarine: Toy, ISpeed, IDepth
    {
        private static int submarineCount = 0;

        private const int minDepth = 0;

        private int maxDepth;

        private int minSpeed;

        private int maxSpeed;

        private int speed;

        private int depth;

        public Submarine(int maxDepth = 20, int minSpeed = -10, int maxSpeed = 15)
            : base("Submarine", submarineCount++)
        {
            this.maxDepth = maxDepth;
            this.minSpeed = minSpeed;
            this.maxSpeed = maxSpeed;
            speed = 0;
            depth = 0;
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
    } 
}
