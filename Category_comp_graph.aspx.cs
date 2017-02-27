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
using System.Configuration;
using System;
using System.Text;


public partial class Category_comp_graph : System.Web.UI.Page
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
            con.Open();
            SqlCommand cmd = new SqlCommand("truncate table tbl_cat_comp_graph", con);
            cmd.ExecuteNonQuery();


            SqlCommand cmd1 = new SqlCommand("insert into tbl_cat_comp_graph select Ddate,P1+P2+P3+P4,P5+P6+P7+P8,P9+P10+P11+P12 from tbl_Viscount", con);
            cmd1.ExecuteNonQuery();
            con.Close();

        }
        catch (Exception)
        {

            throw;
        }
        if (ddl_chart.SelectedItem.Text.Equals("Stacked Chart"))
        {
            stacked();
            MultiView1.ActiveViewIndex = 0;
        }

        if (ddl_chart.SelectedItem.Text.Equals("Line Chart"))
        {
            linecat();
            MultiView1.ActiveViewIndex = 1;
        }
    
    }

    private void linecat()
    {
        LoadChartData1();
       
    }

    private void LoadChartData()
    {


        Chart2.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        Chart2.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        string query = "SELECT  * from tbl_cat_comp_graph ";

        SqlDataAdapter da = new SqlDataAdapter(query, con);
        DataTable table = new DataTable();
        da.Fill(table);

        DataView dv = table.DefaultView;
        Chart2.DataBind();
        Chart2.Series["Sony"].Points.DataBindXY(dv, "Ddate", dv, "cat1");
        Chart2.Series["Canon"].Points.DataBindXY(dv, "Ddate", dv, "cat2");
        Chart2.Series["Nikon"].Points.DataBindXY(dv, "Ddate", dv, "cat3");
        getdata();
    }

    private void LoadChartData1()
    {


        Chart3.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        Chart3.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        string query = "SELECT  * from tbl_cat_comp_graph ";

        SqlDataAdapter da = new SqlDataAdapter(query, con);
        DataTable table = new DataTable();
        da.Fill(table);

        DataView dv = table.DefaultView;
        Chart3.DataBind();
        Chart3.Series["Sony"].Points.DataBindXY(dv, "Ddate", dv, "cat1");
        Chart3.Series["Canon"].Points.DataBindXY(dv, "Ddate", dv, "cat2");
        Chart3.Series["Nikon"].Points.DataBindXY(dv, "Ddate", dv, "cat3");
        getdata();
    }

    private void getdata()
    {
        try
        {
            string from = ddl_frommonth.Text + "/" + ddl_fromdate.Text + "/" + ddl_fromyear.Text;
            string to = ddl_tomonth.Text + "/" + ddl_todate.Text + "/" + ddl_toyear.Text;

            SqlDataAdapter da = new SqlDataAdapter("select Ddate as [Date] ,cat1 AS [Sony],cat2 AS [Canon],cat3 AS [Nikon] from tbl_cat_comp_graph where Ddate between '" + from + "' AND '" + to + "' ", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_cat_comp_graph");
            gv_data.DataSource = ds;
            gv_data.DataBind();
        }
        catch (Exception)
        {

        }
    }

    private void stacked()
    {
        LoadChartData();
    }

    protected void btn_print_Click(object sender, EventArgs e)
    {
        //try
        //{
        //    Session["ctrl"] = Panel1;
        //    ClientScript.RegisterStartupScript(this.GetType(), "onclick", "<script language=javascript>window.open('Print.aspx','PrintMe','height=300px,width=300px,scrollbars=1');</script>");
        //}
        //catch (Exception)
        //{

        //}

    }
    protected void gv_data_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv_data.PageIndex = e.NewPageIndex;
        getdata();
    }
}
