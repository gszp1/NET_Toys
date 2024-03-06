using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    public class Car : Toy, ISpeed
    {

        private static int carCounter = 0;

        private int speed;

        private int maxSpeed;

        private int minSpeed;

        public Car(int maxSpeed = 10, int minSpeed = -10) : base("Car", carCounter++)
        {
            this.maxSpeed = maxSpeed;
            this.minSpeed = minSpeed;
            speed = 0;
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
    }
}
