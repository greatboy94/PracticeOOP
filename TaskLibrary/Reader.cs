namespace LibraryTask;

public class Reader
{
    private string fullname;
    private int numberOfTicket;
    private string faculty;
    private string dateOfBirth;
    private int phoneNumber;

    public Reader(string fullname, int numberOfTicket, string faculty, string dateOfBirth, int phoneNumber)
    {
        this.fullname = fullname;
        this.numberOfTicket = numberOfTicket;
        this.faculty = faculty;
        this.dateOfBirth = dateOfBirth;
        this.phoneNumber = phoneNumber;
    }

    public string Fullname
    {
        get { return fullname;}
        set { fullname = value;}
    }
    public int NumberOfTicket
    {
        get { return numberOfTicket;}
        set { numberOfTicket = value;}
    }
    public string Faculty
    {
        get { return faculty;}
        set { faculty = value;}
    }
    public string DateOfBirth
    {
        get { return dateOfBirth;}
        set { dateOfBirth = value;}
    }

    public int PhoneNumber
    {
        get { return phoneNumber;}
        set { phoneNumber = value;}
    }

    public void TakeBook(int count)
    {
        Console.WriteLine($"{fullname} взял {count} книги.");
    }
    public void TakeBook(string[] bookName)
    {
        Console.WriteLine($"{fullname} взял книги:");
        foreach (string element in bookName)
        {
            Console.WriteLine(element);
        }
        Console.WriteLine();
    }

    // Тут я не понял что я не так делаю. Не могу исползовать этот метод в Program.cs
    public void TakeBook(Book[] books)
    {
        Console.WriteLine($"{fullname} взял книги:");
        foreach (Book el in books)
        {
            Console.WriteLine(el.Name+"автор"+el.Author);
        }

        Console.WriteLine();
    }

    public void ReturnBook(int count)
    {
        Console.WriteLine($"{fullname} вернул {count} книги.");
    }

    public void ReturnBook(string[] bookName)
    {
        Console.WriteLine($"{fullname} вернул книги:");
        foreach (string el in bookName)
        {
            Console.WriteLine(el);
        }
        Console.WriteLine();
    }

    public void ReturnBook(Book[] books)
    {
        Console.WriteLine($"{fullname} вернул книги:");
        foreach (var el in books)
        {
            Console.WriteLine(el.Name+", автор"+el.Author);
        }
    }

    public string GetText()
    {
        return
            $"Имя: {fullname} Номер: {numberOfTicket} Факультет: {faculty} дата рождения: {dateOfBirth} телефон: {phoneNumber}";
    }

    public void TakeBook(string bookName, string empty)
    {
        throw new NotImplementedException();
    }

    public void ReturnBook(Book bookName, Book book2, Book book3)
    {
        throw new NotImplementedException();
    }
}