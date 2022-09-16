using System;

namespace Operações
{
    class Contas
    {
    [STAThread]
        static void Main(string[] args)
        {
            double N1, N2;
            double SOMA, SUB, MULTI, DIV;

            Console.Write("\tEntre com o 1° número: ");
            N1 = Double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("\tEntre com o 2° número: ");
            N2 = Double.Parse(Console.ReadLine());
            Console.WriteLine();

            //Realizar operações
            SOMA = (N1 + N2);
            SUB = (N1 - N2);
            MULTI = (N1 * N2);
            DIV = (N1 / N2);

            //Exibir resultado das operações
            Console.WriteLine("\tA soma dos números {0} e {1} é de: {2}", N1, N2, SOMA);
            Console.WriteLine();

            Console.WriteLine("\tA subtração dos números {0} e {1} é de: {2}", N1, N2, SUB);
            Console.WriteLine();

            Console.WriteLine("\tA Multiplicação dos números {0} e {1} é de: {2}", N1, N2, MULTI);
            Console.WriteLine();

            Console.WriteLine("\tA Divisão dos números {0} e {1} é de: {2}", N1, N2, DIV);
            Console.WriteLine();
        }
    }
}
