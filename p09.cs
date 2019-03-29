using System;

namespace ProjectEuler
{
    class p09
    {
        static void Main(string[] args)
        {
            for (int a = 0; a < 999; a++)
            {
                for (int b = 0; b < 998; b++)
                {
                    for (int c = 0; c < 997; c++)
                    {
                        if (a < b && b < c)
                        {
                            if ((a * a + b * b == c * c) && (a + b + c == 1000))
                            {
                                Console.WriteLine(a * b * c);
                                break;
                            }
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}