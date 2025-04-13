using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace databases
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = "data source=.; database=Sample; integrated security=SSPI";
            //SqlConnection con = new SqlConnection(CS);
            //try
            //{
            //    SqlCommand cmd = new SqlCommand("Select * from tblProducts", con);
            //    con.Open();
            //    GridView1.DataSource = cmd.ExecuteReader();
            //    GridView1.DataBind();
            //}
            //catch 
            //{

            //}
            //finally
            //{
            //    con.Close();
            //}

            using (SqlConnection con = new SqlConnection(CS))
            {

                SqlCommand cmd = new SqlCommand("Select * from tblProducts", con);
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
  
            }


        }
    }
}