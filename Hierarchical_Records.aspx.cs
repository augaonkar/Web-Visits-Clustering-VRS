using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class Hierarchical_Records : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cntr"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["U_name"] == null)
            {
                Response.Redirect("AdminLogin.aspx");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select Distinct RegionName from Locations", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.Close();
                gvParentGrid.DataSource = ds;
                gvParentGrid.DataBind();
            }
        }
        catch (Exception)
        {
        
        }
       

    }

    protected void gvUserInfo_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                con.Open();
                GridView gv = (GridView)e.Row.FindControl("gvChildGrid");
                //int CountryId = Convert.ToInt32(e.Row.Cells[1].Text);
                string Statename = e.Row.Cells[1].Text;
                SqlCommand cmd = new SqlCommand("select Distinct CityName from Locations where RegionName='" + Statename + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.Close();
                gv.DataSource = ds;
                gv.DataBind();
            }
        }
        catch (Exception)
        {
            
        }
     
    }
}
