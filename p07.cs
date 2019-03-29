using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    class p07
    {
        static void Main(string[] args)
        {
            bool solved = false;
            int num = 1;
            int primeNum = 1;
            int index = 1;

            while (!solved)
            {
                bool isPrime = true;

                for (int i = 2; i < num - 1; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primeNum = num;
                    index++;
                    Console.WriteLine(num);
                }

                if (index == 10003)
                {
                    solved = true;
                }

                num++;
            }

            Console.WriteLine(primeNum);
            Console.ReadKey();
        }
    }
}