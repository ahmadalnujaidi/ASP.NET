using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace databases
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("data source = .; database = Sample; integrated security= SSPI"))
            {
                //SqlCommand cmd = new SqlCommand("select ProductId, ProductName, Description, Price, Quantity from tblProducts", con); executeReader

                //SqlCommand cmd = new SqlCommand("select count(productId) from tblProducts", con); // executreScalar

                //SqlCommand cmd = new SqlCommand("insert into tblProducts values (4, 'Apple watch', 'Appleshit', 100.90, 250)", con); // insert into table executeNonQuery

                //SqlCommand cmd = new SqlCommand("update tblProducts set Quantity = 200 where ProductID = 1", con); // update table executeNonQuery

                SqlCommand cmd = new SqlCommand("delete from tblProducts where ProductID = 3", con); // DELETE from table executeNonQuery

                con.Open();
                //GridView1.DataSource = cmd.ExecuteReader();
                //GridView1.DataBind();

                //int totalRows = (int)cmd.ExecuteScalar();
                //Response.Write(totalRows);

                int affectedRows = cmd.ExecuteNonQuery();
                Response.Write(affectedRows);

            }
        }
    }
}