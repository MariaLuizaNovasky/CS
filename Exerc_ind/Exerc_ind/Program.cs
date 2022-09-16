using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_ind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe  a sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            int categoria = 0;

            if (idade < 6)
            {
                categoria = 1;
            }

            else if (idade >= 6 && idade < 20)
            {
                categoria = 2;
            }

            else if (idade >= 20 && idade < 48)
            {
                categoria = 3;
            }

            else
            {
                categoria = 4;
            }

            switch (categoria)
            {
                case 1:
                    Console.WriteLine("Você entra na categoria infantil");
                    break;

                case 2:
                    Console.WriteLine("Você entra na categoria juvenil");
                    break;

                case 3:
                    Console.WriteLine("Você entra na categoria profissional");
                    break;

                case 4:
                    Console.WriteLine("Você entra na categoria veterano");
                    break;
            }
        }
    }
}