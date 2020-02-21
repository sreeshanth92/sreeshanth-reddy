using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sreesahadatafirst
{
    class Program
    {
        static sreemodelContainer af = new sreemodelContainer();
        static void Main(string[] args)

        {

            Console.WriteLine("enter bid");
            int bid = int.Parse(Console.ReadLine());

            Console.WriteLine("enter cid");
            int cid = int.Parse(Console.ReadLine());





            var ban = new bank
            {
                bid = bid,
                cid = cid,




            };
            af.banks.Add(ban);
            af.SaveChanges();

        }
        private static void insertmethod()
        {
            Console.WriteLine("enter cid");
            int cid = int.Parse(Console.ReadLine());

            Console.WriteLine("enter cname");
            string cname = Console.ReadLine();

            var cus = new customer
            {
                cid = cid,
                cname = cname,



            };
            af.customers.Add(cus);
            af.SaveChanges();
        }
    }
}

