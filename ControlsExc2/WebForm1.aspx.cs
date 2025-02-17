using System;
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
            String txt = "Dear " + DropDownList1.SelectedItem.Text + " " + TextBox1.Text + ", your ";
            if (CheckBox1.Checked)
            {
                txt += "student ";
            }
            txt = txt + "registration is successful";
            Response.Write(txt);
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            DropDownList1.SelectedIndex = 0;
            TextBox1.Text = "";
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            CheckBox1.Checked = false;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ListItem li1 = new ListItem("Dr.");
            ListItem li2 = new ListItem("Engr.");

            // only add if they do not exist
            if (!DropDownList1.Items.Contains(li1)) { DropDownList1.Items.Add(li1); }
            if (!DropDownList1.Items.Contains(li2)) { DropDownList1.Items.Add(li2); }

            //DropDownList1.Items.Add(li1);
            //DropDownList1.Items.Add(li2);
        }
    }
}