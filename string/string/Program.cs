using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "helloworld!";
            Console.WriteLine(data);
            string a = data.Insert(6, "my");
            Console.WriteLine(a);
            Console.WriteLine(string.Concat(a, bn));
            string up = data.ToUpper();
            string lc = up.ToLower();
            Console.WriteLine("{0}\t{1}", up, lc);
            string[] names = new string[] { "sreeshanth", "discoraja", "uzumakinaruto" };
            foreach(string st in names)
            {
                Console.WriteLine(st);
            }
            string allnames = string.Join(",", names);
            Console.WriteLine(allnames);
            string st1 = "welcome to c#";
            string[] words = st1.Split();
            foreach(string s in words)
            {
                Console.WriteLine(s);
            }
            string nstr = string.Copy(st1);
            Console.WriteLine("copied string is {0}", nstr);
            int i = st1.IndexOf("to");
            Console.WriteLine("index of {1} is ", i);
            int i = st1.Length;
            Console.WriteLine("length of string {0}", 1);
            words.Reverse();

        }
    }
}
