using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27ege
{
    class TwoPointers
    {
        static int TwoPointersSumCount(int[] arr, int targetSum)
        {
            int l = 0;
            int r = 0;
            int sum = 0;
            int count = 0;
            int n = arr.Length;

            while (l < n && r < n)
            {
                sum += arr[r];

                if (sum == targetSum)
                {
                    count++;
                }
                else if (sum > targetSum)
                {
                    while (sum > targetSum)
                    {
                        sum -= arr[l];
                        l++;
                        if (sum == targetSum)
                        {
                            count++;
                        }

                    }
                }

                r++;
            }

            return count;
        }

        static int FullSearch(int[] arr, int targetSum)
        {
            int count = 0;
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = i; j < n; j++)
                {
                    sum += arr[j];
                    if (sum == targetSum)
                    {
                        count++;
                        break;
                    }
                }
            }

            return count;
        }

        static void testTwoPointers()
        {
            for (int i = 0; i < 100; i++)
            {
                Random rand = new Random();
                int n = rand.Next(1, 10);
                int[] arr = new int[n];
                int targetSum = 15;

                for (int j = 0; j < n; j++)
                {
                    arr[j] = rand.Next(10, 51);
                }

                int twoPointersResult = TwoPointersSumCount(arr, targetSum);
                int fullSearchResult = FullSearch(arr, targetSum);

                if (fullSearchResult != 0)
                {
                    Console.Write(fullSearchResult + " ");
                }

                if (twoPointersResult != fullSearchResult)
                {
                    Console.WriteLine("test failed");
                    return;
                }
            }

            Console.WriteLine("Yeah, niger!");
        }
    }
}
