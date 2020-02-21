using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            task ta = new task();
            int Id = int.Parse(TextBox1.Text);
            string Name = TextBox2.Text;
            string Location = TextBox3.Text;
            string Course = TextBox4.Text;
            ta.insertrow(Id, Name, Location, Course);
        }

        }
    }
