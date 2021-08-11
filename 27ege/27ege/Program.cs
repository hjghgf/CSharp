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

            if (maxSum % 109 != 0 )
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
                else if (a%26 == 0)
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
                if(currentProd>maxProd)
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
                    if (parameters[pos,0]==int.MaxValue)
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

            double s = s0 > s1 ? s0/2 : s1/2;

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

        static void Main(string[] args)
        {
            Task5258();
            /*
            int mod = 4;
            int[] r = new int[mod];
            r[0] = 0;
            r[1] = 0;
            r[2] = 2;
            r[3] = 0;
            // 2 6

            int ans = (r[0] * (r[0] - 1)) / 2;

            for (int i = 1; i < mod/2; i++)
            {
                ans += r[i] * r[mod - i];
            }

            if (mod % 2 == 0)
            {
                ans += r[mod / 2] * (r[mod / 2] - 1) / 2;
            }

            Console.WriteLine(ans);
            */
        }
    }
}