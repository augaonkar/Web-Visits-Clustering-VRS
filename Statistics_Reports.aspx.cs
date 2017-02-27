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

public partial class Statistics_Reports : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
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
            if (ddl_chart.SelectedItem.Text.Equals("Show All"))
            {
                ShowAllGraph();
            }


        
            string from = ddl_frommonth.Text + "/" + ddl_fromdate.Text + "/" + ddl_fromyear.Text;
            string to = ddl_tomonth.Text + "/" + ddl_todate.Text + "/" + ddl_toyear.Text;
             
                string cityname = "";
                con.Open();
                SqlCommand cmd1 = new SqlCommand("truncate table tbl_stat_datewise_cnt", con);
                cmd1.ExecuteNonQuery();
                con.Close();
                SqlDataAdapter da = new SqlDataAdapter("select distinct CityName from Master_Product", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Master_Product");
                int discitycount = ds.Tables[0].Rows.Count;
                for (int i = 0; i < discitycount; i++)
                {
                    
                    cityname = ds.Tables[0].Rows[i]["CityName"].ToString();
                    con.Open();
                    
                    SqlCommand cmd = new SqlCommand("select Count(CityName) as CountCity from  Master_Product where CityName='" + cityname + "' AND Visiting_Date between '" + from + "' AND '" + to + "' and ProductId='"+ddl_productlist.SelectedItem.Value.ToString()+"'", con);
                    int CcCount = (int)cmd.ExecuteScalar();
                    SqlCommand cmd2 = new SqlCommand("insert into tbl_stat_datewise_cnt values('"+cityname+"','"+CcCount+"')", con);
                    cmd2.ExecuteNonQuery();                    
                    con.Close();
               
                }
              
                if (ddl_chart.SelectedItem.Text.Equals("Bar Chart"))
                {
                    MultiView1.ActiveViewIndex = 0;
                    LoadChartData();
                }
                if (ddl_chart.SelectedItem.Text.Equals("Pie Chart"))
                {
                    MultiView1.ActiveViewIndex = 1;
                    LoadChartData2();
                }
                if (ddl_chart.SelectedItem.Text.Equals("Line Chart"))
                {
                    MultiView1.ActiveViewIndex = 2;
                    LoadChartData1();
                }
                if (ddl_chart.SelectedItem.Text.Equals("Pyramid Chart"))
                {
                    MultiView1.ActiveViewIndex = 3;
                    LoadChartData3();
                }
        }
        catch (Exception)
        {
          
        }
      
    }

    private void ShowAllGraph()
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

    private void getdata()
    {
        try
        {
            SqlDataAdapter da = new SqlDataAdapter("select top 10 Ddate as [Date],Vcount As [No of Visitors] from tbl_Viscount order by Vid Desc", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_Viscount");
            gv_data.DataSource = ds;
            gv_data.DataBind();
        }
        catch (Exception)
        {

        }

    }

    private void LoadChartData2()
    {
        Chart2.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        Chart2.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        string query = "SELECT City_nm,Count from tbl_stat_datewise_cnt";

        SqlDataAdapter da = new SqlDataAdapter(query, con);
        DataTable table = new DataTable();
        da.Fill(table);
        DataView dv = table.DefaultView;      
        Chart2.DataBind();
        Chart2.Series["Series1"].Points.DataBindXY(dv, "City_nm", dv, "Count");
        gv_data.DataMember = "tbl_stat_datewise_cnt";
        gv_data.DataSource = table;
        gv_data.DataBind();
    }

    private void LoadChartData1()
    {
        Chart3.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        Chart3.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        string query = "SELECT City_nm,Count from tbl_stat_datewise_cnt";

        SqlDataAdapter da = new SqlDataAdapter(query, con);
        DataTable table = new DataTable();
        da.Fill(table);
        DataView dv = table.DefaultView;
        Chart3.DataBind();
        Chart3.Series["Series1"].Points.DataBindXY(dv, "City_nm", dv, "Count");
        gv_data.DataMember = "tbl_stat_datewise_cnt";
        gv_data.DataSource = table;
        gv_data.DataBind();
    }

    private void LoadChartData3()
    {
        Chart4.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        Chart4.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        string query = "SELECT City_nm,Count from tbl_stat_datewise_cnt";

        SqlDataAdapter da = new SqlDataAdapter(query, con);
        DataTable table = new DataTable();
        da.Fill(table);
        DataView dv = table.DefaultView;
        Chart4.DataBind();
        Chart4.Series["Series1"].Points.DataBindXY(dv, "City_nm", dv, "Count");
        gv_data.DataMember = "tbl_stat_datewise_cnt";
        gv_data.DataSource = table;
        gv_data.DataBind();
    }


    private void LoadChartData()
    {
        Chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        Chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
       
        string query = "SELECT City_nm,Count from tbl_stat_datewise_cnt";

        SqlDataAdapter da = new SqlDataAdapter(query, con);
        DataTable table = new DataTable();
        da.Fill(table);

        DataView dv = table.DefaultView;
        Chart1.DataBind();
        Chart1.Series["Series1"].Points.DataBindXY(dv, "City_nm", dv, "Count");

        gv_data.DataMember = "tbl_stat_datewise_cnt";
        gv_data.DataSource = table;
        gv_data.DataBind();
    }


    protected void btn_print_Click(object sender, EventArgs e)
    {
       /* try
        {
            Session["ctrl"] = Panel1;
            ClientScript.RegisterStartupScript(this.GetType(), "onclick", "<script language=javascript>window.open('Print.aspx','PrintMe','height=300px,width=300px,scrollbars=1');</script>");
        }
        catch (Exception)
        {
           
        }*/

        try
        {
            Session["ctrl"] = Panel1;
            ClientScript.RegisterStartupScript(this.GetType(), "onclick", "<script language=javascript>window.open('Print.aspx','PrintMe','height=300px,width=300px,scrollbars=1');</script>");
        }
        catch (Exception)
        {

        }
       
    }
    protected void btn_print_Click1(object sender, EventArgs e)
    {

    }
}
