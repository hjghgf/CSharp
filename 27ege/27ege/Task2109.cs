using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _27ege
{
    class Task2109
    {
        public static void Run()
        {            
            var file = new StreamReader("..\\..\\..\\27.txt");

            int n = int.Parse(file.ReadLine());
            int[,] s = new int[2, 7];
            int sum = 0;
            int length = 1;
            int a = int.Parse(file.ReadLine());
            sum += a;
            int maxLength = 0;
            s[0, a % 7] = a;
            s[1, a % 7] = 1;                
            int b = int.Parse(file.ReadLine());
            int k = b - a;

            for (int i = 2; i < n; i++)
            {
                if (a == 9)
                {
                    int c = 1;
                }
                if (b - a == k && k >= 1)
                {
                    sum += b;
                    length++;

                    if (s[0, sum % 7] == 0 && sum % 7 != 0)
                    {
                        s[0, sum % 7] = sum;
                        s[1, sum % 7] = i;
                    }

                    if (length - s[1, sum % 7] > maxLength)
                    {
                        maxLength = length - s[1, sum % 7];
                    }

                }
                else
                {                            
                    if (length - s[1, sum % 7] > maxLength)
                    {
                        maxLength = length - s[1, sum % 7];
                    }
                        
                    length = 2;                    
                    sum = 0;
                    k = 0;

                    for (int j = 0; j < 7; j++)
                    {
                        s[0, j] = 0;
                        s[1, j] = 0;
                    }

                }
                                
                if (k == 0)
                {
                    k = b - a;
                    sum += a + b;
                }
                
                a = b;
                b = int.Parse(file.ReadLine());
            }


            if (length - s[1, sum % 7] > maxLength)
            {
                maxLength = length - s[1, sum % 7];
            }


            file.Close();

            Console.WriteLine(maxLength);
        }
    }
}
