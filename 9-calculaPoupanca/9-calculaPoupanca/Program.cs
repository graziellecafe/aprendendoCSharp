using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_calculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcula Poupança");
            double valorInvestido = 1000.00;

            int i = 1; 
            while (i <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * (0.36 / 100);
                Console.WriteLine("Após " + i + " mes(es), você terá R$ " + valorInvestido);
                i++;
            }


            Console.Read();
        }
    }
}
