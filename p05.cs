using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    class p05
    {
        static void Main(string[] args)
        {
            bool solved = false;

            uint num = 20;

            while (!solved)
            {
                bool isDividedWithNoRemainder = true;

                for (int i = 1; i < 21; i++)
                {
                    if (num % i != 0)
                    {
                        isDividedWithNoRemainder = false;
                        break;
                    }
                }

                if (isDividedWithNoRemainder)
                {
                    solved = true;
                }
                else
                {
                    num++;
                }
            }

            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}