using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace viewState
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        int ClickCount = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox2.Text = "0";
            }
        }

        protected void Button2_Click (object sender, EventArgs e)
        {
            if (ViewState["Clicks"] != null)
            {
                ClickCount = (int)ViewState["Clicks"] + 1;
            }
            TextBox2.Text = ClickCount.ToString();
            ViewState["Clicks"] = ClickCount;
        }
    }
}