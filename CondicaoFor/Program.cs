﻿using System;

namespace CondicaoFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);      
            }

            string[] carros = {"fusca", "brasília", "variant"};
            foreach (string y in carros)
            {
                Console.WriteLine(y);   
            }

        }
    }
}
