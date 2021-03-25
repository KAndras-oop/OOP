using System;
using System.Collections.Generic;
using System.Text;

namespace KonyvNs
{
    class Beolvas
    {
        public Book[] konyvek;
        public void leghosszabb()
        {
            int x = -1;
            int z = 0;
            for (int y = 0; y < konyvek.Length; y++)
            {
                if(konyvek[y].GetPagenumber() > x)
                {
                    x = konyvek[y].GetPagenumber();
                    z = y;
                }
            }
            Console.WriteLine("A leghosszabb könyv: " + konyvek[z].ToString());

        }
        public void leghosszabbparos()
        {
            int x = -1;
            int z = 0;
            for (int y = 0; y < konyvek.Length; y++)
            {
                if (konyvek[y].GetPagenumber() > x)
                {
                    if (konyvek[y].GetPagenumber() % 2 == 0)
                    {
                        x = konyvek[y].GetPagenumber();
                        z = y;
                    }
                }
            }
            if(x == -1)
            {
                Console.WriteLine("Egy páros oldalű könyv sem volt. ");
            }
                Console.WriteLine("A leghosszabb páros oldalú könyv: " + konyvek[z].ToString());

        }
        public void init()
            {
                Console.WriteLine("Adja meg hány darab könyvet szeretne hozzáadni:");
                int x = Convert.ToInt32(Console.ReadLine());
                konyvek = new Book[x];
                int y = 0;
                while (y < x)
                {
                    Console.WriteLine("Adja meg a könyv címét: ");
                    string title = Console.ReadLine();
                    Console.WriteLine("Adja meg a könyv íróját: ");
                    string author = Console.ReadLine();
                    Console.WriteLine("Adja meg a könyv árát: ");
                    int price = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Adja meg a könyv oldalszámát: ");
                    int pagenumber = Convert.ToInt32(Console.ReadLine());
                    Book konyv = new Book(author, title, price, pagenumber);
                    konyvek[y] = konyv;
                    y++;
                }
            }
        public void hanykonyv()
        {
            List<String> marvizsgalt = new List<String>();
            string szerzo;
            for(int x = 0; x < konyvek.Length; x++)
            {
                int db = 0;
                szerzo = konyvek[x].GetAuthor();
                if (!marvizsgalt.Contains(szerzo))
                {
                    for (int y = 0; y < konyvek.Length; y++)
                    {
                        if(konyvek[y].GetAuthor() == szerzo)
                        {
                            db++;
                        }
                    }
                    marvizsgalt.Add(szerzo);
                    Console.WriteLine(szerzo + " szerzőnek, ennyi darab könyve volt: " + db);
                  }
            }
        }
        }
    }
