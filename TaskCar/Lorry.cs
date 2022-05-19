using CarTask.details;
using CarTask.vehicles;
using CarTask.professions;
using CarTask.vehicles;


namespace CarTask;

public class Lorry: Car
{
    private int handle;
    
    public Lorry(string carBrand, string classCar, int carWeight, Driver driver, Engine engine, int handle) : base(carBrand, classCar, carWeight, driver, engine)
    {
        this.handle = handle;
    }
    public int Handle
    {
        get { return handle; }
        set { handle = value; }
    }

    public override string ToString()
    {
        return "Handle: " + handle + " " + base.ToString();
    }
}