using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Book
    {
        private string _title;
        private string _author;
        private decimal _price;

        public Book(string title, string author, decimal price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public virtual decimal Price
        {
            get
            {
                return _price;
            }

            protected set
            {
                if (value < 0)
                {
                    Console.WriteLine("Price cannot be negative.");
                }

                _price = value;
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }

            protected set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Title cannot be less then 3 chars.");
                }

                _title = value;
            }
        }

        public string Author
        {
            get
            {
                return _author;
            }

            protected set
            {
                string[] names = value.Split();

                char secondNameFirstLetter = names[1][0];
                if (char.IsDigit(secondNameFirstLetter))
                {
                    Console.WriteLine("Author not valid!");
                }

                _author = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Type: ").AppendLine(this.GetType().Name)
                .Append("Title: ").AppendLine(this.Title)
                .Append("Author: ").AppendLine(this.Author)
                .Append("Price: ").Append($"{this.Price:f1}")
                .AppendLine();

            return sb.ToString();
        }
    }
}
