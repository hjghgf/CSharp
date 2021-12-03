using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _27ege
{
    class Task35484SecondTry
    {
        public static void Run()
        {
            var file = new StreamReader("..\\..\\..\\27.txt");

            int length = int.Parse(file.ReadLine());
            int[] arr = { 1, 2, 3 };

            Console.WriteLine(Array.BinarySearch(arr, 0));
        }
    }
}
