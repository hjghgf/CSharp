using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _27ege
{
    class Task477Class
    {
        public static void Task477()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");
            int length = int.Parse(file.ReadLine());

            int minEven = 1001;
            int minOdd = 1001;

            int countEven = 0;
            int countOdd = 0;

            int res = 0;

            for (int i = 0; i < length; i++)
            {
                int a = int.Parse(file.ReadLine());

                if (a % 2 != 0)
                {
                    if (a > minEven)
                    {
                        res += countEven;
                    }

                    if (a < minOdd)
                    {
                        minOdd = a;
                    }

                    countOdd++;
                }
                else
                {
                    if (a > minOdd)
                    {
                        res += countOdd;
                    }

                    if (a < minEven)
                    {
                        minEven = a;    
                    }

                    countEven++;
                }
            }

            Console.WriteLine(res);

            file.Close();
        }
 
    }
}
