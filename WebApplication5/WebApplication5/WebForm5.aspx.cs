using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApplication5
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        void Page_PreRender()
        {
            string uploadfolder = MapPath("~/Resources/");
            DirectoryInfo dir = new DirectoryInfo(uploadfolder);
            DataList1.DataSource = dir.GetFiles();
            DataList1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        bool CheckFileType(string fileName)
        {
            string ext = Path.GetExtension(fileName);
            switch (ext.ToLower())
            {
                case ".gif":
                    return true;
                case ".png":
                    return true;
                case ".jpg":
                    return true;
                case ".jpeg":
                    return true;
                default:
                    return false;

            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload.HasFile)
            {
                if (CheckFileType(FileUpload.FileName))
                {
                    FileUpload.SaveAs(MapPath("~/Resources/" + FileUpload.FileName));
                }
            }
        }
    }
}