using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios
{
    class Exerc_03
    {
        static void Main(String[] args)
        {
            double n1, n2, n3, n4;

            Console.WriteLine("Insira as quatro notas do aluno em sequência: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());
            n3 = Convert.ToDouble(Console.ReadLine());
            n4 = Convert.ToDouble(Console.ReadLine());

            double media = (n1 + n2 + n3 + n4) / 4;

            if (media >= 7)
            {
                Console.WriteLine("Aluno aprovado");
            }
            else
            {
                Console.WriteLine("Aluno Reprovado");
            }

            Console.WriteLine("A média do aluno é: {0}", media);
        }
    }
}