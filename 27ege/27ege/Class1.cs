using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27ege
{
    class Class1
    {
        public static void Task27891()
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

            for (int i = 0; i < amount; i++)
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
                else if (a % 7 != 0 && a > isntDivisibleBy7[a % 160])
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
                if (a > 50)
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

                if (input[2] - input[0] < minDiff && (input[2] - input[0]) % 2 != 0)
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

        static void Task35485()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");
            int length = int.Parse(file.ReadLine());

            int[,] max = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    max[i, j] = 0;
                }
            }

            for (int i = 0; i < length; i++)
            {
                int a = int.Parse(file.ReadLine());
                int mod = a % 3;
                if (a > max[mod, 2])
                {
                    max[mod, 0] = max[mod, 1];
                    max[mod, 1] = max[mod, 2];
                    max[mod, 2] = a;
                }
                else if (a > max[mod, 1] && a <= max[mod, 2])
                {
                    max[mod, 0] = max[mod, 1];
                    max[mod, 1] = a;
                }
                else if (a > max[mod, 0] && a <= max[mod, 1])
                {
                    max[mod, 0] = a;
                }
            }

            int[] sum = { 0, 0, 0, 0 };

            for (int mod = 0; mod < 3; mod++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (max[mod, i] == 0)
                    {
                        sum[mod] = 0;
                        break;
                    }

                    sum[mod] += max[mod, i];
                }
            }

            for (int mod = 0; mod < 3; mod++)
            {
                if (max[mod, 2] == 0)
                {
                    sum[3] = 0;
                    break;
                }

                sum[3] += max[mod, 2];
            }

            int maxSum = 0;
            for (int i = 0; i < 4; i++)
            {
                if (sum[i] > maxSum)
                {
                    maxSum = sum[i];
                }
            }

            Console.Write(maxSum);

            file.Close();
        }

        static void Task36040()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");
            int length = int.Parse(file.ReadLine());

            long maxSum = 0;
            int minDiff = 20001;

            for (int i = 0; i < length; i++)
            {
                string[] inp = file.ReadLine().Split();
                int[] arr = { int.Parse(inp[0]), int.Parse(inp[1]), int.Parse(inp[2]) };
                Sorting(ref arr);

                int diff21 = arr[2] - arr[1];
                int diff20 = arr[2] - arr[0];

                if (diff21 < minDiff && diff21 % 109 != 0)
                {
                    minDiff = diff21;
                }

                if (diff20 < minDiff && diff20 % 109 != 0)
                {
                    minDiff = diff20;
                }

                maxSum += arr[2];
            }

            if (maxSum % 109 != 0)
            {
                Console.WriteLine(maxSum);
            }
            else if (minDiff != 20001)
            {
                Console.WriteLine(maxSum - minDiff);
            }
            else
            {
                Console.WriteLine("no solution ;(");
            }

            file.Close();

        }

        static void Task29673()
        {
            for (int num = 123456789; num < 223456789; num++)
            {
                int divider = 0;
                double root1 = Math.Sqrt(num);
                double root2 = Math.Floor(root1);

                if (root1 == root2)
                {
                    int count = 0;

                    for (int i = 2; i < Math.Sqrt(num); i++)
                    {
                        if (num % i == 0)
                        {
                            count++;
                            if (count > 1)
                            {
                                break;
                            }

                            divider = i;
                        }

                    }

                    if (count == 1)
                    {
                        Console.WriteLine(num + " " + num / divider);
                    }
                }
            }
        }

        static void Task36882()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");
            int length = int.Parse(file.ReadLine());

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < length; i++)
            {
                string[] inp = file.ReadLine().Split();
                int a = int.Parse(inp[0]);
                int b = int.Parse(inp[1]);

                if (b % 2 != 0)
                {
                    sum1 += b > a ? b : a;
                    sum2 += b < a ? b : a;
                }
            }

            file.Close();
        }

        static void Task37162()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");
            int length = int.Parse(file.ReadLine());

            int mod = 89;
            int sum = 0;
            int[,] r = new int[mod, 2];
            int maxSum = 0;
            int minLength = 68001;

            r[0, 0] = 0;
            r[0, 1] = 0;

            for (int i = 1; i < mod; i++)
            {
                r[i, 0] = -1;
                r[i, 1] = 0;
            }

            for (int i = 0; i < length; i++)
            {
                int a = int.Parse(file.ReadLine());

                sum += a;
                int rem = sum % mod;

                if (r[rem, 0] == -1)
                {
                    r[rem, 0] = sum;
                    r[rem, 1] = i + 1;
                }
                else
                {
                    int max = sum - r[rem, 0];
                    int size = i + 1 - r[rem, 1];

                    if (max > maxSum)
                    {
                        maxSum = max;
                        minLength = size;
                    }
                    else if (maxSum == max)
                    {
                        if (size < minLength)
                        {
                            minLength = size;
                        }
                    }

                }

            }

            Console.WriteLine(minLength + " " + maxSum);

            file.Close();
        }

        static void Task9211()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");
            int length = int.Parse(file.ReadLine());

            int max3_1 = 0;
            int max3_2 = 0;
            int max1 = 0;
            int max2 = 0;

            for (int i = 0; i < length; i++)
            {
                int a = int.Parse(file.ReadLine());
                int rem = a % 3;
                if (rem == 0)
                {
                    if (a >= max3_1)
                    {
                        max3_2 = max3_1;
                        max3_2 = a;
                    }
                    else if (a >= max3_2 && a < max3_1)
                    {
                        max3_2 = a;
                    }
                }
                if (rem == 1 && a > max1)
                {
                    max1 = a;
                }
                if (rem == 2 && a > max2)
                {
                    max2 = a;
                }
            }

            int sum1 = max3_1 + max3_2;
            int sum2 = max1 + max2;
            int R = 1;

            if (max3_1 != 0 && max3_2 != 0 && sum1 > sum2)
            {
                R = sum1;
            }
            else if (max1 != 0 && max2 != 0 && sum2 > sum1)
            {
                R = sum2;
            }
            int r = int.Parse(file.ReadLine());

            Console.Write("контрольное знчаение: " + r);

            if (r == R)
            {
                Console.WriteLine("контроль пройден");
            }
            else
            {
                Console.WriteLine("контроль не пройден");
            }

            file.Close();

        }

        static void Task9662()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");
            int length = int.Parse(file.ReadLine());

            int max2 = 0;
            int max13 = 0;
            int max0_1 = 0;
            int max = 0;
            int max0_2 = 0;

            for (int i = 0; i < length; i++)
            {
                int a = int.Parse(file.ReadLine());

                if (a % 2 == 0 && a % 13 != 0 && a > max2)
                {
                    max2 = a;
                }
                else if (a % 13 == 0 && a % 2 != 0 && a > max13)
                {
                    max13 = a;
                }
                else if (a % 26 == 0)
                {
                    if (a >= max0_1)
                    {
                        max0_2 = max0_1;
                        max0_2 = a;
                    }
                    else if (a >= max0_2 && a < max0_1)
                    {
                        max0_2 = a;
                    }

                }
                else if (a > max)
                {
                    max = a;
                }
            }

            int[] prod = { max0_1 * max0_2, max0_1 * max, max0_1 * max13, max0_1 * max2, max13 * max2 };
            Sorting(ref prod);

            Console.WriteLine(prod[4]);

            file.Close();
        }

        class Element
        {
            public int del19_1 = 0;
            public int del19_2 = 0;
            public int neDel19 = 0;
        }

        static void Task25963()
        {
            int n = int.Parse(Console.ReadLine());
            Element[] max = new Element[2];

            for (int i = 0; i < 2; i++)
            {
                max[i] = new Element();
            }

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                int rem = a % 2;

                if (a % 19 == 0)
                {
                    if (a >= max[rem].del19_1)
                    {
                        max[rem].del19_2 = max[rem].del19_1;
                        max[rem].del19_1 = a;
                    }
                    else if (a >= max[rem].del19_2 && a < max[rem].del19_1)
                    {
                        max[rem].del19_2 = a;
                    }
                }
                else if (a > max[rem].neDel19)
                {
                    max[rem].neDel19 = a;
                }
            }

            int[] sum1 = { max[0].del19_1, max[0].del19_1, max[1].del19_1, max[1].del19_1 };
            int[] sum2 = { max[0].del19_2, max[0].neDel19, max[1].del19_2, max[1].neDel19 };

            int maxSum = 0;
            int k = 0;
            int m = 0;

            for (int i = 0; i < 4; i++)
            {
                int currentSum = sum1[i] + sum2[i];
                if (currentSum > maxSum && sum1[i] * sum2[i] != 0)
                {
                    maxSum = currentSum;
                    k = sum1[i];
                    m = sum2[i];
                }
            }

            Console.WriteLine(k + " " + m);
        }

        static void Task15812()
        {
            int n = int.Parse(Console.ReadLine());
            int amount23 = 0;
            int amount2 = 0;
            int amount3 = 0;
            int amount0 = 0;

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a % 2 == 0 && a % 3 == 0)
                {
                    amount23++;
                }
                else if (a % 2 == 0 && a % 3 != 0)
                {
                    amount2++;
                }
                else if (a % 3 == 0 && a % 2 != 0)
                {
                    amount3++;
                }
                else
                {
                    amount0++;
                }
            }
            int res = amount23 * amount3 + amount23 * amount0 + amount2 * amount3;
            Console.WriteLine(res);
        }

        static void Task15937()
        {
            int n = int.Parse(Console.ReadLine());

            int max0 = 0;
            int max2 = 0;
            int max3 = 0;
            int max23 = 0;

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a % 2 == 0 && a % 3 == 0 && a > max23)
                {
                    max23 = a;
                }
                else if (a % 2 == 0 && a % 3 != 0 && a > max2)
                {
                    max2 = a;
                }
                else if (a % 3 == 0 && a % 2 != 0 && a > max3)
                {
                    max3 = a;
                }
                else if (a > max0)
                {
                    max0 = a;
                }
            }

            int m1 = 0;
            int m2 = 0;
            int maxProd = 0;

            int[] prod1 = { max23, max23, max3 };
            int[] prod2 = { max0, max3, max2 };

            for (int i = 0; i < 3; i++)
            {
                int currentProd = prod1[i] * prod2[i];
                if (currentProd > maxProd)
                {
                    m1 = prod1[i];
                    m2 = prod2[i];
                }

            }

            if (m1 * m2 != 0)
            {
                Console.WriteLine(m1 + " " + m2);
            }
            else
            {
                Console.WriteLine("0");
            }
        }

        static void Task18729()
        {
            int n = int.Parse(Console.ReadLine());
            int[] rem = new int[117];

            for (int i = 0; i < 117; i++)
            {
                rem[i] = 0;
            }

            int R = 0;
            int L = 0;

            for (int i = 0; i < n; i++)
            {
                int r = int.Parse(Console.ReadLine());
                int remainder = r % 117;
                int l = rem[(117 - remainder) % 117];

                if (l != 0 && l > r && l + r > R + L)
                {
                    L = l;
                    R = r;
                }

                if (r > rem[remainder])
                {
                    rem[remainder] = r;
                }
            }
            Console.WriteLine(L + " " + R);
        }

        static void AnnoyingTask2()
        {
            int mod = 80;

            int[] moreThan50 = new int[mod];
            int[] lessOrEqualThan50 = new int[mod];

            int res = (moreThan50[0] * (moreThan50[0] - 1)) / 2 + moreThan50[0] * lessOrEqualThan50[0];

            for (int i = 1; i < mod / 2; i++)
            {
                res += moreThan50[i] * lessOrEqualThan50[mod - i] + moreThan50[i] * moreThan50[mod - i] + lessOrEqualThan50[i] * moreThan50[mod - i];
            }

            if (mod % 2 == 0)
            {
                res += (moreThan50[mod / 2] * (moreThan50[mod / 2] - 1)) / 2 + moreThan50[mod / 2] * lessOrEqualThan50[mod / 2];
            }
        }

        static void Task27285()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int n = int.Parse(file.ReadLine());
            int maxDiff = 0;
            int L = 0;
            int R = 0;

            int[] rem = new int[80];
            for (int i = 0; i < 80; i++)
            {
                rem[i] = 0;
            }

            for (int i = 0; i < n; i++)
            {
                int r = int.Parse(file.ReadLine());
                int remainder = r % 80;
                int l = rem[remainder];

                int currentDiff = Math.Abs(l - r);
                if (currentDiff > maxDiff && l != 0)
                {
                    maxDiff = currentDiff;
                    L = l;
                    R = r;
                }
                if (r > rem[remainder])
                {
                    rem[remainder] = r;
                }
            }
            Console.WriteLine(R + " " + L);

            file.Close();
        }

        static void Task9777()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int n = int.Parse(file.ReadLine());
            int maxX = 0;
            int maxY = 0;

            for (int i = 0; i < n; i++)
            {
                string[] inp = file.ReadLine().Split();
                int x = Math.Abs(int.Parse(inp[0]));
                int y = Math.Abs(int.Parse(inp[1]));

                if (x > maxX && y == 0)
                {
                    maxX = x;
                }
                else if (y > maxY && x == 0)
                {
                    maxY = y;
                }
            }

            int S = maxX * maxY / 2;
            if (S != 0)
            {
                Console.WriteLine(S);
            }
            else
            {
                Console.WriteLine("треугольника не существует");
            }

            file.Close();
        }

        static void Task9813()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int n = int.Parse(file.ReadLine());
            int minX = 0;
            int minY = 0;

            for (int i = 0; i < n; i++)
            {
                string[] inp = file.ReadLine().Split();
                int x = Math.Abs(int.Parse(inp[0]));
                int y = Math.Abs(int.Parse(inp[1]));

                if (x < minX && y == 0)
                {
                    minX = x;
                }
                else if (y < minY && x == 0)
                {
                    minY = y;
                }
            }

            int S = minX * minY / 2;
            if (S != 0)
            {
                Console.WriteLine(S);
            }
            else
            {
                Console.WriteLine("треугольника не существует");
            }
            file.Close();
        }

        static void Task4862()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int n = int.Parse(file.ReadLine());
            int[,] parameters = new int[2, 3];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 1; j < 3; j++)
                {
                    parameters[i, j] = 0;
                }
            }

            parameters[0, 0] = int.MaxValue;
            parameters[1, 0] = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                string[] inp = file.ReadLine().Split();
                int x = int.Parse(inp[0]);
                int y = int.Parse(inp[1]);
                int pos = y > 0 ? 0 : 1;

                x = Math.Abs(x);
                y = Math.Abs(y);

                if (x == 0)
                {
                    if (parameters[pos, 0] == int.MaxValue)
                    {
                        parameters[pos, 0] = y;
                    }

                    if (y > parameters[pos, 1])
                    {
                        parameters[pos, 1] = y;
                    }
                    else if (y < parameters[pos, 0])
                    {
                        parameters[pos, 0] = y;
                    }
                }
                else if (x != 0 && y != 0 && x > parameters[pos, 2])
                {
                    parameters[pos, 2] = x;
                }
            }

            int a0 = parameters[0, 1] - parameters[0, 0];
            int a1 = parameters[1, 1] - parameters[1, 0];

            double s0 = (a0 * parameters[0, 2]);
            double s1 = (a1 * parameters[1, 2]);

            double s = s0 > s1 ? s0 / 2 : s1 / 2;

            Console.WriteLine("{0:f}", s);

            file.Close();
        }

        static void Task5258()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int n = int.Parse(file.ReadLine());

            int[] quarters = { 0, 0, 0, 0 };
            int[,] points = new int[2, 4];

            int k = 0;
            int M = 0;
            int R = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    points[i, j] = 0;
                }
            }

            for (int i = 0; i < n; i++)
            {
                string[] inp = file.ReadLine().Split();
                int x = int.Parse(inp[0]);
                int y = int.Parse(inp[1]);
                int q = 0;

                if (x > 0 && y > 0)
                {
                    q = 0;
                    quarters[q]++;
                }
                else if (x > 0 && y < 0)
                {
                    q = 1;
                    quarters[q]++;
                }
                else if (x < 0 && y < 0)
                {
                    q = 2;
                    quarters[q]++;
                }
                else if (x < 0 && y > 0)
                {
                    q = 3;
                    quarters[q]++;
                }

                if (x < points[0, q] || y < points[1, q])
                {
                    points[0, q] = x;
                    points[1, q] = y;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                int r = Math.Abs(points[0, i]) < Math.Abs(points[1, i]) ? Math.Abs(points[0, i]) : Math.Abs(points[1, i]);

                if (quarters[i] >= M && R != r)
                {
                    k = i + 1;
                    R = r;
                    M = quarters[i];
                }
                else if (quarters[i] == M && R == r)
                {
                    k = k < i + 1 ? k : i + 1;
                }
            }

            Console.WriteLine("k = " + k);
            Console.WriteLine("M = " + M);
            Console.WriteLine("A (" + points[0, k - 1] + "; " + points[1, k - 1] + ")");
            Console.WriteLine("R = " + R);

            file.Close();
        }

        static void Task6906()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int n = int.Parse(file.ReadLine());

            int maxX = int.MinValue;
            int minX = int.MaxValue;
            int maxPosY = int.MinValue;
            int maxNegY = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                string[] inp = file.ReadLine().Split();
                int x = int.Parse(inp[0]);
                int y = int.Parse(inp[1]);
                if (y == 0)
                {
                    if (x > maxX)
                    {
                        maxX = x;
                    }
                    else if (x < minX)
                    {
                        minX = x;
                    }
                }
                else
                {
                    if (y > maxPosY)
                    {
                        maxPosY = y;
                    }
                    else if (y < maxNegY)
                    {
                        maxNegY = y;
                    }
                }
            }

            maxNegY = Math.Abs(maxNegY);

            double s = (maxX - minX) * (maxPosY + maxNegY) / 2;
            Console.WriteLine(s);

            file.Close();
        }

        static void Task10401()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int n = int.Parse(file.ReadLine());
            int[] quarters = { 0, 0, 0, 0, 0 };
            for (int i = 0; i < n; i++)
            {
                string[] inp = file.ReadLine().Split();
                int x = int.Parse(inp[0]);
                int y = int.Parse(inp[1]);

                if (x > 0 && y > 0)
                {
                    quarters[1]++;
                }
                else if (x > 0 && y < 0)
                {
                    quarters[2]++;
                }
                else if (x < 0 && y < 0)
                {
                    quarters[3]++;
                }
                else if (x < 0 && y > 0)
                {
                    quarters[4]++;
                }
            }
            int a = quarters[1];
            int b = quarters[2];
            int c = quarters[3];
            int d = quarters[4];

            int res = a * b + a * d + b * c + d * c;
            Console.WriteLine(res);

            file.Close();
        }

        static void Task6436()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int n = int.Parse(file.ReadLine());
            int[,] points = new int[2, 16];

            for (int j = 0; j < 16; j++)
            {
                points[1, j] = 0;
            }
            for (int i = 0; i < 16; i++)
            {
                points[0, i] = i + 1;
            }

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(file.ReadLine());
                points[1, a - 1]++;
            }

            for (int i = 0; i < 15; i++)
            {
                for (int j = i + 1; j < 16; j++)
                {
                    if (points[1, i] < points[1, j])
                    {
                        int temp = points[1, i];
                        points[1, i] = points[1, j];
                        points[1, j] = temp;

                        int temp2 = points[0, i];
                        points[0, i] = points[0, j];
                        points[0, j] = temp2;
                    }
                }
            }

            Console.WriteLine();
            for (int i = 0; i < 16; i++)
            {
                if (points[1, i] != 0)
                {
                    Console.WriteLine(points[0, i] + " " + points[1, i]);
                }
            }

            file.Close();
        }

        static int SumOfDigits(int number, int mod)
        {
            int sum = 0;

            while (number != 0)
            {
                sum += number % mod;
                number /= mod;
            }

            return sum;
        }

        static void Task5375()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int n = int.Parse(file.ReadLine());
            int amountNeg = 0;
            double maxNeg = -Math.Pow(10, 9);
            int maxNeg_i = 0;
            int zero_i = 0;

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(file.ReadLine());

                if (a < 0)
                {
                    amountNeg++;
                    if (a > maxNeg)
                    {
                        maxNeg = a;
                        maxNeg_i = i;
                    }
                }

                if (a == 0)
                {
                    zero_i = i;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (i != zero_i && (amountNeg % 2 == 0 || i != maxNeg_i))
                {
                    Console.Write((i + 1) + "  ");
                }
            }
            file.Close();
        }

        static void Task5471()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int n = int.Parse(file.ReadLine());
            int amountOdd = 0;
            double minOdd = Math.Pow(10, 9);
            int minOdd_i = 0;
            int zero_i = 0;

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(file.ReadLine());

                if (a % 2 != 0)
                {
                    amountOdd++;
                    if (a < minOdd)
                    {
                        minOdd = a;
                        minOdd_i = i;
                    }
                }

                if (a == 0)
                {
                    zero_i = i;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (i != zero_i && (amountOdd % 2 == 0 || i != minOdd_i))
                {
                    Console.Write((i + 1) + "  ");
                }
            }

            file.Close();
        }

        static void Task5631()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int n = int.Parse(file.ReadLine());
            int count = 0;
            double minEl = 1000001;

            for (int i = 0; i < n; i++)
            {
                double a = double.Parse(file.ReadLine());
                if (a > 1)
                {
                    count++;
                    if (a < minEl)
                    {
                        minEl = a;
                    }
                }
            }
            Console.WriteLine(count + " " + minEl);
            file.Close();
        }

        static void Task11256()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int n = int.Parse(file.ReadLine());

            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int n4 = 0;

            for (int i = 0; i < n; i++)
            {
                string[] inp = file.ReadLine().Split();
                int x = int.Parse(inp[0]);
                int y = int.Parse(inp[1]);

                if (x > 0 && y > 0)
                {
                    n1++;
                }
                else if (x < 0 && y > 0)
                {
                    n2++;
                }
                else if (x < 0 && y < 0)
                {
                    n3++;
                }
                else if (x > 0 && y < 0)
                {
                    n4++;
                }
            }

            int s = (n1 * (n1 - 1) * n2 + n2 * (n2 - 1) * n1 + n3 * (n3 - 1) * n4 + n4 * (n4 - 1) * n3) / 2;
            Console.WriteLine(s);

            file.Close();
        }

        static void Task7772()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int n = int.Parse(file.ReadLine());
            int[] buffer = { 0, 0, 0, 0, 0, 0, 0, 0 };
            int max = 0;
            int maxProd = 0;

            for (int i = 0; i < 8; i++)
            {
                buffer[i] = int.Parse(file.ReadLine());
            }

            for (int i = 8; i < n; i++)
            {
                int x = int.Parse(file.ReadLine());

                if (buffer[0] > max)
                {
                    max = buffer[0];
                }

                if (x * max > maxProd)
                {
                    maxProd = x * max;
                }

                for (int j = 1; j < 8; j++)
                {
                    buffer[j - 1] = buffer[j];
                }

                buffer[7] = x;
            }

            Console.WriteLine(maxProd);
            file.Close();
        }

        static void Task8115()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int n = int.Parse(file.ReadLine());
            int[] buffer = new int[6];
            int min = 100001;
            int minProd = 100001;

            for (int i = 0; i < 6; i++)
            {
                buffer[i] = int.Parse(file.ReadLine());
            }
            for (int i = 6; i < n; i++)
            {
                int x = int.Parse(file.ReadLine());

                if (buffer[0] < min && buffer[0] % 2 != 0)
                {
                    min = buffer[0];
                }

                if (min * x < minProd && x % 2 != 0)
                {
                    minProd = min * x;
                }

                for (int j = 1; j < 6; j++)
                {
                    buffer[j - 1] = buffer[j];
                }

                buffer[5] = x;
            }
            Console.WriteLine(minProd);
            file.Close();

        }

        static int Charachteristic(int number)
        {
            if (number % 6 == 0)
            {
                return 6;
            }
            else if (number % 2 == 0 && number % 3 != 0)
            {
                return 2;
            }
            else if (number % 3 == 0 && number % 2 != 0)
            {
                return 3;
            }
            else if (number % 3 != 0 && number % 2 != 0)
            {
                return 0;
            }

            return -1;
        }

        static void Task16830()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int amount = int.Parse(file.ReadLine());

            int[] n = new int[7];
            for (int i = 0; i < 7; i++)
            {
                n[i] = 0;
            }

            int[] buffer = new int[6];

            for (int i = 0; i < 6; i++)
            {
                buffer[i] = int.Parse(file.ReadLine());
            }

            int answer = 0;

            for (int i = 0; i < amount; i++)
            {
                int x = int.Parse(file.ReadLine());

                ++n[Charachteristic(buffer[0])];

                switch (Charachteristic(x))
                {
                    case 6:
                        answer += n[2] + n[3] + n[6] + n[0];
                        break;
                    case 3:

                    default:
                        break;
                }
            }

            file.Close();
        }

        static void Task11332()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int length = int.Parse(file.ReadLine());
            int minDiff = 100001;
            int maxSum = 0;


            for (int i = 0; i < length; i++)
            {
                string[] inp = file.ReadLine().Split();
                int a = int.Parse(inp[0]);
                int b = int.Parse(inp[1]);

                maxSum += a > b ? a : b;

                if (Math.Abs(a - b) < minDiff && Math.Abs(a - b) % 3 != 0)
                {
                    minDiff = Math.Abs(a - b);
                }
            }

            if (maxSum % 3 != 0)
            {
                Console.WriteLine(maxSum);
            }
            else
            {
                Console.WriteLine(maxSum - minDiff);
            }

            file.Close();
        }

        static void Task3628()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int a = int.Parse(file.ReadLine());
            int maxLength = 1;
            int currentLength = 1;
            int previousNumber = a;

            while (a != 0)
            {
                if (a > previousNumber)
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        currentLength = 1;
                    }
                }

                previousNumber = a;
                a = int.Parse(file.ReadLine());
            }

            Console.WriteLine(maxLength);
            file.Close();
        }

        static void Task5291()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int a = int.Parse(file.ReadLine());
            int maxLength = 1;
            int currentLength = 1;
            int previousNumber = a;
            int firstNumber = a;
            int amount = 0;

            while (a != 0)
            {
                if (a > previousNumber)
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > firstNumber)
                    {
                        amount++;
                        firstNumber = a;
                    }
                }

                previousNumber = a;
                a = int.Parse(file.ReadLine());
            }

            Console.WriteLine(maxLength);
            file.Close();

        }

        static void Task7321()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int n = int.Parse(file.ReadLine());

            int t = int.Parse(file.ReadLine());

            int An = 0;
            int Bn = 0;

            for (int i = 0; i < n; i++)
            {
                string[] inp = file.ReadLine().Split();

                int a = int.Parse(inp[0]);
                int b = int.Parse(inp[1]);

                An += a;
                Bn = Math.Min(Bn + b, An + t);
            }

            Console.WriteLine(Bn);
        }

        static void Task27421()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int maxLength = 1;
            int currentLength = 1;

            int previousSymbol = file.Read();


            while (!file.EndOfStream)
            {
                int currentSymbol = file.Read();

                if (currentSymbol != previousSymbol)
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }
                    currentLength = 1;
                }
                previousSymbol = currentSymbol;
            }

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
            }

            Console.WriteLine(maxLength);
            file.Close();
        }

        enum Parser
        {
            waitingForX,
            waitingForY,
            waitingForZ
        }

        static void Task27689()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            var state = Parser.waitingForX;

            int currentLength = 0;
            int maxLength = 0;

            while (!file.EndOfStream)
            {
                int symbol = file.Read();

                if (state == Parser.waitingForX && symbol == 'X')
                {
                    ++currentLength;
                    state = Parser.waitingForY;
                }
                else if (state == Parser.waitingForY && symbol == 'Y')
                {
                    ++currentLength;
                    state = Parser.waitingForZ;
                }
                else if (state == Parser.waitingForZ && symbol == 'Z')
                {
                    ++currentLength;
                    state = Parser.waitingForX;
                }
                else
                {
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }

                    currentLength = 0;
                    state = Parser.waitingForX;

                    if (symbol == 'X')
                    {
                        currentLength = 1;
                        state = Parser.waitingForY;
                    }
                }
            }

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
            }

            Console.WriteLine(maxLength);

            file.Close();
        }

        static void Task29762()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");
            int amount = 0;

            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                int amountE = 0;
                int amountA = 0;

                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == 'A')
                    {
                        amountA++;
                    }
                    else if (line[i] == 'E')
                    {
                        amountE++;
                    }
                }

                if (amountE > amountA)
                {
                    amount++;
                }
            }

            Console.WriteLine(amount);

            file.Close();
        }

        static void Task33526()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int symb1 = file.Read();
            int symb2 = file.Read();
            int symb3 = file.Read();

            int[] freq = new int[26];

            for (int i = 0; i < 26; i++)
            {
                freq[i] = 0;
            }

            while (!file.EndOfStream)
            {
                if (symb1 == symb3)
                {
                    freq[symb2 - 'A']++;
                }

                symb1 = symb2;
                symb2 = symb3;
                symb3 = file.Read();
            }

            int maxFreq = 0;
            int res_i = 0;

            for (int i = 0; i < 26; i++)
            {
                if (freq[i] > maxFreq)
                {
                    maxFreq = freq[i];
                    res_i = i;
                }
            }

            Console.WriteLine(Convert.ToChar(res_i + 'A'));

            file.Close();
        }

        static void Task33769()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int symb1 = file.Read();
            int symb2 = file.Read();
            int symb3 = file.Read();

            int[] freq = new int[26];

            for (int i = 0; i < 26; i++)
            {
                freq[i] = 0;
            }

            while (!file.EndOfStream)
            {
                if (symb1 == symb2)
                {
                    freq[symb3 - 'A']++;
                }

                symb1 = symb2;
                symb2 = symb3;
                symb3 = file.Read();
            }

            int maxFreq = 0;
            int res_i = 0;

            for (int i = 0; i < 26; i++)
            {
                if (freq[i] > maxFreq)
                {
                    maxFreq = freq[i];
                    res_i = i;
                }
            }

            Console.WriteLine(Convert.ToChar(res_i + 'A'));

            file.Close();
        }

        static void Task35482()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");
            int minAmount = int.MaxValue;
            int res = 0;
            int minNumOfLetters = int.MaxValue;

            int[] alphabet = new int[26];
            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = 0;
            }

            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                int amount = 0;

                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == 'G')
                    {
                        amount++;
                    }

                    alphabet[line[i] - 'A']++;
                }

                if (amount < minAmount)
                {
                    for (int i = 0; i < 26; i++)
                    {
                        if (alphabet[i] <= minNumOfLetters)
                        {
                            minNumOfLetters = alphabet[i];
                            res = i;
                        }
                    }
                    minAmount = amount;
                }

                for (int i = 0; i < 26; i++)
                {
                    alphabet[i] = 0;
                }
            }

            Console.WriteLine(Convert.ToChar(res + 'A'));

            file.Close();
        }

        static void Task36037()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int[] arr = new int[4];
            int maxCount = 1;
            int count = 3;

            for (int i = 0; i < 4; i++)
            {
                arr[i] = '0';
            }

            while (!file.EndOfStream)
            {
                arr[0] = arr[1];
                arr[1] = arr[2];
                arr[2] = arr[3];
                arr[3] = file.Read();

                if (arr[0] == 'X' && arr[1] == 'Z' && arr[2] == 'Z' && arr[3] == 'Y')
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                    count = 3;
                }
                else
                {
                    count++;
                }
            }

            if (count > maxCount)
            {
                maxCount = count;
            }

            Console.WriteLine(maxCount);

            file.Close();
        }

        static void Task27423()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            string[] inp = file.ReadLine().Split();
            int S = int.Parse(inp[0]);
            int N = int.Parse(inp[1]);
            int[] arr = new int[N];

            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(file.ReadLine());
            }

            Sorting(ref arr);

            int sum = 0;
            int count = 0;

            while (sum <= S)
            {
                sum += arr[count];
                count++;
            }
            int maxi = arr[count];

            for (int i = count; i < N; i++)
            {
                if (sum + arr[i] - maxi <= S)
                {
                    sum = sum + arr[i] - maxi;
                    maxi = arr[i];
                }

            }

            Console.WriteLine(count + " " + maxi);

            file.Close();
        }

        static void Task29674()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int n = int.Parse(file.ReadLine());
            double sum = 0;
            int maxCost = 0;
            var moreThan50 = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(file.ReadLine());

                if (a <= 50)
                {
                    sum += a;
                }
                else
                {
                    moreThan50.Add(a);
                }

            }

            moreThan50.Sort();

            for (int i = 0; i < moreThan50.Count / 2; i++)
            {
                sum += moreThan50[i] * 0.75;

                if (moreThan50[i] > maxCost)
                {
                    maxCost = moreThan50[i];
                }
            }

            for (int i = moreThan50.Count / 2; i < moreThan50.Count; i++)
            {
                sum += moreThan50[i];
            }

            sum = Math.Ceiling(sum);

            Console.WriteLine(maxCost + " " + sum);
            file.Close();
        }

        static void fixMax(ref List<int> mainList, ref List<int> resultList, int fixPosition, int weightLimit)
        {
            int fixSum = 0;
            foreach (var item in resultList)
            {
                fixSum += item;
            }

            int fixIndex = -1;
            for (int i = fixPosition + 1; i < mainList.Count; i++)
            {
                int currentSum = fixSum - resultList[fixPosition] + mainList[i];
                if (currentSum <= weightLimit)
                {
                    fixIndex = i;
                }
            }

            if (fixIndex == -1)
            {
                return;
            }

            resultList[fixPosition] = mainList[fixIndex];
            mainList.RemoveAt(fixIndex);

            if (fixPosition - 1 < 0)
            {
                return;
            }

            fixMax(ref mainList, ref resultList, fixPosition - 1, weightLimit);
        }

        static void Task33198()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            string[] inp = file.ReadLine().Split();

            int n = int.Parse(inp[0]);
            int m = int.Parse(inp[1]);
            int currWeight = 0;
            var otherCargos = new List<int>();
            int cargosAmount = 0;

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(file.ReadLine());

                if (a >= 200 && a <= 210)
                {
                    currWeight += a;
                    cargosAmount++;
                }
                else
                {
                    otherCargos.Add(a);
                }
            }

            otherCargos.Sort();

            int count = 0;

            for (int i = 0; i < otherCargos.Count; i++)
            {
                if (currWeight <= m)
                {
                    currWeight += otherCargos[i];
                    count = i;
                }
            }

            int maxMass = otherCargos[count];
            var res = new List<int>();

            for (int i = 0; i < count; i++)
            {
                res.Add(otherCargos[i]);
            }

            fixMax(ref otherCargos, ref res, count - 1, m);

            cargosAmount += res.Count;

            Console.WriteLine(cargosAmount + " " + currWeight);
            file.Close();
        }

        static void PrintList(List<int> l)
        {
            foreach (var item in l)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        class CostAndAmount
        {
            public int cost;
            public int amount;

            public CostAndAmount(int cost, int amount)
            {
                this.cost = cost;
                this.amount = amount;
            }

            public int TotalCost()
            {
                return this.cost * this.amount;
            }
        }

        static void Sort(ref List<CostAndAmount> l)
        {
            for (int i = 0; i < l.Count; i++)
            {
                for (int j = 0; j < l.Count - 1; j++)
                {
                    if (l[j].cost > l[j + 1].cost)
                    {
                        var temp = new CostAndAmount(l[j].cost, l[j].amount);

                        l[j] = l[j + 1];
                        l[j + 1] = temp;
                    }
                }
            }
        }

        static int WastingMyBudget(List<CostAndAmount> items, ref int budget)
        {
            int count = 0;

            for (int i = 0; i < items.Count; i++)
            {
                int maxAmount = budget / items[i].cost;

                if (items[i].amount <= maxAmount)
                {
                    budget -= items[i].TotalCost();
                    count += items[i].amount;
                }
                else
                {
                    budget -= items[i].cost * maxAmount;
                    count += maxAmount;
                    break;
                }
            }

            return count;
        }

        static void Task33528()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            string[] inp = file.ReadLine().Split();
            int n = int.Parse(inp[0]);
            int budget = int.Parse(inp[1]);

            var itemsA = new List<CostAndAmount>();
            var itemsB = new List<CostAndAmount>();

            for (int i = 0; i < n; i++)
            {
                string[] input = file.ReadLine().Split();

                int letter = Convert.ToChar(input[2]) - 'A';

                var element = new CostAndAmount(cost: int.Parse(input[0]), amount: int.Parse(input[1]));

                if (letter == 0)
                {
                    itemsA.Add(element);
                }
                else if (letter == 1)
                {
                    itemsB.Add(element);
                }
            }

            Sort(ref itemsA);
            Sort(ref itemsB);

            WastingMyBudget(itemsA, ref budget);
            int amountB = WastingMyBudget(itemsB, ref budget);
            Console.WriteLine(amountB + " " + budget);

            file.Close();
        }

        static bool Search(int a, List<int> numbers, int firstEl, int lastEl)
        {
            if (firstEl == lastEl)
            {
                return a == numbers[firstEl];
            }

            int middle = (firstEl + lastEl) / 2;
            int middleNumb = numbers[middle];

            if (middleNumb == a)
            {
                return true;
            }

            if (a > middleNumb)
            {
                return Search(a, numbers, middle, lastEl);
            }
            else
            {
                return Search(a, numbers, middle, lastEl);
            }

        }

        static void Task35484()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int n = int.Parse(file.ReadLine());
            var even = new List<int>();
            var allNubers = new List<int>();



            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(file.ReadLine());

                if (a % 2 == 0)
                {
                    even.Add(a);
                }

                allNubers.Add(a);
            }

            bool condition = false;
            int count = 0;
            int maxAverage = 0;

            for (int i = 0; i < even.Count; i++)
            {
                for (int j = i + 1; j < even.Count; j++)
                {
                    int average = (even[i] + even[j]) / 2;
                    condition = Search(average, allNubers, 0, allNubers.Count);
                    if (condition)
                    {
                        count++;
                        if (average > maxAverage)
                        {
                            maxAverage = average;
                        }
                    }
                }
            }

            Console.WriteLine(count + " " + maxAverage);

            file.Close();
        }

        static int[] Merge(int[] sortArrayLeft, int[] sortArrayRight)
        {
            int[] resultArray = new int[sortArrayRight.Length + sortArrayLeft.Length];
            int countLeft = 0;
            int countRight = 0;
            int index = 0;

            while (countLeft < sortArrayLeft.Length && countRight < sortArrayRight.Length)
            {
                if (sortArrayLeft[countLeft] < sortArrayRight[countRight])
                {
                    resultArray[index] = sortArrayLeft[countLeft];
                    countLeft++;
                }
                else
                {
                    resultArray[index] = sortArrayRight[countRight];
                    countRight++;
                }

                index++;
            }

            if (countLeft < sortArrayLeft.Length)
            {
                for (int i = countLeft; i < sortArrayLeft.Length; i++)
                {
                    resultArray[index] = sortArrayLeft[i];
                }
            }
            if (countRight < sortArrayRight.Length)
            {
                for (int i = countRight; i < sortArrayRight.Length; i++)
                {
                    resultArray[index] = sortArrayRight[i];
                    index++;
                }

            }

            return resultArray;
        }

        static void twoArrays(int[] array)
        {

        }

        static void MergeSort(ref int[] array)
        {
            if (array.Length == 1)
            {
                return;
            }

            #region nuTakoe

            int halfSize = array.Length / 2;

            int[] sortArray1 = new int[halfSize];
            int[] sortArray2 = new int[array.Length - halfSize];

            for (int i = 0; i < halfSize; i++)
            {
                sortArray1[i] = array[i];
            }

            for (int i = 0; i < array.Length - halfSize; i++)
            {
                sortArray2[i] = array[i + halfSize];
            }
            #endregion

            MergeSort(ref sortArray1);
            MergeSort(ref sortArray2);

            array = Merge(sortArray1, sortArray2);
        }

        static void swap(ref int a1, ref int a2)
        {
            int temp = a2;
            a2 = a1;
            a1 = temp;
        }

        static int AmountOfElementsLessThanFirst(int[] array, int start, int end)
        {
            int count = 0;
            for (int i = 1 + start; i <= end; i++)
            {
                if (array[i] < array[start])
                {
                    count++;
                }
            }

            return count + start;
        }

        static void QuickSort(ref int[] array)
        {
            QuickSortRec(ref array, 0, array.Length - 1);
        }

        static void SwapLeftAndRight(ref int[] array, int start, int end, int position)
        {
            swap(ref array[start], ref array[position]);

            while (end >= position + 1 && start <= position - 1)
            {
                if (array[end] < array[position] && array[start] >= array[position])
                {
                    swap(ref array[end], ref array[start]);
                    end--;
                    start++;
                }
                else if (array[start] < array[position])
                {
                    ++start;
                }
                else if (array[end] >= array[position])
                {
                    --end;
                }
            }

        }

        static void QuickSortRec(ref int[] array, int start, int end)
        {

            if (end <= start)
            {
                return;
            }

            int position = AmountOfElementsLessThanFirst(array, start, end);

            SwapLeftAndRight(ref array, start, end, position);

            QuickSortRec(ref array, start, position - 1);

            QuickSortRec(ref array, position + 1, end);

        }

        static void Task66()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");
            int count = 0;
            int maxCount = 0;

            while (!file.EndOfStream)
            {
                int symbol = file.Read();

                if ((symbol == 'К' && count % 3 == 0) || (symbol == 'О' && count % 3 == 1) || (symbol == 'Т' && count % 3 == 2))
                {
                    count++;
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }

                    if (symbol == 'K')
                    {
                        count = 1;
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }

            Console.WriteLine(maxCount / 3);

            file.Close();
        }

        static void Task314()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            var s = "";
            int count = 0;

            for (int i = 0; i < 3; i++)
            {
                if (file.EndOfStream)
                {
                    Console.WriteLine(count);
                    return;
                }

                s += Convert.ToChar(file.Read());
            }

            if (s.Substring(0, 3) == "OCK")
            {
                ++count;
            }

            if (file.EndOfStream)
            {
                Console.WriteLine(count);
                return;
            }

            s += Convert.ToChar(file.Read());

            if (s.Substring(1, 3) == "OCK")
            {
                ++count;
            }

            s = 'x' + s;

            while (!file.EndOfStream)
            {
                s += Convert.ToChar(file.Read());
                s = s.Substring(1, 5);

                if (s.Substring(2, 3) == "OCK" && s != "STOCK")
                {
                    ++count;
                }
            }

            Console.WriteLine(count);

            file.Close();
        }

        static void Task320()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            var s = "";
            int max = 0;

            while (!file.EndOfStream)
            {
                char c = Convert.ToChar(file.Read());
                if (char.IsDigit(c))
                {
                    s += c;
                }
                else
                {
                    if (s.Length != 0)
                    {
                        int num = Convert.ToInt32(s);
                        if (num % 2 == 0 && num > max)
                        {
                            max = num;
                        }
                    }
                    s = "";
                }
            }

            Console.WriteLine(max);

            file.Close();
        }

        static void Task322()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");
            int count = 0;
            int words_count = 0;
            bool condition = false;

            while (!file.EndOfStream)
            {
                char c = Convert.ToChar(file.Read());
                if (char.IsDigit(c))
                {
                    condition = true;
                    if (count == 4)
                    {
                        words_count++;
                        count = 0;
                    }
                    else
                    {
                        count = 0;
                    }
                }
                else
                {
                    if (condition)
                    {
                        count++;
                    }

                }
            }

            Console.WriteLine(words_count);

            file.Close();
        }

        static void Task439()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");
            int c1 = file.Read() - '0';
            int c2 = file.Read() - '0';
            int count = 1;
            int subsequenceCount = 0;

            while (!file.EndOfStream)
            {
                if (c1 < c2)
                {
                    count++;
                    if (count > 5)
                    {
                        count = 1;
                    }
                }
                else
                {
                    if (count == 5)
                    {
                        subsequenceCount++;
                        count = 1;
                    }
                    else
                    {
                        count = 1;
                    }
                }
                c1 = c2;
                c2 = file.Read() - '0';
            }

            if (c2 > c1)
            {
                count++;
            }
            if (count == 5)
            {
                subsequenceCount++;
            }

            Console.WriteLine(subsequenceCount);

            file.Close();
        }

        static void Task679()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");
            int count = 2;
            int pairs = 0;
            char c1 = Convert.ToChar(file.Read());
            char c2 = Convert.ToChar(file.Read());

            while (!file.EndOfStream)
            {
                count++;

                if (c1 == '(' && c2 == ')')
                {
                    pairs++;
                }

                if (pairs == 9999 && c1 == '(')
                {
                    break;
                }
                c1 = c2;
                c2 = Convert.ToChar(file.Read());
            }

            Console.WriteLine(count);

            file.Close();
        }

        static void Task705()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int length = 1;
            int maxCount = 0;
            int a1 = file.Read();
            int a2 = file.Read();
            int currentStart = 0;
            int start = 0;
            int count = 1;

            while (!file.EndOfStream)
            {
                if (a1 > a2)
                {
                    length++;
                }
                else
                {
                    if (length > maxCount)
                    {
                        maxCount = length;
                        start = currentStart;
                    }
                    currentStart = count + 1;
                    length = 1;
                }
                count++;
                a1 = a2;
                a2 = file.Read();
            }

            if (length > maxCount)
            {
                maxCount = length;
                start = currentStart;
            }

            Console.WriteLine(start);

            file.Close();
        }

        static bool Palindrom(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        static void Task855()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int a1 = file.Read();
            int a2 = file.Read();
            int a3 = file.Read();

            int[] alphabet = new int[26];

            while (!file.EndOfStream)
            {
                if (a1 == 'X' && a3 == 'Z')
                {
                    alphabet[a2 - 'A']++;
                }
                a1 = a2;
                a2 = a3;
                a3 = file.Read();
            }

            int max = 0;
            int letter = 'A';

            for (int i = 0; i < 26; i++)
            {
                if (alphabet[i] > max)
                {
                    max = alphabet[i];
                    letter = 'A' + i;
                }
            }

            Console.Write(Convert.ToChar(letter));
            Console.Write(max);

            file.Close();
        }

        static void Task29673Nostalgia()
        {

        }

        static void Array()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int max = 0;
            int count = 0;

            while (!file.EndOfStream)
            {
                int a = int.Parse(file.ReadLine());
                if (a > max)
                {
                    max = a;
                    count = 0;
                }
                if (a == max)
                {
                    count++;
                }
            }

            Console.WriteLine(count);

            file.Close();
        }

        static void Task18575()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int length = int.Parse(file.ReadLine());
            int l = 6;
            int[] arr = new int[l];
            int[] rem = { 0, 0, 0 };
            int pairs = 0;

            for (int i = 0; i < l; i++)
            {
                arr[i] = int.Parse(file.ReadLine());
            }

            for (int i = l; i < length; i++)
            {
                rem[arr[0] % 3]++;

                int a = int.Parse(file.ReadLine());
                int remainder = a % 3;
                pairs += rem[(3 - remainder) % 3];

                for (int j = 0; j < l - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[l - 1] = a;
            }

            Console.WriteLine(pairs);

            file.Close();
        }

        class PositionAndNumber
        {
            public int sum = -1;
            public int length = 0;
        }

        static void Task37162Repeat()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");
            int mod = 50;
            PositionAndNumber[] remainders = new PositionAndNumber[mod];

            for (int i = 0; i < mod; i++)
            {
                remainders[i] = new PositionAndNumber();
            }

            int n = int.Parse(file.ReadLine());

            int maxSum = 0;
            int sum = 0;
            int minLength = 68001;

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(file.ReadLine());
                sum += a;
                int rem = sum % mod;

                if (remainders[rem].sum == -1 && rem != 0)
                {
                    remainders[rem].sum = sum;
                    remainders[rem].length = i + 1;
                }
                else
                {
                    int probMax = sum - remainders[rem].sum;
                    int probLength = i - remainders[rem].length + 1;

                    if (probMax > maxSum)
                    {
                        maxSum = probMax;
                        minLength = probLength;
                    }
                    else if (probMax == maxSum)
                    {
                        if (probLength < minLength)
                        {
                            minLength = probLength;
                        }
                    }
                }
            }

            Console.WriteLine(minLength + " " + maxSum);

            file.Close();
        }

        static void Task69()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");
            int length = int.Parse(file.ReadLine());

            int[,] rems13 = new int[2, 13];

            for (int i = 0; i < length; i++)
            {
                int a = int.Parse(file.ReadLine());
                int rem13 = a % 13;
                int rem2 = a % 2;

                rems13[rem2, rem13]++;
            }

            int res = 0;
            for (int i = 0; i < 13; i++)
            {
                res += rems13[0, i] * (rems13[0, i] - 1) / 2 + rems13[0, i] * rems13[1, i];
            }

            Console.WriteLine(res);

            file.Close();
        }


    }
}
