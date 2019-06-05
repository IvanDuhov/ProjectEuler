using System;

namespace ProjectEuler
{
    class p10
    {
        public static void Main()
        {
            long sum = 0; // Was originally an int. Thanks Soner Gönül!
            for (int i = 1; i < 2000000; i++)
            {
                if (IsPrime(i))
                    sum += i;
            }
            System.Console.WriteLine(sum);
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;

            for (int i = 3; i * i < number; i += 2)
            {
                if ((number % i) == 0)
                    return false;
            }

            return true;
        }
    }
}
