using System;

namespace caixaRetangular
{
    class Caixa
    {
        [STAThread]
        static void Main(string[] args)
        {
            //Declarão de Variaveis
            double volume;
            double comprimento;
            double largura;
            double altura;

            Console.WriteLine("Por favor entre com a medida do comprimento da caixa em metros: ");
            comprimento = double.Parse(Console.ReadLine());

            Console.WriteLine("Por favor entre com a medida da largura da caixa em metros: ");
            largura = double.Parse(Console.ReadLine());

            Console.Write("Por favor entre com a medida da altura da caixa em metros: ");
            altura = double.Parse(Console.ReadLine());

            volume = comprimento * largura * altura; //Calcula o volume da caixa

            Console.WriteLine("O volume da caixa retangular com {0} metros de comprimento, {1} metros de largura e {2} metros de altura é de: {3} metros cúbicos", altura, volume, comprimento);

        }
    }
}
