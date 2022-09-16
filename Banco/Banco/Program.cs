using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco CriCri
{
    class Program
{
    static void Main(string[] args)
    {

        double saldo = 0;
        double valor = 0;
        int numTentativas = 0;
        bool acabar = false;

        while (!acabar)
        {
            Console.WriteLine("BEM VINDO AO BANCO CRICRI:");
            Console.WriteLine("Escolha opção:");
            Console.WriteLine("1- Consultar Saldo");
            Console.WriteLine("2- Realizar Saque");
            Console.WriteLine("3- Realizar Depósito");
            Console.WriteLine("4- Tentativas falhadas");
            Console.WriteLine("5- Sair");
            int menu = int.Parse(Console.ReadLine());
        }
        switch (menu)
        {
            case 1:
                {
                    Console.WriteLine("Consultar Saldo: ");
                    valor = Double.Parse(Console.ReadLine());
                    if (valor > saldo)
                    {
                        Console.WriteLine("Seu Saldo está");
                        numTentativas = numTentativas + 1;
                    }
                    else
                    {
                        saldo = saldo - valor;
                        Console.WriteLine("Saldo = " + saldo);
                    }
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Realizar Saque: ");
                    valor = int.Parse(Console.ReadLine());
                    saldo = saldo + valor;
                    Console.WriteLine("Saldo = " + saldo);


                    else
                    {
                        saldo = saldo - valor;
                        Console.WriteLine("Saldo = " + saldo);
                    }
                    break;

                }
        }
    }
}
}
