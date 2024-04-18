using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasPOO
{
    public class Program
    {
        static void Main(string[] args)
        {

            bool tioMorto = true;

            int quantidadeFilhos = 3;

            double saldo = 2000;

            double quantiaFinal;

            try
            {
                if (tioMorto)
                    throw new Exception();
                Console.WriteLine("Tá vivo <3\n");
            }
            catch (Exception ex)
            {
                quantiaFinal = saldo / quantidadeFilhos;
                Console.WriteLine("\nTio Morreu e a quantia dividida foi: " + $"{quantiaFinal:F2}");

            }
        }
    }
}
