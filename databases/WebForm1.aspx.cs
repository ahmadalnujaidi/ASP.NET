using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;
//using System.Data.OracleClient; ?


namespace databases
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("data source=.; database=Sample; integrated security=SSPI");
            //SqlCommand cmd = new SqlCommand("Select * from tblProduct", con);
            //con.Open();
            //SqlDataReader rdr = cmd.ExecuteReader();
            //GridView1.DataSource = rdr;
            //GridView1.DataBind();
            //con.Close();



        }

    }
}