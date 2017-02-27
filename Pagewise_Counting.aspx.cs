using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class Pagewise_Counting : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                if (Session["U_name"] == null)
                {
                    Response.Redirect("AdminLogin.aspx");
                }
                else
                {
                    GetData();
                }
            }

        }
        catch (Exception)
        {

            throw;
        }
    }
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cntr"].ToString());

    protected void Grid_Log_PageIndexChanging1(object sender, GridViewPageEventArgs e)
    {
        Grid_Log.PageIndex = e.NewPageIndex;
        GetData();
    }
    private void GetData()
    {
        try
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Page,Count from tbl_Pagecnt", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_Pagecnt");
            Grid_Log.DataSource = ds;
            Grid_Log.DataMember = "tbl_Pagecnt";
            Grid_Log.DataBind();
            int cnttb = ds.Tables["tbl_Pagecnt"].Rows.Count;
            
        }
        catch (Exception)
        {


        }
    }
}
