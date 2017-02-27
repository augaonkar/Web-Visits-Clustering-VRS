<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Category_comp_graph.aspx.cs" Inherits="Category_comp_graph" %>

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
         <script type="text/javascript" src="https://www.google.com/jsapi"></script>
        <style type="text/css">

*
{
  margin: 0 auto 0 auto;
	}

            .style18
            {
                width: 27px;
            }
            .style19
            {
                width: 27px;
                height: 1047px;
            }
            .style20
            {
                height: 1047px;
            }
            </style>
            
             <!--/.Start - Copy for change menubar -->
               <meta http-equiv='Content-Type' content='text/html; charset=utf-8' />
	<meta http-equiv='X-UA-Compatible' content='IE=edge,chrome=1' />
	<link rel='stylesheet' type='text/css' href='cssmenu3/menu_source/styles.css' />
	<script src='http://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js'></script>
	<script type='text/javascript' src='cssmenu3/menu_source/menu_jquery.js'></script>
                <!--/.End - Copy for change menubar -->
<script language="javascript" type="text/javascript">
    function printdiv(Panel1)
    {
      var headstr = "<html><head><title></title></head><body>";
      var footstr = "</body>";
      var newstr = document.all.item(Panel1).innerHTML;
      var oldstr = document.body.innerHTML;
      document.body.innerHTML = headstr+newstr+footstr;
      window.print();
      document.body.innerHTML = oldstr;
      return false;
    }
</script>

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
   <li><a href="Home.aspx"><span>Home</span></a></li>
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
         <li class="active"><a href="Category_comp_graph.aspx"><span>All Category Comparison</span></a></li>
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
                                <div class="muted pull-left">Variance Rover System- All Category Comparison&nbsp;

                                </div>
                            </div>
                            <div>
                            
                            
                            
                             <table>
        <tr>
        <td class="style19">
        </td>
        <td class="style20">
        <asp:Panel ID="Panel1" runat="server" Height="1108px">
                                <table>
                                    <tr>
                                        <td class="style14">
                                            </td>
                                        <td class="style15">
                                            </td>
                                        <td class="style15">
                                            </td>
                                        <td class="style16">
                                            </td>
                                        <td class="style17">
                                            </td>
                                        <td class="style17">
                                            </td>
                                        <td class="style17">
                                        <asp:Button ID="btn_print" runat="server" Height="27px" OnClientClick = "return printdiv('Panel1');" Text="Print" Width="88px" />
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="style7">
                                            Date</td>
                                        <td class="style1">
                                            Month</td>
                                        <td class="style5">
                                            Year</td>
                                        <td class="style4">
                                            &nbsp;</td>
                                        <td class="style1">
                                            Date</td>
                                        <td class="style1">
                                            Month</td>
                                        <td class="style1">
                                            Year</td>
                                    </tr>
                                    <tr>
                                        <td class="style9">
                                            <asp:DropDownList ID="ddl_fromdate" runat="server" Height="25px" Width="90px">
                                            </asp:DropDownList>
                                        </td>
                                        <td class="style10">
                                            <asp:DropDownList ID="ddl_frommonth" runat="server" Height="25px" Width="90px">
                                            </asp:DropDownList>
                                        </td>
                                        <td class="style10">
                                            <asp:DropDownList ID="ddl_fromyear" runat="server" Height="25px" Width="90px">
                                            </asp:DropDownList>
                                        </td>
                                        <td class="style8">
                                            &nbsp;&nbsp;To</td>
                                         <td class="style11">
                                             <asp:DropDownList ID="ddl_todate" runat="server" Height="25px" Width="90px">
                                             </asp:DropDownList>
                                        </td>
                                        <td class="style11">
                                            <asp:DropDownList ID="ddl_tomonth" runat="server" Height="25px" Width="90px">
                                            </asp:DropDownList>
                                        </td>
                                        <td class="style11">
                                            <asp:DropDownList ID="ddl_toyear" runat="server" Height="25px" Width="90px">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style1" colspan="3">
                                            &nbsp;</td>
                                        <td class="style4">
                                            &nbsp;</td>
                                        <td colspan="3">
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="style1" colspan="4">
                                            Select Chart -
                                            <asp:DropDownList ID="ddl_chart" runat="server" Height="27px" Width="163px">
                                                <asp:ListItem>Stacked Chart</asp:ListItem>
                                                <asp:ListItem>Line Chart</asp:ListItem>
                                            </asp:DropDownList>
                                            &nbsp;
                                            <asp:Button ID="btn_get" runat="server" Height="27px" onclick="btn_get_Click" 
                                                Text="Get Report" Width="76px" />
                                        </td>
                                        <td colspan="3">
                                             
      
