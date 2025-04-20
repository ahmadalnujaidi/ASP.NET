using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace databases
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cs = "data source = .; database = Sample; integrated security = SSPI";
            using (SqlConnection con = new SqlConnection(cs))
            {
                //string command = "Select * from tblProducts where ProductName like '" + TextBox1.Text + "%'";
                //SqlCommand cmd = new SqlCommand(command, con);
                // COULD CAUSE SQL INJECTION!
                // for example inserting ip' delete from tblProducts --

                // USING PARAMETRISED QUERIES
                SqlCommand cmd = new SqlCommand("Select * from tblProducts where ProductName like @ProductName", con);
                cmd.Parameters.AddWithValue("@ProductName", TextBox1.Text + "%");

                // OR USING STORED PROCEDURES

                
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
                
            }
        }
    }
}