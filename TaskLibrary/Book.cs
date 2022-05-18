using System.Collections;

namespace LibraryTask;

public class Book
{
    private string name;
    private string author;

    public Book(string name, string author)
    {
        this.name = name;
        this.author = author;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public string GetText()
    {
        return $"Имя: {name} Автор: {author}";
    }
}