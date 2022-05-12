using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_garage_master
{
    public class Vehicle
    {
        public int Speed { get; set; }
        public int TopSpeed { get; set; }
        public Vehicle(int speed, int topSpeed)
        {
            Speed = speed;
            TopSpeed = topSpeed;
        }

        // This is required if you want to have a vehicle constructor that isn't empty.
        public Vehicle()
        {
            Speed = 0;
            TopSpeed = 100;
        }

        // Virtual used here so that it can be overidden within classes that inherit Vehicle
        public virtual void Accelerate()
        {
            if (Speed < TopSpeed)
            {
                Speed++;
            }
        }

        public virtual void Brake()
        {
            if(Speed > 0)
            {
                Speed--;
            }
        }

        public virtual string Display()
        {
            return "Current Speed: " + Speed; 
        }
    }
}
