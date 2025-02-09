using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace viewState
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox3.Text = "0";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int ClicksCount = Convert.ToInt32(TextBox3.Text) + 1;
            TextBox3.Text = ClicksCount.ToString();
        }
    }
}