using System;

namespace _10.OddEvenSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfRows = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;

            for (int value = 1; value <= numOfRows; value++)
            {
                int curNumber = int.Parse(Console.ReadLine());
                if (value % 2 == 0)
                {
                    evenSum += curNumber;
                }
                else
                {
                    oddSum += curNumber;
                }
            }
            if (evenSum == oddSum)
            {
                Console.WriteLine($"Yes\r\nSum = {evenSum}");
            }
            else
            {
                Console.WriteLine($"No \r\nDiff = {Math.Abs(evenSum - oddSum)}");
            }
        }
    }
}
