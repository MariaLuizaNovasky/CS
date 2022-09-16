using System;

namespace Banco
{
    class Conta
    {
        static void Main(string[] args)
        {         
                double saldo = 0;
                double valor = 0;
                int numTentativas = 0;
                bool acabar = false;
                string nome, banco;

            Console.WriteLine("Informe seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Informe qual banco irá usar: ");
            banco = Console.ReadLine();

            while (!acabar)
                {
                    Console.WriteLine("BEM VINDO!, SELECIONE UMA OPÇÃO ABAIXO: ");
                    Console.WriteLine("1- Saldo -----------------------------");
                    Console.WriteLine("2- Saque -----------------------------");
                    Console.WriteLine("3- Deposito --------------------------");
                    Console.WriteLine("4- Tentativas falhadas ---------------");
                    Console.WriteLine("5- Sair ------------------------------");
                    int menu = int.Parse(Console.ReadLine());

                    switch (menu)
                    {
                        case 1:
                            {
                                Console.WriteLine("Saldo: ");
                                valor = Double.Parse(Console.ReadLine());
                                if (valor > saldo)
                                {
                                    Console.WriteLine("Saldo insuficiente");
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
                                Console.WriteLine("Saque: ");
                                valor = Double.Parse(Console.ReadLine());
                                saldo = saldo + valor;
                                Console.WriteLine("Saldo = " + saldo);
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Saldo = " + saldo);
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Tentativas falhadas = " + numTentativas);
                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine("Fim do Programa");
                                acabar = true;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Opção errada...");
                                break;
                            }
                    }
                }

            }
        }
    }