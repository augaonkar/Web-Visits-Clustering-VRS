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

public partial class Show_All_Visitors : System.Web.UI.Page
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
                getdata();
               
            }

        }
        catch (Exception)
        {

        }
    }

    private void getdata()
    {
        SqlDataAdapter da = new SqlDataAdapter("Select IPAddress,CountryName as [Country Name],CityName as [City Name],Latitude,Longitude,Visiting_Date as [Visiting Date] from Locations ORDER BY Visiting_Date DESC", con);
        DataSet ds = new DataSet();
        da.Fill(ds, "Locations");
        Grid_Log.DataSource = ds;
        Grid_Log.DataMember = "Locations";
        Grid_Log.DataBind();
        int cnttb = ds.Tables["Locations"].Rows.Count;
        Label1.Text = cnttb.ToString();
    }
    protected void Grid_Log_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        Grid_Log.PageIndex = e.NewPageIndex;
        getdata();
    }
}
