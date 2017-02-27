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

public partial class Total_Review_Details : System.Web.UI.Page
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

                GetcountofComments();
                SqlDataAdapter da1 = new SqlDataAdapter("select CityName as[City],GoodCnt as [Good Cmnt],BadCnt as [Bad Cmnt],CantSayCnt as [Cant Say Cmnt],TotalCnt as [Total],TotalNoTcmnt as [Not Cmnt],TotalVisitors as [Total Visitors] from tbl_CompltChangeCommentCount where Pro_id='1'", con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "tbl_CompltChangeCommentCount");
                GridView2.DataSource = ds1;
                GridView2.DataBind();

                SqlDataAdapter da2 = new SqlDataAdapter("select CityName as[City],GoodCnt as [Good Cmnt],BadCnt as [Bad Cmnt],CantSayCnt as [Cant Say Cmnt],TotalCnt as [Total],TotalNoTcmnt as [Not Cmnt],TotalVisitors as [Total Visitors] from tbl_CompltChangeCommentCount where Pro_id='2'", con);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2, "tbl_CompltChangeCommentCount");
                GridView3.DataSource = ds2;
                GridView3.DataBind();

                SqlDataAdapter da3 = new SqlDataAdapter("select CityName as[City],GoodCnt as [Good Cmnt],BadCnt as [Bad Cmnt],CantSayCnt as [Cant Say Cmnt],TotalCnt as [Total],TotalNoTcmnt as [Not Cmnt],TotalVisitors as [Total Visitors] from tbl_CompltChangeCommentCount where Pro_id='3'", con);
                DataSet ds3 = new DataSet();
                da3.Fill(ds3, "tbl_CompltChangeCommentCount");
                GridView4.DataSource = ds3;
                GridView4.DataBind();

                SqlDataAdapter da4 = new SqlDataAdapter("select CityName as[City],GoodCnt as [Good Cmnt],BadCnt as [Bad Cmnt],CantSayCnt as [Cant Say Cmnt],TotalCnt as [Total],TotalNoTcmnt as [Not Cmnt],TotalVisitors as [Total Visitors] from tbl_CompltChangeCommentCount where Pro_id='4'", con);
                DataSet ds4 = new DataSet();
                da4.Fill(ds4, "tbl_CompltChangeCommentCount");
                GridView5.DataSource = ds4;
                GridView5.DataBind();

                SqlDataAdapter da5 = new SqlDataAdapter("select CityName as[City],GoodCnt as [Good Cmnt],BadCnt as [Bad Cmnt],CantSayCnt as [Cant Say Cmnt],TotalCnt as [Total],TotalNoTcmnt as [Not Cmnt],TotalVisitors as [Total Visitors] from tbl_CompltChangeCommentCount where Pro_id='5'", con);
                DataSet ds5 = new DataSet();
                da5.Fill(ds5, "tbl_CompltChangeCommentCount");
                GridView6.DataSource = ds5;
                GridView6.DataBind();

                SqlDataAdapter da6 = new SqlDataAdapter("select CityName as[City],GoodCnt as [Good Cmnt],BadCnt as [Bad Cmnt],CantSayCnt as [Cant Say Cmnt],TotalCnt as [Total],TotalNoTcmnt as [Not Cmnt],TotalVisitors as [Total Visitors] from tbl_CompltChangeCommentCount where Pro_id='6'", con);
                DataSet ds6 = new DataSet();
                da6.Fill(ds6, "tbl_CompltChangeCommentCount");
                GridView7.DataSource = ds6;
                GridView7.DataBind();

                SqlDataAdapter da7 = new SqlDataAdapter("select CityName as[City],GoodCnt as [Good Cmnt],BadCnt as [Bad Cmnt],CantSayCnt as [Cant Say Cmnt],TotalCnt as [Total],TotalNoTcmnt as [Not Cmnt],TotalVisitors as [Total Visitors] from tbl_CompltChangeCommentCount where Pro_id='7'", con);
                DataSet ds7 = new DataSet();
                da7.Fill(ds7, "tbl_CompltChangeCommentCount");
                GridView8.DataSource = ds7;
                GridView8.DataBind();

                SqlDataAdapter da8 = new SqlDataAdapter("select CityName as[City],GoodCnt as [Good Cmnt],BadCnt as [Bad Cmnt],CantSayCnt as [Cant Say Cmnt],TotalCnt as [Total],TotalNoTcmnt as [Not Cmnt],TotalVisitors as [Total Visitors] from tbl_CompltChangeCommentCount where Pro_id='8'", con);
                DataSet ds8 = new DataSet();
                da8.Fill(ds8, "tbl_CompltChangeCommentCount");
                GridView9.DataSource = ds8;
                GridView9.DataBind();

                SqlDataAdapter da9 = new SqlDataAdapter("select CityName as[City],GoodCnt as [Good Cmnt],BadCnt as [Bad Cmnt],CantSayCnt as [Cant Say Cmnt],TotalCnt as [Total],TotalNoTcmnt as [Not Cmnt],TotalVisitors as [Total Visitors] from tbl_CompltChangeCommentCount where Pro_id='9'", con);
                DataSet ds9 = new DataSet();
                da9.Fill(ds9, "tbl_CompltChangeCommentCount");
                GridView10.DataSource = ds9;
                GridView10.DataBind();

                SqlDataAdapter da10 = new SqlDataAdapter("select CityName as[City],GoodCnt as [Good Cmnt],BadCnt as [Bad Cmnt],CantSayCnt as [Cant Say Cmnt],TotalCnt as [Total],TotalNoTcmnt as [Not Cmnt],TotalVisitors as [Total Visitors] from tbl_CompltChangeCommentCount where Pro_id='10'", con);
                DataSet ds10 = new DataSet();
                da10.Fill(ds10, "tbl_CompltChangeCommentCount");
                GridView11.DataSource = ds10;
                GridView11.DataBind();

                SqlDataAdapter da11 = new SqlDataAdapter("select CityName as[City],GoodCnt as [Good Cmnt],BadCnt as [Bad Cmnt],CantSayCnt as [Cant Say Cmnt],TotalCnt as [Total],TotalNoTcmnt as [Not Cmnt],TotalVisitors as [Total Visitors] from tbl_CompltChangeCommentCount where Pro_id='11'", con);
                DataSet ds11 = new DataSet();
                da11.Fill(ds11, "tbl_CompltChangeCommentCount");
                GridView12.DataSource = ds11;
                GridView12.DataBind();

                SqlDataAdapter da12 = new SqlDataAdapter("select CityName as[City],GoodCnt as [Good Cmnt],BadCnt as [Bad Cmnt],CantSayCnt as [Cant Say Cmnt],TotalCnt as [Total],TotalNoTcmnt as [Not Cmnt],TotalVisitors as [Total Visitors] from tbl_CompltChangeCommentCount where Pro_id='12'", con);
                DataSet ds12 = new DataSet();
                da12.Fill(ds12, "tbl_CompltChangeCommentCount");
                GridView13.DataSource = ds12;
                GridView13.DataBind();
            }
        }
        catch (Exception)
        {

        }
    }

    private void GetcountofComments()
    {
        try
        {
            string cityname = "";
            con.Open();
            SqlCommand cmd1 = new SqlCommand("truncate table tbl_CompltChangeCommentCount", con);
            cmd1.ExecuteNonQuery();
            con.Close();
            SqlDataAdapter da = new SqlDataAdapter("select distinct C_City_nm from tbl_comments", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_comments");
            int discitycount = ds.Tables[0].Rows.Count;
            for (int i = 0; i < discitycount; i++)
            {
                cityname = ds.Tables[0].Rows[i]["C_City_nm"].ToString();
                for (int j = 1; j < 13; j++)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select Count(C_City_nm) as CountCity from  tbl_comments where C_City_nm='" + cityname + "' and C_Pid ='" + j + "' and C_Comment_type='good'", con);
                    int CcCount = (int)cmd.ExecuteScalar();

                    SqlCommand cmd2 = new SqlCommand("select Count(C_City_nm) as CountCity from  tbl_comments where C_City_nm='" + cityname + "' and C_Pid ='" + j + "' and C_Comment_type='bad'", con);
                    int CcCount1 = (int)cmd2.ExecuteScalar();

                    SqlCommand cmd3 = new SqlCommand("select Count(C_City_nm) as CountCity from  tbl_comments where C_City_nm='" + cityname + "' and C_Pid ='" + j + "' and C_Comment_type='cant say'", con);
                    int CcCount2 = (int)cmd3.ExecuteScalar();

                    SqlCommand cmd4 = new SqlCommand("select Count(CityName) as CountCity from  Master_Product where CityName='" + cityname + "' and ProductId ='" + j + "'", con);
                    int TotalVisitors = (int)cmd4.ExecuteScalar();

                    con.Close();
                    int total = CcCount + CcCount1 + CcCount2;
                    int notcommented = TotalVisitors - total;


                    SqlDataAdapter da1 = new SqlDataAdapter("insert into tbl_CompltChangeCommentCount values('" + j + "','" + cityname + "','" + CcCount + "','" + CcCount1 + "','" + CcCount2 + "','" + total + "','" + notcommented + "','" + TotalVisitors + "')", con);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1, "tbl_CompltChangeCommentCount");
                }
            }
        }
        catch (Exception)
        {
          
        }
       
    }
}
