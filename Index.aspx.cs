
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
        //pup.ShowPopupWindow();    
        try
        {
            if (!IsPostBack)
            {
                int count = 0;
                SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Pagecnt where Id='1'", con);
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
                SqlDataAdapter da1 = new SqlDataAdapter("update tbl_Pagecnt set Count='" + count + "' where Id='2'", con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "tbl_Pagecnt");
        
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
                    string RegionName1 = locations[0].RegionName;
                    string ZipCode1 = locations[0].ZipCode;
                    string Latitude1 = locations[0].Latitude;
                    string Longitude1 = locations[0].Longitude;
                    string TimeZone1 = locations[0].TimeZone;
                    string VisitingDate = (DateTime.Now).ToString();
                    if (CountryName1.Equals("INDIA"))
                    {

                        SqlCommand cmd = new SqlCommand("Insert into Locations(IPAddress,CountryName,CountryCode,CityName,RegionName,ZipCode,Latitude,Longitude,TimeZone,Visiting_Date) values('" + IPAddress1.ToString() + "' , '" + CountryName1.ToString() + "' , '" + CountryCode1.ToString() + "' , '" + CityName1.ToString() + "' , '" + RegionName1.ToString() + "' ,'" + ZipCode1.ToString() + "' ,  '" + Latitude1.ToString() + "' , '" + Longitude1.ToString() + "' , '" + TimeZone1.ToString() + "' , '" + VisitingDate.ToString() + "'   )", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                    }

                }
                string date = DateTime.Now.Date.ToShortDateString();
                string[] onlydate = date.Split(' ');
                SqlDataAdapter da2 = new SqlDataAdapter("select * from tbl_Viscount where ddate='" + onlydate[0] + "'", con);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2, "tbl_Viscount");
                if (ds2.Tables[0].Rows.Count > 0)
                {
                    int count2=Convert.ToInt32(ds.Tables[0].Rows[0]["Vcount"].ToString()) + 1;
                    SqlCommand cmd = new SqlCommand("update  tbl_Viscount set Vcount='" + count2 + "' where ddate='" + onlydate[0] + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into  tbl_Viscount values('" + onlydate[0] + "','1','0','0','0','0','0','0','0','0','0','0','0','0')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        //}
        catch (Exception)
        {
          
        }
       
    }
    protected void MycloseWindow(object sender, EventArgs e)
    {

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
        Session["index1"] = "ok";
        Response.Redirect("Index_Cat1.aspx");
       
    }
     
    protected void lnkb_pro_2_Click(object sender, EventArgs e)
    {
        Session["index1"] = "ok";
        Response.Redirect("Index_Cat2.aspx");

    }

    protected void lnkb_pro_3_Click(object sender, EventArgs e)
    {
        Session["index1"] = "ok";
        Response.Redirect("Index_Cat3.aspx");
    }

    protected void ImageButton4_Click(object sender, System.Web.UI.ImageClickEventArgs e)
    {
        Session["index1"] = "ok";
        Response.Redirect("Index_Cat1.aspx");
    }
    protected void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
    {
        Session["index1"] = "ok";
        Response.Redirect("Index_Cat2.aspx");
    }
    protected void ImageButton5_Click(object sender, System.Web.UI.ImageClickEventArgs e)
    {
        Session["index1"] = "ok";
        Response.Redirect("Index_Cat3.aspx");
    }
}
