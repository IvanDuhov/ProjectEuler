using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    class p08
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,,] cube = new int[size, size, size];

            int indexX = 0;
            int indexY = 0;

            // Запълване на Матрицата
            for (int j = 0; j < size; j++)
            {
                string rowi = Console.ReadLine();
                string[] nums = rowi.Split(' ');

                List<int> pureNums = new List<int>();

                // Взимане само на числата от входните данни (Премахваме "|" и интервалите)
                for (int k = 0; k < nums.Length; k++)
                {
                    int p;
                    bool parsed = int.TryParse(nums[k], out p);

                    if (parsed)
                    {
                        pureNums.Add(p);
                    }
                }

                // Запълване на куба по редове
                for (int p = 0; p < pureNums.Count; p++)
                {
                    cube[p / size, indexX, indexY] = pureNums[p];

                    if (indexY == size - 1)
                    {
                        indexY = 0;
                    }
                    else
                    {
                        indexY++;
                    }
                }

                pureNums.RemoveRange(0, pureNums.Count - 1);
                indexX++;
            }

            // Четене на кординатите
            string coordinates = Console.ReadLine();
            string[] cooValues = coordinates.Split(' ');

            int wI = 0; int wX = 0; int wY = 0;
            int index = 0;

            // Запазване на кординатите на грешния елемент в wI,wX,wY
            for (int o = 0; o < cooValues.Length; o++)
            {
                int p;
                bool parsed = int.TryParse(cooValues[o], out p);

                if (parsed && index == 0)
                {
                    wI = p;
                    index++;
                }
                else if (parsed && index == 1)
                {
                    wX = p;
                    index++;
                }
                else if (parsed && index == 2)
                {
                    wY = p;
                    index++;
                }
            }

            // Нов куб, в който ще се заместват стойностите
            int[,,] replacedCube = new int[size, size, size];

            for (int a = 0; a < size; a++)
            {
                for (int b = 0; b < size; b++)
                {
                    for (int c = 0; c < size; c++)
                    {
                        replacedCube[a, b, c] = cube[a, b, c];
                    }
                }
            }

            // Намиране на грешния елемент
            int wrongValue = cube[wI, wX, wY];

            // Заместване на първоначалния грешен елемнт
            replacedCube[wI, wX, wY] = ReplaceValue(cube, wI, wX, wY, size, wrongValue);

            // Броя на грешните елементи в куба
            int numOfWrongValues = 0;

            // Обикаляне на куба за сгрешени елементи
            for (int i = 0; i < size; i++)
            {
                for (int x = 0; x < size; x++)
                {
                    for (int y = 0; y < size; y++)
                    {
                        // Заместване на сгрешените елементи
                        if (cube[i, x, y] == wrongValue)
                        {
                            replacedCube[i, x, y] = ReplaceValue(cube, i, x, y, size, wrongValue);
                            numOfWrongValues++;
                        }
                    }
                }
            }

            Console.WriteLine("Wrong values found and replaced: {0}", numOfWrongValues);

            // Отпечатване на вече куба с поправени стойности
            for (int i = 0; i < size; i++)
            {
                for (int x = 0; x < size; x++)
                {
                    for (int y = 0; y < size; y++)
                    {
                        Console.Write(replacedCube[i, x, y] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }

        // Намиране на стойността, с която трябва да се замести
        private static int ReplaceValue(int[,,] cube, int wI, int wX, int wY, int size, int wrong)
        {
            int sum = 0;

            if (InsideBoundary(wI - 1, size) && (cube[wI - 1, wX, wY] != wrong))
            {
                sum += cube[wI - 1, wX, wY];
            }
            if (InsideBoundary(wI + 1, size) && (cube[wI + 1, wX, wY] != wrong))
            {
                sum += cube[wI + 1, wX, wY];
            }

            if (InsideBoundary(wX - 1, size) && (cube[wI, wX - 1, wY] != wrong))
            {
                sum += cube[wI, wX - 1, wY];
            }
            if (InsideBoundary(wX + 1, size) && (cube[wI, wX + 1, wY] != wrong))
            {
                sum += cube[wI, wX + 1, wY];
            }

            if (InsideBoundary(wY + 1, size) && (cube[wI, wX, wY + 1] != wrong))
            {
                sum += cube[wI, wX, wY + 1];
            }
            if (InsideBoundary(wY - 1, size) && (cube[wI, wX, wY - 1] != wrong))
            {
                sum += cube[wI, wX, wY - 1];
            }

            return sum;
        }

        // Проверка дали елемент с дадени индекси съществува в куба
        private static bool InsideBoundary(int value, int size)
        {
            if ((value >= 0) && (value <= (size - 1)))
            {
                return true;
            }

            return false;
        }
    }
}