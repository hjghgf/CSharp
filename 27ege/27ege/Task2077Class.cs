using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _27ege
{
    class Task2077Class
    {
        public static int[,] Array(string path = "..\\..\\..\\27.txt")
        {
            var file = new StreamReader(path);
            int length = int.Parse(file.ReadLine());

            int[,] array = new int[2, length];

            array[0, 0] = int.Parse(file.ReadLine());
            array[1, 0] = array[0, 0];

            for (int i = 1; i < length; i++)
            {
                array[0, i] = int.Parse(file.ReadLine());
                array[1, i] = array[1, i - 1] + array[0, i];
            }

            file.Close();

            return array;
        }

        static int Sum(int i, int j, int[,] arr)
        {
            return arr[1, j - 1] - arr[1, i];
        }

        public static void Run()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int length = int.Parse(file.ReadLine());
            int[,] rems = new int[2, 3];
            int res = 0;
            int p = 0;
            int x = 0;

            for (int i = 1; i < length; i++)
            {
                int y = int.Parse(file.ReadLine());

                if (y % 3 == 0)
                {
                    if (x % 2 == 0)
                    {
                        res += rems[0, 0];
                        if (p % 3 == 0)
                        {
                            res += 1;
                        }

                        if (p % 3 == 0)
                        {

                        }
                        else if (p % 3 == 1)
                        {

                        }
                        else if (p % 3 == 2)
                        {
                            rems[0, 2]++;
                        }
                    }
                    else if (x % 2 == 1)
                    {

                    }
                }
                else if (y % 3 == 1)
                {

                }
                else if (y % 3 == 2)
                {

                }
                p = x;
                x = y;
            }

            Console.WriteLine(res);

            file.Close();
        }

        public static void Run1()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");
            int length = int.Parse(file.ReadLine());
            file.Close();

            int[,] array = Array();
            int res = 0;

            for (int i = 0; i < length - 2; i++)
            {
                for (int j = i + 2; j < length; j++)
                {
                    int s = Sum(i, j, array);
                    if (s % 2 == 0 && (array[0, i] + array[0, j]) % 3 == 0)
                    {
                        res++;
                    }
                }
            }

            Console.WriteLine(res);

            file.Close();
        }

        static void ChangeArray(int[,] arr1, ref int[,] arr2, int x, int l = 3, int w = 2)
        {
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    arr2[i, j] = arr1[Math.Abs(i - x % 2), j];
                }
            }

        }

        static void CopyArray(ref int[,] arr1, ref int[,] arr2)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr1[i, j] = arr2[i, j];
                    arr2[i, j] = 0;
                }
            }
        }

        static void Run2()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");
            int length = int.Parse(file.ReadLine());
            int[,] arr = new int[2, 3];
            int[,] arr2 = new int[2, 3];
 
            int x = int.Parse(file.ReadLine());

            int ans = 0;

            for (int i = 1; i < length; i++)
            {
                int y = int.Parse(file.ReadLine());
                ChangeArray(arr, ref arr2, x);
                ans += arr2[0, (3 - y % 3) % 3];
                arr2[0, x % 3]++;
                x = y;
                CopyArray(ref arr, ref arr2);
            }

            Console.WriteLine(ans);

            file.Close();
        }


    }
}
