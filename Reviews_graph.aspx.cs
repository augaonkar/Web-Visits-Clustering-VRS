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

public partial class Reviews_graph : System.Web.UI.Page
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
        string from = ddl_frommonth.Text + "/" + ddl_fromdate.Text + "/" + ddl_fromyear.Text;
        string to = ddl_tomonth.Text + "/" + ddl_todate.Text + "/" + ddl_toyear.Text;

        string cityname = "";
        con.Open();
       
        SqlCommand cmd18 = new SqlCommand("truncate table tbl_cat_wise_comment", con);
        cmd18.ExecuteNonQuery();
        con.Close();

        con.Open();
        SqlCommand cmd = new SqlCommand("select Count(C_City_nm) as CountCityName from  tbl_comments where C_Pid='"+ddl_product.SelectedItem.Value+"' and C_Comment_type='good' AND C_Currentdate between '" + from + "' AND '" + to + "' ", con);
        int CcCount = (int)cmd.ExecuteScalar();
        SqlCommand cmd1 = new SqlCommand("select Count(C_City_nm) as CountCityName from  tbl_comments where  C_Pid='" + ddl_product.SelectedItem.Value + "' and C_Comment_type='bad' AND C_Currentdate between '" + from + "' AND '" + to + "' ", con);
        int CcCount1 = (int)cmd1.ExecuteScalar();
        SqlCommand cmd2 = new SqlCommand("select Count(C_City_nm) as CountCityName from  tbl_comments where C_Pid='" + ddl_product.SelectedItem.Value + "' and C_Comment_type='cant say' AND C_Currentdate between '" + from + "' AND '" + to + "' ", con);
        int CcCount2 = (int)cmd2.ExecuteScalar();

        SqlCommand cmd14 = new SqlCommand("insert into tbl_cat_wise_comment values('good','" + CcCount + "')", con);
        cmd14.ExecuteNonQuery();
        SqlCommand cmd15 = new SqlCommand("insert into tbl_cat_wise_comment values('bad','" + CcCount1 + "')", con);
        cmd15.ExecuteNonQuery();
        SqlCommand cmd16 = new SqlCommand("insert into tbl_cat_wise_comment values('can say','" + CcCount2 + "')", con);
        cmd16.ExecuteNonQuery();
        con.Close();
        getdata1();
        LoadChartData4();

         MultiView1.ActiveViewIndex = 0;
      
       
    }

    private void getdata1()
    {
        try
        {
            string from = ddl_frommonth.Text + "/" + ddl_fromdate.Text + "/" + ddl_fromyear.Text;
            string to = ddl_tomonth.Text + "/" + ddl_todate.Text + "/" + ddl_toyear.Text;

            SqlDataAdapter da = new SqlDataAdapter("select comment_type as [Type] ,Ccount AS [NO of Comments] from tbl_cat_wise_comment ", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_cat_wise_comment");
            gv_data.DataSource = ds;
            gv_data.DataBind();
        }
        catch (Exception)
        {

        }
    }

    private void LoadChartData4()
    {
        Chart2.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        Chart2.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        string query = "SELECT  comment_type,Ccount from tbl_cat_wise_comment ";

        SqlDataAdapter da = new SqlDataAdapter(query, con);
        DataTable table = new DataTable();
        da.Fill(table);

        DataView dv = table.DefaultView;
        Chart2.DataBind();
        Chart2.Series["Series1"].Points.DataBindXY(dv, "comment_type", dv, "Ccount");
        getdata1();
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
    protected void btn_print_Click1(object sender, EventArgs e)
    {

    }
}
