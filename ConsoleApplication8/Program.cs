using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"input.txt");
            string[] numbers = text.Split(' ');
            int[] a = new int[numbers.Length];
            for (int i = 0; i< numbers.Length; ++i)
            {
                a[i] = Convert.ToInt32(numbers[i]);
            }
            int max, min;
            max = int.MinValue;
            min = int.MaxValue;
            for (int i = 0; i < numbers.Length; ++i)
            {
                if (max < a[i]) max = a[i];
                if (min > a[i]) min = a[i];
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}
