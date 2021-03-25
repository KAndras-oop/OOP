using System;
using System.Collections.Generic;
using System.Text;

namespace KonyvNs
{
    class Book
    {
        private int pagenumber;
        private string author;
        private string title;
        //A feladat konstansot kért, és a readonly értéke se változik szóval konstansnak minősül 
        private readonly int yearOfPublication;
        private int price; 
        private static string publishercompany = "Móra";
        public override string ToString()
        {
            return "Szerző: " + author + ", Cím: " + title + ", Kiadás dátuma: " + yearOfPublication + ", Ár: " + price + ", Kiadó: " + publishercompany + ", Oldalszám: " + pagenumber;
        }
        public Book(string author, string title, int price, int pagenumber)
        {
            this.author = author;
            this.title = title;
            this.price = price;
            this.pagenumber = pagenumber;
            DateTime currentDate = DateTime.Now;
            int year = currentDate.Year;
            yearOfPublication = year;
        }
        public Book(string author, string title)
        {
            this.author = author;
            this.title = title;
            this.price = 2500;
            DateTime currentDate = DateTime.Now;
            int year = currentDate.Year;
            yearOfPublication = year;
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public int YearOfPublication
        {
            get { return yearOfPublication; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public int Pagenumber
        {
            get { return pagenumber; }
            set { pagenumber = value; }
        }
        public int GetPrice()
        { return price; }

        public void SetPrice(int value)
        { price = value; }

        public int GetPagenumber()
        { return pagenumber; }

        public void SetPagenumber(int value)
        { price = value; }

        public int GetYearOfPublication()
        { return yearOfPublication; }

        public string GetTitle()
        { return title; }

        public void SetTitle(string value)
        { title = value; }

        public string GetAuthor()
        { return author; }

        public void SetAuthor(string value)
        { author = value; }

        public void IncreasePrice(int percentage)
        {
            price += (int)(price * percentage / 100.0);
        }

        public string DisplayInformation()
        {
            return "Szerző: " + author + ", Cím: " + title + ", Kiadás dátuma: " + yearOfPublication + ", Ár: " + price + ", Kiadó: " + publishercompany + ", Oldalszám: " + pagenumber;
        }
        public Book hosszabb(Book a, Book b)
        {
            if (a.GetPagenumber() > b.GetPagenumber())
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public bool paros()
        {
            if (this.pagenumber % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
