using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classnani2
{
    class exam
    {
        string name, subject, subcode;
        string date;
        public void getdata(string nm, string sub, string scode, string dt)
        {
            name = nm;
            subject = sub;
            subcode = scode;
            date = dt;

        }
        public void ShowData()
        {
            Console.WriteLine(name);
            Console.WriteLine(subject);
            Console.WriteLine(subcode);
            Console.WriteLine(date);

        }





    }
}