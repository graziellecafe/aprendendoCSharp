using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 27; 

            if(idade >= 18)
            {
                Console.Write("Você tem mais de 18 anos de idade!");
            }
            else
            {
                Console.Write("Você tem menos de 18 anos");
            }

            Console.Read();
        }
    }
}
