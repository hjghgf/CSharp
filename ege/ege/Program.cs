using System;
using System.IO;

namespace ege
{
    class Program
    {
        static void Task27424()
        {
            using (var file = new StreamReader("test.txt"))
            {                   
                int sum = 0;
                int globalMax = 10001;
                int minDifference = globalMax;

                int amount = int.Parse(file.ReadLine());

                for (int i = 0; i < amount; i++)
                {
                    string[] inp = file.ReadLine().Split(' ');
                    int a = int.Parse(inp[0]);
                    int b = int.Parse(inp[1]);

                    sum += (a > b ? a : b);
                    
                    int currentDifference = Math.Abs(a - b);
                    
                    if (Math.Abs(a - b) < minDifference && currentDifference % 3 != 0)
                    {
                        minDifference = Math.Abs(a - b);
                    }
                }

                if (sum % 3 != 0)
                {
                    Console.WriteLine(sum);
                }
                else if (minDifference != 10001)
                {
                    Console.WriteLine(sum - minDifference);
                }
                else
                {
                    Console.WriteLine("no solution");
                }
            }
           
        }

        static void Task27891()
        {
            var file = new StreamReader("test.txt");

            int amount = int.Parse(file.ReadLine());
            int max7 = 0;
            int max2 = 0;
            int max14 = 0;
            int max = 0;

            for(int i=0; i<amount; i++)
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

            if(max14*max>max7*max2)
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

        /*
         * вводят количество чисел, затем сами числа, вывести первое и второе набиольшее значение
         * 5 1 2 3 4 5 -> 4 5
         * 5 1 2 3 4 4 -> 4 4
         */
        static void SecondMax()
        {
            int amount = int.Parse(Console.ReadLine());

            int m1 = -1001;
            int m2 = -1001;

            for (int i = 0; i < amount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > m1)
                {
                    m2 = m1;
                    m1 = number;
                }
                if (number > m2 && number <= m1) // why? :(
                {
                    m2 = number;
                }
            }

            Console.WriteLine(m2 + " " + m1);
        }

        static void Main(string[] args)
        {
            Task27891();
        }
    }
}
