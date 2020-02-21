using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace classlib
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 cl = new Class1();
            cl.No1 = 400;
            cl.No2 = 50;
            Console.WriteLine(cl.Add());
            Console.WriteLine(cl.Difference());
            Console.WriteLine(cl.Multiply());
            Console.WriteLine(cl.division());


        }
    }
}
