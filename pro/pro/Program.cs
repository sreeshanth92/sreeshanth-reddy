﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> multiply = (x, y) => Console.WriteLine("{0}", x * y);
            multiply(5, 8);
            Func<int, int, double> ad = (x, y) => x + y;
            Console.WriteLine("sum:{0} ", ad(4, 5));


            /* List<pro> courselist = new List<pro>();

            courselist.Add(new pro { Cid = 1, Cname = "c#", StartDate = DateTime.Today, Fees = 7000 });
            courselist.Add(new pro { Cid = 2, Cname = "webapps", StartDate = DateTime.Parse("05-02-2020"), Fees = 8000 });
            courselist.Add(new pro { Cid = 3, Cname = "python", StartDate = Convert.ToDateTime("08-02-2020"), Fees = 6000 });
            courselist.Sort(); */
            List<student12> stlist = new List<student12>();
            stlist.Add(new student12 { Id = 1, Studentname = "sreeshanth" });
            stlist.Add(new student12 { Id = 2, Studentname = "reddy" });
            stlist.Add(new student12 { Id = 3, Studentname = "bheemreddy" });
            // stlist.Sort();


            stlist.Sort((a, b) => a.Id.CompareTo(b.Id));
            /* foreach (var p in courselist)
            {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", p.Cid, p.Cname, p.Fees,p.StartDate);
            }*/

            foreach (var p in stlist)
            {
                Console.WriteLine("{0}\t{1}", p.Id, p.Studentname);
            }


            // Predicate<pro> fst = x => x.Cid == 3;
            // pro pt = courselist.Find(fst);
            // Console.WriteLine("{0}\t{1}\t{2}", pt.Cid, pt.Cname, pt.Fees);
            /* foreach (pro cr in courselist)
            {

            Console.WriteLine("{0}\t{1}\t{2}\t{3} ", cr.Cid, cr.Cname, cr.StartDate, cr.Fees);
            }*/




        }
    }
    }

