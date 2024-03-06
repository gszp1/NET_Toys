using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    public class Car : ISpeed
    {
        private static string name = "Car";

        private static int carCounter = 0;

        private int id;

        private int speed;

        private int maxSpeed;

        private int minSpeed;

        public Car(int maxSpeed = 10, int minSpeed = -10)
        {
            speed = 0;
            this.maxSpeed = maxSpeed;
            this.minSpeed = minSpeed;
            id = carCounter++;
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

        public override string ToString()
        {
            return string.Concat(name, id);
        }
    }
}
