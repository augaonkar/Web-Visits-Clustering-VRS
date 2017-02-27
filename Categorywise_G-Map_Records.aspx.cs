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

public partial class Categorywise_G_Map_Records : System.Web.UI.Page
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
            { }
        }
        catch (Exception)
        {
          
        }
       
    }
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cntr"].ToString());

    protected void btn_get_Click(object sender, EventArgs e)
    {
        Getall();      
    }

    private void Getall()
    {
        try
        {

            if (ddl_cat.SelectedItem.Text.StartsWith("Sony"))
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select  IPAddress AS [IP Address],CountryName AS [Country],CityName AS [City],Latitude,Longitude,Visiting_Date AS [Visiting Date] from Master_Product where ProductCategory='category_1' order by Visiting_Date DESC", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);

                SqlCommand cmd1 = new SqlCommand("Select  IPAddress AS [IP Address],CountryName AS [Country],CityName AS [City],Latitude,Longitude,Visiting_Date AS [Visiting Date] from Master_Product where ProductCategory='category_2' order by Visiting_Date DESC", con);
                SqlDataAdapter da1 = new SqlDataAdapter();
                da1.SelectCommand = cmd1;
                da1.Fill(dt);
                SqlCommand cmd2 = new SqlCommand("Select  IPAddress AS [IP Address],CountryName AS [Country],CityName AS [City],Latitude,Longitude,Visiting_Date AS [Visiting Date] from Master_Product where ProductCategory='category_3' order by Visiting_Date DESC", con);
                SqlDataAdapter da2 = new SqlDataAdapter();
                da2.SelectCommand = cmd2;
                da2.Fill(dt);
                SqlCommand cmd3 = new SqlCommand("Select  IPAddress AS [IP Address],CountryName AS [Country],CityName AS [City],Latitude,Longitude,Visiting_Date AS [Visiting Date] from Master_Product where ProductCategory='category_4' order by Visiting_Date DESC", con);
                SqlDataAdapter da3 = new SqlDataAdapter();
                da3.SelectCommand = cmd3;
                da3.Fill(dt);
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
                gv_data.DataMember = "Master_Product";
                gv_data.DataSource = dt;
                gv_data.DataBind();
            }
            if (ddl_cat.SelectedItem.Text.StartsWith("Canon"))
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select  IPAddress AS [IP Address],CountryName AS [Country],CityName AS [City],Latitude,Longitude,Visiting_Date AS [Visiting Date] from Master_Product where ProductCategory='category_5' order by Visiting_Date DESC", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);
                SqlCommand cmd1 = new SqlCommand("Select  IPAddress AS [IP Address],CountryName AS [Country],CityName AS [City],Latitude,Longitude,Visiting_Date AS [Visiting Date] from Master_Product where ProductCategory='category_6' order by Visiting_Date DESC", con);
                SqlDataAdapter da1 = new SqlDataAdapter();
                da1.SelectCommand = cmd1;
                da1.Fill(dt);
                SqlCommand cmd2 = new SqlCommand("Select  IPAddress AS [IP Address],CountryName AS [Country],CityName AS [City],Latitude,Longitude,Visiting_Date AS [Visiting Date] from Master_Product where ProductCategory='category_7' order by Visiting_Date DESC", con);
                SqlDataAdapter da2 = new SqlDataAdapter();
                da2.SelectCommand = cmd2;
                da2.Fill(dt);
                SqlCommand cmd3 = new SqlCommand("Select  IPAddress AS [IP Address],CountryName AS [Country],CityName AS [City],Latitude,Longitude,Visiting_Date AS [Visiting Date] from Master_Product where ProductCategory='category_8' order by Visiting_Date DESC", con);
                SqlDataAdapter da3 = new SqlDataAdapter();
                da3.SelectCommand = cmd3;
                da3.Fill(dt);
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
                gv_data.DataMember = "Master_Product";
                gv_data.DataSource = dt;
                gv_data.DataBind();
            }
            if (ddl_cat.SelectedItem.Text.StartsWith("Nikon"))
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select  IPAddress AS [IP Address],CountryName AS [Country],CityName AS [City],Latitude,Longitude,Visiting_Date AS [Visiting Date] from Master_Product where ProductCategory='category_9' order by Visiting_Date DESC", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);
                SqlCommand cmd1 = new SqlCommand("Select  IPAddress AS [IP Address],CountryName AS [Country],CityName AS [City],Latitude,Longitude,Visiting_Date AS [Visiting Date] from Master_Product where ProductCategory='category_10' order by Visiting_Date DESC", con);
                SqlDataAdapter da1 = new SqlDataAdapter();
                da1.SelectCommand = cmd1;
                da1.Fill(dt);
                SqlCommand cmd2 = new SqlCommand("Select  IPAddress AS [IP Address],CountryName AS [Country],CityName AS [City],Latitude,Longitude,Visiting_Date AS [Visiting Date] from Master_Product where ProductCategory='category_11' order by Visiting_Date DESC", con);
                SqlDataAdapter da2 = new SqlDataAdapter();
                da2.SelectCommand = cmd2;
                da2.Fill(dt);
                SqlCommand cmd3 = new SqlCommand("Select  IPAddress AS [IP Address],CountryName AS [Country],CityName AS [City],Latitude,Longitude,Visiting_Date AS [Visiting Date] from Master_Product where ProductCategory='category_12' order by Visiting_Date DESC", con);
                SqlDataAdapter da3 = new SqlDataAdapter();
                da3.SelectCommand = cmd3;
                da3.Fill(dt);
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
                gv_data.DataMember = "Master_Product";
                gv_data.DataSource = dt;
                gv_data.DataBind();
            }
        }

        catch (Exception)
        {

        }
    }

    protected void gv_data_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv_data.PageIndex = e.NewPageIndex;
        Getall();
    }
}
