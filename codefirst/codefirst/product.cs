using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace codefirst
{
    class product
    {
        [Key]
        public int Pid { get; set; }
        [MaxLength(250)]
        public string pname { get; set; }
        [Required]
        public double Price { get; set; }

        public virtual ICollection<Purchase>Purchases { get; set; }
    }
}
