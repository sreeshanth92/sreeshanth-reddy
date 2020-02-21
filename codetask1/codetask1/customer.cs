using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace codetask1
{
    class customer:product
    {
        [Key]
        public int Cid { get; set; }
        public string Cname { get; set; }
        public List<product> product { get; set; }


    }
}
