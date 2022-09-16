using System;

namespace SConstante
{
    class Program
    {
        static void Main(string[] args)
            {
                string linha;
                int[] lista = new int[20];
                int conta = 0;
                int num = 0;
                while (conta < 20)
                {
                    linha = Console.ReadLine();
                    num = int.Parse(linha);
                    if (num >= 0)
                    {
                        conta = conta + 1;
                        lista[conta - 1] = num;
                    }
                }
                for (int i = 19; i <= 0; i--)
                {
                    Console.WriteLine("Posicao " + i + " valor " + lista[conta]);
                }

                conta = 20;
                while (conta > 0)
                {
                    conta = conta - 1;
                    Console.WriteLine("Posicao " + conta + " valor " + lista[conta]);
                }
                conta = 19;
                while (conta >= 0)
                {
                    Console.WriteLine("Posicao " + conta + " valor " + lista[conta]);
                    conta = conta - 1;
                }
            }

        }
    }
