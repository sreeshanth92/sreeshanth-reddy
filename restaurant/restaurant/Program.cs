using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace conn
{
    class Class1
    {
        static void Main(string[] args)
        {
            restaurant2 res = new restaurant2();
            res.show();
            res.insert();
            res.show();

        }
    }
}
