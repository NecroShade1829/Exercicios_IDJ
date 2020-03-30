using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio4
{
    public static class BeerCounter
    {
        public static int beerInStock;
        public static int beerDrankCount;

        public static void Beer(int bottleCount)
        {
            beerInStock += bottleCount;
        }

        public static void DrankBeer(int bottleCount)
        {
            beerDrankCount += bottleCount;
            beerInStock -= bottleCount;
        }
    }
}
