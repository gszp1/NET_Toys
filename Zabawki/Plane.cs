using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    public class Plane : ISpeed, IHeight
    {

        private string name = "Plane";

        private static int planeCounter = 0;

        private int id;

        private const int MinSpeed = 0;

        private const int MinHeight = 0;

        private int speed;
        
        private int height;

        private int maxSpeed;

        private int maxHeight;

        public Plane(int maxSpeed = 15, int maxHeight = 20)
        {
            this.maxSpeed = maxSpeed;
            this.maxHeight = maxHeight;
            speed = 0;
            height = 0;
            id = planeCounter++;
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

        public override string ToString()
        {
            return string.Concat(name, id);
        }

    }
}
