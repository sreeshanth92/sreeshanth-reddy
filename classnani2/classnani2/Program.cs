using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classnani2
{
    class program
    {
        static void Main(string[] args)
        {
            student std = new student();
            std.Name = "sreeshanth";
            std.Id = 370;
            std.Course = "CSE";
            std.Joindate = Convert.ToDateTime("02-23-1998");
            Console.WriteLine("name is {0}\n id is {1}", std.Name, std.Id);
            Console.WriteLine("course : {0}\n joining date is {1}", std.Course, std.Joindate);





        }



            





        }
    }
