﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void showdata(int m,int n)
        {
            double sum = m + n;
            Console.WriteLine("sum is {0}", sum);
            m += 5;n += 5;

        }
        static void showref(ref int m,ref int n)
        {
            double sum = m + n;
            Console.WriteLine("sum is {0}", sum);
            m += 5; n += 5;
        }

        static void Main(string[] args)
        {
            int a, b; a = 10; b = 20;
            showdata(a, b);
            Console.WriteLine("values called {0} and {1}", a, b);
            showref(ref a, ref b);
            Console.WriteLine("callbyref by reference values {0} and {1}", a, b);
            

        }
    }
}
