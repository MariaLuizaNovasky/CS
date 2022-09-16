using System;

namespace Valores
{
    class Compara
    {
        [STAThread]
        static void Main(string[] args)
        {
            int N1, N2, N3, N4, N5; //-> Numeros que serão oferecido pelo Usuario. 
            int MAIOR; //-> Armazena o maior valor 
            int MENOR; //-> Armazena o menor valor 

            Console.Write("\tInforme o valor de N1: "); //Solicita numero oferecido pelo Usuario.
            N1 = Int32.Parse(Console.ReadLine()); //Le o numero oferecido pelo Usuario.
            Console.WriteLine(); //Adiciona uma linha em branco.

            Console.Write("\tInforme o valor de N2: "); //Solicita numero oferecido pelo Usuario.
            N2 = Int32.Parse(Console.ReadLine()); //Le o numero oferecido pelo Usuario.
            Console.WriteLine(); //Adiciona uma linha em branco.

            Console.Write("\tInforme o valor de N3: "); //Solicita numero oferecido pelo Usuario.
            N3 = Int32.Parse(Console.ReadLine()); //Le o numero oferecido pelo Usuario.
            Console.WriteLine(); //Adiciona uma linha em branco.

            Console.Write("\tInforme o valor de N4: "); //Solicita numero oferecido pelo Usuario.
            N4 = Int32.Parse(Console.ReadLine()); //Le o numero oferecido pelo Usuario.
            Console.WriteLine(); //Adiciona uma linha em branco.

            Console.Write("\tInforme o valor de N5: "); //Solicita numero oferecido pelo Usuario.
            N5 = Int32.Parse(Console.ReadLine()); //Le o numero oferecido pelo Usuario.
            Console.WriteLine(); //Adiciona uma linha em branco.
            Console.WriteLine(); //Adiciona uma linha em branco.

            //Verifica qual o maior dentre os números fornecidos.
            if ((N1 >= N2) && (N1 >= N3) && (N1 >= N4) && (N1 >= N5))
            {
                MAIOR = N1;
                Console.WriteLine("\tO número N1 é o maior: {0}", MAIOR);
                Console.WriteLine();
            }
            else
            {
                if ((N2 >= N1) && (N2 >= N3) && (N2 >= N4) && (N2 >= N5))
                {
                    MAIOR = N2;
                    Console.WriteLine("\tO Número N2 é o maior: {0}", MAIOR);
                    Console.WriteLine();
                }
                else
                {
                    if ((N3 >= N1) && (N3 >= N2) && (N3 >= N4) && (N3 >= N5))
                    {
                        MAIOR = N3;
                        Console.WriteLine("\tO número N3 é o maior: {0}", MAIOR);
                        Console.WriteLine();
                    }
                    else
                    {
                        if ((N4 >= N1) && (N4 >= N2) && (N4 >= N3) && (N4 >= N5))
                        {
                            MAIOR = N4;
                            Console.WriteLine("\tO número N4 é o maior: {0}", MAIOR);
                            Console.WriteLine();
                        }
                        else
                        {
                            if ((N5 >= N1) && (N5 >= N2) && (N5 >= N3) && (N5 >= N4))
                            {
                                MAIOR = N5;
                                Console.WriteLine("\tO número N5 é o maior: {0}", MAIOR);
                                Console.WriteLine();
                            }
                        }
                    } // verificar o menor numero
                    if ((N1 <= N2) && (N1 <= N3) && (N1 <= N4) && (N1 <= N5))
                    {
                        MENOR = N1;
                        Console.WriteLine("\tO número N1 é o menor: {0}", MENOR);
                        Console.WriteLine();
                    }
                    else
                    {
                        if ((N2 <= N1) && (N2 <= N3) && (N2 <= N4) && (N2 <= N5))
                        {
                            MENOR = N1;
                            Console.WriteLine("\tO número N2 é o menor: {0}", MENOR);
                            Console.WriteLine();
                        }
                        else
                        {
                            if ((N3 <= N1) && (N3 <= N2) && (N3 <= N4) && (N3 <= N5))
                            {
                                MENOR = N1;
                                Console.WriteLine("\tO número N3 é o menor: {0}", MENOR);
                                Console.WriteLine();
                            }
                            else
                            {
                                if ((N4 <= N1) && (N4 <= N2) && (N4 <= N3) && (N4 <= N5))
                                {
                                    MENOR = N1;
                                    Console.WriteLine("\tO número N4 é o menor: {0}", MENOR);
                                    Console.WriteLine();
                                }
                                else
                                {
                                    if ((N5 <= N1) && (N5 <= N2) && (N5 <= N3) && (N5 <= N4))
                                    {
                                        MENOR = N1;
                                        Console.WriteLine("\tO número N5 é o menor: {0}", MENOR);
                                        Console.WriteLine();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
