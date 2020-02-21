using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ARRAYLIST
{
    class Program
    {
        static void Main(string[] args)
        {
            //  list();

           // sortedlist();

            ArrayList a1 = new ArrayList() { "sri", "venu", "sunil", "brahmi" };
            foreach (string a in a1)
            {
                Console.WriteLine(a);
            }
            a1.Sort();
            foreach (string a in a1)
            {
                Console.WriteLine(a);
            }
            a1.Add("rookie");
            a1.Add("reddy");
            a1.Insert(4, "sreeshanth");
            Console.WriteLine();
            foreach (string a in a1)
            {
                Console.WriteLine(a);
            }
            a1.Reverse();
            foreach (string a in a1)
            {
                Console.WriteLine(a);
            }
            string[] r = new string[] { "cat", "mat" };
            a1.SetRange(4, r);
            foreach (string a in a1)
            {
                Console.WriteLine(a);
            }
            a1.RemoveRange(2, 2);
            Console.WriteLine();
            foreach (string a in a1)
            {
                Console.WriteLine(a);
            }
        }

        private static void sortedlist()
        {
            SortedList slist = new SortedList();
            slist.Add("akthar", 234);
            slist.Add("malik", 134);
            slist.Add("umar", 213);
            slist.Add("kamran", 678);
            foreach (string k in slist.Keys)
            {
                Console.WriteLine(k);
            }
            foreach (string v in slist.Values)
            {
                Console.WriteLine(v);
            }
        }

        private static void list()
        {
            List<project> courselist = new List<project>();
            courselist.Add(new project
            {
                Cid = 1,
                Cname = "c#",
                Designation = 
                Fees = 6000
            });
            courselist.Add(new project
            {
                Cid = 2,
                Cname = "sreeshanth",
                StartDate = DateTime.Parse("09-02-2019"),
                Fees = 8000
            }
                );
            courselist.Add(new project
            {
                Cid = 3,
                Cname = "python",
                StartDate = Convert.ToDateTime("09-01-2019"),
                Fees = 10000
            }
                );

            foreach (project cr in courselist)

            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",
                    cr.Cid, cr.Cname, cr.StartDate, cr.Fees);

            }
            foreach (KeyValuePair<int, project> dc in dcrs)
}
        SortedDictionary<int, string> sort = new SortedDictionary<int, string>();
        


                    
            }
        }
    



