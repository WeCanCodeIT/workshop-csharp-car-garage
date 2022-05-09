using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_garage_master
{
    internal class Car : Vehicle
    {
        //let students pick properties to get them used to creating class. Let them know speed properties are in Vehicle class. In the end, make sure the care has at least the following properties:
        
        //Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int FuelLevel { get; set; }
        
        //Constructors
        public Car(string make, string model, int topSpeed)
        {
            Make = make;
            Model = model;
            Speed = 0;
            TopSpeed = topSpeed;
            FuelLevel = 100;
        }

        public Car(string make, string model)
        {
            Make = make;
            Model = model;
            Speed = 0;
            TopSpeed = 100;
            FuelLevel = 100;
        }

        public Car()
        {

        }


        //Accelerate

        //Brake

        //Turn

        //Add Tick method


    }
}


