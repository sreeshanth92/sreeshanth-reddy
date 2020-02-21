using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static double multiply(int a, int b)
        {
            double mul = a * b;
            return mul;

        }

        static void Main(string[] args)
        {
            int a, b; a = 57; b = 45;
            double res = multiply(a, b);
            Console.WriteLine("product of {0} and {1} = {2}", a, b, res);


        }
    }
}