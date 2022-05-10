// .NET 6 requires a using statement within program.cs
using car_garage_master;

string input = "";
int num = 0;
bool validResult = false;
while (!validResult)
{
    Console.Clear();
    Console.WriteLine("How many vehicles would you like to hold in your garage? 1-9");
    input = Console.ReadLine();
    validResult = int.TryParse(input, out num) && num > 0;
}
Garage garage = new Garage(num);

validResult = false;
while (!validResult)
{
    Console.Clear();
    Console.WriteLine("What type of vehicle would you like to add to your garage? 1. Car 2. Bicycle");
    input = Console.ReadLine();
    validResult = int.TryParse(input, out num) && (num == 1 || num == 2);
}
switch (num)
{
    case 1:
        Console.Clear();
        Console.WriteLine("What is your vehicle's make?");
        string make = Console.ReadLine();
        Console.WriteLine("What is your vehicle's model?");
        string model = Console.ReadLine();
        Car car = new Car(make, model);
        garage.Vehicles.Add(car);
        break;
    case 2:
        Console.Clear();
        Console.WriteLine("What is your bicycle's brand?");
        string brand = Console.ReadLine();
        Bicycle bike = new Bicycle(brand);
        garage.Vehicles.Add(bike);
        break;
    default:
        Console.WriteLine("Invalid vehicle type.");
        return;
        break;
}
Vehicle currentVehicle = garage.Vehicles[0];

bool playing = true;
while (playing)
{
    Console.Clear();
    Console.WriteLine("What would you like to do?");
    Console.WriteLine(currentVehicle.Display());
    Console.WriteLine("1. Accelerate");
    Console.WriteLine("2. Brake");
    Console.WriteLine("3. Add Vehicle"); // Time dependent
    Console.WriteLine("4. Swap Vehicles"); // Time dependent
    Console.WriteLine("5. Quit");
    if (currentVehicle.GetType() == typeof(Car))
    {
        Console.WriteLine("6. Refuel");
    }

    input = Console.ReadLine();
    if(int.TryParse(input, out num) && num == 1)
    {
        currentVehicle.Accelerate();
    }
    else if(int.TryParse(input, out num) && num == 2)
    {
        currentVehicle.Brake();
    }
    else if (int.TryParse(input, out num) && num == 3)
    {
        if(garage.Vehicles.Count != garage.Capacity)
        {
            validResult = false;
            while (!validResult)
            {
                Console.Clear();
                Console.WriteLine("What type of vehicle would you like to add to your garage? 1. Car 2. Bicycle");
                input = Console.ReadLine();
                validResult = int.TryParse(input, out num) && (num == 1 || num == 2);
            }
            switch (num)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("What is your vehicle's make?");
                    string make = Console.ReadLine();
                    Console.WriteLine("What is your vehicle's model?");
                    string model = Console.ReadLine();
                    Car car = new Car(make, model);
                    garage.Vehicles.Add(car);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("What is your bicycle's brand?");
                    string brand = Console.ReadLine();
                    Bicycle bike = new Bicycle(brand);
                    garage.Vehicles.Add(bike);
                    break;
                default:
                    Console.WriteLine("Invalid vehicle type.");
                    break;
            }
            currentVehicle = garage.Vehicles[garage.Vehicles.Count - 1];
        } else
        {
            Console.Clear();
            Console.WriteLine("Garage is full!");
            Console.Read();
        }
        
    }
    else if (int.TryParse(input, out num) && num == 4)
    {
        validResult = false;
        while (!validResult)
        {
            Console.Clear();
            Console.WriteLine("What vehicle would you like to switch to?");
            input = Console.ReadLine();
            validResult = int.TryParse(input, out num) && (num < garage.Capacity);
        }
        currentVehicle = garage.Vehicles[num];
        Console.WriteLine("Swapped to vehicle " + num);
        Console.Read();
    }
    else if (int.TryParse(input, out num) && num == 5)
    {
        playing = false;
    }
    else if (int.TryParse(input, out num) && num == 6)
    {
        Car car = (Car)currentVehicle;
        car.Refuel();
    }

    if (currentVehicle.GetType() == typeof(Car))
    {
        Car car = (Car)currentVehicle;
        car.Tick();
    }
}