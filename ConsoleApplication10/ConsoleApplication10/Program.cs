using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{   
    class Complex
    {
        int a, b;
        public Complex (int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public static Complex operator +(Complex x, Complex y)
        {
            return new Complex(x.a + y.a, x.b + y.b);
        }
        public override string ToString()
        {
            return this.a + "," + b;    
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex lol = new Complex(3, 4);
            Complex lol1 = new Complex(1, 6);
            Console.WriteLine(lol+lol1);
            Console.ReadKey();
        }
    }
}
