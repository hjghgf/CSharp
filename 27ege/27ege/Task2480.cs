using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _27ege
{
    class Task2480
    {
        public static void Run()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int n = int.Parse(file.ReadLine());
            int[] arr = new int[2000001];

            for (int i = 0; i < n; i++)
            {
                string[] inp = file.ReadLine().Split();
                int a = int.Parse(inp[0]);
                int b = int.Parse(inp[1]);

                for (int j = a + 1; j <= b; j++)
                {
                    arr[j] = 1;
                }
            }

            int count = 0;
            int length = 0;
            //int[] arr = { 0, 0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 0, 1, 0, 0, 1, 1 };

            bool end = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                {
                    ++length;
                    end = true;
                }
                else if (end)
                {
                    ++count;
                    end = false;
                }
            }

            if (arr[arr.Length - 1] == 1)
            {
                count++;    
            }

            Console.WriteLine(count + " " + length);

            file.Close();
        }
    }
}
