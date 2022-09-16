using System;

namespace Doisnumeros
{
    class Diferença
    {
        [STAThread]
        static void Main(string[] args)
        {
            //Declaração de Variaveis.
            double N1, N2; //-> Números fornecidos pelo Usúario.
            double SUBT; //-> Diferença entre maior e o menor.

            // Solicita e le os Números.
            Console.Write("\t\tInforme o valor de N1: ");
            N1 = Double.Parse(Console.ReadLine());
            Console.WriteLine(); //-> Adiciona uma Linha em Branco.

            Console.Write("\t\tInforme o valor de N2: ");
            N2 = Double.Parse(Console.ReadLine());
            Console.WriteLine(); //-> Adiciona uma Linha em Branco. 

            if (N1 > N2)
            {
                SUBT = N1 - N2;
                Console.WriteLine("\t\tA diferença de {0}" + "-" "+" {1})
            }
        }
    }
}
