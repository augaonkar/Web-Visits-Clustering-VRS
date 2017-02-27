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
using System.Net.Mail;

public partial class AdminLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //tb();
    }
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cntr"].ToString());
    protected void gvLocation_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    double Lat, Long;
    string city1;
    int CountCity = 0;
    private void tb()    //master_product
    {
        SqlDataAdapter da = new SqlDataAdapter("select distinct CityName from Master_Product", con);
        DataSet ds = new DataSet();
        da.Fill(ds, "Product_Master");
        CountCity = ds.Tables[0].Rows.Count;

        string ans = "";
        int rowid = 0;
        double[] DistArray = new double[CountCity]; ;
        string[] citynames = new string[CountCity];
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
                for (int j = 0; j < CountCity; j++)
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
                SqlDataAdapter da7 = new SqlDataAdapter("update Master_Product set Cluster='" + nearbyCity + "' where U_Id='" + rowid + "'", con);
                DataSet ds7 = new DataSet();
                da7.Fill(ds7);

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
        //show();
    }
    protected void btn_LogIn_Click(object sender, EventArgs e)
    {
        try
        {
            if (txt_UserName.Text == "ipadmin")
            {
                if (txt_Password.Text == "ipadmin")
                {
                    Session["U_name"] = txt_UserName.Text;
                    Response.Redirect("Home.aspx");
                }

            }
            else
            {
             
                    txt_UserName.Text = "";
                    txt_Password.Text = "";
                    Label1.Text = "Incorrect Username or Password... Please Try Again...";
                
            }


            //else
            //{
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand("Select * from Registration where U_Name= '" + txt_UserName.Text + "' and U_Password= '" + txt_Password.Text + "' ", con);
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    if (dr.HasRows)
            //    {
            //        Session["U_name"] = txt_UserName.Text;
            //        Response.Redirect("Home.aspx");
            //    }
            //    else
            //    {
            //        Label1.Text = "Incorrect Username or Password... Please Try Again...";
            //    }
            //}
        }
        catch (Exception)
        {

            throw;
        }
    }
    protected void btn_Cancel_Click(object sender, EventArgs e)
    {
        txt_UserName.Text = "";
        txt_Password.Text = "";
        Label1.Text = "";
    }
    protected void lnb_frgtpass_Click(object sender, EventArgs e)
    {
        try
        {
            MailMessage mail = new MailMessage();
            string to = "smartvrs@gmail.com";
            mail.To.Add(to);
            mail.From = new MailAddress("smartvrs@gmail.com");
            mail.Subject = "Mail From smarthit.co.in";
            string Body = "User Name: ipadmin  " + "<br/><br/>Password : ipadmin";
            mail.Body = Body;
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;

            smtp.Credentials = new System.Net.NetworkCredential("smartvrs@gmail.com", "smarthit");

            smtp.EnableSsl = true;
            smtp.Send(mail);
            Label1.Text = "Mail Sent Successfuly !!!";
            
        }
        catch (Exception ex)
        {
            Label1.Text = "Sorry !!!";
        }
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
