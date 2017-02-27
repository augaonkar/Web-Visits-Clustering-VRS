
using System;
using System.Net;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class Index : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cntr"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                if (Session["index1"] == null)
                {

                    Response.Redirect("Index.aspx");
                }
                else
                {
                    int count = 0;
                    SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Pagecnt where Id='4'", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tbl_Pagecnt");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        count = Convert.ToInt32(ds.Tables[0].Rows[0]["Count"].ToString()) + 1;
                    }
                    else
                    {
                        count = 1;
                    }
                    SqlDataAdapter da1 = new SqlDataAdapter("update tbl_Pagecnt set Count='" + count + "' where Id='5'", con);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1, "tbl_Pagecnt");
                }
            }
         
        }
        catch (Exception)
        {
        
        }
       
    }

    public class Location
    {
        public string IPAddress { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public string CityName { get; set; }
        public string RegionName { get; set; }
        public string ZipCode { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string TimeZone { get; set; }
    }   

    private void saveipinfo(int Pid, string Catid)
    {
        try
        {
            string ipAddress = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (string.IsNullOrEmpty(ipAddress))
            {
                ipAddress = Request.ServerVariables["REMOTE_ADDR"];
            }

            string APIKey = "4881a104de9446d5136c0b8267760697adca3aa21cec8477e6fd6bddc633289d";
            string url = string.Format("http://api.ipinfodb.com/v3/ip-city/?key={0}&ip={1}&format=json", APIKey, ipAddress);
            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);
                Location location = new JavaScriptSerializer().Deserialize<Location>(json);
                List<Location> locations = new List<Location>();
                locations.Add(location);
                string IPAddress1 = locations[0].IPAddress;
                string CountryName1 = locations[0].CountryName;
                string CountryCode1 = locations[0].CountryCode;
                string CityName1 = locations[0].CityName;
                Session["city_nm"] = CityName1;
                string RegionName1 = locations[0].RegionName;
                string ZipCode1 = locations[0].ZipCode;
                string Latitude1 = locations[0].Latitude;
                string Longitude1 = locations[0].Longitude;
                string TimeZone1 = locations[0].TimeZone;
                string VisitingDate = (DateTime.Now).ToString();
                if (CountryName1.Equals("INDIA"))
                {

                SqlCommand cmd = new SqlCommand("Insert into Master_Product(ProductId,ProductCategory,IPAddress,CountryName,CountryCode,CityName,RegionName,ZipCode,Latitude,Longitude,TimeZone,Visiting_Date) values('" + Pid + "','" + Catid + "','" + IPAddress1.ToString() + "' , '" + CountryName1.ToString() + "' , '" + CountryCode1.ToString() + "' , '" + CityName1.ToString() + "' , '" + RegionName1.ToString() + "' ,'" + ZipCode1.ToString() + "' ,  '" + Latitude1.ToString() + "' , '" + Longitude1.ToString() + "' , '" + TimeZone1.ToString() + "' , '" + VisitingDate.ToString() + "'   )", con);
                con.Open();
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("Insert into Master_Product_dummy(ProductId,ProductCategory,IPAddress,CountryName,CountryCode,CityName,RegionName,ZipCode,Latitude,Longitude,TimeZone,Visiting_Date) values('" + Pid + "','" + Catid + "','" + IPAddress1.ToString() + "' , '" + CountryName1.ToString() + "' , '" + CountryCode1.ToString() + "' , '" + CityName1.ToString() + "' , '" + RegionName1.ToString() + "' ,'" + ZipCode1.ToString() + "' ,  '" + Latitude1.ToString() + "' , '" + Longitude1.ToString() + "' , '" + TimeZone1.ToString() + "' , '" + VisitingDate.ToString() + "'   )", con);
                int j = cmd2.ExecuteNonQuery();
                if (j > 0)
                {
                    Session["C_Pid"] = Pid;
                    Session["Valid"] = "Ok";
                    Session["Catname"] = "Canon";
                    Response.Redirect("Products.aspx");
                }
                else
                {

                }
                con.Close();

                }
                else
                {
                    Session["C_Pid"] = Pid;
                    Session["Valid"] = "NotOk";
                    Session["Catname"] = "Canon";
                    Response.Redirect("Products.aspx");
                }
            }
        }
        catch (Exception)
        {
          
        }
       

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        try
        {
        
            string date = DateTime.Now.Date.ToShortDateString();
            string[] onlydate = date.Split(' ');
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Viscount where ddate='" + onlydate[0] + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_Viscount");
            if (ds.Tables[0].Rows.Count > 0)
            {
                int count = Convert.ToInt32(ds.Tables[0].Rows[0]["Vcount"].ToString()) + 1;
                int p5 = Convert.ToInt32(ds.Tables[0].Rows[0]["P5"].ToString());
                if (p5 > 0)
                {
                    int p51 = Convert.ToInt32(ds.Tables[0].Rows[0]["P5"].ToString()) + 1;
                    SqlCommand cmd = new SqlCommand("update  tbl_Viscount set P5='" + p51 + "' where ddate='" + onlydate[0] + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("update  tbl_Viscount set P5='1' where ddate='" + onlydate[0] + "' ", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into  tbl_Viscount(Ddate,P5) values('" + onlydate[0] + "','1')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
          
            int Pid = 5;
            string Catid = "category_5";
            Session["proname"] = "Canon EOS 60D SLR";
            saveipinfo(Pid, Catid);

        }
        catch (Exception)
        {
          
        }
      

    }

    protected void lnkb_pro_2_Click(object sender, EventArgs e)
    {
        try
        {
        
            string date = DateTime.Now.Date.ToShortDateString();
            string[] onlydate = date.Split(' ');
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Viscount where ddate='" + onlydate[0] + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_Viscount");
            if (ds.Tables[0].Rows.Count > 0)
            {
                int count = Convert.ToInt32(ds.Tables[0].Rows[0]["Vcount"].ToString()) + 1;
                int p5 = Convert.ToInt32(ds.Tables[0].Rows[0]["P6"].ToString());
                if (p5 > 0)
                {
                    int p51 = Convert.ToInt32(ds.Tables[0].Rows[0]["P6"].ToString()) + 1;
                    SqlCommand cmd = new SqlCommand("update  tbl_Viscount set P6='" + p51 + "' where ddate='" + onlydate[0] + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("update  tbl_Viscount set P6='1' where ddate='" + onlydate[0] + "' ", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into  tbl_Viscount(Ddate,P6) values('" + onlydate[0] + "','1')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
          
            int Pid = 6;
            string Catid = "category_6";
            Session["proname"] = "Canon IXUS 255 HS Point & Shoot";
            saveipinfo(Pid, Catid);

        }

        catch (Exception)
        {

        }
      
    }

    protected void lnkb_pro_3_Click(object sender, EventArgs e)
    {
        try
        {
          

            string date = DateTime.Now.Date.ToShortDateString();
            string[] onlydate = date.Split(' ');
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Viscount where ddate='" + onlydate[0] + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_Viscount");
            if (ds.Tables[0].Rows.Count > 0)
            {
                int count = Convert.ToInt32(ds.Tables[0].Rows[0]["Vcount"].ToString()) + 1;
                int p5 = Convert.ToInt32(ds.Tables[0].Rows[0]["P7"].ToString());
                if (p5 > 0)
                {
                    int p51 = Convert.ToInt32(ds.Tables[0].Rows[0]["P7"].ToString()) + 1;
                    SqlCommand cmd = new SqlCommand("update  tbl_Viscount set P7='" + p51 + "' where ddate='" + onlydate[0] + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("update  tbl_Viscount set P7='1' where ddate='" + onlydate[0] + "' ", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into  tbl_Viscount(Ddate,P7) values('" + onlydate[0] + "','1')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            
            int Pid = 7;
            string Catid = "category_7";
            Session["proname"] = "Canon IXUS 255 HS Point & Shoot";
            saveipinfo(Pid, Catid);
        }
        catch (Exception)
        {

        }
    
    }

    protected void lnkb_pro_4_Click(object sender, EventArgs e)
    {
        try
        {
        
               string date = DateTime.Now.Date.ToShortDateString();
            string[] onlydate = date.Split(' ');
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Viscount where ddate='" + onlydate[0] + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_Viscount");
            if (ds.Tables[0].Rows.Count > 0)
            {
                int count = Convert.ToInt32(ds.Tables[0].Rows[0]["Vcount"].ToString()) + 1;
                int p5 = Convert.ToInt32(ds.Tables[0].Rows[0]["P8"].ToString());
                if (p5 > 0)
                {
                    int p51 = Convert.ToInt32(ds.Tables[0].Rows[0]["P8"].ToString()) + 1;
                    SqlCommand cmd = new SqlCommand("update  tbl_Viscount set P8='" + p51 + "' where ddate='" + onlydate[0] + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("update  tbl_Viscount set P8='1' where ddate='" + onlydate[0] + "' ", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into  tbl_Viscount(Ddate,P8) values('" + onlydate[0] + "','1')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            
            int Pid = 8;
            string Catid = "category_8";
            Session["proname"] = "Canon IXUS 255 HS Point & Shoot";
            saveipinfo(Pid, Catid);

        }
        catch (Exception)
        {
           
        }
       
    }

 
}
