using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while(command != "End")
            {
                string[] comandoPalavra = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int BuyBeer = int.Parse(comandoPalavra[0]);
                int DrinkBeer = int.Parse(comandoPalavra[1]);
                BeerCounter.Beer(BuyBeer);
                BeerCounter.DrankBeer(DrinkBeer);

                command = Console.ReadLine();
            }
            Console.WriteLine(BeerCounter.beerInStock + " " + BeerCounter.beerDrankCount);
        }
    }
}
