using System.IO;

namespace _27ege
{
    class Task1786Class
    {
        public static void Run()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");
            string[] inp = file.ReadLine().Split();
            int n = int.Parse(inp[0]);
            int k = int.Parse(inp[1]);
            int count = 0;
            int sum = 0;
            int[,] mindif = new int[2, 10];

            for (int i = 0; i < n; i++)
            {
                if (count <= k)
                {
                    string[] input = file.ReadLine().Split();
                    int[] arr = new int[3];
                    arr[0] = int.Parse(input[0]);
                    arr[1] = int.Parse(input[1]);
                    arr[2] = int.Parse(input[2]);
                    Class1.Sorting(ref arr);

                    sum += arr[2] + arr[1];
                    int[] rem = { arr[2] - arr[1], arr[2] - arr[1], arr[1] - arr[0] };

                    for (int j = 0; j < 3; j++)
                    {
                        if (mindif[0, rem[j] % 7] == 0 || rem[j] < mindif[0, rem[j] % 7])
                        {
                            mindif[0, rem[j] % 7] = rem[j];    
                        }
                        if (mindif[1, rem[j] % 5] == 0 || rem[j] < mindif[1, rem[j] % 5])
                        {
                            mindif[1, rem[j] % 5] = rem[j];
                        }

                    }

                }
                else
                {
                    break;
                }
            }

            if (sum % 7 == 3 || sum % 10 == 5)
            {
                int temp = sum;

                for (int i = 0; i < 7; i++)
                {

                }
            }
        }
    }
}
