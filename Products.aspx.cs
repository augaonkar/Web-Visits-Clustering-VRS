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
using System.Data;
using System.Drawing;
using System.Globalization;

public partial class Products : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                if (Session["index1"] == null)
                {
                    Response.Redirect("Index.aspx");
                }
                else
                {
                   
                   LinkButton1.Text = Session["Catname"].ToString()+ " > ";
                   

                    string pro_id = Session["C_Pid"].ToString();
                    Label4.Text = Session["proname"].ToString();
                    checkproduct(pro_id);
                    GetPostData();
                    Getcommentdata();

                 
                   // string pro_id = "1";
                    Image1.ImageUrl = "~/css/Fullsize/" + pro_id + ".jpg";
                   
                    SqlCommand cmd = new SqlCommand("select C_Cid,C_Pid,C_Comment_cnt,C_Commenttext,C_Currentdate from tbl_comments where C_Pid='" + pro_id + "' order by C_Cid DESC", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    int cnt = ds.Tables[0].Rows.Count;
                    if (cnt > 0)
                    {
                        lblcomment_cnt.Text = (ds.Tables[0].Rows.Count).ToString();
                    }
                    else
                    {
                        lblcomment_cnt.Text = "0";
                    }
                    SqlCommand cmd1 = new SqlCommand("select MAX(C_Cid) as C_Cid from tbl_comments", con);
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    int cnt1 = ds1.Tables[0].Rows.Count;
                    if (ds1.Tables[0].Rows[0]["C_Cid"].ToString().Equals(""))
                    {
                        cnt1 = 0;
                    }


                    if (cnt1 > 0)
                    {
                        maxid = Convert.ToInt32(ds1.Tables[0].Rows[0]["C_Cid"].ToString()) + 1;
                        lblTop.Text = maxid.ToString();
                    }
                    else
                    {
                        maxid = 1;
                        lblTop.Text = maxid.ToString();
                    }

                }
        }
        }
        catch (Exception ex)
        {
         
        }
      
        

    }

    private void checkproduct(string pro_id)
    {
        if (pro_id.Equals("1"))
        {
            l1.Text = "• 16.1 megapixel Camera";
            l2.Text = "• Exmor APS HD CMOS Image Sensor";
            l3.Text = "• Full HD Recording";
            l4.Text = "• 2.7 inch TFT LCD";
            l5.Text = "• ISO 100 - ISO 16000 Sensitivity"; 
        }
        if (pro_id.Equals("2"))
        {
            l1.Text = "• 24.3 megapixel Camera";
            l2.Text = "• Exmor APS HD CMOS Image Sensor";
            l3.Text = "• Full HD Recording";
            l4.Text = "• 3 inch TFT, Xtra Fine LCD with TruBlack Technology";
            l5.Text = "• ISO 100 - ISO 16000 Sensitivity";
        }
        if (pro_id.Equals("3"))
        {
            l1.Text = "• Super HAD CCD Image Sensor";
            l2.Text = "• 35 mm Equivalent Focal Length: 28 - 140 mm";
            l3.Text = "• 20.1 Megapixel Camera";
            l4.Text = "• HD Recording (720p)";
            l5.Text = "• 6x Optical Zoom";
            l6.Text = "• 2.7 inch TFT LCD Screen";
        }
        if (pro_id.Equals("4"))
        {
            l1.Text = "• Exmor R CMOS Image Sensor";
            l2.Text = "• 10x Optical Zoom and 40x Digital Zoom";
            l3.Text = "• 2.7 inch Clear Photo TFT LCD";
            l4.Text = "• 18.2 Megapixel Camera";
            l5.Text = "• 35 mm Equivalent Focal Length: 25 - 250 mm";
            l6.Text="• Full HD Recording";
            l7.Text="• f/3.3 - f/8.0 Aperture";
        }
        if (pro_id.Equals("5"))
        {
            l1.Text = "• Full HD Recording";
            l2.Text = "• 18 Megapixel Camera";
            l3.Text = "• CMOS Image Sensor";
            l4.Text = "• 3 inch Wide Vari-angle LCD Screen";
          
        }
        if (pro_id.Equals("6"))
        {
            l1.Text = "• 3 inch TFT Color LCD Screen";
            l2.Text = "• 18 Megapixel Camera";
            l3.Text = "• Full HD Recording";
            l4.Text = "• CMOS Image Sensor";
            l5.Text = "• Focal Length: 18 - 55 mm";
        }
        if (pro_id.Equals("7"))
        {
            l1.Text = "• 35 mm Equivalent Focal Length: 28 - 140 mm";
            l2.Text = "• 16.0 Megapixel Camera";
            l3.Text = "• CCD Image Sensor";
            l4.Text = "• 5x Optical Zoom and 4x Digital Zoom";
            l5.Text = "• f/2.8 - f/6.9 Aperture";
            l6.Text = "• 3 inch TFT Color LCD Touch Screen (Wide Viewing Angle)";

        }
        if (pro_id.Equals("8"))
        {
            l1.Text = "• f/3.0 - f/6.9 Aperture";
            l2.Text = "• Full HD Recording";
            l3.Text = "• CMOS Image Sensor";
            l4.Text = "• 10x Optical Zoom and 4x Digital Zoom";
            l5.Text = "• 3 inch TFT PureColor II G LCD";
            l6.Text = "• 12.1 Megapixel Camera 35 mm Equivalent Focal Length: 24 - 240 mm";
        }
        if (pro_id.Equals("9"))
        {
            l1.Text = "• 3 inch TFT LCD";
            l2.Text = "• CMOS Image Sensor";
            l3.Text = "• 24.2 Megapixel Camera";
            l4.Text = "• Full HD Recording";
            l5.Text = "• ISO 100 - ISO 6400 Sensitivity";
        }
        if (pro_id.Equals("10"))
        {
            l1.Text = "• CMOS Image Sensor";
            l2.Text = "• 16.2 Megapixel Camera";
            l3.Text = "• Full HD Recording";
            l4.Text = "• 3 inch Low-temperature Polysilicon TFT LCD Screen";
            l5.Text = "• ISO 100 - ISO 6400 Sensitivity";
            l6.Text = "• Focal Length: 18 – 55";
        }
        if (pro_id.Equals("11"))
        {
    
            l1.Text = "• CMOS Image Sensor";
            l2.Text = "• 3 inch Wide Viewing Angle OLED Monitor with Anti-reflection Coating";
            l3.Text = "• 35 mm Equivalent Focal Length: 25 - 550 mm";
            l4.Text = "• f/3.4 - f/6.3 Aperture";
            l5.Text = "• 22x Optical Zoom and 4x Digital Zoom";
            l6.Text="• Full HD Recording";
            l7.Text="• 18 Megapixel Camera";
        }
        if (pro_id.Equals("12"))
        {
            l1.Text = "• 2.7 inch TFT LCD Monitor";
            l2.Text = "• HD Recording";
            l3.Text = "• 16.0 Megapixel Camera";
            l4.Text = "• 35 mm Equivalent Focal Length: 26 - 156 mm";
            l5.Text = "• 6x Optical Zoom and 4x Digital Zoom";
             l6.Text="• CCD Image Sensor";
            l7.Text="• f/3.5 - f/6.5 Apertur";
        }
    }

   

    double good_cnt = 0.0, bad_cnt = 0.0, cant_say_cnt = 0.0, good_cnt1 = 0.0, bad_cnt1 = 0.0, cant_say_cnt1 = 0.0;

    private void Getcommentdata()
    {
        try
        {
            string pro_id = Session["C_Pid"].ToString();
            SqlCommand cmd = new SqlCommand("select * from tbl_comments where C_Pid='" + pro_id + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            double cnt = ds.Tables[0].Rows.Count;
            if (cnt > 0)
            {
                SqlCommand cmd1 = new SqlCommand("select * from tbl_comments where C_Pid='" + pro_id + "' and C_Comment_type='good'", con);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                double cnt1 = ds1.Tables[0].Rows.Count;
                if (cnt1 > 0)
                {
                    good_cnt = Convert.ToDouble(((cnt1 / cnt) * 100));
                    lbl_good.Text = "Good Comments : " + good_cnt.ToString("00.00", CultureInfo.InvariantCulture) + "%";
                }
                else
                {
                    lbl_good.Text = "Good Comments : 0%";
                }

                SqlCommand cmd2 = new SqlCommand("select * from tbl_comments where C_Pid='" + pro_id + "' and C_Comment_type='bad'", con);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);
                double cnt2 = ds2.Tables[0].Rows.Count;
                if (cnt2 > 0)
                {
                    bad_cnt = Convert.ToDouble(((cnt2 / cnt) * 100));
                    lbl_bad.Text = "Bad Comments : " + bad_cnt.ToString("00.00", CultureInfo.InvariantCulture) + "%";
                }
                else
                {
                    lbl_bad.Text = "Bad Comments : 0%";
                }

                SqlCommand cmd3 = new SqlCommand("select * from tbl_comments where C_Pid='" + pro_id + "' and C_Comment_type='cant say'", con);
                SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                DataSet ds3 = new DataSet();
                da3.Fill(ds3);
                int cnt3 = ds3.Tables[0].Rows.Count;
                if (cnt3 > 0)
                {
                    cant_say_cnt = Convert.ToDouble(((cnt3 / cnt) * 100));
                    lbl_cnt_say.Text = "Cant Say Comments : " + cant_say_cnt.ToString("00.00", CultureInfo.InvariantCulture) + "%";
                }
                else
                {
                    lbl_cnt_say.Text = "Cant Say Comments : 0%";
                }
                string total = good_cnt + "," + bad_cnt + "," + cant_say_cnt;
            }

            good = 0;
            bad = 0;
            good_cnt = 0.0;
            bad_cnt = 0.0;
            cant_say_cnt = 0.0;
            good_cnt1 = 0.0;
            bad_cnt1 = 0.0;
            cant_say_cnt1 = 0.0;
        }
        catch (Exception)
        {
          
        }     
       
    }   
   
    string pro_id = "";
    static int good = 0,bad=0;
    int maxid = 0;
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cntr"].ToString());

    private void GetPostData()
    {
        try
        {
            string pro_id = Session["C_Pid"].ToString();
            SqlCommand cmd = new SqlCommand("select C_Cid,C_Pid,C_Comment_cnt,C_Commenttext,C_Currentdate from tbl_comments where C_Pid='" + pro_id + "' order by C_Cid DESC", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int cnt = ds.Tables[0].Rows.Count;
            if (cnt > 0)
            {
                lblcomment_cnt.Text = (ds.Tables[0].Rows.Count).ToString();
                lblcmt.Text = (ds.Tables[0].Rows.Count).ToString();
            }
            else
            {
                lblcmt.Text = "0";
            }
            GridViewComment.DataSource = ds.Tables[0].DefaultView;
            GridViewComment.DataBind();
        }
        catch (Exception)
        {
         
        }
     
    }
  
    protected void btnComment_click(object sender, EventArgs e)
    {
        try
        {
           // string isok = Session["Valid"].ToString();
            string isok = "Ok";


            if (isok.Equals("Ok"))
            {
                if (txtcomment.Text.Equals(""))
                { }
                else
                {
                    string Comment_type = "";
                    string city_nm = Session["city_nm"].ToString();
                    string PID = Session["C_Pid"].ToString();
                    string comment = txtcomment.Text;
                    string currentdate = DateTime.Now.ToString();
                    string str1 = "insert into tbl_comments(C_Pid,C_Commenttext,C_Currentdate,C_City_nm)values(@PID,@comment,@currentdate,@C_City_nm)";
                    SqlCommand cmd1 = new SqlCommand(str1, con);
                    cmd1.Parameters.AddWithValue("@PID", PID);
                    cmd1.Parameters.AddWithValue("@comment", comment);
                    cmd1.Parameters.AddWithValue("@currentdate", currentdate);
                    cmd1.Parameters.AddWithValue("@C_City_nm", city_nm);
                    con.Open();
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    GetPostData();

                    getdata();
                    if (bad > good)
                    {
                        Comment_type = "bad";
                    }                   
                        if (good > bad)
                        {
                            Comment_type = "good";
                        }
                        if (good == bad)
                        {
                            Comment_type = "cant say";
                        }

                        SqlCommand cmd9 = new SqlCommand("select MAX(C_Cid) as C_Cid from tbl_comments", con);
                        SqlDataAdapter da9 = new SqlDataAdapter(cmd9);
                        DataSet ds9 = new DataSet();
                        da9.Fill(ds9);
                        int cnt9 = ds9.Tables[0].Rows.Count;
                        if (ds9.Tables[0].Rows[0]["C_Cid"].ToString().Equals(""))
                        {
                            cnt9 = 0;
                        }


                        if (cnt9 > 0)
                        {
                            maxid = Convert.ToInt32(ds9.Tables[0].Rows[0]["C_Cid"].ToString());
                            lblTop.Text = maxid.ToString();
                        }
                        else
                        {
                            maxid = 1;
                            lblTop.Text = maxid.ToString();
                        }

                    int commentcnt = Convert.ToInt32(lblcmt.Text) + 1;
                    lblcomment_cnt.Text = commentcnt.ToString();
                    string str = "update tbl_comments set C_Comment_cnt=@commentcnt,C_Comment_type='" + Comment_type + "' where C_Pid=@PID and C_Cid='" + lblTop.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.Parameters.AddWithValue("@commentcnt", commentcnt - 1);
                    cmd.Parameters.AddWithValue("@PID", PID);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    txtcomment.Text = "";
                    GetPostData();
                    Getcommentdata();
                }
            }
            else
            {
                txtcomment.Text = "";
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
            string comment1 = txtcomment.Text.ToLower();
            string[] comment = comment1.Split(' ');
            var e = from s in comment
                    select s;

            int c = e.Count();
            for (int i = 0; i < c; i++)
            {
                if (i > 0)
                {
                    if (comment[i - 1].Equals("dont") || comment[i - 1].Equals("didnt") || comment[i - 1].Equals("doesnt") || comment[i - 1].Equals("not"))
                    {
                        SqlDataAdapter da5 = new SqlDataAdapter("select * from tbl_bad where bad_words='" + comment[i] + "'", con);
                        DataSet ds5 = new DataSet();
                        da5.Fill(ds5, "tbl_bad");
                        int cnt5 = ds5.Tables[0].Rows.Count;
                        if (cnt5 > 0)
                        {
                            good++;
                        }
                        SqlDataAdapter da6 = new SqlDataAdapter("select * from tbl_good where good_words='" + comment[i] + "'", con);
                        DataSet ds6 = new DataSet();
                        da6.Fill(ds6, "tbl_good");
                        int cnt6 = ds6.Tables[0].Rows.Count;
                        if (cnt6 > 0)
                        {
                            bad++;
                        }
                    }
                    else
                    {
                        SqlDataAdapter da = new SqlDataAdapter("select * from tbl_good where good_words='" + comment[i] + "'", con);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "tbl_good");
                        int cnt = ds.Tables[0].Rows.Count;
                        if (cnt > 0)
                        {
                            good++;
                        }
                        else
                        {
                            SqlDataAdapter da1 = new SqlDataAdapter("select * from tbl_bad where bad_words='" + comment[i] + "'", con);
                            DataSet ds1 = new DataSet();
                            da1.Fill(ds1, "tbl_bad");
                            int cnt1 = ds1.Tables[0].Rows.Count;
                            if (cnt1 > 0)
                            {
                                bad++;
                            }
                        }
                    } 
                }

                else
                {
                    
                        SqlDataAdapter da = new SqlDataAdapter("select * from tbl_good where good_words='" + comment[i] + "'", con);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "tbl_good");
                        int cnt = ds.Tables[0].Rows.Count;
                        if (cnt > 0)
                        {
                            good++;
                        }
                        else
                        {
                            SqlDataAdapter da1 = new SqlDataAdapter("select * from tbl_bad where bad_words='" + comment[i] + "'", con);
                            DataSet ds1 = new DataSet();
                            da1.Fill(ds1, "tbl_bad");
                            int cnt1 = ds1.Tables[0].Rows.Count;
                            if (cnt1 > 0)
                            {
                                bad++;
                            }
                        }
                  
                }
            }
        }
        catch (Exception)
        {
           
        }
     
    }

    protected void btn_SeeMore_click(object sender, EventArgs e)
    {
        int TopVal1 = Convert.ToInt32(lblTop.Text) + 3;
        GetPostData();
    }

    protected void GridViewComment_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridViewComment.PageIndex = e.NewPageIndex;
        GetPostData();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        if (Session["Catname"].Equals("Nikon"))
        {
            Response.Redirect("Index_Cat3.aspx");
        }
        if (Session["Catname"].Equals("Canon"))
        {
            Response.Redirect("Index_Cat2.aspx");
        }
        if (Session["Catname"].Equals("Sony"))
        {
            Response.Redirect("Index_Cat1.aspx");
        }
    }
}