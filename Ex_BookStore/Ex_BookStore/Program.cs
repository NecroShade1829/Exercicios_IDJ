﻿using System;

namespace Ex_BookStore
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string author = Console.ReadLine();
                string title = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                Book book = new Book(author, title, price);
                GoldenEditionBook goldenEditionBook = new GoldenEditionBook(author, title, price);
                Console.WriteLine(book);
                Console.WriteLine(goldenEditionBook);
            }   
            catch (ArgumentException a)
            {
                Console.WriteLine(a.Message);
            }
        }
    }
}
