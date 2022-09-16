using System;

namespace Soma_ 
{
    class Adicao
    {
 
    [STAThread]
        static void Main(string[] args)
        {
            double N1, N2, soma;

            Console.WriteLine("Informe o 1° Numero: ");
            N1 = Double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Informe o 2° Numero: ");
            N2 = Double.Parse(Console.ReadLine());
            Console.WriteLine();

            soma = (N1 + N2);

            if (soma >= 10)
            {
                soma = soma + 5;
                Console.WriteLine("O novo valor da soma agora é: {0}", soma);
                Console.WriteLine();
            }

            else
            {
                soma = soma - 7;
                Console.WriteLine("O novo valor da soma agora é: {0}", soma);
                Console.WriteLine();
            }

        }
    }
}
