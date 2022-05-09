using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_garage_master
{
    internal class Bicycle : Vehicle
    {
        public string Brand { get; set; }
        public bool TrainingWheels { get; set; }
        public enum bikeType
        {
            road,
            mountain,
            hybrid,
            electric,
            bmx
        }
        public bikeType BikeType { get; set; }
    }
}
