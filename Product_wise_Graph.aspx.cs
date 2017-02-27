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

public partial class Product_wise_Graph : System.Web.UI.Page
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

        if (ddl_chart.SelectedItem.Text.Equals("Doughnut Chart"))
        {
            commentcount();           
        }

        if (ddl_chart.SelectedItem.Text.Equals("Line Chart"))
        {
            lineproduct();
        }

        if (ddl_chart.SelectedItem.Text.Equals("Pie Chart"))
        {
            citywisecoumt();

        }
       
       

      

    }

    private void lineproduct()
    {
        Coppytable(); 
       // getdata();
        MultiView1.ActiveViewIndex = 1;
        LoadChartData1();
 
    }
    private void LoadChartData1()
    {
        string from = ddl_frommonth.Text + "/" + ddl_fromdate.Text + "/" + ddl_fromyear.Text;
        string to = ddl_tomonth.Text + "/" + ddl_todate.Text + "/" + ddl_toyear.Text;

        Chart3.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        Chart3.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        string query = "SELECT  Ddate,Vcount from tbl_show_all_graph where Ddate between '" + from + "' AND '" + to + "' order by Ddate ASC";

        SqlDataAdapter da = new SqlDataAdapter(query, con);
        DataTable table = new DataTable();
        da.Fill(table);

        DataView dv = table.DefaultView;
        Chart3.DataBind();
        Chart3.Series["Series1"].Points.DataBindXY(dv, "Ddate", dv, "VCount");
        getdata2();
    }
    private void getdata2()
    {
        try
        {
            string from = ddl_frommonth.Text + "/" + ddl_fromdate.Text + "/" + ddl_fromyear.Text;
            string to = ddl_tomonth.Text + "/" + ddl_todate.Text + "/" + ddl_toyear.Text;

            SqlDataAdapter da = new SqlDataAdapter("select Ddate as [Date],Vcount AS [No of Visitors] from tbl_show_all_graph where Ddate between '" + from + "' AND '" + to + "' order by Ddate ASC", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_show_all_graph");
            gv_data.DataSource = ds;
            gv_data.DataBind();
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

        if (ddl_product.SelectedItem.Value.Equals("1"))
        {
            SqlCommand cmd = new SqlCommand("insert into tbl_show_all_graph select Ddate,P1 from tbl_Viscount", con);
            cmd.ExecuteNonQuery();
        }
        if (ddl_product.SelectedItem.Value.Equals("2"))
        {
            SqlCommand cmd = new SqlCommand("insert into tbl_show_all_graph select Ddate,P2 from tbl_Viscount", con);
            cmd.ExecuteNonQuery();
        }
        if (ddl_product.SelectedItem.Value.Equals("3"))
        {
            SqlCommand cmd = new SqlCommand("insert into tbl_show_all_graph select Ddate,P3 from tbl_Viscount", con);
            cmd.ExecuteNonQuery();
        }
        if (ddl_product.SelectedItem.Value.Equals("4"))
        {
            SqlCommand cmd = new SqlCommand("insert into tbl_show_all_graph select Ddate,P4 from tbl_Viscount", con);
            cmd.ExecuteNonQuery();
        }
        if (ddl_product.SelectedItem.Value.Equals("5"))
        {
            SqlCommand cmd = new SqlCommand("insert into tbl_show_all_graph select Ddate,P5 from tbl_Viscount", con);
            cmd.ExecuteNonQuery();
        }
        if (ddl_product.SelectedItem.Value.Equals("6"))
        {
            SqlCommand cmd = new SqlCommand("insert into tbl_show_all_graph select Ddate,P6 from tbl_Viscount", con);
            cmd.ExecuteNonQuery();
        }
        if (ddl_product.SelectedItem.Value.Equals("7"))
        {
            SqlCommand cmd = new SqlCommand("insert into tbl_show_all_graph select Ddate,P7 from tbl_Viscount", con);
            cmd.ExecuteNonQuery();
        }
        if (ddl_product.SelectedItem.Value.Equals("8"))
        {
            SqlCommand cmd = new SqlCommand("insert into tbl_show_all_graph select Ddate,P8 from tbl_Viscount", con);
            cmd.ExecuteNonQuery();
        }
        if (ddl_product.SelectedItem.Value.Equals("9"))
        {
            SqlCommand cmd = new SqlCommand("insert into tbl_show_all_graph select Ddate,P9 from tbl_Viscount", con);
            cmd.ExecuteNonQuery();
        }
        if (ddl_product.SelectedItem.Value.Equals("10"))
        {
            SqlCommand cmd = new SqlCommand("insert into tbl_show_all_graph select Ddate,P10 from tbl_Viscount", con);
            cmd.ExecuteNonQuery();
        }
        if (ddl_product.SelectedItem.Value.Equals("11"))
        {
            SqlCommand cmd = new SqlCommand("insert into tbl_show_all_graph select Ddate,P11 from tbl_Viscount", con);
            cmd.ExecuteNonQuery();
        }
        if (ddl_product.SelectedItem.Value.Equals("12"))
        {
            SqlCommand cmd = new SqlCommand("insert into tbl_show_all_graph select Ddate,P12 from tbl_Viscount", con);
            cmd.ExecuteNonQuery();
        }


      
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
    private void commentcount()
    {
        string from = ddl_frommonth.Text + "/" + ddl_fromdate.Text + "/" + ddl_fromyear.Text;
        string to = ddl_tomonth.Text + "/" + ddl_todate.Text + "/" + ddl_toyear.Text;
        con.Open();
        SqlCommand cmd18 = new SqlCommand("truncate table tbl_cat_wise_comment", con);
        cmd18.ExecuteNonQuery();
        con.Close();

        con.Open();
        SqlCommand cmd = new SqlCommand("select Count(C_City_nm) as CountCityName from  tbl_comments where C_Pid='" + ddl_product.SelectedItem.Value + "' and C_Comment_type='good' AND C_Currentdate between '" + from + "' AND '" + to + "' ", con);
        int CcCount = (int)cmd.ExecuteScalar();
        SqlCommand cmd1 = new SqlCommand("select Count(C_City_nm) as CountCityName from  tbl_comments where  C_Pid='" + ddl_product.SelectedItem.Value + "' and C_Comment_type='bad' AND C_Currentdate between '" + from + "' AND '" + to + "' ", con);
        int CcCount1 = (int)cmd1.ExecuteScalar();
        SqlCommand cmd2 = new SqlCommand("select Count(C_City_nm) as CountCityName from  tbl_comments where C_Pid='" + ddl_product.SelectedItem.Value + "' and C_Comment_type='cant say' AND C_Currentdate between '" + from + "' AND '" + to + "' ", con);
        int CcCount2 = (int)cmd2.ExecuteScalar();

        SqlCommand cmd14 = new SqlCommand("insert into tbl_cat_wise_comment values('Good','" + CcCount + "')", con);
        cmd14.ExecuteNonQuery();
        SqlCommand cmd15 = new SqlCommand("insert into tbl_cat_wise_comment values('Bad','" + CcCount1 + "')", con);
        cmd15.ExecuteNonQuery();
        SqlCommand cmd16 = new SqlCommand("insert into tbl_cat_wise_comment values('Cant say','" + CcCount2 + "')", con);
        cmd16.ExecuteNonQuery();
        con.Close();
        getdata1();
        LoadChartData4();
        MultiView1.ActiveViewIndex = 2;
    }

    private void citywisecoumt()
    {
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
            SqlCommand cmd = new SqlCommand("select Count(CityName) as CountCity from  Master_Product where CityName='" + cityname + "' AND Visiting_Date between '" + from + "' AND '" + to + "' and ProductId='" + ddl_product.SelectedItem.Value.ToString() + "'", con);
            int CcCount = (int)cmd.ExecuteScalar();
            SqlCommand cmd2 = new SqlCommand("insert into tbl_stat_datewise_cnt values('" + cityname + "','" + CcCount + "')", con);
            cmd2.ExecuteNonQuery();
            con.Close();
            MultiView1.ActiveViewIndex = 0;
            LoadChartData2();
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
       //s Chart2.Series["Series1"]["PieLabelStyle"] = "Outside";
     
        Chart2.Series["Series1"].Points.DataBindXY(dv, "City_nm", dv, "Count");
        getdata3();
    }
    private void getdata1()
    {
        try
        {         

            SqlDataAdapter da = new SqlDataAdapter("select comment_type as [Type] ,Ccount AS [No of Comments] from tbl_cat_wise_comment ", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_cat_wise_comment");
            gv_data.DataSource = ds.Tables["tbl_cat_wise_comment"];
            gv_data.DataBind();
        }
        catch (Exception)
        {

        }
    }

    private void LoadChartData4()
    {
        Chart5.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        Chart5.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        string query = "SELECT  comment_type,Ccount from tbl_cat_wise_comment ";

        SqlDataAdapter da = new SqlDataAdapter(query, con);
        DataTable table = new DataTable();
        da.Fill(table);

        DataView dv = table.DefaultView;
        Chart5.DataBind();
        Chart5.Series["Series1"].Points.DataBindXY(dv, "comment_type", dv, "Ccount");
        getdata1();
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
        if (ddl_chart.SelectedItem.Text.Equals("Pie Chart"))
        {
            gv_data.PageIndex = e.NewPageIndex;
            getdata1();
        }

        if (ddl_chart.SelectedItem.Text.Equals("Line Chart"))
        {
            gv_data.PageIndex = e.NewPageIndex;
            getdata2();
        }

        if (ddl_chart.SelectedItem.Text.Equals("Doughnut Chart"))
        {
            gv_data.PageIndex = e.NewPageIndex;
            getdata3();

        }
    }

    private void getdata3()
    {
        string query = "SELECT City_nm,Count from tbl_stat_datewise_cnt";

        SqlDataAdapter da = new SqlDataAdapter(query, con);
        DataTable table = new DataTable();
        da.Fill(table);    
        gv_data.DataMember = "tbl_stat_datewise_cnt";
        gv_data.DataSource = table;
        gv_data.DataBind();
    }
    protected void btn_print_Click1(object sender, EventArgs e)
    {

    }
}
