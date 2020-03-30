using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3
{
   public static class Converte
    {
        
        public static string CelsiusToFah(int grauCel)
        {
            double grauEmFah = grauCel * 9/5 + 32;
            return String.Format("{0}",grauEmFah);
        }

        public static string FahrenheitToCel(int grauFah)
        {
            double grauEmCel = (grauFah - 32) * (5 / 9);
            return String.Format("{0}",grauEmCel);
        }
    }
}
