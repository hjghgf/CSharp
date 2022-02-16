using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _27ege
{
    class Task912
    {
        public static void Run()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");
            int length = int.Parse(file.ReadLine());

            int mod = 7;
            int minSum = 0;
            int maxSum = 0;
            int[] minRems = new int[mod];

            for (int i = 0; i < length; i++)
            {
                string[] inp = file.ReadLine().Split();
                int a = int.Parse(inp[0]);
                int b = int.Parse(inp[1]);

                minSum += a < b ? a : b;
                maxSum += a > b ? a : b;
                int possibRem = Math.Abs(a - b) % mod;
                int temp = Math.Abs(a - b);

                if (temp < minRems[possibRem] || minRems[possibRem] == 0)
                {
                    minRems[possibRem] = temp;
                }

            }

            int remMin = minSum % mod;
            int remMax = maxSum % mod;

            if (remMax > remMin)
            {
                maxSum -= minRems[remMax - remMin];
            }
            else if (remMax < remMin)
            {
                maxSum -= minRems[remMax + mod - remMin];
            }

            Console.WriteLine(maxSum);
            file.Close();
        }
    }
}
//115780
//410888948