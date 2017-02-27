<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Review_Setting.aspx.cs" Inherits="Review_Setting" %>

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

            .style1
            {
                height: 411px;
                width: 533px;
            }

            .style2
            {
                text-align: left;
                width: 533px;
            }

            .style3
            {
                width: 533px;
            }

            .style4
            {
                width: 54px;
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
         <li><a href="Category_comp_graph.aspx"><span>All Category Comparison</span></a></li>
         <li><a href="Reviews_graph.aspx"><span>Review Reports</span></a></li>
      </ul>
   </li>
   
         
         
   
   
   <li><a href='All_Clusters.aspx'><span>All Clusters</span></a></li>
   <li><a href='Productwise_Clusters.aspx'><span>Productwise Clusters</span></a></li>
   <li><a href='Total_Visitors_Report.aspx'><span>Total Visitor Details </span></a></li>
   <li><a href='Total_Review_Details.aspx'><span>Total Review Details</span></a></li>
   <li><a href='Statistics_Reports.aspx'><span>Statistics Report</span></a></li>
   
   <li class="active"><a href='Review_Setting.aspx'><span>Review Settings</span></a></li>
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
                                <div class="muted pull-left">Variance Rover System :- Review Setting&nbsp;

                                </div>
                            </div>
                            <div>
                            
                             <table>
        <tr>
        <td class="style4">
        </td>
        <td>
        <table align="center">
                                    <tr>
                                        <td class="style3" colspan="2">
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            <asp:Button ID="btn_goodword" runat="server" onclick="btn_goodword_Click" 
                                                Text="Edit Positive Words" Height="27px" />
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
                                                ID="btn_badword" runat="server" onclick="btn_badword_Click" 
                                                Text="Edit Negative Words" Height="27px" />
                                            <br />
                                            <br />
                                            <br />
                                        </td>
                                        <td class="style2">
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="style3" colspan="2">
                                            <asp:MultiView ID="MultiView1" runat="server">
                                                <asp:View ID="View1" runat="server">
                                                    Positive Words :<br />
                                                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                                        CellPadding="4" ForeColor="#333333" GridLines="Both" 
                                                        onrowdeleting="GridView1_RowDeleting">
                                                        <RowStyle BackColor="#EFF3FB" />
                                                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                                        <EditRowStyle BackColor="#2461BF" />
                                                        <AlternatingRowStyle BackColor="White" />
                                                        <Columns>
                                                            <asp:TemplateField HeaderText="Sr.No">
                                                                <ItemTemplate>
                                                                    <%#Container.DataItemIndex+1 %>
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                        </Columns>
                                                        <Columns>
                                                            <asp:TemplateField HeaderText="Keyword">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="lbl_good" runat="server" Text='<%#Eval("good_words") %>'></asp:Label>
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                        </Columns>
                                                        <Columns>
                                                            <asp:TemplateField HeaderText="Operation">
                                                                <ItemTemplate>
                                                                    <asp:LinkButton ID="lnb_delete" runat="server" CommandName="Delete" 
                                                                        ForeColor="Blue">Delete</asp:LinkButton>
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                        </Columns>
                                                    </asp:GridView>
                                                    <br />
                                                    <asp:TextBox ID="txt_keyword" runat="server" Width="183px"></asp:TextBox>
                                                    &nbsp;&nbsp;&nbsp;
                                                    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add Positive Word" 
                                                        Width="131px" />
                                                    <br />
                                                </asp:View>
                                                <asp:View ID="View2" runat="server">
                                                    Negative Words :<br />
                                                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                                                        CellPadding="4" ForeColor="#333333" GridLines="Both" 
                                                        onrowdeleting="GridView2_RowDeleting">
                                                        <RowStyle BackColor="#EFF3FB" />
                                                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                                        <EditRowStyle BackColor="#2461BF" />
                                                        <AlternatingRowStyle BackColor="White" />
                                                        <Columns>
                                                            <asp:TemplateField HeaderText="Sr.No">
                                                                <ItemTemplate>
                                                                    <%#Container.DataItemIndex+1 %>
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                        </Columns>
                                                        <Columns>
                                                            <asp:TemplateField HeaderText="Keyword">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="lbl_bad" runat="server" Text='<%#Eval("bad_words") %>'></asp:Label>
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                        </Columns>
                                                        <Columns>
                                                            <asp:TemplateField HeaderText="Operation">
                                                                <ItemTemplate>
                                                                    <asp:LinkButton ID="lnb_delete1" runat="server" CommandName="Delete" 
                                                                        ForeColor="Blue">Delete</asp:LinkButton>
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                        </Columns>
                                                    </asp:GridView>
                                                    <br />
                                                    <asp:TextBox ID="txt_bad" runat="server" Width="178px"></asp:TextBox>
                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                    <asp:Button ID="btn_addbad" runat="server" onclick="btn_addbad_Click" 
                                                        Text="Add Negative Word" Width="128px" />
                                                    <br />
                                                </asp:View>
                                                <br />
                                            </asp:MultiView>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style1" colspan="2">
                                        </td>
                                    </tr>
                                </table>
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
