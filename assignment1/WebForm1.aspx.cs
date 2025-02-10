using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace assignment1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write("<p style='color:"+ Session["Color"].ToString()+ "' > Hello!</p>");
            TextBox1.Text = Session["Color"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Color"] = TextBox1.Text;
        }
    }
}