using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace _27ege
{
    class SegmentTreeRunProgram
    {
        public static int ChildIndex()
        {
            return 0;
        }

        static void QueryGeneration(int length, int i, int n = 4000000)
        {
            var rand = new Random();
            var name = "q" + i.ToString();
            var file = new StreamWriter(name);

            for (int j = 0; j < n; j++)
            {
                int index1 = rand.Next(length);
                int index2 = rand.Next(index1, length);
                file.WriteLine(index1.ToString() + " " + index2.ToString());
            }
            file.Close();
        }

        static void ArrayGenerator(int length, int i)
        {
            var name = "a" + i.ToString();
            var file = new StreamWriter(name);
            Random rand = new Random();

            for (int j = 0; j < length; j++)
            {
                file.WriteLine(rand.Next(100));
            }

            file.Close();
        }

        static void FileGenerator(int amount)
        {
            int length = 1000;
            for (int i = 0; i < amount; i++)
            {
                ArrayGenerator(length, i);
                QueryGeneration(length, i);
                length += 1000;
            }
        }

        static int StupidMethod(int[] arr, int index1, int index2)
        {
            int sum = 0;
            for (int i = index1; i <= index2; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        static void SegmentTreeRun()
        {
            int[] arr = new int[10];
            var st = new SegmentTree(arr);
            int n = 10000000;
            int sum = 0;
            //QueryGeneration();

            var file = new StreamReader("queries.txt");

            System.Diagnostics.Stopwatch stopWatch1 = new System.Diagnostics.Stopwatch();
            stopWatch1.Start();

            for (int i = 0; i < n; i++)
            {
                string[] inp = file.ReadLine().Split();
                sum = st.SumSegment(int.Parse(inp[0]), int.Parse(inp[1]));
            }

            stopWatch1.Stop();
            file.Close();

            Console.WriteLine(sum);
            TimeSpan ts = stopWatch1.Elapsed;
            string elapsedTime1 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine(elapsedTime1);

            file = new StreamReader("queries.txt");

            stopWatch1.Start();
            sum = 0;
            for (int i = 0; i < n; i++)
            {
                string[] inp = file.ReadLine().Split();
                sum = StupidMethod(arr, int.Parse(inp[0]), int.Parse(inp[1]));
            }
            Console.WriteLine(sum);

            stopWatch1.Stop();

            TimeSpan t = stopWatch1.Elapsed;
            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", t.Hours, t.Minutes, t.Seconds, t.Milliseconds / 10);
            Console.WriteLine(elapsedTime2);

        }

        static int[] ToArray(string name, int length)
        {
            var file = new StreamReader(name);
            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(file.ReadLine());
            }

            file.Close();

            return arr;
        }

        static void AnswerFile()
        {
            var ans = new StreamWriter("answer.txt");
            ans.Flush();

            for (int i = 0; i < 100; i++)
            {
                int[] arr = ToArray("a" + i.ToString(), (1 + i) * 1000);
                var st = new SegmentTree(arr);
                var file = new StreamReader("q" + i.ToString());

                System.Diagnostics.Stopwatch stopWatch1 = new System.Diagnostics.Stopwatch();
                stopWatch1.Start();

                for (int j = 0; j < 4000000; j++)
                {
                    string[] inp = file.ReadLine().Split();
                    st.SumSegment(int.Parse(inp[0]), int.Parse(inp[1]));
                }

                stopWatch1.Stop();
                file.Close();
                TimeSpan ts = stopWatch1.Elapsed;

                ans.WriteLine(arr.Length + " " + ts.Seconds);
            }

            ans.Close();
        }

        static void Garbage()
        {
            Random rand = new Random();
            int n = 1048576;

            var file1 = new StreamWriter("file1.txt");
            int length = 1024;

            for (int i = 0; i < length; i++)
            {
                file1.WriteLine(rand.Next(100));
            }

            file1.Close();

            var qfile1 = new StreamWriter("qfile1.txt");

            for (int j = 0; j < n; j++)
            {
                int index1 = rand.Next(length);
                int index2 = rand.Next(index1, length);
                qfile1.WriteLine(index1.ToString() + " " + index2.ToString());
            }

            qfile1.Close();

            var file2 = new StreamWriter("file2.txt");
            length = 16384;

            for (int i = 0; i < length; i++)
            {
                file2.WriteLine(rand.Next(100));
            }

            file2.Close();

            var qfile2 = new StreamWriter("qfile2.txt");

            for (int j = 0; j < n; j++)
            {
                int index1 = rand.Next(length);
                int index2 = rand.Next(index1, length);
                qfile2.WriteLine(index1.ToString() + " " + index2.ToString());
            }

            qfile2.Close();

            var file3 = new StreamWriter("file3.txt");
            length = 262144;

            for (int i = 0; i < length; i++)
            {
                file3.WriteLine(rand.Next(100));
            }

            file3.Close();

            var qfile3 = new StreamWriter("qfile3.txt");

            for (int j = 0; j < n; j++)
            {
                int index1 = rand.Next(length);
                int index2 = rand.Next(index1, length);
                qfile3.WriteLine(index1.ToString() + " " + index2.ToString());
            }

            qfile3.Close();

        }

        static void garbage2()
        {
            int n = 1048576;

            int[] arr1 = ToArray("file1.txt", 1024);
            var qfile1 = new StreamReader("qfile1.txt");
            var st1 = new SegmentTree(arr1);

            System.Diagnostics.Stopwatch stopWatch1 = new System.Diagnostics.Stopwatch();
            stopWatch1.Start();

            for (int i = 0; i < n; i++)
            {
                string[] inp = qfile1.ReadLine().Split();
                st1.SumSegment(int.Parse(inp[0]), int.Parse(inp[1]));
            }

            stopWatch1.Stop();
            qfile1.Close();

            TimeSpan ts1 = stopWatch1.Elapsed;

            Console.WriteLine("1024" + " " + ts1.Milliseconds);

            int[] arr2 = ToArray("file2.txt", 16384);

            var qfile2 = new StreamReader("qfile2.txt");
            var st2 = new SegmentTree(arr2);

            System.Diagnostics.Stopwatch stopWatch2 = new System.Diagnostics.Stopwatch();
            stopWatch2.Start();

            for (int i = 0; i < n; i++)
            {
                string[] inp = qfile2.ReadLine().Split();
                st2.SumSegment(int.Parse(inp[0]), int.Parse(inp[1]));
            }

            stopWatch2.Stop();
            qfile2.Close();

            TimeSpan ts2 = stopWatch2.Elapsed;

            Console.WriteLine("16384" + " " + ts2.Milliseconds);

            int[] arr3 = ToArray("file3.txt", 262144);

            var qfile3 = new StreamReader("qfile3.txt");
            var st3 = new SegmentTree(arr3);

            System.Diagnostics.Stopwatch stopWatch3 = new System.Diagnostics.Stopwatch();
            stopWatch3.Start();

            for (int i = 0; i < n; i++)
            {
                string[] inp = qfile3.ReadLine().Split();
                st3.SumSegment(int.Parse(inp[0]), int.Parse(inp[1]));
            }

            stopWatch3.Stop();
            qfile3.Close();

            TimeSpan ts3 = stopWatch3.Elapsed;

            Console.WriteLine("262144" + " " + ts3.Milliseconds);


        }
    }
}