using System;

namespace Segundograu
{
    class Equações
    {
        [STAThread]
        static void Main(string[] args)
        {

            double A, B, C;
            double DELTA;
            double R1, R2;

            Console.Write("\tInforme o valor de A: ");
            A = Double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("\tInforme o valor de B: ");
            B = Double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("\tInforme o valor de C: ");
            C = Double.Parse(Console.ReadLine());
            Console.WriteLine();

            if ((A > 0) || (A < 0))
            {
                DELTA = (Math.Pow(B, 2) - 4 * A * C);
                if (DELTA >= 0) ;

                R1 = ((-B + (Math.Pow(DELTA, 0.5))) / (2 * A));
                R2 = ((-B - (Math.Pow(DELTA, 0.5))) / (2 * A));
                Console.WriteLine("\tAs raízes da equação são: {0},{1}", R1, R2);
                Console.WriteLine();

            }

            else
            {
                Console.WriteLine("\tA equação apresenta raízes imaginárias!!!");
            }

        Console.WriteLine("\tOs números fornecidos {0}, {1} e {2} não formam uma equação do 2º grau!", A, B, C);
        Console.WriteLine();
  
        }
    }
}
