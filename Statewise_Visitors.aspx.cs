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

public partial class Statewise_Visitors : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
  if (!IsPostBack)
        {
            if (Session["U_name"] == null)
            {
                Response.Redirect("AdminLogin.aspx");
            }
            else
            {
                binddropdowns();
            }
        }
       
        }
        catch (Exception)
        {
            
            throw;
        }
    }
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cntr"].ToString());

    private void binddropdowns()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select DISTINCT RegionName from Locations ORDER BY RegionName DESC", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["RegionName"].ToString().Equals(""))
                {

                }
                else
                {
                    drp_states.Items.Add(dr["RegionName"].ToString());
                }

            }
            dr.Close();
            con.Close();
        }
        catch (Exception)
        {
            
        }
       
    }

    protected void btn_okstates_Click(object sender, EventArgs e)
    {
        GetData();

       
    }

    private void GetData()
    {
        try
        {
            SqlDataAdapter da = new SqlDataAdapter("Select IPAddress,CountryName as [Country Name],CityName as [City Name],Latitude,Longitude,Visiting_Date as [Visiting Date] from Locations where RegionName='" + drp_states.SelectedItem.Text + "' ORDER BY Visiting_Date DESC ", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Locations");
            Grid_Log.DataSource = ds;
            Grid_Log.DataMember = "Locations";
            Grid_Log.DataBind();
            int cnttb = ds.Tables["Locations"].Rows.Count;
            Label1.Text = cnttb.ToString();
        }
        catch (Exception)
        {


        }
    }
    protected void Grid_Log_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        
    }
    protected void Grid_Log_PageIndexChanging1(object sender, GridViewPageEventArgs e)
    {
        Grid_Log.PageIndex = e.NewPageIndex;
        GetData();
    }
}
