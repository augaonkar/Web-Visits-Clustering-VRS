<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>
 <%@ Register Assembly="System.Web.DataVisualization, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head>
        <title> :: VRS ::</title>
          <script type = "text/javascript" >
       function preventBack(){window.history.forward();}
        setTimeout("preventBack()", 10);
        window.onunload=function(){null};
    </script>
        <!-- Bootstrap -->
        <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet" media="screen">
        <link href="bootstrap/css/bootstrap-responsive.min.css" rel="stylesheet" media="screen">
        <link href="vendors/easypiechart/jquery.easy-pie-chart.css" rel="stylesheet" media="screen">
        <link href="assets/styles.css" rel="stylesheet" media="screen">
        
        <script src="vendors/modernizr-2.6.2-respond-1.1.0.min.js"></script>
        <style type="text/css">

*
{
  margin: 0 auto 0 auto;
	}

            .style4
            {
            }
            .style6
            {
                width: 101%;
            }
            .style7
            {
            }
            .style8
            {
                width: 100%;
            }
            .style10
            {
                width: 77px;
            }

            .style11
            {
            }
            .style12
            {
                width: 29px;
            }

            .style13
            {
            }
            .style14
            {
                width: 186px;
            }
            .style15
            {
                width: 31px;
            }
            .style16
            {
                width: 314px;
            }

            .style17
            {
                width: 230px;
            }
            .style19
            {
                width: 153px;
            }
            .style20
            {
                width: 189px;
            }

            .style21
            {
                width: 77px;
                height: 22px;
            }
            .style22
            {
                height: 22px;
            }

            </style>
         
         


              <!--/.Start - Copy for change menubar -->
               <meta http-equiv='Content-Type' content='text/html; charset=utf-8' />
	<meta http-equiv='X-UA-Compatible' content='IE=edge,chrome=1' />
	<link rel='stylesheet' type='text/css' href='cssmenu3/menu_source/styles.css' />
	<script src='http://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js'></script>
	<script type='text/javascript' src='cssmenu3/menu_source/menu_jquery.js'></script>
                <!--/.End - Copy for change menubar -->


    </head>
    
    <body>
    


        <form id="form1" runat="server">
        <div class="navbar navbar-fixed-top">
            <div class="navbar-inner">
                <div class="container-fluid">
                    <a class="btn btn-navbar" data-toggle="collapse" data-target=".nav-collapse"> <span class="icon-bar"></span>
                     <span class="icon-bar"></span>
                     <span class="icon-bar"></span>
                    </a>
                    <a class="brand" href="#" >Variance Rover System Panel</a
                    ><div class="nav-collapse collapse">
                        <ul class="nav pull-right">
                        </ul>
                    </div>
                    <!--/.nav-collapse -->
                </div>
            </div>
        </div>
        
        
        
        <div class="container-fluid">
            <div class="row-fluid">
                <div class="span3" id="sidebar">
                
                
                
                <!--/.Start - Copy for change menubar -->
                    <div id='cssmenu'>
<ul>
   <li class="active"><a href="Home.aspx"><span>Home</span></a></li>
   <li class='has-sub'><a><span>Tabular Visitor Reports </span></a>
      <ul>
         <li><a href='Show_All_Visitors.aspx'><span>Show All Visitors</span></a></li>
         <li><a href='Statewise_Visitors.aspx'><span>Statewise Visitors </span></a></li>
         <li><a href='Citywise_Visitors.aspx'><span>Citywise Visitors</span></a></li>
         <li><a href='Hierarchical_Records.aspx'><span>Hierarchical Records</span></a></li>
      </ul>
   </li>
   <li class='has-sub'><a><span>Visitor Reports On G-map</span></a>
      <ul>
         <li><a href='Categorywise_G-Map_Records.aspx'><span>Categoerywise G-map Reports</span></a></li>
         <li><a href='Productwise_G-Map_Records.aspx'><span>Productwise G-map Reports</span></a></li>
         <li><a href='All_Records_on_G-Map.aspx'><span>All Records on G-map</span></a></li>
      </ul>
   </li>
   <li class='has-sub'><a><span>Graphical Reports</span></a>
      <ul>
         <li><a href="Show_All_Graph.aspx"><span>Show All Reports</span></a></li>
         <li><a href="StateWise_Graph.aspx"><span>Statewise Reports</span></a></li>
         <li><a href="Citywise_graph.aspx"><span>Citywise Reports</span></a></li>
         <li><a href="Categorywise_graph.aspx"><span>Categorywise Reports</span></a></li>
         <li><a href="Product_wise_Graph.aspx"><span>Productwise Reports</span></a></li>
         <li><a href="Category_comp_graph.aspx"><span>All Category Comparison</span></a></li>
         <li><a href="Reviews_graph.aspx"><span>Review Reports</span></a></li>
      </ul>
   </li>
   
         
         
   
   
   <li><a href='All_Clusters.aspx'><span>All Clusters</span></a></li>
   <li><a href='Productwise_Clusters.aspx'><span>Productwise Clusters</span></a></li>
   <li><a href='Total_Visitors_Report.aspx'><span>Total Visitor Details </span></a></li>
   <li><a href='Total_Review_Details.aspx'><span>Total Review Details</span></a></li>
   <li><a href='Statistics_Reports.aspx'><span>Statistics Report</span></a></li>
   
   <li><a href='Review_Setting.aspx'><span>Review Settings</span></a></li>
   <li><a href='Comparison.aspx'><span>Comparison</span></a></li>
   <li><a href='Custom_report.aspx'><span>Custom Reports</span></a></li>
   <li><a href='Pagewise_Counting.aspx'><span>Pagewise counting</span></a></li>
   <li><a href='SignOut.aspx'><span>Sign Out</span></a></li>
