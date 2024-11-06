using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookShop
{
    public abstract class CBook
    {
        public string isbn { get; set; }
        public string author { get; set; }
        public double basePrice { get; set; }
        public double countryTax { get; set; }

        public CBook(string isbn, string author, double basePrice, double countryTax)
        {
            this.isbn = isbn;
            this.author = author;
            this.basePrice = basePrice;
            this.countryTax = countryTax;
        }

        public CBook()
        {
            isbn = "";
            author = "";
            basePrice = 0;
            countryTax = 0;
        }

        public CBook(string isbn)
        {
            this.isbn = isbn;
            author = "";
            basePrice = 0;
            countryTax = 0;
        }
        public abstract void getUserInput();
        public abstract void ShowDetails();
        public void Delete()
        {

        }


    }
}
