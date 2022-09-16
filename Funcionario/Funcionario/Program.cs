using System;

namespace Reajuste
{
    class Funcionário
    {
        [STAThread]
        static void Main(string[] args)
        {
            // Declaração de Variáveis.
            double salarioInicial; //-> Salario Inicial do Fúncionario.
            double salarioFinal; //-> Salario Final do Fúncionario.

            Console.Write("\t\tInforme o valor do Salário do Fúncionario: ");
            salarioInicial = Double.Parse(Console.ReadLine());
            Console.WriteLine(); //-> Exibe uma linha em Branco.

           /* salarioInicial(Atual)
           Reajuste Salarial (salario Final)
           Salario menor ou igual a R$500,00 -> 15%
           Salario menor ou igual a R$1000,00 -> 10%
           Salario maior a R$1000,00 -> 5%
           */

            if (salarioInicial <= 500)
            {
                salarioFinal = (salarioInicial + (salarioInicial * 0.15));
                Console.WriteLine("\t\tO novo salario é igual a: {0}", salarioFinal);
                Console.WriteLine();
            }

            else
            {
                if (salarioInicial <= 1000)
                {
                    salarioFinal = (salarioInicial + (salarioInicial * 0.10));
                    Console.WriteLine("\t\tO novo salario é igual a: {0}", salarioFinal);
                    Console.WriteLine();
                }

            else
            {
                    salarioFinal = (salarioInicial + (salarioInicial * 0.05));
                    Console.WriteLine("\t\tO novo salario é igual a: {0}", salarioFinal);
                    Console.WriteLine();
                }
            }

        }
    }
}
