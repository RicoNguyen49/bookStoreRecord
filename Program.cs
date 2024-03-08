using System;

namespace bookStoreRecord
{
    public record Bookstore(int ID, string Title, string Author, double Price);

    class Program
    {
        static void Main(string[] args)
        {
            //Bookstore record objects
            Bookstore book1 = new Bookstore(1, "Night", "Elie Wiesel", 6.67);
            Bookstore book2 = new Bookstore(2, "Kite Runner", "khaled hosseini", 6.79);
            Bookstore book3 = new Bookstore(3, "Animal Farm", "George Orwell", 9.99);

            //Display
            Console.WriteLine("Bookstore Records:");
            Console.WriteLine($"Book 1:");
            Console.WriteLine($"ID = {book1.ID}");
            Console.WriteLine($"Title - {book1.Title}");
            Console.WriteLine($"Author - {book1.Author}");
            Console.WriteLine($"Price - ${book1.Price}");
            Console.WriteLine("");
            Console.WriteLine($"Book 2:");
            Console.WriteLine($"ID = {book2.ID}");
            Console.WriteLine($"Title - {book2.Title}");
            Console.WriteLine($"Author - {book2.Author}");
            Console.WriteLine($"Price - ${book2.Price}");
            Console.WriteLine("");
            Console.WriteLine($"Book 3:");
            Console.WriteLine($"ID = {book3.ID}");
            Console.WriteLine($"Title - {book3.Title}");
            Console.WriteLine($"Author - {book3.Author}");
            Console.WriteLine($"Price - ${book3.Price}");


        }
    }
}
