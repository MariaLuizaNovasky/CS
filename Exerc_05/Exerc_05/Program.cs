using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Exerc_05
    {
        static void Main(string[] args)
        {
            double Vreal, Vdolar = 5.24, Vcotacao;

            Console.Write("Informe o valor em real: ");
            Vreal = Convert.ToDouble(Console.ReadLine());

            Vcotacao = Vreal * Vdolar;

            Console.WriteLine("O valor em dolar é: " + Vcotacao);
        }
    }
}