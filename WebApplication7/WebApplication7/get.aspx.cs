using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class get : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            task ta = new task();
            int Id = Convert.ToInt32(TextBox1.Text);
            var sreesha = ta.getdetails(Id);
            GridView1.DataSource = sreesha;
            GridView1.DataBind();
        }
        }
    }
