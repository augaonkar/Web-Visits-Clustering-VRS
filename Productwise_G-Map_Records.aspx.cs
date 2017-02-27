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

public partial class Productwise_G_Map_Records : System.Web.UI.Page
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
            }
        }
        catch (Exception)
        {
           
        }
      
    }
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cntr"].ToString());
   
      protected void btn_getdata_Click(object sender, EventArgs e)
    {
        Getall();
        
    }

      private void Getall()
      {
          try
          {
              DataTable dt = new DataTable();
              SqlCommand cmd = new SqlCommand("Select IPAddress AS [IP Address],CountryName AS [Country],CityName AS [City],Latitude,Longitude,Visiting_Date AS [Visiting Date] from Master_Product where ProductId='"+ddl_product.SelectedItem.Value.ToString()+"' order by Visiting_Date DESC", con);
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
              gv_data.DataMember = "Master_Product";
              gv_data.DataSource = dt;
              gv_data.DataBind();
              //if (ddl_product.SelectedItem.Text.Equals("Product 1"))
              //{
              //    DataTable dt = new DataTable();
              //    SqlCommand cmd = new SqlCommand("Select IPAddress AS [IP Address],CountryName AS [Country],CityName AS [City],Latitude,Longitude,Visiting_Date AS [Visiting Date] from Master_Product where ProductId='1' order by Visiting_Date DESC", con);
              //    SqlDataAdapter da = new SqlDataAdapter();
              //    da.SelectCommand = cmd;
              //    da.Fill(dt);
              //    int cnt = dt.Rows.Count;
              //    if (cnt > 0)
              //    {
              //        Label3.Text = "No of Visitors : " + cnt;
              //    }
              //    else
              //    {
              //        Label3.Text = "No of Visitors : 0";
              //    }
              //    rptMarkers.DataSource = dt;
              //    rptMarkers.DataBind();
              //    gv_data.DataMember = "Master_Product";
              //    gv_data.DataSource = dt;
              //    gv_data.DataBind();
              //}
              //if (ddl_product.SelectedItem.Text.Equals("Product 2"))
              //{
              //    DataTable dt = new DataTable();
              //    SqlCommand cmd = new SqlCommand("Select IPAddress AS [IP Address],CountryName AS [Country],CityName AS [City],Latitude,Longitude,Visiting_Date AS [Visiting Date] from Master_Product where ProductId='2'order by Visiting_Date DESC", con);
              //    SqlDataAdapter da = new SqlDataAdapter();
              //    da.SelectCommand = cmd;
              //    da.Fill(dt);
              //    int cnt = dt.Rows.Count;
              //    if (cnt > 0)
              //    {
              //        Label3.Text = "No of Visitors : " + cnt;
              //    }
              //    else
              //    {
              //        Label3.Text = "No of Visitors : 0";
              //    }
              //    rptMarkers.DataSource = dt;
              //    rptMarkers.DataBind();
              //    gv_data.DataMember = "Master_Product";
              //    gv_data.DataSource = dt;
              //    gv_data.DataBind();
              //}
              //if (ddl_product.SelectedItem.Text.Equals("Product 3"))
              //{
              //    DataTable dt = new DataTable();
              //    SqlCommand cmd = new SqlCommand("Select IPAddress AS [IP Address],CountryName AS [Country],CityName AS [City],Latitude,Longitude,Visiting_Date AS [Visiting Date] from Master_Product where ProductId='3' order by Visiting_Date DESC", con);
              //    SqlDataAdapter da = new SqlDataAdapter();
              //    da.SelectCommand = cmd;
              //    da.Fill(dt);
              //    int cnt = dt.Rows.Count;
              //    if (cnt > 0)
              //    {
              //        Label3.Text = "No of Visitors : " + cnt;
              //    }
              //    else
              //    {
              //        Label3.Text = "No of Visitors : 0";
              //    }
              //    rptMarkers.DataSource = dt;
              //    rptMarkers.DataBind();
              //    gv_data.DataMember = "Master_Product";
              //    gv_data.DataSource = dt;
              //    gv_data.DataBind();
              //}
              //if (ddl_product.SelectedItem.Text.Equals("Product 4"))
              //{
              //    DataTable dt = new DataTable();
              //    SqlCommand cmd = new SqlCommand("Select IPAddress AS [IP Address],CountryName AS [Country],CityName AS [City],Latitude,Longitude,Visiting_Date AS [Visiting Date] from Master_Product where ProductId='4' order by Visiting_Date DESC", con);
              //    SqlDataAdapter da = new SqlDataAdapter();
              //    da.SelectCommand = cmd;
              //    da.Fill(dt);
              //    int cnt = dt.Rows.Count;
              //    if (cnt > 0)
              //    {
              //        Label3.Text = "No of Visitors : " + cnt;
              //    }
              //    else
              //    {
              //        Label3.Text = "No of Visitors : 0";
              //    }
              //    rptMarkers.DataSource = dt;
              //    rptMarkers.DataBind();
              //    gv_data.DataMember = "Master_Product";
              //    gv_data.DataSource = dt;
              //    gv_data.DataBind();
              //}
              //if (ddl_product.SelectedItem.Text.Equals("Product 5"))
              //{
              //    DataTable dt = new DataTable();
              //    SqlCommand cmd = new SqlCommand("Select IPAddress AS [IP Address],CountryName AS [Country],CityName AS [City],Latitude,Longitude,Visiting_Date AS [Visiting Date] from Master_Product where ProductId='5' order by Visiting_Date DESC", con);
              //    SqlDataAdapter da = new SqlDataAdapter();
              //    da.SelectCommand = cmd;
              //    da.Fill(dt);
              //    int cnt = dt.Rows.Count;
              //    if (cnt > 0)
              //    {
              //        Label3.Text = "No of Visitors : " + cnt;
              //    }
              //    else
              //    {
              //        Label3.Text = "No of Visitors : 0";
              //    }
              //    rptMarkers.DataSource = dt;
              //    rptMarkers.DataBind();
              //    gv_data.DataMember = "Master_Product";
              //    gv_data.DataSource = dt;
              //    gv_data.DataBind();
              //}
              //if (ddl_product.SelectedItem.Text.Equals("Product 6"))
              //{
              //    DataTable dt = new DataTable();
              //    SqlCommand cmd = new SqlCommand("Select IPAddress AS [IP Address],CountryName AS [Country],CityName AS [City],Latitude,Longitude,Visiting_Date AS [Visiting Date] from Master_Product where ProductId='6'order by Visiting_Date DESC", con);
              //    SqlDataAdapter da = new SqlDataAdapter();
              //    da.SelectCommand = cmd;
              //    da.Fill(dt);
              //    int cnt = dt.Rows.Count;
              //    if (cnt > 0)
              //    {
              //        Label3.Text = "No of Visitors : " + cnt;
              //    }
              //    else
              //    {
              //        Label3.Text = "No of Visitors : 0";
              //    }
              //    rptMarkers.DataSource = dt;
              //    rptMarkers.DataBind();
              //    gv_data.DataMember = "Master_Product";
              //    gv_data.DataSource = dt;
              //    gv_data.DataBind();
              //}
              //if (ddl_product.SelectedItem.Text.Equals("Product 7"))
              //{
              //    DataTable dt = new DataTable();
              //    SqlCommand cmd = new SqlCommand("Select IPAddress AS [IP Address],CountryName AS [Country],CityName AS [City],Latitude,Longitude,Visiting_Date AS [Visiting Date] from Master_Product where ProductId='7' order by Visiting_Date DESC", con);
              //    SqlDataAdapter da = new SqlDataAdapter();
              //    da.SelectCommand = cmd;
              //    da.Fill(dt);
              //    int cnt = dt.Rows.Count;
              //    if (cnt > 0)
              //    {
              //        Label3.Text = "No of Visitors : " + cnt;
              //    }
              //    else
              //    {
              //        Label3.Text = "No of Visitors : 0";
              //    }
              //    rptMarkers.DataSource = dt;
              //    rptMarkers.DataBind();
              //    gv_data.DataMember = "Master_Product";
              //    gv_data.DataSource = dt;
              //    gv_data.DataBind();
              //}
              //if (ddl_product.SelectedItem.Text.Equals("Product 8"))
              //{
              //    DataTable dt = new DataTable();
              //    SqlCommand cmd = new SqlCommand("Select IPAddress AS [IP Address],CountryName AS [Country],CityName AS [City],Latitude,Longitude,Visiting_Date AS [Visiting Date] from Master_Product where ProductId='8' order by Visiting_Date DESC", con);
              //    SqlDataAdapter da = new SqlDataAdapter();
              //    da.SelectCommand = cmd;
              //    da.Fill(dt);
              //    int cnt = dt.Rows.Count;
              //    if (cnt > 0)
              //    {
              //        Label3.Text = "No of Visitors : " + cnt;
              //    }
              //    else
              //    {
              //        Label3.Text = "No of Visitors : 0";
              //    }
              //    rptMarkers.DataSource = dt;
              //    rptMarkers.DataBind();
              //    gv_data.DataMember = "Master_Product";
              //    gv_data.DataSource = dt;
              //    gv_data.DataBind();
              //}
              //if (ddl_product.SelectedItem.Text.Equals("Product 9"))
              //{
              //    DataTable dt = new DataTable();
              //    SqlCommand cmd = new SqlCommand("Select IPAddress AS [IP Address],CountryName AS [Country],CityName AS [City],Latitude,Longitude,Visiting_Date AS [Visiting Date] from Master_Product where ProductId='9' order by Visiting_Date DESC", con);
              //    SqlDataAdapter da = new SqlDataAdapter();
              //    da.SelectCommand = cmd;
              //    da.Fill(dt);
              //    int cnt = dt.Rows.Count;
              //    if (cnt > 0)
              //    {
              //        Label3.Text = "No of Visitors : " + cnt;
              //    }
              //    else
              //    {
              //        Label3.Text = "No of Visitors : 0";
              //    }
              //    rptMarkers.DataSource = dt;
              //    rptMarkers.DataBind();
              //    gv_data.DataMember = "Master_Product";
              //    gv_data.DataSource = dt;
              //    gv_data.DataBind();
              //}
              //if (ddl_product.SelectedItem.Text.Equals("Product 10"))
              //{
              //    DataTable dt = new DataTable();
              //    SqlCommand cmd = new SqlCommand("Select IPAddress AS [IP Address],CountryName AS [Country],CityName AS [City],Latitude,Longitude,Visiting_Date AS [Visiting Date] from Master_Product where ProductId='10' order by Visiting_Date DESC", con);
              //    SqlDataAdapter da = new SqlDataAdapter();
              //    da.SelectCommand = cmd;
              //    da.Fill(dt);
              //    int cnt = dt.Rows.Count;
              //    if (cnt > 0)
              //    {
              //        Label3.Text = "No of Visitors : " + cnt;
              //    }
              //    else
              //    {
              //        Label3.Text = "No of Visitors : 0";
              //    }
              //    rptMarkers.DataSource = dt;
              //    rptMarkers.DataBind();
              //    gv_data.DataMember = "Master_Product";
              //    gv_data.DataSource = dt;
              //    gv_data.DataBind();
              //}
              //if (ddl_product.SelectedItem.Text.Equals("Product 11"))
              //{
              //    DataTable dt = new DataTable();
              //    SqlCommand cmd = new SqlCommand("Select IPAddress AS [IP Address],CountryName AS [Country],CityName AS [City],Latitude,Longitude,Visiting_Date AS [Visiting Date] from Master_Product where ProductId='11' order by Visiting_Date DESC", con);
              //    SqlDataAdapter da = new SqlDataAdapter();
              //    da.SelectCommand = cmd;
              //    da.Fill(dt);
              //    int cnt = dt.Rows.Count;
              //    if (cnt > 0)
              //    {
              //        Label3.Text = "No of Visitors : " + cnt;
              //    }
              //    else
              //    {
              //        Label3.Text = "No of Visitors : 0";
              //    }
              //    rptMarkers.DataSource = dt;
              //    rptMarkers.DataBind();
              //    gv_data.DataMember = "Master_Product";
              //    gv_data.DataSource = dt;
              //    gv_data.DataBind();
              //}
              //if (ddl_product.SelectedItem.Text.Equals("Product 12"))
              //{
              //    DataTable dt = new DataTable();
              //    SqlCommand cmd = new SqlCommand("Select IPAddress AS [IP Address],CountryName AS [Country],CityName AS [City],Latitude,Longitude,Visiting_Date AS [Visiting Date] from Master_Product where ProductId='12' order by Visiting_Date DESC", con);
              //    SqlDataAdapter da = new SqlDataAdapter();
              //    da.SelectCommand = cmd;
              //    da.Fill(dt);
              //    int cnt = dt.Rows.Count;
              //    if (cnt > 0)
              //    {
              //        Label3.Text = "No of Visitors : " + cnt;
              //    }
              //    else
              //    {
              //        Label3.Text = "No of Visitors : 0";
              //    }
              //    rptMarkers.DataSource = dt;
              //    rptMarkers.DataBind();
              //    gv_data.DataMember = "Master_Product";
              //    gv_data.DataSource = dt;
              //    gv_data.DataBind();
              //}
          }
          catch (Exception)
          {
          }
      }
      protected void gv_data_PageIndexChanging(object sender, GridViewPageEventArgs e)
      {
          gv_data.PageIndex = e.NewPageIndex ;
          Getall();
      }
}
