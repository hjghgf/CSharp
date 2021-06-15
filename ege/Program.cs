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

                if (a % 7 == 0 && a % 2 != 0 && a > max7)
                {
                    max7 = a;
                }

                if (a % 14 == 0 && a > max14)
                {
                    max14 = a;
                }

                if (a > max)
                {
                    max = a;
                }
            }

            int maxcomp = 1;

            if (max14 * max > max7 * max2)
            {
                maxcomp = max14 * max;
            }
            else
            {
                maxcomp = max2 * max7;
            }
            Console.WriteLine(maxcomp);
            file.Close();
        }

        static void Main(string[] args)
        {
            Task27891();
        }
    }
}