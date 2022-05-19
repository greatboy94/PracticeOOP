using CarTask.professions;
using CarTask.details;

namespace CarTask.vehicles;

public class Car
{
    private string carBrand;
    private string classCar;
    private int carWeight;
    private Driver driver;
    private Engine engine;
    
    public Car(string carBrand, string classCar, int carWeight, Driver driver, Engine engine)
    {
        this.carBrand = carBrand;
        this.classCar = classCar;
        this.carWeight = carWeight;
        this.driver = driver;
        this.engine = engine;
    }
    public string CarBrand
    {
        get { return carBrand; }
        set { carBrand = value; }
    }
    public string ClassCar
    {
        get { return classCar; }
        set { classCar = value; }
    }
    public int CarWeight
    {
        get { return carWeight; }
        set { carWeight = value; }
    }
    public Driver Driver
    {
        get { return driver; }
        set { driver = value; }
    }
    public Engine Engine
    {
        get { return engine; }
        set { engine = value; }
    }

    public void Start()
    {
        Console.WriteLine("Поехали");
    }

    public void Stop()
    {
        Console.WriteLine("Останавливаемся");
    }
    public void TurnRight()
    {
        Console.WriteLine("Поворот направо");
    }

    public void TurnLeft()
    {
        Console.WriteLine("Поворот налево");
    }

    public override string ToString()
    {
        return $"Brand: {carBrand} | Class: {classCar} | Weight: {carWeight} | Driver: {driver} | Engine->git branch {engine}";
    }
}