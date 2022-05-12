using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_garage_master
{
    public class Car : Vehicle
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
            FuelLevel = 100;
            Speed = 0;
            TopSpeed = topSpeed;
        }

        public Car(string make, string model)
        {
            Make = make;
            Model = model;
            FuelLevel = 100;
            Speed = 0;
            TopSpeed = 100;
        }

        public Car()
        {
            Make = "Chrysler";
            Model = "PT Cruiser";
            FuelLevel= 100;
            Speed = 0;
            TopSpeed = 100;
        }

        //Accelerate
        public override void Accelerate()
        {
            if (Speed <= TopSpeed - 5)
            {
                Speed += 5;
            }
        }
        //Brake
        public override void Brake()
        {
            if (Speed >= 5)
            {
                Speed -= 5;
            }
        }

        public override string Display()
        {
            return "Make: " + Make + " Model: " + Model + " Current Speed: " + Speed + " Fuel: " + FuelLevel;
        }

        //Add Tick method
        public void Tick()
        {
            if(FuelLevel - (Speed / 10) > 0)
            {
               FuelLevel -= Speed / 10;
            } 
        }
        public void Refuel()
        {
            FuelLevel = 100;
        }
    }
}


