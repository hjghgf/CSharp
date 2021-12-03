using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _27ege
{
    
    class KnapsackProblem
    {
        class Thing
        {
            public int mass = 0;
            public int value = 0;
        }

        static Thing[] goods = null;

        static int weightLimit;

        public static void InitializeDataFromFile(string path)
        {
            var file = new StreamReader(path);
            int amount = int.Parse(file.ReadLine());
            weightLimit = int.Parse(file.ReadLine());
            goods = new Thing[amount];

            for (int i = 0; i < amount; i++)
            {
                goods[i] = new Thing();
                string[] inp = file.ReadLine().Split();
                goods[i].mass = int.Parse(inp[0]);
                goods[i].value = int.Parse(inp[1]);
            }
        }

        public static int max(int a, int b)
        {
            return a > b ? a : b;
        }

        static int Knapsack(int weightLimit, int lastElement)
        {
            if (lastElement == -1 || weightLimit == 0)
            {
                return 0;
            }

            var thing = goods[lastElement];

            if (thing.mass > weightLimit)
            {
                return Knapsack(weightLimit, lastElement - 1);
            }
            else
            {
                int value1 = Knapsack(weightLimit - thing.mass, lastElement - 1) + thing.value;
                int value2 = Knapsack(weightLimit, lastElement - 1);

                return max(value1, value2);
            }
        }

        static int MaxValue(string path)
        {
            InitializeDataFromFile(path);
            return Knapsack(weightLimit, goods.Length - 1);
        }

        static int KnapsackDynamic(string path = "..\\..\\..\\27.txt")
        {
            InitializeDataFromFile(path);

            int[,] knapsack = new int[goods.Length + 1, weightLimit + 1];

            for (int i = 0; i < goods.Length + 1; i++)
            {
                knapsack[i, 0] = 0; 
            }
            for (int i = 0; i < weightLimit + 1; i++)
            {
                knapsack[0, i] = 0;
            }


            for (int i = 1; i <= goods.Length; i++)
            {
                for (int j = 1; j <= weightLimit; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        knapsack[i, j] = 0;
                    }
                    else
                    {
                        if (goods[i - 1].mass > j)
                        {
                            knapsack[i, j] = knapsack[i - 1, j];
                        }
                        else
                        {
                            knapsack[i, j] = max(knapsack[i - 1, j], goods[i - 1].value + knapsack[i - 1, j - goods[i - 1].mass]);
                        }
                    }
                }
            }

            KEGE1080.PrintArray(knapsack, goods.Length + 1, weightLimit + 1);

            return knapsack[goods.Length, weightLimit];
        }

        static bool test(string path)
        {
            int test1 = MaxValue(path);
            int test2 = KnapsackDynamic(path);
            return test1 == test2 ? true : false;
        }

    }
}
