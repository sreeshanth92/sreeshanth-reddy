using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace codetask
{
    class customer:product
    {
        [Key]
        public int Cid { get; set; }

        public string Cname { get; set; }

        public list<product> product { get; set; }

           

    }
}
