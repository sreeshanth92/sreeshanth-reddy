using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advance
{
    class Program
    {
        public delegate void Mydelg(string s);

        static void Main(string[] args)
        {
            Mydelg delgt = a => Console.WriteLine(a);
            delgt("hello");
            Func<int, double, double> Calc = (x, y) => x * y;
            Console.WriteLine(Calc(12, 10.8));

            int[] nos = { 45, 23, 12, 98, 65 };
            var sort = nos.OrderBy(x => x);
                
            
        }
    }
}
