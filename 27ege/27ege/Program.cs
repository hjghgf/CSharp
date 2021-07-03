using System;
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
            int[,] minDiffs = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    minDiffs[i, j] = 10001;
                }
            }

            for (int i = 0; i < amount; i++)
            {
                string[] inp = file.ReadLine().Split(" ");
                int a = int.Parse(inp[0]);
                int b = int.Parse(inp[1]);

                maxSum += a > b ? a : b;
                int diff = Math.Abs(a - b);
                int r = diff % 3;

                if (r == 0)
                {
                    continue;
                }

                if (diff < minDiffs[r, 2] && diff >= minDiffs[r, 1])
                {
                    minDiffs[r, 2] = diff;
                }
                else if (diff < minDiffs[r, 1])
                {
                    minDiffs[r, 2] = minDiffs[r, 1];
                    minDiffs[r, 1] = diff;
                }
            }

            int remainder = maxSum % 3;

            if (remainder == 0)
            {
                Console.WriteLine(maxSum);

                return;
            }

            int firstWay = minDiffs[remainder, 1];
            int secondWay = minDiffs[3 - remainder, 1] + minDiffs[3 - remainder, 2];
            maxSum -= firstWay < secondWay ? firstWay : secondWay;

            Console.WriteLine(maxSum);

            file.Close();
        }
        static void Sorting(ref int[] mas)
        {
            for (int i = 0; i < mas.Length - 1; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        int temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
        }
        static void Task28129()
        {
            var file = new StreamReader("27.txt");

            int amount = int.Parse(file.ReadLine());
            int[] isDivisibleBy7 = new int[160];
            int[] isntDivisibleBy7 = new int[160];

            for (int i = 0; i < 160; i++)
            {
                isDivisibleBy7[i] = 0;
                isntDivisibleBy7[i] = 0;
            }

            for (int i = 0; i < amount; i++)
            {
                int a = int.Parse(file.ReadLine());

                if (a % 7 == 0 && a > isDivisibleBy7[a % 160])
                {
                    isDivisibleBy7[a % 160] = a;
                }
                else if(a % 7 != 0 && a > isntDivisibleBy7[a % 160])
                {
                    isntDivisibleBy7[a % 160] = a;
                }
            }

            Sorting(ref isDivisibleBy7);
            Sorting(ref isntDivisibleBy7);

            int[] first = { isDivisibleBy7[0], isDivisibleBy7[0], isDivisibleBy7[0], isDivisibleBy7[1], isDivisibleBy7[1] };
            int[] second = { isDivisibleBy7[1], isntDivisibleBy7[0], isntDivisibleBy7[1], isntDivisibleBy7[0], isntDivisibleBy7[1] };

            int l = 0;
            int r = 0;

            for (int i = 0; i < 5; i++)
            {
                if (first[i] != 0 && second[i] != 0 && first[i] + second[i] > l + r)
                {
                    l = first[i];
                    r = second[i];
                }
            }
            Console.WriteLine(l + " " + r);

            file.Close();
        }
        static void Task28130()
        {
            var file = new StreamReader("27.txt");

            int length = int.Parse(file.ReadLine());
            int[] moreThan50 = new int[80];
            int[] lessThan50 = new int[80];

            for (int i = 0; i < 80; i++)
            {
                moreThan50[i] = 0;
                lessThan50[i] = 0;
            }
            for (int i = 0; i < length; i++)
            {
                int a = int.Parse(file.ReadLine());
                int mod = a % 80;
                if (a>50)
                {
                    moreThan50[mod]++;
                }
                else
                {
                    lessThan50[mod]++;
                }
            }
            int sum = 0;
            for (int i = 1; i < 40; i++)
            {
                sum += moreThan50[i] * moreThan50[80 - i] + lessThan50[80 - i] * moreThan50[i] + lessThan50[i] * moreThan50[80 - i];
            }
            sum += moreThan50[0] * (moreThan50[0] - 1) / 2 + moreThan50[0] * lessThan50[0] + moreThan50[40] * (moreThan50[40] - 1) / 2 + moreThan50[40] * lessThan50[40];

            Console.WriteLine(sum);
            file.Close();
        }
        static void Task2671()
        {
            var file = new StreamReader("27.txt");

            int length = int.Parse(file.ReadLine());
            int mod = 8;
            int[] sum = new int[mod];
            for (int i = 0; i < mod; i++)
            {
                sum[i] = 0;
            }

            string[] firstInp = file.ReadLine().Split(" ");
            
            int amount = 3;
            int[] firstMas = new int[amount];
            for (int i = 0; i < amount; i++)
            {
                firstMas[i] = int.Parse(firstInp[i]);
            }

            for (int i = 0; i < 2; i++)
            {
                int r = firstMas[i] % mod;
                if (firstMas[i] > sum[r])
                {
                    sum[r] = firstMas[i];
                }
            }

            for (int i = 1; i < length; i++)
            {
                string[] inp = file.ReadLine().Split(" ");
                int[] mas = new int[amount];
                for (int j = 0; j < amount; j++)
                {
                    mas[j] = int.Parse(inp[j]);
                }
                int[] newSum = new int[mod];
                for (int j = 0; j < amount; j++)
                {
                    for (int k = 0; k < mod; k++)
                    {
                        if (sum[k] == 0)
                        {
                            continue;
                        }

                        int candidate = sum[k] + mas[j];
                        int r = candidate % mod;

                        if (candidate > newSum[r])
                        {
                            newSum[r] = candidate;
                        }
                    }
                }
                for (int j = 0; j < mod; j++)
                {
                    sum[j] = newSum[j];
                    //Console.Write(sum[l] + " ");
                }
                //Console.WriteLine();
            }
            Console.WriteLine(sum[0]);
            file.Close();
        }
        static void Task28131()
        {
            var file = new StreamReader("27.txt");

            int length = int.Parse(file.ReadLine());
            int L = 0;
            int R = 0;

            int[] mas = new int[120];
            for (int i = 0; i < 120; i++)
            {
                mas[i] = 0;
            }

            for (int i = 0; i < length; i++)
            {
                int r = int.Parse(file.ReadLine());
                int mod = r % 120;

                int l = mas[(120 - mod) % 120];

                if (l != 0 && l > r && l + r > L + R)
                {
                    L = l;
                    R = r;
                }

                if (r > mas[mod])
                {
                    mas[mod] = r;
                }
            }

            Console.WriteLine(L + " " + R);

            file.Close();
        }
        static void Task12()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");
            int lenght = int.Parse(file.ReadLine());
            int p = 5;
            int[,] max = new int[2, 2];
            for (int k = 0; k < 2; k++)
            {
                for (int j = 0; j < 2; j++)
                {
                    max[k, j] = 0;
                }
            }

            for (int i = 0; i < lenght; i++)
            {
                int a = int.Parse(file.ReadLine());
                int r = a % 7 == 0 ? 1 : 0;
                if (a > max[0, r])
                {
                    if (a % p == max[0, r] % p)
                    {
                        max[0, r] = a;
                    }
                    else
                    {
                        max[1, r] = max[0, r];
                        max[0, r] = a;
                    }
                }
                else if (a > max[1, r] && a <= max[0, r] && a % p != max[0, r] % p)
                {
                    max[1, r] = a;
                }
            }

            int[] first = { max[0, 1], max[0, 1], max[0, 1], max[1, 1], max[1, 1] };
            int[] second = { max[1, 1], max[0, 0], max[1, 0], max[0, 0], max[1, 0] };

            int n1 = 0;
            int n2 = 0;

            for (int i = 0; i < 5; i++)
            {
                if (first[i] != 0 && second[i] != 0 && first[i] + second[i] > n1 + n2)
                {
                    n1 = first[i];
                    n2 = second[i];
                }
            }
            Console.WriteLine(n1 + " " + n2);

            file.Close();
        }
        static void Task33199()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int length = int.Parse(file.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int minDiff = 10001;

            for (int i = 0; i < length; i++)
            {
                string[] inp = file.ReadLine().Split();
                int[] input = { int.Parse(inp[0]), int.Parse(inp[1]), int.Parse(inp[2]) };
                Sorting(ref input);

                sum1 += input[0];
                sum2 += input[1];
                sum3 += input[2];

                if (input[2] - input[1] < minDiff && (input[2] - input[1]) % 2 != 0)
                {
                    minDiff = input[2] - input[1];
                }
                else if (input[2] - input[0] < minDiff && (input[2] - input[0]) % 2 != 0)
                {
                    minDiff = input[2] - input[0];
                }
            }
            if (sum1 % 2 != sum2 % 2)
            {
                Console.WriteLine(sum3);
            }
            else if (minDiff != 10001)
            {
                Console.Write(sum3 - minDiff);
            }
            else
            {
                Console.WriteLine("haha");
            }
            file.Close();
        }
        static void Main(string[] args)
        {
            Task33199();
        }
    }
}