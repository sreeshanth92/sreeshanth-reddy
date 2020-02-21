using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classnani2
{
    class student
    {
        string name;
        string firstname;
        string lastname;
        int id;
        string course;
        DateTime joindate;
        public student() {}
        public student(string fn,string ln)
            {
            firstname = fn;
            secondname = sn;

}
            
       


        public string Name
        {
           get {return string.Format("{0} {1}", firstname, lastname);}
        }
        public int Id
        {
            get { return id; }
            set { id = value; }

        }
        public string Course
        {
            get { return course; }
            set{course=value;}


        

        }
        public DateTime Joindate
        {
            get { return joindate; }
            set { joindate = value; }
        }
    

    }
}
