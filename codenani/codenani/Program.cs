using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codenani
{
    class Program
    {
        static void Main(string[] args)
        {
            //insertdata();
            employeecontext empl = new employeecontext();

            var employees = empl.Employees;
            foreach(var emp in employees)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",emp.Eid,emp.Ename,emp.Designation,emp.salary);
            }

        }

        private static void insertdata()
        {
            employeecontext emp = new employeecontext();

            Console.WriteLine("enter employee name");
            string name = Console.ReadLine();
            Console.WriteLine("enter designation");
            string desg = Console.ReadLine();
            Console.WriteLine("enter salary");
            double sal = Convert.ToDouble(Console.ReadLine());

            emp.Employees.Add(new employee
            {
                Ename = name,
                Designation = desg,
                salary = sal
            }
                );
            emp.SaveChanges();
        }
    }
}
