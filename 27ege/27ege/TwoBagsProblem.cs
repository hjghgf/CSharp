using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _27ege
{
    class TwoBagsProblem
    {
        class Thing
        {
            public int mass = 0;
            public int volume = 0;
        }

        static Thing[] things = null;
        static int maxMass;
        static int maxVolume;

        static void InitializeData(string path = "..\\..\\..\\27.txt")
        {
            var file = new StreamReader(path);
            string[] inp = file.ReadLine().Split();
            int amount = int.Parse(inp[0]);
            maxVolume = int.Parse(inp[1]);
            maxMass = int.Parse(inp[2]);
            things = new Thing[amount];
            string[] inpVolume = file.ReadLine().Split();
            string[] inpMass = file.ReadLine().Split();

            for (int i = 0; i < amount; i++)
            {
                things[i] = new Thing();
                things[i].volume = int.Parse(inpVolume[i]);
                things[i].mass = int.Parse(inpMass[i]);
            }
        }

        static void Initialize(string path = "..\\..\\..\\27.txt")
        {
            var file = new StreamReader(path);
            int amount = int.Parse(file.ReadLine());
            maxMass = int.Parse(file.ReadLine());
            things = new Thing[amount];

            for (int i = 0; i < amount; i++)
            {
                things[i] = new Thing();
                string[] inp = file.ReadLine().Split();
                things[i].mass = int.Parse(inp[0]);
                things[i].volume = int.Parse(inp[1]);
            }
        }

        static void RewriteArray(ref int[] arr1, ref int[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = arr2[i];
                arr2[i] = 0;
            }
        }

        static string TwoBags()
        {
            string res = "";
            int remainingMass = 0;
            InitializeData();
            int[] previous = new int[maxMass + 1];
            int[] current = new int[maxMass + 1];

            for (int j = 1; j < things.Length; j++)
            {
                RewriteArray(ref previous, ref current);
                for (int i = 1; i <= maxMass; i++)
                {
                    if (things[j - 1].mass > i)
                    {
                        current[i] = previous[i];
                    }
                    else
                    {
                        current[i] = KnapsackProblem.max(previous[i], things[j - 1].volume + previous[i - things[j - 1].mass]);
                        if (current[i] == previous[i])
                        {
                            res += "y";
                            remainingMass += i;
                        }
                        else
                        {
                            res += "x";
                        }
                    }
                }
            }
            if (remainingMass < maxMass)
            {
                return res; 
            }
            return "-1";
        }

    }
}