</ul>
</div>
                <!--/.End - Copy for change menubar -->
                
                </div>
                
                <!--/span-->
                <div class="span9" id="content">
                    <div class="row-fluid">
                        <div class="alert alert-success">
                            <h4>VRS is Designed and Developed by SmartHit Group&nbsp; </h4>
                        </div>
                    	</div>
                    <div class="row-fluid">
                        <!-- block -->
                        <div class="block">
                            <div class="navbar navbar-inner block-header">
                                <div class="muted pull-left">Variance Rover System :- Home&nbsp;

                                </div>
                            </div>
                            <div >
                              <table>
                               <tr>
                              <td class="style10">
                                  &nbsp;</td>
                              <td class="style4">
                                  &nbsp;</td>
                              </tr>
                               <tr>
                              <td class="style10">
                                  &nbsp;</td>
                              <td class="style4">
                                  <table class="style6" style="border: medium none #800000">
                                      <tr>
                                          <td class="style17">
                                  <asp:Label ID="Label4" runat="server" Text="Website Visitors Count: " Font-Size="Medium"></asp:Label>
                                  <asp:Label ID="lbl_no1" runat="server" Font-Size="Medium"></asp:Label>
                                          </td>
                                          <td class="style11">
                                              &nbsp;</td>
                                          <td class="style11">
                                              &nbsp;</td>
                                          <td>
                                              &nbsp;</td>
                                          <td class="style12">
                                              &nbsp;</td>
                                      </tr>
                                      <tr>
                                          <td class="style17">
                                              &nbsp;</td>
                                          <td class="style11">
                                              &nbsp;</td>
                                          <td class="style11">
                                              &nbsp;</td>
                                          <td>
                                              &nbsp;</td>
                                          <td class="style12">
                                              &nbsp;</td>
                                      </tr>
                                      <tr>
                                          <td class="style16" colspan="2">
                                  <asp:Label ID="Label2" runat="server" Text="Select Date : "></asp:Label>
                                  <asp:DropDownList ID="ddl_date" runat="server" Height="25px" Width="141px">
                                  </asp:DropDownList>
                                          &nbsp;<asp:Button ID="btn_get" runat="server" onclick="btn_get_Click" Text="Get" 
                                      Width="80px" Height="25px" />
                                          </td>
                                          <td>
                                              &nbsp;</td>
                                          <td class="style7">
                                              &nbsp;</td>
                                          <td class="style12">
                                              &nbsp;</td>
                                      </tr>
                                      <tr>
                                          <td class="style16" colspan="2">
                                              &nbsp;</td>
                                          <td>
                                              &nbsp;</td>
                                          <td class="style7">
                                              &nbsp;</td>
                                          <td class="style12">
                                              &nbsp;</td>
                                      </tr>
                                      <tr>
                                          <td class="style16" colspan="2">
                                  <asp:Label ID="Label3" runat="server" Text="No of Visitors : " Font-Size="Medium"></asp:Label>
                                              <asp:Label ID="lbl_no" runat="server" Font-Size="Medium"></asp:Label>
                                          </td>
                                          <td>
                                              &nbsp;</td>
                                          <td>
                                              &nbsp;</td>
                                          <td class="style12">
                                              &nbsp;</td>
                                      </tr>
                                  </table>
                            </td>
                              </tr>
                               <tr>
                              <td class="style10">
                                 
 
                                  &nbsp;</td>
                              <td>
                                 
 
                                  &nbsp;</td>
                              </tr>
                               <tr>
                              <td class="style10">
                                 
 
                                  &nbsp;</td>
                              <td>
                                 
 
                                  <table class="style8" style="border: medium none #800000">
                                      <tr>
                                          <td class="style19">
                                              Product of the Day is :
                                                        </td>
                                          <td>
                                              &nbsp;</td>
                                          <td>
                                              &nbsp;</td>
                                          <td>
                                              &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td class="style19">
                                                            <asp:TextBox ID="txt_proday" runat="server" Height="55px" TextMode="MultiLine"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                </table>
                                            </td>
                              </tr>
                               <tr>
                              <td class="style21">
                                 
 
                                   </td>
                              <td class="style22">
                                 
 
                                   </td>
                              </tr>
                               <tr>
                              <td class="style10">
                                  &nbsp;</td>
                              <td>
                                  <table class="style8" style="border: medium none #800000">
                                      <tr>
                                          <td class="style20">
                                  <asp:Label ID="Label1" runat="server" Text="Last 10 days Record"></asp:Label>
                                          </td>
                                          <td class="style13" colspan="2">
                                              &nbsp;</td>
                                          <td class="style13" colspan="2">
                                              &nbsp;</td>
                                          <td class="style13" colspan="2">
                                              &nbsp;</td>
                                          <td class="style13">
                                              &nbsp;</td>
                                      </tr>
                                      <tr>
                                          <td class="style14" colspan="2">
                                 
 
                                  <asp:GridView ID="gvdata" runat="server" BackColor="White" 
                                      BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                                      Width="255px">
                                      <RowStyle ForeColor="#000066" />
                                      <FooterStyle BackColor="White" ForeColor="#000066" />
                                      <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                      <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                      <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                                      <Columns>
                                      <asp:TemplateField>
                                      <ItemTemplate>
                                      <%#Container.DataItemIndex+1 %>
                                      </ItemTemplate>
                                      </asp:TemplateField>
                                      </Columns>
                                  </asp:GridView>
                                          </td>
                                          <td colspan="2">
                                              &nbsp;</td>
                                          <td class="style15" colspan="2">
                                 
 
        <asp:Chart ID="Chart1" runat="server" Palette="None" >
            <Series>
                <asp:Series Name="Series1">
                </asp:Series>
