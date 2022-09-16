using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ParEImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = 0;
            int R = 0;
            Console.WriteLine("Exercício 1 - If e Else");
            Console.WriteLine("Digite um número");
            Num = Convert.ToInt32(Console.ReadLine());
            R = Num % 2;
            if (R == 0)

            {
                Console.WriteLine("O Número é Par");
            }
            else
            {
                Console.WriteLine("O Número é Impar");
            }
            Console.WriteLine("Digite qualquer valor para sair do aplicativo");
            Console.ReadKey();
        }
    }
}