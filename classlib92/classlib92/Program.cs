using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classlib92.Math

{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new person();
            john.FirstName = "sreeshanth";
            john.LastName = "reddy";
            john.Introduce();

            calculator cal = new calculator();
            var result = cal.Add(1,2);
            Console.WriteLine(result);
        }
    }
}
