
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
            }
            else
            {
                int count = 0;
                SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Pagecnt where Id='3'", con);
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
                SqlDataAdapter da1 = new SqlDataAdapter("update tbl_Pagecnt set Count='" + count + "' where Id='4'", con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "tbl_Pagecnt");
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
                //int count = Convert.ToInt32(ds.Tables[0].Rows[0]["Vcount"].ToString()) + 1;
                int p5 = Convert.ToInt32(ds.Tables[0].Rows[0]["P1"].ToString());
                if (p5 > 0)
                {
                    int p51 = Convert.ToInt32(ds.Tables[0].Rows[0]["P1"].ToString()) + 1;
                    SqlCommand cmd = new SqlCommand("update  tbl_Viscount set P1='" + p51 + "' where ddate='" + onlydate[0] + "' ", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("update  tbl_Viscount set P1='1' where ddate='" + onlydate[0] + "' ", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into  tbl_Viscount(Ddate,P1) values('" + onlydate[0] + "','1')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
           
            int Pid = 1;
            string Catid = "category_1";
            Session["proname"] = "SONY ALPHA A37K";
            saveipinfo(Pid, Catid);

           
        }
        catch (Exception)
        {
            throw;
        }
     
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
                if (CountryName1.Equals("INDIA"))//  Only For India
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
                        Session["Catname"] = "Sony";
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
                    Session["Catname"] = "Sony";
                    Response.Redirect("Products.aspx");
                }
            }
        }
        catch (Exception ex)
        {
            throw;
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
                //   int count = Convert.ToInt32(ds.Tables[0].Rows[0]["Vcount"].ToString()) + 1;
                int p5 = Convert.ToInt32(ds.Tables[0].Rows[0]["P2"].ToString());
                if (p5 > 0)
                {
                    int p51 = Convert.ToInt32(ds.Tables[0].Rows[0]["P2"].ToString()) + 1;
                    SqlCommand cmd = new SqlCommand("update  tbl_Viscount set P2='" + p51 + "' where ddate='" + onlydate[0] + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("update  tbl_Viscount set P2='1' where ddate='" + onlydate[0] + "' ", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into  tbl_Viscount(Ddate,P2) values('" + onlydate[0] + "','1')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
           
            int Pid = 2;
            string Catid = "category_2";
            Session["proname"] = "Sony Alpha A65VK SLT SLR";
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
                int p5 = Convert.ToInt32(ds.Tables[0].Rows[0]["P3"].ToString());
                if (p5 > 0)
                {
                    int p51 = Convert.ToInt32(ds.Tables[0].Rows[0]["P3"].ToString()) + 1;
                    SqlCommand cmd = new SqlCommand("update  tbl_Viscount set P3='" + p51 + "' where ddate='" + onlydate[0] + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("update  tbl_Viscount set P3='1' where ddate='" + onlydate[0] + "' ", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into  tbl_Viscount(Ddate,P3) values('" + onlydate[0] + "','1')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
         
            int Pid = 3;
            string Catid = "category_3";
            Session["proname"] = "Sony Cybershot DSC-T2 8MP";
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
                int p5 = Convert.ToInt32(ds.Tables[0].Rows[0]["P4"].ToString());
                if (p5 > 0)
                {
                    int p51 = Convert.ToInt32(ds.Tables[0].Rows[0]["P4"].ToString()) + 1;
                    SqlCommand cmd = new SqlCommand("update  tbl_Viscount set P4='" + p51 + "' where ddate='" + onlydate[0] + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("update  tbl_Viscount set P4='1' where ddate='" + onlydate[0] + "' ", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into  tbl_Viscount(Ddate,P4) values('" + onlydate[0] + "','1')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
          
            int Pid = 4;
            string Catid = "category_4";
            Session["proname"] = "Sony Cyber-shot DSC-WX200";
            saveipinfo(Pid, Catid);

        }
        catch (Exception)
        {
            
        }
     
    }
  
   
}
