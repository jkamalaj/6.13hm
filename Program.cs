using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            
            Journal journal1 = new Journal
            {
                Company = "Accounting, Organizations and Society",

            };
            Journal journal2 = new Journal()
            {
                Company = "Review of Accounting Studies",
            };
            Book book1 = new Book()
            {
                Author = "Lewis Carol",
                Genre = "Adventure,fantasy",
            };
            Book book2 = new Book
            {
                Author = "William Shakespeare",
                Genre = "Tragedy",
            };
            library.AddProduct(book1);
            library.AddProduct(book2);
            library.AddProduct(journal1);
            library.AddProduct(journal2);

            Console.WriteLine(library.GetBooksCount());
            Console.WriteLine(library.GetJurnalsCount());


        }
    }
}
