﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsExc2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String txt = "Dear " + DropDownList1.SelectedItem.Text + " " + TextBox1.Text + ", your registration is successful. <br /><br />";
            Response.Write(txt);
        }
    }
}