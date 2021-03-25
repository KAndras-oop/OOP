using System;

namespace _4_Book
{
    class BookProgram
    {
        static void Main(string[] args)
        {
            Book book = new Book("Németh Mihály", "A zöld könyv", 1998, 2000);
            Book book2 = new Book("Kovács Kálmán", "Néha jó néha jobb");
            Console.WriteLine(book.DisplayInformation());
            Console.WriteLine(book2.DisplayInformation());
            Console.WriteLine(book.ToString());
            Console.WriteLine(book2.ToString());
        }
    }
}
