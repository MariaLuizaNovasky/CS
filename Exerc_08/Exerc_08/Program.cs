using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace Exercicios
{
    class Exerc_08
    {
        static void Main(string[] args)
        {
            double valor = double.Parse(Console.ReadLine());
            double raiz = Convert.ToSingle(Math.Sqrt(valor));
            double cubica = Convert.ToSingle(Math.Pow(valor, 1.0 / 3.0));

            Console.WriteLine(raiz);
            Console.WriteLine(cubica);
        }
    }
}