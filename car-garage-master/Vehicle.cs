using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_garage_master
{
    internal class Vehicle
    {
        public int Speed { get; set; }
        public int TopSpeed { get; set; }

        public virtual void Accelerate()
        {
            Speed++;
        }
       
    }
}
