﻿using System;

namespace AlphabetTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //necessary variables
            char ch = 'A';
            int i, j, k, m;

            for (i = 1; i <= 5; i++)
            {
                for (j = 5; j >= i; j--)
                    Console.Write(" ");
                for (k = 1; k <= i; k++)
                    Console.Write(ch++);
                ch--;
                for (m = 1; m < i; m++)
                    Console.Write(--ch);
                Console.Write("\n");

                ch = 'A';
            }

        }
    }
}
