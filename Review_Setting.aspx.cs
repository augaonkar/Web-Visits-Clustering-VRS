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

public partial class Review_Setting : System.Web.UI.Page
{
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
                Bind1();
                Bind();
            }
        }
        catch (Exception)
        {
          
        }
       
    }

    private void Bind1()
    {
        try
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_bad", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_bad");
            GridView2.DataSource = ds;
            GridView2.DataBind();
        }
        catch (Exception)
        {
         
        }
        
    }

    private void Bind()
    {
        try
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_good", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_good");
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        catch (Exception)
        {
        }
      
    }

    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cntr"].ToString());

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            string keyword = txt_keyword.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_good values('" + keyword + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            txt_keyword.Text = "";
            Bind();
        }
        catch (Exception)
        {
          
        }
      
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            Label goodword = (Label)row.FindControl("lbl_good");
            string a = goodword.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from tbl_good where good_words='" + a + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Bind();
        }
        catch (Exception)
        {
        }
       
        //string keyword = (string)GridView1.DataKeys[e.RowIndex].Value;
    }

    protected void btn_addbad_Click(object sender, EventArgs e)
    {
        try
        {
            string keyword = txt_bad.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_bad values('" + keyword + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            txt_bad.Text = "";
            Bind1();
        }
        catch (Exception)
        {
          
        }
     
    }

    protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            GridViewRow row = GridView2.Rows[e.RowIndex];
            Label goodword = (Label)row.FindControl("lbl_bad");
            string a = goodword.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from tbl_bad where bad_words='" + a + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Bind1();
        }
        catch (Exception)
        {
          
        }
   
    }

    protected void btn_goodword_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
    }

    protected void btn_badword_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
    }
}
