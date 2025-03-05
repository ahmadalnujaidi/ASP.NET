using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace compareValidator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                Response.Write("<p style='color: green'> Page is valid </p>");
                
            }
            else
            {
                Response.Write("<p style='color: red'> Page is not valid </p>");
            }
        }
    }
}