using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace codetask
{
    class product
    {
        [Key]
        public int Pid { get; set; }
        public int Pname { get; set; }

        public int list<Price> { get; set; }


    }
}
