using System;

namespace ProjectEuler
{
    class p02
    {
        static void Main(string[] args)
        {
            int f0 = 0;
            int f1 = 1;
            int f2 = 0;

            int sum = 0;

            while (f2 <= 4000000)
            {
                f2 = f0 + f1;
                f0 = f1;
                f1 = f2;

                if (f2 % 2 ==0)
                {
                    sum += f2;
                }
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
