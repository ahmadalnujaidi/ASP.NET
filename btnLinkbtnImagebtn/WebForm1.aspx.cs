﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace btnLinkbtnImagebtn
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Response.Write("Submit Button Clicked");
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Response.Write("Link Button Clicked");
        }
    }
}