using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _27ege
{
    class Task789Class
    {
        public static void Run()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int length = int.Parse(file.ReadLine());
            int n1 = 0;
            int n0 = 0;
            int nChet = 0;
            int nNech = 0;
            int ans = 0;
            int firstChetIndex = 0;
            for (int i = 0; i < length; i++)
            {
                int number = int.Parse(file.ReadLine());
                if (number % 2 == 0)
                {
                    firstChetIndex = i;
                    break;
                }
            }
            for (int i = firstChetIndex + 1; i < length; i++)
            {
                int number = int.Parse(file.ReadLine());
                if (number == 1)
                {
                    ++n1;
                    continue;
                }

                if (number % 2 == 1)
                {
                    continue;
                }

                if (n1 == 0)
                {
                    n0++;
                    ans += nChet;
                }
                else if (n1 % 2 != 0)
                {
                    int temp = nChet;
                    nChet = nNech;
                    nNech = temp + n0 + 1;
                    ans += nChet;
                    n0 = 0;
                    n1 = 0;
                }
                else
                {
                    nChet += n0 + 1;
                    ans += nChet;
                    n0 = 0;
                    n1 = 0;
                }
            }

            Console.WriteLine(ans);

            file.Close();
        }


    }
}
