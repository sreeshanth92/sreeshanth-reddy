using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {
            task ta = new task();
            int Id = Convert.ToInt32(TextBox1.Text);
            string Location = TextBox2.Text;
            ta.updatedata(Id, Location);
        }
    }
}