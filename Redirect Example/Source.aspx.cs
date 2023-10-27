using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Redirect_Example
{
    public partial class Source : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Resedirect(object sender, EventArgs e)
        {
            string val = txtBox.Text;
            Response.Redirect("Target.aspx?txt=" + val);
        }

        protected void btn_ServerTransfer(object sender, EventArgs e)
        {
            Context.Items["demoTxt"] = txtBox.Text;
            Server.Transfer("Target.aspx");
        }

        public string demoText
        {
            get
            {
                return txtBox.Text;
            }
        }

        protected void btn_CrossPagePostBack(object sender, EventArgs e)
        {

        }
    }
}