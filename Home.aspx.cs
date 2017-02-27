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

public partial class Home : System.Web.UI.Page
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
                if (!IsPostBack)
                {
                    getdate();
                    getdata();
                    getall();
                    getcount();
                }
                LoadChartData();
            }
        }
        catch (Exception)
        {
            
        }


        try
        {
            SqlDataAdapter da = new SqlDataAdapter("select Vcount from tbl_Viscount where Ddate='" + ddl_date.SelectedItem.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_Viscount");
            int cnt = ds.Tables[0].Rows.Count;
            if (cnt > 0)
            {
                lbl_no.Text = ds.Tables[0].Rows[0]["Vcount"].ToString();

            }
        }
        catch (Exception)
        {

            throw;
        }

     
    }

    private void getcount()
    {
        try
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Locations", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Locations");
            int cnt = ds.Tables[0].Rows.Count;
            if (cnt > 0)
            {
                lbl_no1.Text = cnt.ToString();
            }
        }
        catch (Exception)
        {

        }
    }

    private void getall()
    {
        try
        {
            string date = DateTime.Now.Date.ToShortDateString();
            string[] onlydate = date.Split(' ');
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Viscount where Ddate='" + onlydate[0] + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_Viscount");
            if (ds.Tables[0].Rows.Count > 0)
            {
                int p1 = Convert.ToInt32(ds.Tables[0].Rows[0]["P1"].ToString());
                int p2 = Convert.ToInt32(ds.Tables[0].Rows[0]["P2"].ToString());
                int p3 = Convert.ToInt32(ds.Tables[0].Rows[0]["P3"].ToString());
                int p4 = Convert.ToInt32(ds.Tables[0].Rows[0]["P4"].ToString());
                int p5 = Convert.ToInt32(ds.Tables[0].Rows[0]["P5"].ToString());
                int p6 = Convert.ToInt32(ds.Tables[0].Rows[0]["P6"].ToString());
                int p7 = Convert.ToInt32(ds.Tables[0].Rows[0]["P7"].ToString());
                int p8 = Convert.ToInt32(ds.Tables[0].Rows[0]["P8"].ToString());
                int p9 = Convert.ToInt32(ds.Tables[0].Rows[0]["P9"].ToString());
                int p10 = Convert.ToInt32(ds.Tables[0].Rows[0]["P10"].ToString());
                int p11 = Convert.ToInt32(ds.Tables[0].Rows[0]["P11"].ToString());
                int p12 = Convert.ToInt32(ds.Tables[0].Rows[0]["P12"].ToString());
                int[] ccnt = { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12 };
                var indexAtMax = ccnt.ToList().IndexOf(ccnt.Max());
                var max = ccnt.Max();
                if (max.Equals(0))
                {
                  
                }
                else
                {
                    if (max.Equals(p1))
                    {
                        txt_proday.Text = txt_proday.Text + "\r\n" + "Product 1";
                    }
                    if (max.Equals(p2))
                    {
                        txt_proday.Text = txt_proday.Text + "\r\n" + "Product 2";
                    }
                    if (max.Equals(p3))
                    {
                        txt_proday.Text = txt_proday.Text + "\r\n" + "Product 3";
                    }
                    if (max.Equals(p4))
                    {
                        txt_proday.Text = txt_proday.Text + "\r\n" + "Product 4";
                    }
                    if (max.Equals(p5))
                    {
                        txt_proday.Text = txt_proday.Text + "\r\n" + "Product 5";
                    }
                    if (max.Equals(p6))
                    {
                        txt_proday.Text = txt_proday.Text + "\r\n" + "Product 6";
                    }
                    if (max.Equals(p7))
                    {
                        txt_proday.Text = txt_proday.Text + "\r\n" + "Product 7";
                    }
                    if (max.Equals(p8))
                    {
                        txt_proday.Text = txt_proday.Text + "\r\n" + "Product 8";
                    }
                    if (max.Equals(p9))
                    {
                        txt_proday.Text = txt_proday.Text + "\r\n" + "Product 9";
                    }
                    if (max.Equals(p10))
                    {
                        txt_proday.Text = txt_proday.Text + "\r\n" + "Product 10";
                    }
                    if (max.Equals(p11))
                    {
                        txt_proday.Text = txt_proday.Text + "\r\n" + "Product 11";
                    }
                    if (max.Equals(p12))
                    {
                        txt_proday.Text = txt_proday.Text + "\r\n" + "Product 12";
                    }
                }
              

            }
        }
        catch (Exception)
        {
            
          
        }
       
    }

    private void LoadChartData()
    {
        Chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        Chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        string query = "SELECT Top 10 Ddate,VCount from tbl_Viscount";

        SqlDataAdapter da = new SqlDataAdapter(query, con);
        DataTable table = new DataTable();
        da.Fill(table);

        DataView dv = table.DefaultView;
        Chart1.DataBind();
        Chart1.Series["Series1"].Points.DataBindXY(dv, "Ddate", dv, "VCount");
      
    }

    private void getdate()
    {
        try
        {
            SqlDataAdapter da = new SqlDataAdapter("select Ddate from tbl_Viscount order by Vid Desc", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_Viscount");
            int cnt = ds.Tables[0].Rows.Count;
            if (cnt > 0)
            {
                for (int i = 0; i < cnt; i++)
                {
                    ddl_date.Items.Add(ds.Tables[0].Rows[i]["Ddate"].ToString());
                }
            }
        }
        catch (Exception)
        {
           
        }
     
                                    
    }

    private void getdata()
    {
        try
        {
            SqlDataAdapter da = new SqlDataAdapter("select top 10 Ddate as [Date],Vcount As [No of Visitors] from tbl_Viscount order by Vid Desc", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_Viscount");
            gvdata.DataSource = ds;
            gvdata.DataBind();
        }
        catch (Exception)
        {

        }
     
    }


    protected void btn_get_Click(object sender, EventArgs e)
    {
        try
        {
             SqlDataAdapter da = new SqlDataAdapter("select Vcount from tbl_Viscount where Ddate='"+ddl_date.SelectedItem.Text+"'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_Viscount");
            int cnt = ds.Tables[0].Rows.Count;
            if (cnt > 0)
            {
                   lbl_no.Text= ds.Tables[0].Rows[0]["Vcount"].ToString();
              
            }
        }
        catch (Exception)
        {
            
            throw;
        }
    }
}
