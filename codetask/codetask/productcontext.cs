﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace codetask
{
    class productcontext:DbContext
    {
        public DbSet<customer> Customer { get; set; }
    }
}
