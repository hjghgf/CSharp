using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27ege
{
    class KEGE1080SecondTry
    {
        static int sequencelength = 4;
        static int fundament = 9;

        static void ChangingSums(ref int[,] sums, int position, int a)
        {
            int[] arr = new int[fundament];
            for (int i = 0; i < fundament; i++)
            {
                if (sums[position - 1, i] != 0)
                {
                    int probsum = a + sums[position - 1, i];
                    arr[probsum % fundament] = probsum;
                }
            }

            foreach (var item in arr)
            {
                if (item < sums[position, item % 9] && item != 0 || sums[position, item % 9] == 0)
                {
                    sums[position, item % 9] = item;
                }
            }

        }

        static void FirstPack(int[,] firsts, ref int[,] sums)
        {
            int numberCount = 0;
            sums[0, firsts[0, 1]] += firsts[0, 0]; //1

            int remainder = (firsts[1, 1] + firsts[0, 1]) % 9; //пара
            sums[1, remainder] = firsts[0, 0] + firsts[1, 0];
            numberCount++;

            if (firsts[1, 0] < sums[0, firsts[1, 1]] || sums[0, firsts[1, 1]] == 0) //один
            {
                sums[0, firsts[1, 1]] = firsts[1, 0];
            }

            remainder += firsts[2, 1] % 9; //тройка
            remainder %= 9;
            sums[2, remainder] = firsts[0, 0] + firsts[1, 0] + firsts[2, 0];
            numberCount++;

            ChangingSums(ref sums, 1, firsts[numberCount, 0]);

            if (firsts[2, 0] < sums[0, firsts[2, 1]] || sums[0, firsts[2, 1]] == 0) //один
            {
                sums[0, firsts[2, 1]] = firsts[2, 0];
            }

            remainder += firsts[3, 1] % 9; //четверка
            remainder %= 9;
            sums[3, remainder] = firsts[0, 0] + firsts[1, 0] + firsts[2, 0] + firsts[3, 0];
            numberCount++;

            ChangingSums(ref sums, 2, firsts[numberCount, 0]); //тройка
            ChangingSums(ref sums, 1, firsts[numberCount, 0]); //двойка

            if (firsts[3, 0] < sums[0, firsts[3, 1]] || sums[0, firsts[3, 1]] == 0) //один
            {
                sums[0, firsts[3, 1]] = firsts[3, 0];
            }

        }

        static void Task1080()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int[,] sums = new int[sequencelength, fundament];
            int n = int.Parse(file.ReadLine());

            int[,] firsts = new int[sequencelength, 2];
            for (int i = 0; i < 4; i++)
            {
                firsts[i, 0] = int.Parse(file.ReadLine());
                firsts[i, 1] = firsts[i, 0] % fundament;
            }

            FirstPack(firsts, ref sums);

            for (int i = 4; i < n; i++)
            {
                int a = int.Parse(file.ReadLine());
                int remainder = a % fundament;

                for (int j = sequencelength - 1; j > 0; j--)
                {
                    ChangingSums(ref sums, j, a);
                }

                if (a < sums[0, remainder] || sums[0, remainder] == 0)
                {
                    sums[0, remainder] = a;
                }
            }

            Console.WriteLine(sums[3, 0]);
            file.Close();
        }

    }

}
