using System;

namespace KonyvNs
{
    class BookProgram
    {
        static void Main(string[] args)
        {
            Book book = new Book("Németh Mihály", "A zöld könyv", 2000, 30);
            Book book2 = new Book("Kovács Kálmán", "Néha jó néha jobb");
            Console.WriteLine(book.DisplayInformation());
            Console.WriteLine(book2.DisplayInformation());
            Console.WriteLine(book.ToString());
            Console.WriteLine(book2.ToString());
            Console.WriteLine("A hosszabb könyv: \n");
            Console.WriteLine(book.hosszabb(book, book2));
            Console.WriteLine("Páros-e a könyv oldalszáma? \n");
            Console.WriteLine(book.paros());

            Beolvas beker = new Beolvas();
            beker.init();
            beker.hanykonyv();
            beker.leghosszabb();
            beker.leghosszabbparos();
        }
    }
}
