﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
    

namespace employee
{
    class employee
    {
        [Key]
        public int Eid { get; set;}
        public string Ename { get; set; }
        public string Designation { get; set; }

        public double salary { get; set; }
    }
}
