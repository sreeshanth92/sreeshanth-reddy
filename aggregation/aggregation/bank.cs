using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aggregation
{
    class bank:customer
    {
        double acno;
        double balance;
        public double Acno { get; set; }
        public double Balancee { get; set; }

        public override string interestamount(double balance)
        {
            double interest = 0.03 * balance;
            double totalbalance = balance + interest;
            return totalbalance.ToString();

        }
    }
}
