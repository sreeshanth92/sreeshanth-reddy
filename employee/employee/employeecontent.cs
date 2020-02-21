using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace employee
{
    class employeecontent :DbContext
    {
       public DbSet<employee>  Employee { get; set; }
    }
}
