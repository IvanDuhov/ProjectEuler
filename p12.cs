using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    class p12
    {
        public static void Main()
        {
            uint index = 1;
            long num = 1;
            Console.WriteLine(Divisors(16));

            while (!(Divisors(num) > 500))
            {
                index++;
                num += index;
                Console.WriteLine(num);
            }

            Console.WriteLine(num);
        }

        public static uint Divisors(long num)
        {
            uint res = 0;
            uint sqrt = (uint)(Math.Sqrt(num));

            for (int i = 1; i <= sqrt; i++)
            {
                if (num % i == 0)
                {
                    res += 2;
                }
            }

            // if the number is a perfect square we need to remove 2 divisors
            if (sqrt * sqrt == num)
            {
                res -= 2;
            }

            return res;
        }
    }

}
