using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace time
{
    class sales
    {
        string productname;
        double quantity;
        double price;
        static double totalsales = 0;

        public string Pname
        {
            set { productname = value; }
            get { return productname; }
        }
        public double Quantity
        {
            set { quantity = value; }
            get { return quantity; }
        }
        public double Price
        {
            set { price = value; }
            get { return price; }

        }
        public double Salesamount
        {
            get { return price * Quantity; }
        }
        public double Totalsales
        {
            get { return totalsales += Salesamount; }

        }





    }
}
