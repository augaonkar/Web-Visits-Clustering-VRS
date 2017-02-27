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
public partial class Citywise_graph : System.Web.UI.Page
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
            loadcity();
             }
        }
    }

    private void loadcity()
    {
          SqlDataAdapter da = new SqlDataAdapter("select distinct CityName from Master_Product", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Master_Product");
            int disregioncount = ds.Tables[0].Rows.Count;
            for (int i = 0; i < disregioncount; i++)
            {
                ddl_city.Items.Add(ds.Tables[0].Rows[i]["CityName"].ToString());
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

            string from = ddl_frommonth.Text + "/" + ddl_fromdate.Text + "/" + ddl_fromyear.Text;
            string to = ddl_tomonth.Text + "/" + ddl_todate.Text + "/" + ddl_toyear.Text;

            string cityname = "";
            con.Open();
            SqlCommand cmd13 = new SqlCommand("truncate table tbl_city_wise_graph", con);
            cmd13.ExecuteNonQuery();
            con.Close();


            cityname = ddl_city.SelectedItem.Text;
                con.Open();

                SqlCommand cmd = new SqlCommand("select Count(CityName) as CountCityName from  Master_Product where CityName='" + cityname + "' and ProductCategory='category_1' AND Visiting_Date between '" + from + "' AND '" + to + "' ", con);
                int CcCount = (int)cmd.ExecuteScalar();
                SqlCommand cmd1 = new SqlCommand("select Count(CityName) as CountCityName from  Master_Product where CityName='" + cityname + "' and ProductCategory='category_2' AND Visiting_Date between '" + from + "' AND '" + to + "' ", con);
                int CcCount1 = (int)cmd1.ExecuteScalar();
                SqlCommand cmd2 = new SqlCommand("select Count(CityName) as CountCityName from  Master_Product where CityName='" + cityname + "' and ProductCategory='category_3' AND Visiting_Date between '" + from + "' AND '" + to + "'", con);
                int CcCount2 = (int)cmd2.ExecuteScalar();
                SqlCommand cmd3 = new SqlCommand("select Count(CityName) as CountCityName from  Master_Product where CityName='" + cityname + "' and ProductCategory='category_4' AND Visiting_Date between '" + from + "' AND '" + to + "'", con);
                int CcCount3 = (int)cmd3.ExecuteScalar();
                int allcat1 = CcCount + CcCount1 + CcCount2 + CcCount3;

                SqlCommand cmd4 = new SqlCommand("select Count(CityName) as CountCityName from  Master_Product where CityName='" + cityname + "' and ProductCategory='category_5' AND Visiting_Date between '" + from + "' AND '" + to + "'", con);
                int CcCount4 = (int)cmd4.ExecuteScalar();
                SqlCommand cmd5 = new SqlCommand("select Count(CityName) as CountCityName from  Master_Product where CityName='" + cityname + "' and ProductCategory='category_6' AND Visiting_Date between '" + from + "' AND '" + to + "' ", con);
                int CcCount5 = (int)cmd5.ExecuteScalar();
                SqlCommand cmd6 = new SqlCommand("select Count(CityName) as CountCityName from  Master_Product where CityName='" + cityname + "' and ProductCategory='category_7' AND Visiting_Date between '" + from + "' AND '" + to + "' ", con);
                int CcCount6 = (int)cmd6.ExecuteScalar();
                SqlCommand cmd7 = new SqlCommand("select Count(CityName) as CountCityName from  Master_Product where CityName='" + cityname + "' and ProductCategory='category_8' AND Visiting_Date between '" + from + "' AND '" + to + "'", con);
                int CcCount7 = (int)cmd7.ExecuteScalar();
                int allcat2 = CcCount4 + CcCount5 + CcCount6 + CcCount7;

                SqlCommand cmd8 = new SqlCommand("select Count(CityName) as CountCityName from  Master_Product where CityName='" + cityname + "' and ProductCategory='category_9' AND Visiting_Date between '" + from + "' AND '" + to + "'", con);
                int CcCount8 = (int)cmd8.ExecuteScalar();
                SqlCommand cmd9 = new SqlCommand("select Count(CityName) as CountCityName from  Master_Product where CityName='" + cityname + "' and ProductCategory='category_10' AND Visiting_Date between '" + from + "' AND '" + to + "'", con);
                int CcCount9 = (int)cmd9.ExecuteScalar();
                SqlCommand cmd10 = new SqlCommand("select Count(CityName) as CountCityName from  Master_Product where CityName='" + cityname + "' and ProductCategory='category_11' AND Visiting_Date between '" + from + "' AND '" + to + "'", con);
                int CcCount10 = (int)cmd10.ExecuteScalar();
                SqlCommand cmd11 = new SqlCommand("select Count(CityName) as CountCityName from  Master_Product where CityName='" + cityname + "' and ProductCategory='category_12' AND Visiting_Date between '" + from + "' AND '" + to + "' ", con);
                int CcCount11 = (int)cmd11.ExecuteScalar();
                int allcat3 = CcCount8 + CcCount9 + CcCount10 + CcCount11;

                SqlCommand cmd14 = new SqlCommand("insert into tbl_city_wise_graph values('Sony','" + CcCount + "','" + CcCount1 + "','" + CcCount2 + "','" + CcCount3 + "','" + allcat1 + "')", con);
                cmd14.ExecuteNonQuery();
                SqlCommand cmd15 = new SqlCommand("insert into tbl_city_wise_graph values('Canon','" + CcCount4 + "','" + CcCount5 + "','" + CcCount6 + "','" + CcCount7 + "','" + allcat2 + "')", con);
                cmd15.ExecuteNonQuery();
                SqlCommand cmd16 = new SqlCommand("insert into tbl_city_wise_graph values('Nikon','" + CcCount8 + "','" + CcCount9 + "','" + CcCount10 + "','" + CcCount11 + "','" + allcat3 + "')", con);
                cmd16.ExecuteNonQuery();
                con.Close();

        
            if (ddl_chart.SelectedItem.Text.Equals("Bar Chart"))
            {
                MultiView2.ActiveViewIndex = 0;
                LoadChartData();
            }
            if (ddl_chart.SelectedItem.Text.Equals("Doughnut Chart"))
            {
                MultiView2.ActiveViewIndex = 1;
                LoadChartData2();
            }
            if (ddl_chart.SelectedItem.Text.Equals("Line Chart"))
            {
                MultiView2.ActiveViewIndex = 2;
                LoadChartData1();
            }
            if (ddl_chart.SelectedItem.Text.Equals("Pyramid Chart"))
            {
                MultiView2.ActiveViewIndex = 3;
                LoadChartData3();
            }

            if (ddl_chart.SelectedItem.Text.Equals("Stacked Chart"))
            {
                MultiView2.ActiveViewIndex = 4;
                LoadChartData4();
            }
        }
        catch (Exception)
        {

        }

    }
    StringBuilder str = new StringBuilder();
    private void LoadChartData4()
    {
        BindChart();
        getdata();
    }
    private DataTable GetData()
    {
        DataTable dt = new DataTable();
        string cmd = "select * from tbl_city_wise_graph";
        SqlDataAdapter adp = new SqlDataAdapter(cmd, con);
        adp.Fill(dt);
        return dt;
    }

    private void BindChart()
    {
        DataTable dt = new DataTable();
        try
        {
            dt = GetData();

            str.Append(@"<script type=text/javascript> google.load( *visualization*, *1*, {packages:[*corechart*]});
            google.setOnLoadCallback(drawChart);
            function drawChart() {
            var data = new google.visualization.DataTable();
            data.addColumn('string', 'Category');
            data.addColumn('number', 'Product 1');
             data.addColumn('number', 'Product 2');
             data.addColumn('number', 'Product 3');
             data.addColumn('number', 'Product 4');    

            data.addRows(" + dt.Rows.Count + ");");

            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                str.Append("data.setValue( " + i + "," + 0 + "," + "'" + dt.Rows[i]["Category"].ToString() + "');");
                str.Append("data.setValue(" + i + "," + 1 + "," + dt.Rows[i]["p1"].ToString() + ") ;");
                str.Append("data.setValue(" + i + "," + 2 + "," + dt.Rows[i]["p2"].ToString() + ") ;");
                str.Append("data.setValue(" + i + "," + 3 + "," + dt.Rows[i]["p3"].ToString() + ") ;");
                str.Append("data.setValue(" + i + "," + 4 + "," + dt.Rows[i]["p4"].ToString() + ") ;");
            }

            str.Append(" var chart = new google.visualization.ColumnChart(document.getElementById('chart_div'));");
            str.Append(" chart.draw(data,{isStacked:true, width:600, height:350, hAxis: {showTextEvery:1, slantedText:true}});}");

            str.Append("</script>");
            lt.Text = str.ToString().TrimEnd(',').Replace('*', '"');
        }
        catch
        {
        }
    }
    private void getdata()
    {
        try
        {
            string from = ddl_frommonth.Text + "/" + ddl_fromdate.Text + "/" + ddl_fromyear.Text;
            string to = ddl_tomonth.Text + "/" + ddl_todate.Text + "/" + ddl_toyear.Text;

            SqlDataAdapter da = new SqlDataAdapter("select Category ,catcount AS [NO of Visitors] from tbl_city_wise_graph ", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_city_wise_graph");
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
        string query = "SELECT  Category,catcount from tbl_city_wise_graph ";

        SqlDataAdapter da = new SqlDataAdapter(query, con);
        DataTable table = new DataTable();
        da.Fill(table);

        DataView dv = table.DefaultView;
        Chart2.DataBind();
        Chart2.Series["Series1"].Points.DataBindXY(dv, "Category", dv, "catcount");
        getdata();
    }

    private void LoadChartData1()
    {
      
        Chart3.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        Chart3.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        string query = "SELECT  Category,catcount from tbl_city_wise_graph ";

        SqlDataAdapter da = new SqlDataAdapter(query, con);
        DataTable table = new DataTable();
        da.Fill(table);

        DataView dv = table.DefaultView;
        Chart3.DataBind();
        Chart3.Series["Series1"].Points.DataBindXY(dv, "Category", dv, "catcount");
        getdata();
    }

    private void LoadChartData3()
    {
    

        Chart4.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        Chart4.ChartAreas[0].AxisY.MajorGrid.Enabled = false;      
        string query = "SELECT  Category,catcount from tbl_city_wise_graph order by catcount DESC";

        SqlDataAdapter da = new SqlDataAdapter(query, con);
        DataTable table = new DataTable();
        da.Fill(table);

        DataView dv = table.DefaultView;
        Chart4.DataBind();
        Chart4.Series["Series1"].Points.DataBindXY(dv, "Category", dv, "catcount");
        getdata();
    }


    private void LoadChartData()
    {
     

        Chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        Chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        string query = "SELECT  Category,catcount from tbl_city_wise_graph ";

        SqlDataAdapter da = new SqlDataAdapter(query, con);
        DataTable table = new DataTable();
        da.Fill(table);

        DataView dv = table.DefaultView;
        Chart1.DataBind();
        Chart1.Series["Series1"].Points.DataBindXY(dv, "Category", dv, "catcount");
        getdata();
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
