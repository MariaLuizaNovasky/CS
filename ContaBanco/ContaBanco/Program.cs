using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBanco
{
    class BancoCriCri
    {
        static void Main(String[] args)
        {
            double saque, deposito, saldo = 0;
            int opcao;
            string nome, nomeBanco;

            Console.WriteLine("Informe seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Informe o Banco: ");
            nomeBanco = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Bem-vindo ao Banco {0} {1}!", nomeBanco, nome);
            Console.WriteLine("Escolha a opção desejada: ");

            do
            {
                Console.WriteLine();
                Console.WriteLine("1 - Saldo ");
                Console.WriteLine("2 - Saque ");
                Console.WriteLine("3 - Depósito ");
                Console.WriteLine("4 - Sair ");
                opcao = Int32.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Seu saldo na conta é de: {0}", saldo);
                        break;

                    case 2:
                        Console.WriteLine("Informe o valor a ser retirado: ");
                        saque = double.Parse(Console.ReadLine());
                        if (saldo < saque)
                        {
                            Console.WriteLine("Saldo insuficiente para retirada!");
                        }
                        else
                        {
                            saldo = saldo - saque;
                        }
                        break;

                    case 3:
                        Console.WriteLine("Informe o valor a ser depósitado: ");
                        deposito = double.Parse(Console.ReadLine());
                        saldo = saldo + deposito;
                        break;

                    default:
                        break;
                }
            } while (opcao != 0);
        }
    }
}