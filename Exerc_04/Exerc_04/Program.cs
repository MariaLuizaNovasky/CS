using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Exerc_04
    {
        static void Main(string[] args)
        {
            double salarioBase = 1800;
            double acrescimo = salarioBase * 0.2;

            double salarioLiquido = salarioBase + acrescimo;

            Console.WriteLine("Salario: " + salarioLiquido);
        }
    }
}