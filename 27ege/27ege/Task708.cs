using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _27ege
{
    class Task708
    {
        public static void Run()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int length = int.Parse(file.ReadLine());
            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(file.ReadLine());
            }

            int count = 0;

            for (int l = 0; l < length; l++)
            {
                for (int r = l + 1; r < length && arr[r] + arr[l] <= 10000; r++)
                {
                    for (int s = r + 1; s < length; s++)
                    {
                        if (arr[s] == arr[r] + arr[l])
                        {
                            count++;
                        }
                    }
                }
            }

            Console.WriteLine(count);

            file.Close();
        }

        public static void ExelRun()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int length = int.Parse(file.ReadLine());
            int[] first = new int[10001];
            int[] sum = new int[10001];
            int count = 0;

            for (int i = 1; i <= length; i++)
            {
                int a = int.Parse(file.ReadLine());

                if (i >= 3)
                {
                    count += sum[a];
                }

                if (i >= 2)
                {
                    for (int f = 0; f < first.Length; f++)
                    {
                        if (first[f] != 0 && f + a <= 10000)
                        {
                            sum[f + a] += first[f];
                        }
                    }
                }

                first[a]++;
            }

            Console.WriteLine(count);
            file.Close();
        }
    }
}
