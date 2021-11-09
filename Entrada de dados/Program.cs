using System;

namespace Entrada_de_dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome? ");
            string nomePessoa = Console.ReadLine();

            Console.Write("Qaqul é a sua idade? ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Meu nome é " + nomePessoa + " e minha odade é " + idade);

        }
    }
}
