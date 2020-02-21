using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            restaurant r = new restaurant();
            r.menu();
        }
    }
}
