using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aggregation
{
    class program
    {
        public static void Main(string[] args)
        {
            customer c = new customer
            {
                Cid = 12,
                Name = "sreeshanth",
                Address = "hyderabad",
                b = new bank { Acno = 12345678 }

            };
            Console.WriteLine("cust id is {0}\nmname is {1}\n address is {2}\n", c.Cid, c.Name, c.Address);
            Console.WriteLine("acno is {0}\n", c.b.Acno);
            Console.WriteLine("balance is {0}", c.interestamount(24000));

            bank bk = new bank();


            Console.WriteLine("total balance is {0}", bk.interestamount(24000));
            fixedamount fd = new fixedamount();
            Console.WriteLine("fixed deposit amount with additional interest:{0}", fd.interestamount(24000));

                
        }
    }
}