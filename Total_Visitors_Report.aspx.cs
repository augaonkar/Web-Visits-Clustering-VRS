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

public partial class Total_Visitors_Report : System.Web.UI.Page
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
                CompletelyChngedCode();
                SqlDataAdapter da11 = new SqlDataAdapter("select CityName As [Name],Pro1 As [P1],Pro2 As [P2],Pro3 As [P3],Pro4 As [P4],Pro5 As [P5],Pro6 As [P6],Pro7 As [P7],Pro8 As [P8],Pro9 As [P9],Pro10 As [P10],Pro11 As [P11],Pro12 As [P12],ProTotal As [Total] from tbl_CompltChange", con);
                DataSet ds11 = new DataSet();
                da11.Fill(ds11, "tbl_CompltChange");
                GridView1.DataSource = ds11;
                GridView1.DataBind();


                Getcountofmainpage();
                SqlDataAdapter da9 = new SqlDataAdapter("select CityName as [City],VisitorsCnt as [Total Visitors] from tbl_CompltChangeMainPageCount order by VisitorsCnt Desc", con);
                DataSet ds9 = new DataSet();
                da9.Fill(ds9, "tbl_CompltChangeMainPageCount");
                GridView12.DataSource = ds9;
                GridView12.DataBind();

                GetcountofmainAndproductpage();
                SqlDataAdapter da10 = new SqlDataAdapter("select CityName as [City],VisitorsCnt as [Total Visitors] from tbl_CompltChangeMainAndProductPageCount order by VisitorsCnt Desc", con);
                DataSet ds10 = new DataSet();
                da10.Fill(ds10, "tbl_CompltChangeMainAndProductPageCount");
                GridView10.DataSource = ds10;
                GridView10.DataBind();
            }
        }
        catch (Exception)
        {

        }
    }

    private void GetcountofmainAndproductpage()
    {
        try
        {
            string cityname = "";
            con.Open();
            SqlCommand cmd1 = new SqlCommand("truncate table tbl_CompltChangeMainAndProductPageCount", con);
            cmd1.ExecuteNonQuery();
            con.Close();
            SqlDataAdapter da = new SqlDataAdapter("select distinct CityName from Locations", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Locations");
            int discitycount = ds.Tables[0].Rows.Count;
            for (int i = 0; i < discitycount; i++)
            {
                cityname = ds.Tables[0].Rows[i]["CityName"].ToString();
                con.Open();
                SqlCommand cmd = new SqlCommand("select Count(CityName) as CountCity from  Locations where CityName='" + cityname + "'", con);
                int CcCount = (int)cmd.ExecuteScalar();

                SqlCommand cmd2 = new SqlCommand("select Count(CityName) as CountCity from  Master_Product where CityName='" + cityname + "'", con);
                int CcCount1 = (int)cmd2.ExecuteScalar();

                int Total = CcCount - CcCount1;
                con.Close();
                SqlDataAdapter da1 = new SqlDataAdapter("insert into tbl_CompltChangeMainAndProductPageCount values('" + cityname + "','" + Total + "')", con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "tbl_CompltChangeMainAndProductPageCount");

            }
        }
        catch (Exception)
        {
           
        }
       
    }

    private void Getcountofmainpage()
    {
        try
        {
            string cityname = "";
            con.Open();
            SqlCommand cmd1 = new SqlCommand("truncate table tbl_CompltChangeMainPageCount", con);
            cmd1.ExecuteNonQuery();
            con.Close();
            SqlDataAdapter da = new SqlDataAdapter("select distinct CityName from Locations", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Locations");
            int discitycount = ds.Tables[0].Rows.Count;
            for (int i = 0; i < discitycount; i++)
            {
                cityname = ds.Tables[0].Rows[i]["CityName"].ToString();
                con.Open();
                SqlCommand cmd = new SqlCommand("select Count(CityName) as CountCity from  Locations where CityName='" + cityname + "'", con);
                int CcCount = (int)cmd.ExecuteScalar();
                con.Close();
                SqlDataAdapter da1 = new SqlDataAdapter("insert into tbl_CompltChangeMainPageCount values('" + cityname + "','" + CcCount + "')", con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "tbl_CompltChangeMainPageCount");

            }
        }
        catch (Exception)
        {
           

        }
      
    }

    private void CompletelyChngedCode()
    {
        try
        {
            string cityname = "";
            con.Open();
            SqlCommand cmd1 = new SqlCommand("truncate table tbl_CompltChange", con);
            cmd1.ExecuteNonQuery();
            con.Close();
            SqlDataAdapter da = new SqlDataAdapter("select distinct CityName from Master_Product", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Master_Product");
            int discitycount = ds.Tables[0].Rows.Count;
            for (int i = 0; i < discitycount; i++)
            {
                string[] Countstringarray = new string[12];
                string Countstring = "";
                cityname = ds.Tables[0].Rows[i]["CityName"].ToString();
                for (int j = 1; j < 13; j++)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select Count(CityName) as CountCity from  Master_Product where CityName='" + cityname + "' and ProductId='" + j + "'", con);
                    int CcCount = (int)cmd.ExecuteScalar();
                    con.Close();
                    if (Countstring.Equals(""))
                    {
                        Countstring = CcCount.ToString();
                    }
                    else
                    {
                        Countstring = Countstring + "," + CcCount;
                    }

                }
                Countstringarray = Countstring.Split(',');
                int total = Convert.ToInt32(Countstringarray[0]) + Convert.ToInt32(Countstringarray[1]) + Convert.ToInt32(Countstringarray[2]) + Convert.ToInt32(Countstringarray[3]) + Convert.ToInt32(Countstringarray[4]) + Convert.ToInt32(Countstringarray[5]) + Convert.ToInt32(Countstringarray[6]) + Convert.ToInt32(Countstringarray[7]) + Convert.ToInt32(Countstringarray[8]) + Convert.ToInt32(Countstringarray[9]) + Convert.ToInt32(Countstringarray[10]) + Convert.ToInt32(Countstringarray[11]);
                SqlDataAdapter da1 = new SqlDataAdapter("insert into tbl_CompltChange values('" + cityname + "','" + Countstringarray[0] + "','" + Countstringarray[1] + "','" + Countstringarray[2] + "','" + Countstringarray[3] + "','" + Countstringarray[4] + "','" + Countstringarray[5] + "','" + Countstringarray[6] + "','" + Countstringarray[7] + "','" + Countstringarray[8] + "','" + Countstringarray[9] + "','" + Countstringarray[10] + "','" + Countstringarray[11] + "','" + total + "')", con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "tbl_CompltChange");
            }


        }
        catch (Exception)
        {
          
        }
       
    }
}
