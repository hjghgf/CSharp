using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace _27ege
{
    class Sandbox
    {
        static bool NextSet(int[] a, int fundament = 9, int sequencelength = 4)
        {
            int j = sequencelength - 1;
            while (j >= 0 && a[j] == fundament - 1)
            {
                j--;
            }

            if (j < 0)
            {
                return false;
            }
            if (a[j] >= fundament)
            {
                j--;
            }

            a[j]++;

            if (j == sequencelength - 1)
            {
                return true;
            }
            for (int k = j + 1; k < sequencelength; k++)
            {
                a[k] = a[j];
            }

            return true;
        }

        static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        static int FibonacciRecursion(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            return FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
        }

        static void Fibonacci(int n)
        {
            int f1 = 0;
            int f2 = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(f2 + " ");
                int res = f1 + f2;
                f1 = f2;
                f2 = res;
            }
        }

        static void Initializing(ref int[,] arr, int n, string path = "..\\..\\..\\27.txt")
        {
            var file = new StreamReader(path);
            for (int i = 0; i < n; i++)
            {
                string[] inp = file.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = int.Parse(inp[j]);
                }
            }
        }

        static int maxArea(int n)
        {
            int[,] matrix = new int[n, n];
            int maxS = 0;
            Initializing(ref matrix, n);
            KEGE1080.PrintArray(matrix, n, n);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int startI = i;
                    int startJ = j;
                    int length = 0;
                    int width = 0;

                    while (startI < n && startJ < n && matrix[startI, startJ] == 0)
                    {
                        width++;

                        while (startI < n && startJ < n && matrix[startI, startJ] == 0)
                        {
                            length++;
                            startJ++;
                        }
                        startI++;
                    }

                    j = startJ;
                    i = startI;

                    int probS = width * length;
                    if (probS > maxS)
                    {
                        maxS = probS;
                    }
                }
            }
            return maxS;
        }

        static void ArrayListTest()
        {
            var arrayList = new ArrayList();

            var amount = int.Parse(Console.ReadLine());

            for (int i = 0; i < amount; i++)
            {
                var element = Console.ReadLine();
                int number = 0;
                if (int.TryParse(element, out number))
                {
                    arrayList.Add(number);
                }
                else
                {
                    arrayList.Add(element);
                }
            }

            foreach (var item in arrayList)
            {
                if (item.GetType() == System.Type.GetType("System.Int32"))
                {
                    Console.WriteLine(item);
                }
            }

        }


    }
}
