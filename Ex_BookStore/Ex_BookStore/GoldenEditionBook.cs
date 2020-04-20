using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_BookStore
{
    public class GoldenEditionBook:Book
    {        
        public GoldenEditionBook(string author, string title, double price) : base(author, title, price) { }

        protected override double Price => base.Price * 1.3;
    }
}
