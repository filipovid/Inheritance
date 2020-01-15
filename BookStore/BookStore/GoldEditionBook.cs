using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class GoldEditionBook : Book
    {
        public GoldEditionBook(string title, string author, decimal price)
            : base(title, author, price)
        {

        }

        public override decimal Price 
        {
            get => base.Price * 1.3m;
        }
    }
}
