using System;

namespace Salarios
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            double Salario1, Salario2, Salario3;
            double SOMA, desconto;

            Console.WriteLine("Informe seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Salario 1: ");
            Salario1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Salario 2: ");
            Salario2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Salario 3: ");
            Salario3 = Double.Parse(Console.ReadLine());

            SOMA = (Salario1 + Salario2 + Salario3);
            desconto = (SOMA - 0.9);

            Console.WriteLine("O Salario final é de: {0}", desconto);

        }
    }
}
