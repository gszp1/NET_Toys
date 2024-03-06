using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    public class Plane : Toy, ISpeed, IHeight
    {
        private static int planeCounter = 0;

        private const int MinSpeed = 0;

        private const int MinHeight = 0;

        private int speed;
        
        private int height;

        private int maxSpeed;

        private int maxHeight;

        public int Speed
        {
            get { return speed; }
        }

        public int Height
        {
            get { return height; }
        }


        public Plane(int maxSpeed = 15, int maxHeight = 20) : base("Plane", planeCounter++)
        {
            this.maxSpeed = maxSpeed;
            this.maxHeight = maxHeight;
            speed = 0;
            height = 0;
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
            if (speed > MinSpeed)
            {
                --speed;
            }
        }

        public void IncreaseHeight()
        {
            if (height < maxHeight)
            {
                ++height;
            }
        }

        public void DecreaseHeight()
        {
            if (height > MinHeight)
            {
                --height;
            }
        }
    }
}
