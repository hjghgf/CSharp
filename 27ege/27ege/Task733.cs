using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _27ege
{
    class Task733
    {
        public static void Run()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int length = int.Parse(file.ReadLine());
            int[] digitFrequencies = new int[10];

            for (int i = 0; i < length; i++)
            {
                int a = int.Parse(file.ReadLine());
                digitFrequencies[a]++;
            }

            int sum = 0;

            if (digitFrequencies[5] > 1)
            {
                sum += 10;
                digitFrequencies[5] -= 2;
            }
            else if (digitFrequencies[0] > 1)
            {
                digitFrequencies[0] -= 2;
            }
            else
            {
                Console.WriteLine("no solutions");
                return;
            }

            int number = -1;

            for (int i = 9; i >= 0; i--)
            {
                int amount = digitFrequencies[i] / 2;

                if (digitFrequencies[i] % 2 != 0 && number == -1)
                {
                    number = i;
                }

                sum += amount * 2 * i;
            }

            if (number != -1)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
