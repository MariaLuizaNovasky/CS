using System;
namespace Potências
{
    class Potencia
    {
        [STAThread]
        static void Main(string[] args)
        {
            double NUM, EXP, POT;
            EXP = 0;
            NUM = 3;

            while (EXP <= 15)
            {
                POT = Math.Pow(NUM, EXP);
                Console.WriteLine("\tA Potência de {0} elevado a {1} é: { 2}\n", NUM, EXP, POT);
            EXP = EXP + 1;
            }
        } 
    } 
}