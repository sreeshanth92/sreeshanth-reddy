using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace codenani
{
    class employeecontext :DbContext
    {
        public DbSet<employee> Employees { get; set; }
    }
}
