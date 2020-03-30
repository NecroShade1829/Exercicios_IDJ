using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] comandoPalavra = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                switch (comandoPalavra[1])
                {
                    case "Celsius": Console.WriteLine(Converte.CelsiusToFah(int.Parse(comandoPalavra[0])));  break;
                    case "Fahrenheit": Console.WriteLine(Converte.FahrenheitToCel(int.Parse(comandoPalavra[0]))); break;
                    default: Console.WriteLine("unidade nao valida"); break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
