// See https://aka.ms/new-console-template for more information

using CarTask;
using CarTask.details;
using CarTask.professions;
using CarTask.vehicles;

class Program
{
    public static void Main(string[] args)
    {
        
        Driver driver1 = new Driver("Tom", 5);
        Engine engine1 = new Engine("350HP", "BMW");
        Car car1 = new Car("BMW", "M", 1200, driver1, engine1);

        Driver vanDriver = new Driver("Alex", 7);
        Engine engine2 = new Engine("520HP", "Volvo");
        Lorry lorry = new Lorry("Volvo", "H", 2300, vanDriver, engine2, 50);
        
        Driver sportCarDriver = new Driver("Hamelton", 10);
        Engine sportCarEngine = new Engine("450HP", "Ford");
        SportCar sportCar = new SportCar("Ford", "F", 1400, sportCarDriver, sportCarEngine, 400);

        Console.WriteLine(car1);
        Console.WriteLine(lorry);
        Console.WriteLine(sportCar);
        
        //Done
    }
}