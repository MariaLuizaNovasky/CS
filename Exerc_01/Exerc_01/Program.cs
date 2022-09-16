using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{
    class Exerc_01
    {
        static void Main(string[] args)
        {
            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());
            int valor3 = int.Parse(Console.ReadLine());

            int soma = valor1 + valor2 + valor3;

            Console.WriteLine(soma);
        }
    }
}