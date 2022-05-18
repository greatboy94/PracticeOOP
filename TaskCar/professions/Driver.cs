namespace CarTask.professions;

public class Driver
{
    private string fullname;
    private int experience;
    
    public Driver(string fullname, int experience)
    {
        this.fullname = fullname;
        this.experience = experience;
    }

    public string Fullname
    {
        get { return fullname;}
        set { fullname = value; }
    }
    public int Experience
    {
        get { return experience;}
        set { experience = value; }
    }

    public override string ToString()
    {
        return fullname + " | Experience: " + experience+"" + base.ToString();
    }
}