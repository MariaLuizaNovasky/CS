using System;

namespace Exercicios
{

    class Exerc_06
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine(num1);
            }
            else if (num2 < num1 && num2 < num3)
            {
                Console.WriteLine(num2);
            }
            else if (num3 < num1 && num3 < num2)
            {
                Console.WriteLine(num3);
            }
        }
    }
}