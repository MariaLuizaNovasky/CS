using System;

namespace Nomes
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            Console.WriteLine("Olá! Escolha um integrante:");
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("(1)");
                Console.WriteLine("(2)");
                Console.WriteLine("(3)");
                Console.WriteLine("(4)");
                Console.WriteLine("(5)");
                Console.WriteLine("(0) - Sair");
                escolha = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (escolha)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Nome: Christian");
                        Console.WriteLine("Data de nascimento: 25/10/2005");
                        Console.WriteLine("Idade: 16");
                        Console.WriteLine("Hobby: Ouvir música");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Nome: Gabriele Bublitz");
                        Console.WriteLine("Data de nascimento: 04/07/2002");
                        Console.WriteLine("Idade: 20");
                        Console.WriteLine("Hobby: Ler");
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Nome: Guilherme");
                        Console.WriteLine("Data de nascimento: 12/12/2003");
                        Console.WriteLine("Idade: 18");
                        Console.WriteLine("Hobby: Ler");
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nome: Maria");
                        Console.WriteLine("Data de nascimento: 05/06/2004");
                        Console.WriteLine("Idade: 18");
                        Console.WriteLine("Hobby: Cozinhar");
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Nome: Nicolle");
                        Console.WriteLine("Data de nascimento: 19/10/2005");
                        Console.WriteLine("Idade: 16");
                        Console.WriteLine("Hobby: Cozinhar");
                        break;
                }
            } while (escolha != 0);
        }
    }
}