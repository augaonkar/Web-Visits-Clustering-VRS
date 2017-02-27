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

public partial class Show_All_Graph : System.Web.UI.Page
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

            Coppytable();
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

    private void Coppytable()
    {
        con.Open();
        SqlCommand cmd1 = new SqlCommand("truncate table tbl_show_all_graph", con);
        cmd1.ExecuteNonQuery();
        SqlCommand cmd = new SqlCommand("insert into tbl_show_all_graph select Ddate,Vcount from tbl_Viscount", con);
        cmd.ExecuteNonQuery();
        con.Close();
    }



    private void getdata()
    {
        try
        {
            string from = ddl_frommonth.Text + "/" + ddl_fromdate.Text + "/" + ddl_fromyear.Text;
            string to = ddl_tomonth.Text + "/" + ddl_todate.Text + "/" + ddl_toyear.Text;

            SqlDataAdapter da = new SqlDataAdapter("select Ddate as [Date],Vcount AS [No of Visitors] from tbl_show_all_graph where Ddate between '" + from + "' AND '" + to + "' order by Vcount DESC", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_show_all_graph");
            gv_data.DataSource = ds;
            gv_data.DataBind();
        }
        catch (Exception)
        {

        }

    }

    private void LoadChartData2()
    {
        string from = ddl_frommonth.Text + "/" + ddl_fromdate.Text + "/" + ddl_fromyear.Text;
        string to = ddl_tomonth.Text + "/" + ddl_todate.Text + "/" + ddl_toyear.Text;

        Chart2.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        Chart2.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        string query = "SELECT  Ddate,Vcount from tbl_show_all_graph where Ddate between '" + from + "' AND '" + to + "'";

        SqlDataAdapter da = new SqlDataAdapter(query, con);
        DataTable table = new DataTable();
        da.Fill(table);

        DataView dv = table.DefaultView;
        Chart2.DataBind();
        Chart2.Series["Series1"].Points.DataBindXY(dv, "Ddate", dv, "VCount");
        getdata();
    }

    private void LoadChartData1()
    {
        string from = ddl_frommonth.Text + "/" + ddl_fromdate.Text + "/" + ddl_fromyear.Text;
        string to = ddl_tomonth.Text + "/" + ddl_todate.Text + "/" + ddl_toyear.Text;

        Chart3.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        Chart3.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        string query = "SELECT  Ddate,Vcount from tbl_show_all_graph where Ddate between '" + from + "' AND '" + to + "'";

        SqlDataAdapter da = new SqlDataAdapter(query, con);
        DataTable table = new DataTable();
        da.Fill(table);

        DataView dv = table.DefaultView;
        Chart3.DataBind();
        Chart3.Series["Series1"].Points.DataBindXY(dv, "Ddate", dv, "VCount");
        getdata();
    }

    private void LoadChartData3()
    {
        string from = ddl_frommonth.Text + "/" + ddl_fromdate.Text + "/" + ddl_fromyear.Text;
        string to = ddl_tomonth.Text + "/" + ddl_todate.Text + "/" + ddl_toyear.Text;

        Chart4.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        Chart4.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        string query = "SELECT  Ddate,Vcount from tbl_show_all_graph where Ddate between '" + from + "' AND '" + to + "' order by Vcount DESC";

        SqlDataAdapter da = new SqlDataAdapter(query, con);
        DataTable table = new DataTable();
        da.Fill(table);

        DataView dv = table.DefaultView;
        Chart4.DataBind();
        Chart4.Series["Series1"].Points.DataBindXY(dv, "Ddate", dv, "VCount");
        getdata();
    }


    private void LoadChartData()
    {
        string from = ddl_frommonth.Text + "/" + ddl_fromdate.Text + "/" + ddl_fromyear.Text;
        string to = ddl_tomonth.Text + "/" + ddl_todate.Text + "/" + ddl_toyear.Text;

        Chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        Chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        string query = "SELECT  Ddate,Vcount from tbl_show_all_graph where Ddate between '" + from + "' AND '" + to + "' ";

        SqlDataAdapter da = new SqlDataAdapter(query, con);
        DataTable table = new DataTable();
        da.Fill(table);

        DataView dv = table.DefaultView;
        Chart1.DataBind();
        Chart1.Series["Series1"].Points.DataBindXY(dv, "Ddate", dv, "Vcount");
        getdata();
    }


    protected void btn_print_Click(object sender, EventArgs e)
    {
        try
        {
            Session["ctrl"] = Panel1;
            ClientScript.RegisterStartupScript(this.GetType(), "onclick", "<script language=javascript>window.open('Print.aspx','PrintMe','height=300px,width=300px,scrollbars=1');</script>");
        }
        catch (Exception)
        {

        }

    }
    protected void gv_data_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv_data.PageIndex = e.NewPageIndex;
        getdata();
    }
}
