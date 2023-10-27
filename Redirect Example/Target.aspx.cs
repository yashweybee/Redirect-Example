using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Redirect_Example
{
    public partial class Target : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage == null)
            {
                string val = Request.QueryString["txt"];
                Response.Write("Hyper / redirect - " + val);
            }
            else if (PreviousPage.IsCrossPagePostBack)
            {
                //string val = Request.Form["txtBox"];

                //TextBox txtBox = (TextBox)PreviousPage.FindControl("txtBox");
                //string val = txtBox.Text;

                string val = PreviousPage.demoText;
                Response.Write("Cross page post back- " + val);
            }
            else
            {
                //string val = Context.Items["demoTxt"].ToString();

                string val = PreviousPage.demoText;

                Response.Write("Server Transfer- " + val);
            }

        }
    }
}