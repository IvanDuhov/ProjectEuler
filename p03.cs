using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    class p03
    {
        static void Main(string[] args)
        {
            long n = 600851475143;
            long k = 1;

            List<long> factors = new List<long>();

            long res = 0;

            while (k * k < n)
            {
                if (n % k == 0)
                {
                    factors.Add(k);
                }
                
                k++;
            }

            for (int i = 0; i < factors.Count; i++)
            {
                res = factors.Max();
                bool isPrime = true;

                for (int j = 2; j < res / 2; j++)
                {
                    if (res % j == 0)
                    {
                        isPrime = false;
                        factors.Remove(res);
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine($"The largest prime factor is: {res}");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
