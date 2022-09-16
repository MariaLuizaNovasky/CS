using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Exerc_07
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Informe seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe seu cargo: ");
            string cargo = Console.ReadLine();

            Console.WriteLine("Informe seu salário base: ");
            double salarioB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("________________________-");

            Console.WriteLine(nome);
            Console.WriteLine(cargo);
            Console.WriteLine(salarioB);
            Console.WriteLine(idade);
        }
    }
}