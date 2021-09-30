using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27ege
{
    class KEGE1080
    {
        static int maxValue = 100000000;

        static int fundament = 9;

        static int sequencelength = 4;

        static string ArrayTostring(int[] arr)
        {
            string result = "";

            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i].ToString() + " ";
            }

            return result;
        }

        static bool TheEndMan(int[] arr, int fundament = 9)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != fundament - 1)
                {
                    return false;
                }
            }

            return true;
        }

        static int ArraySum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        static void IncreaseArray(ref int[] arr, int fundament = 9)
        {
            ++arr[arr.Length - 1];
            for (int i = arr.Length - 1; i > 0; i--)
            {
                if (arr[i] == fundament)
                {
                    arr[i] = 0;
                    ++arr[i - 1];
                }
            }
        }

        static void fillingTheArray(ref int[,] minimums)
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int length = int.Parse(file.ReadLine());

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    minimums[i, j] = maxValue;
                }
            }

            for (int i = 0; i < length; i++)
            {
                int a = int.Parse(file.ReadLine());
                int rem = a % 9;
                if (a < minimums[0, rem])
                {
                    minimums[3, rem] = minimums[2, rem];
                    minimums[2, rem] = minimums[1, rem];
                    minimums[1, rem] = minimums[0, rem];
                    minimums[0, rem] = a;
                }
                else if (a < minimums[1, rem] && a >= minimums[0, rem])
                {
                    minimums[3, rem] = minimums[2, rem];
                    minimums[2, rem] = minimums[1, rem];
                    minimums[1, rem] = a;
                }
                else if (a < minimums[2, rem] && a >= minimums[1, rem])
                {
                    minimums[3, rem] = minimums[2, rem];
                    minimums[2, rem] = a;
                }
                else if (a < minimums[3, rem] && a >= minimums[2, rem])
                {
                    minimums[3, rem] = a;
                }
            }
        }

        static void PrintArray(int[,] arr, int n = 4, int k = 9)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        class Element
        {
            public int value = maxValue;
            public int numberOfMin = -1;

            public Element(int value, int numberOfMin)
            {
                this.value = value;
                this.numberOfMin = numberOfMin;
            }
        }

        static Element[] MinMap(int[] sequence)
        {
            int[] digitFrequencies = new int[fundament];

            var minMap = new Element[sequence.Length];

            for (int i = 0; i < sequence.Length; i++)
            {
                minMap[i] = new Element(sequence[i], digitFrequencies[sequence[i]]);
                ++digitFrequencies[sequence[i]];
            }

            return minMap;
        }


        static void Task1080()
        {
            int[,] minimums = new int[sequencelength, fundament];

            fillingTheArray(ref minimums);

            int min = maxValue;

            for (int[] arr = new int[sequencelength]; !TheEndMan(arr); IncreaseArray(ref arr))
            {
                if (arr[0] == 0 && arr[1] == 0 && arr[2] == 0 && arr[3] == 0)
                {
                    Console.WriteLine();
                }            
                
                int sum = 0;
                bool appropriate = true;

                foreach (var element in MinMap(arr))
                {
                    int value = minimums[element.numberOfMin, element.value];
                    if (value == maxValue)
                    {
                        appropriate = false;
                        break;
                    }

                    sum += value;
                }

                if (!appropriate)
                {
                    continue;
                }

                if (sum % fundament == 0 && sum < min)
                {
                    min = sum;
                }

            }

            Console.WriteLine(min);
        }

        static void Main(string[] args)
        {
            Task1080();
        }
    }
}
