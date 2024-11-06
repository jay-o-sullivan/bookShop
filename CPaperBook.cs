using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookShop
{
    public class CPaperBook : CBook
    {
        public double shippingWeight { get; set; }
        public double handlingCost { get; set; }

        public CPaperBook(string isbn) : base(isbn)
        {
            shippingWeight = 0;
            handlingCost = 0;
        }

        public CPaperBook() : base()
        {
            shippingWeight = 0;
            handlingCost = 0;
        }

        public CPaperBook(string isbn, string author, double basePrice, double countryTax, double shippingWeight, double handlingCost) : base(isbn, author, basePrice, countryTax)
        {
            this.shippingWeight = shippingWeight;
            this.handlingCost = handlingCost;
        }

        public override void ShowDetails()
        {
            Console.WriteLine("\t{0} {1,10} {2,10} {3,10} {4,10} {5,10}", isbn, author, basePrice.ToString("F2"), countryTax.ToString("F2"), shippingWeight.ToString("F2"), handlingCost.ToString("F2"));
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
            Console.WriteLine("Please enter a shippinh weight");
            this.shippingWeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the handling cost");
            this.handlingCost= Convert.ToDouble(Console.ReadLine());



        }
    }
}
