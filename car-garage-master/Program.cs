using car_garage_master;

Car car = new Car();

Vehicle vehicle = new Vehicle();

Bicycle bike = new Bicycle();

bike.BikeType = Bicycle.bikeType.road;

if(bike.BikeType == 0)
{
    Console.WriteLine("blah");
}