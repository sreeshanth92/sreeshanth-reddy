using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codetask1
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<product> plis = new List<product>();
            productcontext pct = new productcontext();
            Console.WriteLine("enter product id");
            int pid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter product name");
            string pname = Console.ReadLine();
            Console.WriteLine("enter product price");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter customer id");
            int cid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter customer name");
            string cname = Console.ReadLine();
            pct.Customer.Add(new customer
            {
                Cid = cid,
                Cname = cname,
                product = new List<product> {
new product
{
Pid = pid,
Pname = pname,
Price = price
}
}
            });
            pct.SaveChanges();
        }
    }
}
