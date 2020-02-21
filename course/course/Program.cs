using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<course1> clst = new List<course1>()
            {
                new course1{Cid = 1,Cname = "c#",Fees = 7000,Startdate = Convert.ToDateTime("11-02-2020")},
                new course1{Cid=2,Cname="css",Fees = 5000,Startdate=Convert.ToDateTime("09-02-1998") },
                 new course1{Cid=3,Cname="ADO.net",Fees = 5000,Startdate=Convert.ToDateTime("09-02-1967") },
                  new course1{Cid=4,Cname="ASP.net",Fees = 8000,Startdate=Convert.ToDateTime("09-02-1997") },
            };
            var query = from aq in clst
                        select aq;
            foreach(var q in query)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\n", q.cid, q.Cname, q.startdate.ToShortDateString(), q.Fees);
            }
            var qget = from gq in clst
                       where gq.Cid == 2
                       select gq;
            foreach(var q in qget)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\n", q.Cid, q.Cname, q.startdate.ToShortDateString(), q.Fees);

            }
            var qget = from gq in clst
                       where gq.Cid == 2
                       select gq;
            foreach (var q in qget)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\n", q.Cid, q.Cname, q.startdate.ToShortDateString(), q.Fees);
            }
            var query = from gq in clst
                       where gq.Cid == 2
                       select gq;
            foreach (var q in qget)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\n", q.Cid, q.Cname, q.startdate.ToShortDateString(), q.Fees);
            }
        }
    }
}
