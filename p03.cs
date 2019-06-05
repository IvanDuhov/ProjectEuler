using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    class p03
    {
        static void Main(string[] args)
        {
            int largestPalindrome = 0;

            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    int possiblePalindrome = i * j;
                    string palin = possiblePalindrome.ToString();

                    bool isPalindrome = true;

                    for (int k = 0; k < palin.Length; k++)
                    {
                        if (palin[k] != palin[palin.Length - k - 1])
                        {
                            isPalindrome = false;
                            break;
                        }
                    }

                    if (isPalindrome && (possiblePalindrome > largestPalindrome))
                    {
                        largestPalindrome = possiblePalindrome;
                    }
                }
            }

            Console.WriteLine(largestPalindrome);
            Console.ReadKey();
        }
    }
}