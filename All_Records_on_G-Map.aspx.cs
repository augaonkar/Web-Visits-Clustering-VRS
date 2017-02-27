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

public partial class All_Records_on_G_Map : System.Web.UI.Page
{
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
                Getall();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select Latitude, Longitude,ProductCategory from Master_Product", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);
                int cnt = dt.Rows.Count;
                if (cnt > 0)
                {
                    Label3.Text = "No of Visitors : " + cnt;
                }
                else
                {
                    Label3.Text = "No of Visitors : 0";
                }
                rptMarkers.DataSource = dt;
                rptMarkers.DataBind();
            }
        }
        catch (Exception)
        {

        }
    }
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cntr"].ToString());

    private void Getall()
    {
        try
        {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select  IPAddress AS [IP Address],CountryName AS [Country],CityName AS [City],Latitude,Longitude,Visiting_Date AS [Visiting Date] from Master_Product order by Visiting_Date DESC", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);
                gv_data.DataMember = "Master_Product";
                gv_data.DataSource = dt;
                gv_data.DataBind();
        }
        catch (Exception)
        {
            
            throw;
        }
    }


    protected void gv_data_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv_data.PageIndex = e.NewPageIndex;
        Getall();
    }
}
