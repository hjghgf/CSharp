﻿using System;
using System.IO;

namespace _27ege
{
    class Program
    {
        static void Task27891()
        {
            var file = new StreamReader("27.txt");

            int amount = int.Parse(file.ReadLine());
            int max7 = 0;
            int max2 = 0;
            int max14 = 0;
            int max = 0;

            for (int i = 0; i < amount; i++)
            {
                string inp = file.ReadLine();
                int a = int.Parse(inp);

                if (a % 2 == 0 && a % 7 != 0 && a > max2)
                {
                    max2 = a;
                }

                else if (a % 7 == 0 && a % 2 != 0 && a > max7)
                {
                    max7 = a;
                }

                else if (a % 14 == 0 && a > max14)
                {
                    max14 = a;
                }

                else if (a % 7 != 0 && a % 2 != 0 && a > max)
                {
                    max = a;
                }
            }

            int maxCmp = 1;

            if (max14 * max > max7 * max2)
            {
                maxCmp = max14 * max;
            }
            else
            {
                maxCmp = max2 * max7;
            }

            Console.WriteLine(maxCmp);
            file.Close();
        }

        static void Task27424()
        {
            var file = new StreamReader("27.txt");

            int amount = int.Parse(file.ReadLine());
            int maxSum = 0;
            int minDiff = 10001;

            for(int i = 0; i < amount; i++)
            {
                string[] inp = file.ReadLine().Split("  ");
                int a = int.Parse(inp[0]);
                int b = int.Parse(inp[1]);
                maxSum += a > b ? a : b;
                int diff = Math.Abs(a - b);
                if (diff < minDiff && diff % 3 != 0)
                {
                    minDiff = diff;
                }
            }

            if (maxSum % 3 != 0)
            {
                Console.WriteLine(maxSum);
            }
            else if (minDiff != 10001)
            {
                Console.WriteLine(maxSum - minDiff);
            }
            else
            {
                Console.WriteLine("no");
            }

            file.Close();
        }
        static void Task27986()
        {
            var file = new StreamReader("27.txt");

            int max7 = 0;
            int max = 0;
            int a = int.Parse(file.ReadLine());
            while (a != 0)
            {
                if (a > max7 && a % 7 == 0 && a % 49 != 0)
                {
                    max7 = a;
                }
                else if (a > max && a % 7 != 0)
                {
                    max = a;
                }
                a = int.Parse(file.ReadLine());
            }
            int maxComp = max * max7;
            if (maxComp != 0)
            {
                Console.WriteLine(maxComp);
            }
            else
            {
                Console.WriteLine("1");
            }

            file.Close();

        }
        static void Task27989()
        {
            var file = new StreamReader("27.txt");

            int amount = int.Parse(file.ReadLine());
            int amount2 = 0;
            int amount13 = 0;
            int amount26 = 0;
            for (int i = 0; i < amount; i++)
            {
                int a = int.Parse(file.ReadLine());
                if (a % 2 == 0 && a % 13 != 0)
                {
                    amount2++;
                }
                else if (a % 13 == 0 && a % 2 != 0)
                {
                    amount13++;
                }
                else if (a % 26 == 0)
                {
                    amount26++;
                }
            }
            int amountFin = amount13 * amount2 + amount26 * (amount - amount26) + amount26 * (amount26 - 1) / 2;
            Console.WriteLine(amountFin);

            file.Close();
        }
        static void Task27991()
        {
            var file = new StreamReader("27.txt");

            int amount = int.Parse(file.ReadLine());
            int a1 = 0;
            int a2 = 0;
            int a3 = 0;
            int b1 = 0;
            int b2 = 0;
            int b3 = 0;

            for (int i = 0; i < amount; i++)
            {
                int number = int.Parse(file.ReadLine());
                if (number % 2 == 0 && number % 17 == 0)
                {
                    if (number > a1)
                    {
                        a2 = a1;
                        a1 = number;
                    }
                    else if (number > a2 && number <= a1)
                    {
                        a2 = number;
                    }
                }
                else if (number % 2 == 0 && number % 17 != 0 && number > a3)
                {
                    a3 = number;
                }
                else if (number % 2 != 0 && number % 17 != 0)
                {
                    if (number > b1)
                    {
                        b2 = b1;
                        b1 = number;
                    }
                    else if (number > b2 && number <= b1)
                    {
                        b2 = number;
                    }
                }
                else if (number % 2 != 0 && number % 17 != 0 && number > b3)
                {
                    b3 = number;
                }
            }

            int[] x = { a1, a1, b1, b1 };
            int[] y = { a2, a3, b2, b3 };

            int l = 0;
            int r = 0;

            for (int i = 0; i < 4; i++)
            {
                if (x[i] != 0 && y[i] != 0 && x[i] + y[i] > l + r)
                {
                    l = x[i];
                    r = y[i];
                }
            }

            Console.WriteLine(l + " " + r);

            file.Close();
        }
        static void Task28128()
        {
            var file = new StreamReader("27.txt");

            int amount = int.Parse(file.ReadLine());
            int R = 0;
            int max1 = -1;
            int max2 = -1;
            int max3_1 = -1;
            int max3_2 = -1;

            for (int i = 0; i < amount; i++)
            {
                int a = int.Parse(file.ReadLine());
                switch (a % 3)
                {
                    case 1:
                        {
                            if (a > max1)
                            {
                                max1 = a;
                            }
                            break;
                        }
                    case 2:
                        {
                            if (a > max2)
                            {
                                max2 = a;
                            }
                            break;
                        }
                    case 0:
                        {
                            if (a > max3_1)
                            {
                                max3_2 = max3_1;
                                max3_1 = a;
                            }
                            else if (a > max3_2 && a <= max3_1)
                            {
                                max3_2 = a;
                            }
                            break;
                        }
                }
            }
            R = max1 + max2 > max3_1 + max3_2 ? max1 + max2 : max3_1 + max3_2;
            Console.WriteLine(R);

            file.Close();
        }
        static void Task29765()
        {
            var file = new StreamReader("27.txt");

            int amount = int.Parse(file.ReadLine());
            int maxSum = 0;
            int minDiff1 = 10001;
            int minDiff2 = 10001;

            for (int i = 0; i < amount; i++)
            {
                string[] inp = file.ReadLine().Split("  ");
                int a = int.Parse(inp[0]);
                int b = int.Parse(inp[1]);

                maxSum += a > b ? a : b;
                int diff = Math.Abs(a - b);
                if (diff < minDiff1 && diff % 3 ==1)
                {
                    minDiff1 = diff;
                }
                else if (diff < minDiff1 && diff % 3 == 2)
                {
                    minDiff2 = diff;
                }
            }
            if (maxSum%3==1)
            {
                maxSum -= minDiff1;//< 2 * minDiff2 ? minDiff1 : minDiff2;
            }
            else if (maxSum%3==2)
            {
                maxSum -= minDiff2;//< 2 * minDiff1 ? minDiff2 : minDiff1;
            }
            Console.WriteLine(maxSum);
            file.Close();
        }
        static void Main(string[] args)
        {
            Task29765();
        }
    }
}