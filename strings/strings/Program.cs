using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            var firstName = "sreeshanth";
            var lastName = "hamedani";
            var myName = "uzumaki";

            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("my name is {0} {1}", firstName, lastName);
            var names = new string[3] { "john", "sreeshanth", "mary" };
            var formatedNames = string.Join(",", names);

            var text = @"Hi sreeshanth look into following paths 
c:/folder1/folder2";
            Console.WriteLine(text);

        }
    }
}
