using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _27ege
{
    class Task442Class
    {
        static void Task442(string str = "..\\..\\..\\27.txt")
        {
            var file = new StreamReader(str);
            int length = int.Parse(file.ReadLine());
            
            int countEvenLeft = 0;
            int countOddLeft = 0;

            int res = 0;  
            
            int countEvenRight = 0;
            int countOddRight = 0;

            int a = -1;

            for (int i = 0; i < length; i++)
            {
                a = int.Parse(file.ReadLine());
                if (a != 0)
                {
                    if (a % 2 == 0)
                    {
                        countEvenRight++;
                    }
                    else
                    {
                        countOddRight++;
                    }
                }
                else
                {
                    res += countEvenLeft * countEvenRight + countOddLeft * countOddRight;
                    countEvenLeft += countEvenRight;
                    countOddLeft += countOddRight;
                    countEvenRight = 0;
                    countOddRight = 0;
                }
            }

            if (a != 0)
            {
                res += countEvenLeft * countEvenRight + countOddLeft * countOddRight;
            }

            Console.WriteLine(res);

            file.Close();
        }

    }
}