</td>
                                    </tr>
                                    <tr>
                                        <td class="style1" colspan="7">
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="style1" colspan="7">
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="style1" colspan="7">
                                            <br />
                                        </td>
                                    </tr>
                                   
                                </table>
                                <table>
                                <tr>
                                <td>
                                <asp:MultiView ID="MultiView1" runat="server">
                                                <asp:View ID="View2" runat="server">
                                                    <asp:Chart ID="Chart2" runat="server" BackGradientStyle="TopBottom" 
                                                        Height="300px" Width="700px">
                                                        <Legends>
                                                            <asp:Legend Alignment="Center" BackColor="Transparent" Docking="Left" 
                                                                Font="Trebuchet MS, 8.25pt, style=Bold" IsTextAutoFit="true" 
                                                                LegendStyle="Column" Name="Default">
                                                            </asp:Legend>
                                                        </Legends>
                                                        <Series>
                                                            <asp:Series ChartType="Column" IsValueShownAsLabel="True" Name="Sony">
                                                            </asp:Series>
                                                            <asp:Series ChartType="Column" IsValueShownAsLabel="True" Name="Canon">
                                                            </asp:Series>
                                                            <asp:Series ChartType="Column" IsValueShownAsLabel="True" Name="Nikon">
                                                            </asp:Series>
                                                        </Series>
                                                        <ChartAreas>
                                                            <asp:ChartArea BackGradientStyle="TopBottom" Name="ChartArea1">
                                                                <AxisX Title="City" TitleForeColor="Brown">
                                                                </AxisX>
                                                                <AxisY Title="No of Visitors" TitleForeColor="Brown">
                                                                </AxisY>
                                                            </asp:ChartArea>
                                                        </ChartAreas>
                                                    </asp:Chart>
                                                </asp:View>
                                                <asp:View ID="View3" runat="server">
                                                    <asp:Chart ID="Chart3" runat="server" Height="300px" Width="500px">
                                                        <Legends>
                                                            <asp:Legend Alignment="Center" BackColor="Transparent" Docking="Left" 
                                                                Font="Trebuchet MS, 8.25pt, style=Bold" IsTextAutoFit="true" 
                                                                LegendStyle="Column" Name="Default">
                                                            </asp:Legend>
                                                        </Legends>
                                                        <Series>
                                                            <asp:Series ChartType="Line" Name="Sony">
                                                            </asp:Series>
                                                            <asp:Series ChartType="Line" Name="Canon">
                                                            </asp:Series>
                                                            <asp:Series ChartType="Line" Name="Nikon">
                                                            </asp:Series>
                                                        </Series>
                                                        <ChartAreas>
                                                            <asp:ChartArea Name="ChartArea1">
                                                                <AxisX Interval="Auto" Title="Date" TitleForeColor="Brown">
                                                                </AxisX>
                                                                <AxisY Title="No of Visitors" TitleForeColor="Brown">
                                                                </AxisY>
                                                            </asp:ChartArea>
                                                        </ChartAreas>
                                                    </asp:Chart>
                                                    <br />
                                                </asp:View>
                                                <br />
                                                <br />
                                            </asp:MultiView>
                                </td>
                                </tr>
                                <tr>
                                <td>
                                <asp:GridView ID="gv_data" runat="server" AllowPaging="True" 
                                                
                onpageindexchanging="gv_data_PageIndexChanging" Width="392px">
                                                <Columns>
                                                    <asp:TemplateField HeaderText="Sr No">
                                                        <ItemTemplate>
                                                            <%#Container.DataItemIndex+1 %>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                </Columns>
                                            </asp:GridView>
                                </td>
                                </tr>
                                </table>
                                 </asp:Panel>
        </td>
        </tr>
        <tr>
        <td class="style18">
            &nbsp;</td>
        <td>
        
                                            
                                        </td>
        </tr>
        </table>
                            
                            
                            
                            
                            
                            
                            
                            
                                
                                <br />
                                <br />
                        

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
