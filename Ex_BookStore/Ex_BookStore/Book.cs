using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_BookStore
{
    public class Book
    {
        private string title;
        private string author;
        private double price;
        protected string Title
        {
            get => title;
            set
            {
                if (value.Length < 3) throw new ArgumentException("Title not valid!");
                title = value;
            }
        }

        protected string Author
        {
            get => author;
            set
            {
                if (Char.IsLetter(value[0]) == false) throw new ArgumentException("Author not valid!");
                author = value;
            }
        }

        protected virtual double Price
        {
            get => price;
            set
            {
                if (value < 0) throw new ArgumentException("Price not valid!");
                price = Math.Round(value, 1);
            }
        }
        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Type: ").Append(this.GetType().Name)
            .Append(Environment.NewLine)
            .Append("Title: ").Append(this.Title)
            .Append(Environment.NewLine)
            .Append("Author: ").Append(this.Author)
            .Append(Environment.NewLine)
            .Append("Price: ").Append(this.Price)
            .Append(Environment.NewLine);
            return sb.ToString();
        }
    }
}
