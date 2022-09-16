using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Digite o valor de a: ");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de b: ");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de c: ");
            c = Int32.Parse(Console.ReadLine());

            double delta = (b * b) - (4 * a * c);
            double raiz = Math.Sqrt(delta);

            double r1 = ((b) + raiz) / (2 * a);
            double r2 = ((b) - raiz) / (2 * a);

            Console.WriteLine("A raiz 1 é: " +r1);
            Console.WriteLine("A raiz 2 é: " +r2);

        }
    }
}
