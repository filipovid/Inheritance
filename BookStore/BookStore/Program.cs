using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Author: ");
                string author = Console.ReadLine();

                Console.WriteLine("Title: ");
                string title = Console.ReadLine();

                Console.WriteLine("Price: ");
                decimal price = decimal.Parse(Console.ReadLine());

                var book = new Book(author, title, price);
                GoldEditionBook goldenBookEdition = new GoldEditionBook(title, author, price);

                Console.WriteLine(book);
                Console.WriteLine(goldenBookEdition);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
