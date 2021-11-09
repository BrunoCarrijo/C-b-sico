using System;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] carros = {"fusca", "Brasília", "Ônix", "Volvo"};
            int[] numeros = { 1, 2, 3, 4, 5 };

            carros[2] = "Passat";
            //Console.Writeline(carros.Length);

            for (int i = 0; i < carros.Length; i++)
            {
                Console.WriteLine(carros[i]);   
            }
        }
    }
}
