﻿using System;

namespace _06.VowelsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int wordLength = word.Length;
            int sum = 0;

            for (int i = 0; i <= wordLength - 1; i++)
            {
                char letter = word[i];

                switch (letter)
                {
                    case 'a':
                        sum++;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
