using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 27;
            int quantidadeDePessoas = 1;
            if (idade >= 18 && quantidadeDePessoas >=2)
            {
                Console.WriteLine("Você PODE entrar!");
            }
            else
            {
                Console.Write("Você NÃO pode entrar");
            }
            Console.Read();
        }
    }
}
