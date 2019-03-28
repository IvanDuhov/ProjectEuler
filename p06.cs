using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    class p06
    {
        static void Main(string[] args)
        {
            int sumOfSquares = 0;
            uint squareOfTheSum = 0;

            for (int i = 1; i < 101; i++)
            {
                sumOfSquares += i * i;
            }

            for (int i = 1; i < 101; i++)
            {
                squareOfTheSum += uint.Parse(i.ToString());
            }
            squareOfTheSum *= squareOfTheSum;

            Console.WriteLine(squareOfTheSum - sumOfSquares);
            Console.ReadKey();
        }
    }
}