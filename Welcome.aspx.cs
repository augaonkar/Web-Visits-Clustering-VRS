using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class Welcome : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cntr"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int count = 0;
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Pagecnt where Id='1'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_Pagecnt");
            if (ds.Tables[0].Rows.Count > 0)
            {
                count = Convert.ToInt32(ds.Tables[0].Rows[0]["Count"].ToString()) + 1;
            }
            else
            {
                count = 1;
            }
            SqlDataAdapter da1 = new SqlDataAdapter("update tbl_Pagecnt set Count='" + count + "' where Id='1'", con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "tbl_Pagecnt");
        }
    }
}
