using CarTask.vehicles;
using CarTask.details;
using CarTask.professions;

namespace CarTask;

public class SportCar: Car
{
    private int speed;
    
    public SportCar(string carBrand, string classCar, int carWeight, Driver driver, Engine engine, int speed) : base(carBrand, classCar, carWeight, driver, engine)
    {
        this.speed = speed;
    }
    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public override string ToString()
    {
        return "Speed" + speed + " " + base.ToString();
    }
}