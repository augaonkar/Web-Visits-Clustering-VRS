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

public partial class Product_wise_clusters : System.Web.UI.Page
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
       

    }

    private void Getdata()
    {

        try
        {
            SqlDataAdapter da = new SqlDataAdapter("select Latitude,Longitude,CityName as [Cluster] from Master_Product where ProductId='"+ddl_product.SelectedItem.Value.ToString()+"' order by CityName", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int cnt = ds.Tables[0].Rows.Count;
            if (cnt > 0)
            {
                Label3.Text = cnt.ToString();
                GV_data.DataSource = ds;
                GV_data.DataBind();
            }
            else
            {
                Label3.Text = "0";
            }
            //if (ddl_product.SelectedItem.Text.Equals("Product 1"))
            //{
            //    SqlDataAdapter da = new SqlDataAdapter("select Latitude,Longitude,CityName as [Cluster] from Master_Product where ProductId='1' order by CityName", con);
            //    DataSet ds = new DataSet();
            //    da.Fill(ds);
            //    int cnt = ds.Tables[0].Rows.Count;
            //    if (cnt > 0)
            //    {
            //        Label3.Text = cnt.ToString();
            //        GV_data.DataSource = ds;
            //        GV_data.DataBind();
            //    }
            //    else
            //    {
            //        Label3.Text = "0";
            //    }
               
            //}
            //if (ddl_product.SelectedItem.Text.Equals("Product 2"))
            //{
            //    SqlDataAdapter da = new SqlDataAdapter("select Latitude,Longitude,CityName as [Cluster] from Master_Product where ProductId='2' order by CityName", con);
            //    DataSet ds = new DataSet();
            //    da.Fill(ds);
            //    int cnt = ds.Tables[0].Rows.Count;
            //    if (cnt > 0)
            //    {
            //        Label3.Text = cnt.ToString();
            //        GV_data.DataSource = ds;
            //        GV_data.DataBind();
            //    }
            //    else
            //    {
            //        Label3.Text = "0";
            //    }
            //}
            //if (ddl_product.SelectedItem.Text.Equals("Product 3"))
            //{
            //    SqlDataAdapter da = new SqlDataAdapter("select Latitude,Longitude,CityName as [Cluster] from Master_Product where ProductId='3' order by CityName", con);
            //    DataSet ds = new DataSet();
            //    da.Fill(ds);
            //    int cnt = ds.Tables[0].Rows.Count;
            //    if (cnt > 0)
            //    {
            //        Label3.Text = cnt.ToString();
            //        GV_data.DataSource = ds;
            //        GV_data.DataBind();
            //    }
            //    else
            //    {
            //        Label3.Text = "0";
            //    }
            //}
            //if (ddl_product.SelectedItem.Text.Equals("Product 4"))
            //{
            //    SqlDataAdapter da = new SqlDataAdapter("select Latitude,Longitude,CityName as [Cluster] from Master_Product where ProductId='4' order by CityName", con);
            //    DataSet ds = new DataSet();
            //    da.Fill(ds);
            //    int cnt = ds.Tables[0].Rows.Count;
            //    if (cnt > 0)
            //    {
            //        Label3.Text = cnt.ToString();
            //        GV_data.DataSource = ds;
            //        GV_data.DataBind();
            //    }
            //    else
            //    {
            //        Label3.Text = "0";
            //    }
            //}
            //if (ddl_product.SelectedItem.Text.Equals("Product 5"))
            //{
            //    SqlDataAdapter da = new SqlDataAdapter("select Latitude,Longitude,CityName as [Cluster] from Master_Product where ProductId='5' order by CityName", con);
            //    DataSet ds = new DataSet();
            //    da.Fill(ds);
            //    int cnt = ds.Tables[0].Rows.Count;
            //    if (cnt > 0)
            //    {
            //        Label3.Text = cnt.ToString();
            //        GV_data.DataSource = ds;
            //        GV_data.DataBind();
            //    }
            //    else
            //    {
            //        Label3.Text = "0";
            //    }
            //}
            //if (ddl_product.SelectedItem.Text.Equals("Product 6"))
            //{
            //    SqlDataAdapter da = new SqlDataAdapter("select Latitude,Longitude,CityName as [Cluster] from Master_Product where ProductId='6' order by CityName", con);
            //    DataSet ds = new DataSet();
            //    da.Fill(ds);
            //    int cnt = ds.Tables[0].Rows.Count;
            //    if (cnt > 0)
            //    {
            //        Label3.Text = cnt.ToString();
            //        GV_data.DataSource = ds;
            //        GV_data.DataBind();
            //    }
            //    else
            //    {
            //        Label3.Text = "0";
            //    }
            //}
            //if (ddl_product.SelectedItem.Text.Equals("Product 7"))
            //{
            //    SqlDataAdapter da = new SqlDataAdapter("select Latitude,Longitude,CityName as [Cluster] from Master_Product where ProductId='7' order by CityName", con);
            //    DataSet ds = new DataSet();
            //    da.Fill(ds);
            //    int cnt = ds.Tables[0].Rows.Count;
            //    if (cnt > 0)
            //    {
            //        Label3.Text = cnt.ToString();
            //        GV_data.DataSource = ds;
            //        GV_data.DataBind();
            //    }
            //    else
            //    {
            //        Label3.Text = "0";
            //    }
            //}
            //if (ddl_product.SelectedItem.Text.Equals("Product 8"))
            //{
            //    SqlDataAdapter da = new SqlDataAdapter("select Latitude,Longitude,CityName as [Cluster] from Master_Product where ProductId='8' order by CityName", con);
            //    DataSet ds = new DataSet();
            //    da.Fill(ds);
            //    int cnt = ds.Tables[0].Rows.Count;
            //    if (cnt > 0)
            //    {
            //        Label3.Text = cnt.ToString();
            //        GV_data.DataSource = ds;
            //        GV_data.DataBind();
            //    }
            //    else
            //    {
            //        Label3.Text = "0";
            //    }
            //}
            //if (ddl_product.SelectedItem.Text.Equals("Product 9"))
            //{
            //    SqlDataAdapter da = new SqlDataAdapter("select Latitude,Longitude,CityName as [Cluster] from Master_Product where ProductId='9' order by CityName", con);
            //    DataSet ds = new DataSet();
            //    da.Fill(ds);
            //    int cnt = ds.Tables[0].Rows.Count;
            //    if (cnt > 0)
            //    {
            //        Label3.Text = cnt.ToString();
            //        GV_data.DataSource = ds;
            //        GV_data.DataBind();
            //    }
            //    else
            //    {
            //        Label3.Text = "0";
            //    }
            //}
            //if (ddl_product.SelectedItem.Text.Equals("Product 10"))
            //{
            //    SqlDataAdapter da = new SqlDataAdapter("select Latitude,Longitude,CityName as [Cluster] from Master_Product where ProductId='10' order by CityName", con);
            //    DataSet ds = new DataSet();
            //    da.Fill(ds);
            //    int cnt = ds.Tables[0].Rows.Count;
            //    if (cnt > 0)
            //    {
            //        Label3.Text = cnt.ToString();
            //        GV_data.DataSource = ds;
            //        GV_data.DataBind();
            //    }
            //    else
            //    {
            //        Label3.Text = "0";
            //    }
            //}
            //if (ddl_product.SelectedItem.Text.Equals("Product 11"))
            //{
            //    SqlDataAdapter da = new SqlDataAdapter("select Latitude,Longitude,CityName as [Cluster] from Master_Product where ProductId='11' order by CityName", con);
            //    DataSet ds = new DataSet();
            //    da.Fill(ds);
            //    int cnt = ds.Tables[0].Rows.Count;
            //    if (cnt > 0)
            //    {
            //        Label3.Text = cnt.ToString();
            //        GV_data.DataSource = ds;
            //        GV_data.DataBind();
            //    }
            //    else
            //    {
            //        Label3.Text = "0";
            //    }
            //}
            //if (ddl_product.SelectedItem.Text.Equals("Product 12"))
            //{
            //    SqlDataAdapter da = new SqlDataAdapter("select Latitude,Longitude,CityName as [Cluster] from Master_Product where ProductId='12' order by CityName", con);
            //    DataSet ds = new DataSet();
            //    da.Fill(ds);
            //    int cnt = ds.Tables[0].Rows.Count;
            //    if (cnt > 0)
            //    {
            //        Label3.Text = cnt.ToString();
            //        GV_data.DataSource = ds;
            //        GV_data.DataBind();
            //    }
            //    else
            //    {
            //        Label3.Text = "0";
            //    }
            //}
        }
        catch (Exception)
        {

        }
    }
    protected void GV_data_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GV_data.PageIndex = e.NewPageIndex;
        Getdata();
    }
    protected void btn_get_Click(object sender, EventArgs e)
    {
        Getdata();
    }
}
