using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace time
{
    class Program
    {
        static void Main(string[] args)
        {
            sales s1 = new sales();
            s1.Pname = "vodka";
            s1.Quantity = 5;
            s1.Price = 20;
            Console.WriteLine("{0}\n{1}\n{2}", s1.Pname, s1.Quantity, s1.Quantity, s1.Price);
            Console.WriteLine(s1.Salesamount);
            Console.WriteLine(s1.Totalsales);

            sales s2 = new sales();
            s2.Pname = "whiskey";
            s2.Quantity = 5;
            s2.Price = 10;
            Console.WriteLine("{0}\n{1}\n{2}", s2.Pname, s2.Price, s2.Quantity);
            Console.WriteLine(s2.Salesamount);
            Console.WriteLine(s2.Totalsales);
            Console.ReadKey();
            // oopconcept op = new oopconcept();
            // Console.WriteLine(op.area(12));
            //Console.WriteLine(op.area(10, 20));
            // Console.WriteLine(op.area(8));
            // Console.WriteLine(op.area(1, 20));


            // narutouzumaki nu = new narutouzumaki();
            //nu.Inch = 5;
            //Console.WriteLine("inches is {0}", nu.Inch);
            //nu.showCm();
            //product pd = new product { Id = 1, Pname = "chocolate", Price = 100 };
            // Console.WriteLine("{0}\n{1}\n{2}", pd.Id, pd.Pname, pd.Price);
            //TimeObjMethod();
        }
      /*  private static void TimeObjMethod()
        {
            timeperiod tp = new timeperiod();
            tp.hours = 15;
            Console.WriteLine("hours: {0}", tp.hours);
            tp.showseconds();
        
        }*/
    }
}
