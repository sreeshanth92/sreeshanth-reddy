using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aggregation
{
    class customer
    {
        int cid;
        string name;
        string address;
        public int Cid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bank b { get; set; }
        public virtual string interestamount(double interest)
        {
            return interest.ToString();
        }
    }
}
