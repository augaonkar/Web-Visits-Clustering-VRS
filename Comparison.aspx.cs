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
using System.Globalization;
using System.Diagnostics;
using System.Threading;

public partial class Comparison : System.Web.UI.Page
{
    private DataTable myTable = new DataTable();
    private DataTable myTable1 = new DataTable();
    int CountCity = 0;
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
                SqlDataAdapter da = new SqlDataAdapter("select distinct CityName from Master_Product", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Product_Master");
                CountCity = ds.Tables[0].Rows.Count;
                Label1.Text = "You Can Enter Upto : - " + CountCity + " Clusters";
            }
        }
        catch (Exception)
        {
          
        }
      

    }


    double Lat, Long;
    string city1;

    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cntr"].ToString());
    protected void btn_ok_Click(object sender, EventArgs e)
    {
        try
        {
            if ((Convert.ToInt32(txt_no_clu.Text)) > CountCity)
            {
                txt_no_clu.Text = "";
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("truncate table tbl_citydata", con);
                cmd.ExecuteNonQuery();
                con.Close();
                SqlDataAdapter da = new SqlDataAdapter("select distinct CityName from Master_Product", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Product_Master");
                int countCity = ds.Tables[0].Rows.Count;
                for (int i = 0; i < Convert.ToInt32(txt_no_clu.Text); i++)
                {
                    SqlDataAdapter da1 = new SqlDataAdapter("insert into tbl_citydata(CityName,Latitude,Longitude) select distinct CityName,Latitude,Longitude from Master_Product where CityName='" + ds.Tables[0].Rows[i]["CityName"].ToString() + "'", con);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1, "tbl_citydata");

                }

                SqlDataAdapter da2 = new SqlDataAdapter("select distinct CityName,Latitude,Longitude from tbl_citydata", con);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2, "tbl_citydata");
                gv_city.DataSource = ds2;
                gv_city.DataBind();

            }
        }
        catch (Exception)
        {
                     
        }
      
    }

    private void getcounts()
    {
        try
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_city1", con);  //master_product_dummy 
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

            SqlDataAdapter da1 = new SqlDataAdapter("select * from tbl_city", con);   //master_product
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            GridView2.DataSource = ds1;
            GridView2.DataBind();
        }
        catch (Exception)
        {
           
        }
       
    }

    protected void btn_start_Click(object sender, EventArgs e)
    {
        try
        {
            var watch = Stopwatch.StartNew();
            tb1();      //master_product_dummy 
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            long a1 = elapsedMs;

            var watch1 = Stopwatch.StartNew();
            tb();     //master_product
            watch.Stop();
            var elapsedMs1 = watch1.ElapsedMilliseconds;
            long a2 = elapsedMs1;
            Label36.Text = "Time Taken : " + a1;
            Label37.Text = "Time Taken : " + a2;
            getcounts();
        }
        catch (Exception)
        {
         
        }
     
    }

    private void tb()    //master_product
    {

        string ans = "";
        int rowid = 0;
        double[] DistArray = new double[Convert.ToInt32(txt_no_clu.Text)]; ;
        string[] citynames = new string[Convert.ToInt32(txt_no_clu.Text)];
        SqlDataAdapter da1 = new SqlDataAdapter("select * from Master_Product", con);
        DataSet ds1 = new DataSet();
        da1.Fill(ds1);
        int cnt = ds1.Tables[0].Rows.Count;
        if (cnt > 0)
        {
            for (int i = 0; i < cnt; i++)
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("truncate table tbl_city", con);
                cmd1.ExecuteNonQuery();
                con.Close();
                string AllDist = "";
                string AllCity = "";
                for (int j = 0; j < Convert.ToInt32(txt_no_clu.Text); j++)
                {
                    SqlDataAdapter da2 = new SqlDataAdapter("select distinct CityName,Latitude,Longitude from tbl_citydata", con);
                    DataSet ds2 = new DataSet();
                    da2.Fill(ds2, "tbl_citydata");

                    Lat = Convert.ToDouble(ds2.Tables[0].Rows[j]["Latitude"].ToString());
                    Long = Convert.ToDouble(ds2.Tables[0].Rows[j]["Longitude"].ToString());
                    city1 = ds2.Tables[0].Rows[j]["CityName"].ToString();
                    double lat = Convert.ToDouble(ds1.Tables[0].Rows[i]["Latitude"].ToString());
                    double longi = Convert.ToDouble(ds1.Tables[0].Rows[i]["Longitude"].ToString());
                    rowid = Convert.ToInt32(ds1.Tables[0].Rows[i]["U_Id"].ToString());
                    double a = ((lat - Lat) * (lat - Lat));
                    double d = ((longi - Long) * (longi - Long));
                    double dist_A = Math.Sqrt(a + d);
                    string fdist_A = dist_A.ToString("00.00000000", CultureInfo.InvariantCulture);

                    if (AllDist.Equals(""))
                    {
                        AllDist = fdist_A;
                    }
                    else
                    {
                        AllDist = AllDist + "," + fdist_A;
                    }
                    if (AllCity.Equals(""))
                    {
                        AllCity = city1;
                    }
                    else
                    {
                        AllCity = AllCity + "," + city1;
                    }
                    citynames = AllCity.Split(',');
                    DistArray = AllDist.Split(',').Select(s => double.Parse(s)).ToArray();


                }
                double m = DistArray.Min();
                int p = Array.IndexOf(DistArray, m);
                string nearbyCity = citynames[p];
                SqlDataAdapter da = new SqlDataAdapter("update Master_Product set Cluster='" + nearbyCity + "' where U_Id='" + rowid + "'", con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                SqlDataAdapter da3 = new SqlDataAdapter("select distinct Cluster from Master_Product", con);
                DataSet ds3 = new DataSet();
                da3.Fill(ds3, "Master_Product");
                if (ds3.Tables[0].Rows.Count > 0)
                {

                    for (int l = 0; l < ds3.Tables[0].Rows.Count; l++)
                    {
                        string a = ds3.Tables[0].Rows[l]["Cluster"].ToString();
                        con.Open();
                        SqlCommand cmd = new SqlCommand("select Count(CityName) as CountCity from  Master_Product where Cluster='" + a + "'", con);
                        int CcCount = (int)cmd.ExecuteScalar();
                        con.Close();
                        SqlDataAdapter da4 = new SqlDataAdapter("insert into tbl_city values('" + a + "','" + CcCount + "')", con);
                        DataSet ds4 = new DataSet();
                        da4.Fill(ds4);
                    }
                }



            }

        }
        show();
    }

    private void show()
    {
        try
        {
            SqlDataAdapter da = new SqlDataAdapter("select Latitude,Longitude,Cluster from Master_Product", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GV_data1.DataSource = ds;
            GV_data1.DataBind();
        }
        catch (Exception)
        {
          
        }
      
    }


    private void tb1()  //master_product_dummy 
    {

        string ans = "";
        int rowid = 0;
        double[] DistArray = new double[Convert.ToInt32(txt_no_clu.Text)]; ;
        string[] citynames = new string[Convert.ToInt32(txt_no_clu.Text)];
        SqlDataAdapter da1 = new SqlDataAdapter("select * from Master_Product_dummy", con);
        DataSet ds1 = new DataSet();
        da1.Fill(ds1);
        int cnt = ds1.Tables[0].Rows.Count;
        if (cnt > 0)
        {
            for (int i = 0; i < cnt; i++)
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("truncate table tbl_city1", con);
                cmd1.ExecuteNonQuery();
                con.Close();
                string AllDist = "";
                string AllCity = "";
                for (int j = 0; j < Convert.ToInt32(txt_no_clu.Text); j++)
                {
                    SqlDataAdapter da2 = new SqlDataAdapter("select distinct CityName,Latitude,Longitude from tbl_citydata", con);
                    DataSet ds2 = new DataSet();
                    da2.Fill(ds2, "tbl_citydata");

                    Lat = Convert.ToDouble(ds2.Tables[0].Rows[j]["Latitude"].ToString());
                    Long = Convert.ToDouble(ds2.Tables[0].Rows[j]["Longitude"].ToString());
                    city1 = ds2.Tables[0].Rows[j]["CityName"].ToString();
                    double lat = Convert.ToDouble(ds1.Tables[0].Rows[i]["Latitude"].ToString());
                    double longi = Convert.ToDouble(ds1.Tables[0].Rows[i]["Longitude"].ToString());
                    rowid = Convert.ToInt32(ds1.Tables[0].Rows[i]["U_Id"].ToString());
                    double a = ((lat - Lat) * (lat - Lat));
                    double d = ((longi - Long) * (longi - Long));
                    double dist_A = Math.Sqrt(a + d);
                    string fdist_A = dist_A.ToString("00.00000000", CultureInfo.InvariantCulture);
                    for (int k = 0; k < cnt; k++)
                    {
                        int[] countaaray1 = { cnt };
                    }

                    if (AllDist.Equals(""))
                    {
                        AllDist = fdist_A;
                    }
                    else
                    {
                        AllDist = AllDist + "," + fdist_A;
                    }
                    if (AllCity.Equals(""))
                    {
                        AllCity = city1;
                    }
                    else
                    {
                        AllCity = AllCity + "," + city1;
                    }
                    citynames = AllCity.Split(',');
                    DistArray = AllDist.Split(',').Select(s => double.Parse(s)).ToArray();


                }
                double m = DistArray.Min();
                int p = Array.IndexOf(DistArray, m);
                string nearbyCity = citynames[p];
                SqlDataAdapter da = new SqlDataAdapter("update Master_Product_dummy set Cluster='" + nearbyCity + "' where U_Id='" + rowid + "'", con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                SqlDataAdapter da3 = new SqlDataAdapter("select distinct Cluster from Master_Product_dummy", con);
                DataSet ds3 = new DataSet();
                da3.Fill(ds3, "Master_Product_dummy");
                if (ds3.Tables[0].Rows.Count > 0)
                {

                    for (int l = 0; l < ds3.Tables[0].Rows.Count; l++)
                    {
                        string a = ds3.Tables[0].Rows[l]["Cluster"].ToString();
                        con.Open();
                        SqlCommand cmd = new SqlCommand("select Count(CityName) as CountCity from  Master_Product_dummy where Cluster='" + a + "'", con);
                        int CcCount = (int)cmd.ExecuteScalar();
                        con.Close();
                        SqlDataAdapter da4 = new SqlDataAdapter("insert into tbl_city1 values('" + a + "','" + CcCount + "')", con);
                        DataSet ds4 = new DataSet();
                        da4.Fill(ds4);
                    }
                }

            }

        }
        show1();
    }

    private void show1()
    {
        try
        {
            SqlDataAdapter da = new SqlDataAdapter("select Latitude,Longitude,Cluster from Master_Product_dummy", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GV_data.DataSource = ds;
            GV_data.DataBind();
        }
        catch (Exception)
        {
         
        }
    }
}
