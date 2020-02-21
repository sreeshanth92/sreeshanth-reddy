using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace codefirst
{
    class customercontext : DbContext
    {
        
            
            public customercontext() : base("customercontext") { }
        public DbSet<customer> customers { get; set; }
        public DbSet<product> products { get; set; }
        public DbSet<Purchase> purchases { get; set; }

    }

    }


