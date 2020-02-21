using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirst
{
    class Program
    {
        public static void insert()
        {

        
        customercontext ctx = new customercontext();
        var customers = new List<customer>
{
new customer{Cname="sreeshanth",Caddress="chennai "},
new customer{Cname="shiva",Caddress="Mumbai"},
new customer{Cname="Akhil",Caddress="Manglore"},

};
        customers.ForEach(s => ctx.customers.Add(s));
            ctx.SaveChanges();
            var products = new List<product>
{
new product{pname="Maggie",Price=75},
new product{pname="pastha",Price=95},
new product{pname="Momos",Price=65}
};
        products.ForEach(p => ctx.products.Add(p));
            ctx.SaveChanges();
            var purchases = new List<Purchase>
{
new Purchase { OrderDate=Convert.ToDateTime("09-02-2020"),Pid=1,Cid=2},
new Purchase{OrderDate=Convert.ToDateTime("02-06-2020"),Pid=2,Cid=1},
new Purchase{OrderDate=Convert.ToDateTime("05-05-2020"),Pid=3,Cid=2}

};
        purchases.ForEach(pr => ctx.purchases.Add(pr));
            ctx.SaveChanges();
        }
        public static void show()
        {
            customercontext c = new customercontext();
            var customers = c.customers;
            Console.WriteLine("customer details ");
            foreach (var p in customers)
            {
                Console.WriteLine("{0}\t{1}\t{2}", p.Cid, p.Cname, p.Caddress);
            }
            var products = c.products;
            Console.WriteLine("product details ");
            foreach (var p in products)
            {
                Console.WriteLine("{0}\t{1}\t{2}", p.Pid, p.pname, p.Price);
            }
            var purchases = c.purchases;
            Console.WriteLine("{0,-8}{1,-14}{2,-8}{3,-15}{4,10}{5,8}{6,15}", "purch_ID", "OrderDate", "pid", "prd_name", "price", "cust_id", "Custname");
            Console.WriteLine("purchase details ");

            foreach (var p in purchases)
            {
                Console.WriteLine("{0,-8}{1,-14}{2,-8}{3,-15}Rs{4,10:N}{5,8}{6,15}", p.Id, p.OrderDate.ToShortDateString(), p.Pid, p.product.pname, p.product.Price, p.Cid, p.Customer.Cname);
                // Console.WriteLine("{0}\t{1}\t{2}", p.id, p.OrderDate, p.cid, p.pid);
            }
        }
    static void Main(string[] args)
        {
            insert();
            show();
        }
    }
}
