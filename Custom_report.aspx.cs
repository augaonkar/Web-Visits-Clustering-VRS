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

public partial class Custom_report : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                if (Session["U_name"] == null)
                {
                    Response.Redirect("AdminLogin.aspx");
                }
                else
                {
                    Caldate();
                }
            }
        }
        catch (Exception)
        {
           
        }
      
    }
    public void Caldate()
    {
        for (int i = 1; i <= 31; i++)
        {
            ddl_fromdate.Items.Add(i.ToString());
        }
        for (int i = 1; i <= 12; i++)
        {
            ddl_frommonth.Items.Add(i.ToString());
        }
       
            ddl_fromyear.Items.Add("2014");
        
        for (int i = 1; i <= 31; i++)
        {
            ddl_todate.Items.Add(i.ToString());
        }
        for (int i = 1; i <= 12; i++)
        {
            ddl_tomonth.Items.Add(i.ToString());
        }
       

            ddl_toyear.Items.Add("2014");
       

    }

    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cntr"].ToString());
    protected void btn_get_Click(object sender, EventArgs e)
    {
        try
        {
            Panel2.Visible = true;
            txt_from.Text = ddl_fromdate.Text + "/" + ddl_frommonth.Text + "/" + ddl_fromyear.Text;
            txt_to.Text = ddl_todate.Text + "/" + ddl_tomonth.Text + "/" + ddl_toyear.Text;
             CompletelyChngedCode();
             SqlDataAdapter da11 = new SqlDataAdapter("select CityName As [Name],Pro1 As [P1],Pro2 As [P2],Pro3 As [P3],Pro4 As [P4],Pro5 As [P5],Pro6 As [P6],Pro7 As [P7],Pro8 As [P8],Pro9 As [P9],Pro10 As [P10],Pro11 As [P11],Pro12 As [P12],ProTotal As [Total] from tbl_wkly", con);
            DataSet ds11 = new DataSet();
            da11.Fill(ds11, "tbl_wkly");
            GridView1.DataSource = ds11;
            GridView1.DataBind();
        }
        catch (Exception)
        {
          
        }
    }

    private void CompletelyChngedCode()
    {
        try
        {
            string from = ddl_frommonth.Text + "/" + ddl_fromdate.Text + "/" + ddl_fromyear.Text;
            string to = ddl_tomonth.Text + "/" + ddl_todate.Text + "/" + ddl_toyear.Text;
            string cityname = "";
            con.Open();
            SqlCommand cmd1 = new SqlCommand("truncate table tbl_wkly", con);
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
                    SqlCommand cmd = new SqlCommand("select Count(CityName) as CountCity from  Master_Product where CityName='" + cityname + "' AND Visiting_Date between '" + from + "' AND '" + to + "' and ProductId='" + j + "'", con);
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
                SqlDataAdapter da1 = new SqlDataAdapter("insert into tbl_wkly values('" + cityname + "','" + Countstringarray[0] + "','" + Countstringarray[1] + "','" + Countstringarray[2] + "','" + Countstringarray[3] + "','" + Countstringarray[4] + "','" + Countstringarray[5] + "','" + Countstringarray[6] + "','" + Countstringarray[7] + "','" + Countstringarray[8] + "','" + Countstringarray[9] + "','" + Countstringarray[10] + "','" + Countstringarray[11] + "','" + total + "')", con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "tbl_wkly");
            }


        }
        catch (Exception)
        {
           
        }
       
    }

    protected void btn_print_Click(object sender, EventArgs e)
    {
        try
        {
            Session["ctrl"] = Panel2;
            ClientScript.RegisterStartupScript(this.GetType(), "onclick", "<script language=javascript>window.open('Print.aspx','PrintMe','height=300px,width=300px,scrollbars=1');</script>");
        }
        catch (Exception)
        {
         
        }
       
    }
}
