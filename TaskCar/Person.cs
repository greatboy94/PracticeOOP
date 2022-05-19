using CarTask.vehicles;

namespace CarTask;

public class Person
{
    private string fullname;
    private int age;

    public Person()
    {
        
    }

    public Person(string fullname, int age)
    {
        this.fullname = fullname;
        this.age = age;
    }

    public string FullName
    {
        get { return fullname; }
        set { fullname = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public void Move()
    {
        Console.WriteLine("Moving");
    }

    public void Talk()
    {
        Console.WriteLine($"{fullname} Talking");
    }
    public override string ToString()
    {
        return $"Fullname: {fullname} Age: {age}";
    }
}