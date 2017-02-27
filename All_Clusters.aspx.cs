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

public partial class All_Clusters : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["U_name"]== null)
            {
                Response.Redirect("AdminLogin.aspx");
            }
            else
            {
                //GetData();
                getdistinctcity();
               
            }
          
        }
        catch (Exception)
        {

        }
    }

    private void getdistinctcity()
    {
        SqlDataAdapter da = new SqlDataAdapter("select distinct CityName from Master_Product", con);
        DataSet ds = new DataSet();
        da.Fill(ds, "Master_Product");
        int disregioncount = ds.Tables[0].Rows.Count;
        Label2.Text = disregioncount.ToString();
        for (int i = 0; i < disregioncount; i++)
        {
            ddl_city.Items.Add(ds.Tables[0].Rows[i]["CityName"].ToString());
        }
    }
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cntr"].ToString());

    private void GetData()
    {
        SqlDataAdapter da = new SqlDataAdapter("select Latitude,Longitude,CityName as [Cluster] from Master_Product where CityName = '"+ddl_city.SelectedItem.Text+"'", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        int cnt = ds.Tables[0].Rows.Count;
        if (cnt > 0)
        {
            Label1.Text = cnt.ToString();
           
            GV_data.DataSource = ds;
            GV_data.DataBind();
        }
      
    }


    protected void GV_data_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GV_data.PageIndex = e.NewPageIndex;
        GetData();
    }

    protected void ddl_city_SelectedIndexChanged(object sender, EventArgs e)
    {
        GetData();
    }
}
