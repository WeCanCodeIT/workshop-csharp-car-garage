using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_garage_master
{
    public class Garage
    {
        public int Capacity;
        public List<Vehicle> Vehicles { get; set; }
        public Garage(int capacity)
        {
            Capacity = capacity;
            Vehicles = new List<Vehicle>();
        }

        public Garage(List<Vehicle> vehicles)
        {
            Capacity = vehicles.Count;
            Vehicles = vehicles;
        }
    }
}
