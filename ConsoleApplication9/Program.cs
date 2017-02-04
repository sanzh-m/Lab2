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
        static bool check (int a)
        {
            if (a < 2) return false;
            for (int i=2; i<a; ++i)
            {
                if (a % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"input.txt");
            string[] numbers = text.Split(' ');
            int[] a = new int[numbers.Length];
            int[] b = new int[numbers.Length];
            int k = 0;
            for (int i = 0; i < numbers.Length; ++i)
            {
                a[i] = Convert.ToInt32(numbers[i]);
                if (check(a[i]))
                {
                    b[k] = a[i];
                    ++k;
                }
            }
            int max = int.MinValue;
            for (int i=0; i<k; ++i)
            {
                if (max < b[i]) max = b[i];
            }
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
