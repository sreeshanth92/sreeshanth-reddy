using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst
{
    class Program
    {
        static EMPLOYEEDBEntities edb = new EMPLOYEEDBEntities();
        static void Main(string[] args)
        {
            show();
            depinsert();
            employeeinsert();

        }

        private static void employeeinsert()
        {
            Console.WriteLine("enter eid");
            string Eid = Console.ReadLine();
            Console.WriteLine("enter ename");
            string ename = Console.ReadLine();
            Console.WriteLine("enter designation");
            string Designation = Console.ReadLine();
            Console.WriteLine("enter dep id");
            string deptid = Console.ReadLine();
            var Employee = new Employee
            {
                Eid = Eid,
                Ename = ename,
                Designation = Designation,
                Did = deptid


            };
            edb.Employees.Add(Employee);
            edb.SaveChanges();
        }

        private static void depinsert()
        {
            Console.WriteLine("enter depid");
            int depid = int.Parse(Console.ReadLine());
            Console.WriteLine("enter depname");
            string depname = Console.ReadLine();
            Console.WriteLine("enter description");
            string descripion = Console.ReadLine();
            var DEPARTMENT = new DEPARTMENT
            {
                DEPID = depid,
                DEPNAME = depname,
                DESCRIPION = descripion

            };
            edb.DEPARTMENTs.Add(DEPARTMENT);
            edb.SaveChanges();
        }

        private static void show()
        {
            Console.WriteLine("All available department...");
            var DEPARTMENTs = edb.DEPARTMENTs;
            foreach (var s in DEPARTMENTs)
            {
                Console.WriteLine("{0}\t{1}\t{2}", s.DEPID, s.DEPNAME, s.DESCRIPION);
            }
            var Employees = edb.Employees;
            foreach (var e in Employees)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", e.Eid, e.Ename, e.Designation, e.Did);
            }
        }
    }
}
