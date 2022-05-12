using NUnit.Framework;
using car_garage_master;
using System.Collections.Generic;

namespace car_garage_tests
{
    public class Tests
    {
        private Vehicle vehicle;
        private Car car;
        private Bicycle bike;
        private Garage garage;

        [SetUp]
        public void Setup()
        {
            vehicle = new Vehicle(0, 100);
            car = new Car("Chrysler", "PT Cruiser");
            bike = new Bicycle("Ozone");
            garage = new Garage(new List<Vehicle>(){vehicle, car, bike });
        }

        [Test]
        public void Car_Accelerate_Should_Increase_Speed_By_5()
        {
            car.Accelerate();
            Assert.AreEqual(car.Speed, 5);
        }

        [Test]
        public void Bike_Accelerate_Should_Increase_Speed_By_1()
        {
            bike.Accelerate();
            Assert.AreEqual(bike.Speed, 1);
        }

        [Test]
        public void Garage_Capacity_Should_Be_Length_Of_List_From_Constructor()
        {
            Assert.AreEqual(garage.Capacity, 3);
        }

        [Test]
        public void Bike_Speed_Should_Not_Go_Below_0()
        {
            bike.Brake();
            bike.Brake();
            bike.Brake();
            Assert.AreEqual(car.Speed, 0);
        }

        [Test]
        public void Car_Display_Should_Return_Helpful_Message()
        {
            Assert.AreEqual(car.Display(), "Make: Chrysler Model: PT Cruiser Current Speed: 0 Fuel: 100");
        }
    }
}