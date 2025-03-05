using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace customValidator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void serverVal(object source, ServerValidateEventArgs args)
        {
            if (args.Value == "")
            {
                args.IsValid = false;
            }
            else
            {
                int Number;
                bool isNumber = int.TryParse(args.Value, out Number);

                if (isNumber && Number >= 0 && Number % 2 == 0)
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
               
                Label1.Text = "Page is valid";
                Label1.ForeColor= System.Drawing.Color.Green;
            }
            else
            {
               
                Label1.Text = "Page is not valid";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}