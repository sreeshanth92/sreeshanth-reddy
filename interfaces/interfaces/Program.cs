using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class Program
    {
        class doit:Ihello
        {
            public void getit()
            {
                Console.WriteLine("sasukeuchiha");
            }
        }
        static void Main(string[] args)
        {
            doit d = new doit();
            d.getit();
        }
    }
}
