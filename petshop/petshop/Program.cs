using System;

namespace petShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, nomeAnimal, idadeAni, sexo, SexoAnimal, racaAnimal, dataNasc, cpf, endPEssoa, especie;
            int idade;

            Console.WriteLine("Exercício 4 - Cadastro");
            Console.WriteLine("Informe o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Informe a sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Informe o seu sexo: ");
            sexo = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Informe o seu Endereço:");
            endPEssoa = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Informe o seu cpf:");
            cpf = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Informe o nome do Animal");
            nomeAnimal = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Informe o sexo do Animal: ");
            SexoAnimal = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Informe a idade do Animal: ");
            idadeAni = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Informe a especie do Animal: ");
            especie = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Informe a Raça do Animal: ");
            racaAnimal = Console.ReadLine();
            Console.WriteLine();

        }
    }
}
