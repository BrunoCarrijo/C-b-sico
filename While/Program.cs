using System;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;

            }

            int x = 0;
            do
            {
                Console.WriteLine(x);
                x++;
            }
            while (x <= 7);

        }
    }
}
