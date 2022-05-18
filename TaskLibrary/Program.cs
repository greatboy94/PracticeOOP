// See https://aka.ms/new-console-template for more information

namespace LibraryTask
{
    class Program
    {
        public static void Main(string[] args)
        {
            Reader reader1 = new Reader("Петров В.В", 1, "Faculty1", "15.10.1996", 998911111);
            Reader reader2 = new Reader("Пушеин A.C", 2, "Faculty2", "15.10.1995", 99891112);
            Reader reader3 = new Reader("Agatha Christie", 3, "Faculty3", "15.10.1994", 99891113);
            Reader[] readers = {reader1, reader2, reader3};

            Book book1 = new Book("История и судьбы", "Петров В.В");
            Book book2 = new Book("Сказка о царе Салтане", "Пушеин A.C");
            Book book3 = new Book("The Mysterious Affair at Styles","Agatha Christie");
            Book[] books = {book1, book2, book3};

            ShowBooks(books);
            ShowReaders(readers);
            
            reader1.TakeBook(6);
            reader2.TakeBook("Some books","Some author");
            reader3.ReturnBook(book1,book2,book3);
            
        }

        private static void ShowBooks(Book[] books)
        {
            Console.WriteLine("List Books: ");
            foreach (Book el in books)
            {
                Console.WriteLine(el.GetText());
            }

            Console.WriteLine();
        }
        private static void ShowReaders(Reader[] readers)
        {
            Console.WriteLine("List Readers: ");
            foreach (Reader el in readers)
            {
                Console.WriteLine(el.GetText());
            }

            Console.WriteLine();
        }
    }
}