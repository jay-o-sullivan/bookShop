using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookShop
{
    class Program
    {
        static void Main()
        {


            List<CBook> shopBooks = new List<CBook>();

            Console.WriteLine("** THE BOOK SHOP **");

            int option = 0;

            do
            {

                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Display Books");
                Console.WriteLine("3. Search By ISBN");
                Console.WriteLine("4. Update Book");
                Console.WriteLine("5. Delete Book");
                option = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(option);
                switch (option)
                {
                    case 1:
                        {
                            addBook(shopBooks);
                            break;
                        }
                    case 2:
                        {
                            displayBooks(shopBooks);
                            break;
                        }
                    case 3:
                        {
                            searchBook(shopBooks);
                            break;
                        }
                    case 4:
                        {
                            updateBook(shopBooks);
                            break;
                        }
                    case 5:
                        {
                            deleteBook(shopBooks);
                            break;
                        }
                    default:
                        Console.WriteLine("Option not implemented");
                        break;
                }
            } while (option != 6);
           

        }


        public static void addBook(List<CBook> cBooks)
        {
            CEBook e1 = new CEBook("1", "Micheal Martins", 11, 10, "www.downloadhere.com", 50);
            CEBook e2 = new CEBook("9781603094122", "Campbell White", 6, 10, "www.topshelfcomix.com", 40);
            CEBook e3 = new CEBook("9781603093002", "John Brown Lew", 9, 8, "www.topshelfcomix.com", 43);

            cBooks.Add(e1);
            cBooks.Add(e2);
            cBooks.Add(e3);

            CPaperBook p1 = new CPaperBook("2", "John Brown Lew", 9, 15, 1, 2);
            CPaperBook p2 = new CPaperBook("9781603094023", "Andrew Aydin", 15, 12, 2, 3);
            CPaperBook p3 = new CPaperBook("9781603094238", "James Jochalka", 19, 10, 1, 4);

            cBooks.Add(p1);
            cBooks.Add(p2);
            cBooks.Add(p3);

            Console.WriteLine("The books have been added successfully.");
        }




        public static void displayBooks(List<CBook> cBooks)
        {
            foreach (CBook a in cBooks)
            {
                a.ShowDetails();
            }
        }


        public static void searchBook(List<CBook> cBooks)
        {
            Console.WriteLine("Please enter an ISBN");
            string input = Console.ReadLine();

            foreach (CBook a in cBooks)
            {
                if (a.isbn.Equals(input))
                {
                    Console.WriteLine("Book Found");
                    a.ShowDetails();
                }
            }

        }
        public static CBook findBook(List<CBook> cBooks, string isbn)
        {
            CBook x = null;
            foreach (CBook a in cBooks)
            {
                if (a.isbn.Equals(isbn))
                {
                    return a;
                }
            }

            return x;
        }

        public static void updateBook(List<CBook> cBooks)
        {
            Console.WriteLine("Please enter a ISBN");
            string input = Console.ReadLine();

            foreach (CBook book in cBooks)
            {
                if (book.isbn.Equals(input))
                {
                    Console.WriteLine("Book Found");
                    book.getUserInput();
                }
            }
          
        }

        public static void deleteBook(List<CBook> cBooks)
        {
            Console.WriteLine("Please enter the ISBN of the book you wish to delete");
            string input = Console.ReadLine();

            CBook x = findBook(cBooks, input);
           
            if (x != null)
            {
                cBooks.Remove(x);
            }else

            Console.WriteLine("Book not found.");
            

        }
            

    }
}
