namespace CarTask.details;

public class Engine
{
    private string power;
    private string producer;
    
    public Engine(string power, string producer)
    {
        this.power = power;
        this.producer = producer;
    }

    public string Power
    {
        get { return power; }
        set { power = value; }
    }
    public string Producer
    {
        get { return producer; }
        set { producer = value; }
    }

    public override string ToString()
    {
        return $"Power: {power} Producer: {producer}";
    }
}