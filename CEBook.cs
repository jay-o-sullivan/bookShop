using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookShop
{
    public class CEBook : CBook
    {
        public string downloadUrl { get; set; }
        public double sizeMb { get; set; }

        public CEBook(string isbn) : base(isbn)
        {
            downloadUrl = "";
            sizeMb = 0;
        }

        public CEBook() : base()
        {
            downloadUrl = "";
            sizeMb = 0;
        }

        public CEBook(string isbn, string author, double basePrice, double countryTax, string downloadUrl, double sizeMb): base(isbn, author, basePrice, countryTax)
        {
            this.downloadUrl = downloadUrl;
            this.sizeMb = sizeMb;
        }

        public override void ShowDetails()
        {
            Console.WriteLine("\t{0} {1,10} {2,10} {3,10} {4,10} {5,10}",isbn, author, basePrice.ToString("F2"), countryTax.ToString("F2"), downloadUrl, sizeMb.ToString("F2"));
        }

        public override void getUserInput()
        {
            Console.WriteLine("Please enter a book ISBN");
            this.isbn = Console.ReadLine();
            Console.WriteLine("Please enter an author");
            this.author = Console.ReadLine();
            Console.WriteLine("Please enter a base price");
            this.basePrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter country tax");
            this.countryTax = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a download URL");
            this.downloadUrl = Console.ReadLine();
            Console.WriteLine("Please enter the size in MBs");
            this.sizeMb = Convert.ToDouble(Console.ReadLine());

        }
    }


}
