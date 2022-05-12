using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_garage_master
{
    public class Bicycle : Vehicle
    {
        public string Brand { get; set; }
        public bool TrainingWheels { get; set; }
        public BikeType BikeType { get; set; }

        public Bicycle(string brand, bool trainingWheels, BikeType bikeType)
        {
            Brand = brand;
            TrainingWheels = trainingWheels;
            BikeType = bikeType;
            Speed = 0;
            TopSpeed = 30; // perhaps make this based on bike type?
        }

        public Bicycle(string brand)
        {
            Brand = brand;
            TrainingWheels = false;
            BikeType = BikeType.Road;
            Speed = 0;
            TopSpeed = 30; // perhaps make this based on bike type?
        }
        public override string Display()
        {
            return "Brand: " + Brand + " Current Speed: " + Speed;
        }
    }

    // enumerables are special lists / categories you can define for properties. Each is equivalent to a numeric value
    public enum BikeType
    {
        Road,
        Mountain,
        Hybrid,
        Electric,
        BMX
    }
}