<System.Web.UI.DataVisualization.Charting.Series Name="Series1" ChartArea="ChartArea1"></System.Web.UI.DataVisualization.Charting.Series>
            </Series>           
                <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                <AxisX Title="Date" TitleForeColor ="Brown" Interval="Auto"></AxisX>
                <AxisY Title ="No of Visitors" TitleForeColor ="Brown"> </AxisY>
                </asp:ChartArea>



<System.Web.UI.DataVisualization.Charting.ChartArea Name="ChartArea1">
<AxisY Title="No of Visitors" TitleForeColor="Brown"></AxisY>

<AxisX Title="Date" TitleForeColor="Brown"></AxisX>
</System.Web.UI.DataVisualization.Charting.ChartArea>



            </ChartAreas>
 
        </asp:Chart>
                                          </td>
                                          <td colspan="2">
                                              &nbsp;</td>
                                      </tr>
                                      <tr>
                                          <td class="style14" colspan="2">
                                              &nbsp;</td>
                                          <td colspan="2">
                                              &nbsp;</td>
                                          <td class="style15" colspan="2">
                                              &nbsp;</td>
                                          <td colspan="2">
                                              &nbsp;</td>
                                      </tr>
                                      <tr>
                                          <td class="style14" colspan="2">
                                 
 
                                              &nbsp;</td>
                                          <td colspan="2">
                                 
 
                                              &nbsp;</td>
                                          <td class="style15" colspan="2">
                                 
 
                                              &nbsp;</td>
                                          <td colspan="2">
                                 
 
                                              &nbsp;</td>
                                      </tr>
                                  </table>
                            </td>
                              </tr>
                              <tr>
                              <td class="style10">
                                  &nbsp;</td>
                              <td>
                                  &nbsp;</td>
                              </tr>
                              
                              </table>

                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- /block -->
                    </div>
                </div>
            </div>
            <hr>
            <footer>
                </form>
                </body>
</html>
