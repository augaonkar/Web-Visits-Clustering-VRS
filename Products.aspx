<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Products.aspx.cs" Inherits="Products" %>

<%--<%@ Register assembly="System.Web.DataVisualization, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
--%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>VRS - Variance Rover System </title>
      <script type = "text/javascript" >
       function preventBack(){window.history.forward();}
        setTimeout("preventBack()", 10);
        window.onunload=function(){null};
    </script>
    <meta http-equiv="Content-type" content="text/html; charset=utf-8" />
    <link rel="shortcut icon" href="css/images/favicon1.ico" />
    <link rel="stylesheet" href="css/style.css" type="text/css" media="all" />
    <!--[if IE 6]>
	<link rel="stylesheet" href="css/ie6.css" type="text/css" media="all" />	
	<![endif]-->
    <link rel="stylesheet" href="css/jquery.jscrollpane.css" type="text/css" media="all" />

    <script src="js/jquery-1.7.min.js" type="text/javascript"></script>

    <script src="js/DD_belatedPNG-min.js" type="text/javascript"></script>

    <script src="js/jquery.jscrollpane.min.js" type="text/javascript"></script>

    <script src="js/jquery.jcarousel.js" type="text/javascript"></script>

    <script src="js/functions.js" type="text/javascript"></script>

    <style type="text/css">
        .style2
        {
            width: 100%;
            height: 191px;
        }
        .style3
        {
            width: 344px;
        }
        .style5
        {
            width: 232px;
        }
        .style6
        {
            height: 18px;
        }
        .style7
        {
            height: 14px;
        }
        .style8
        {
            height: 2px;
        }
        .style9
        {
            height: 28px;
        }
        .style10
        {
            width: 21px;
        }
        .style11
        {
            font-weight: bold;
            color: #FFFFFF;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <!-- Wrapper -->
    <div id="wrapper">
        <div id="wrapper-bottom">
            <div class="shell">
                <!-- Header -->
                <div id="header">
                    <!-- Logo -->
                    <h1 id="logo">
                        <a href="http:///www.smarthit.co.in" title="Home">accessories store</a></h1>
                    <!-- Search -->
                    <div id="search">
                        <div class="retract-button">
                            <p>
                                retract</p>
                        </div>
                        <input type="text" class="field" value="Search" title="Search" />
                        <input type="submit" value="" class="submit-button" />
                    </div>
                    <!-- END Search -->
                    <div class="cl">
                    </div>
                    <!-- Navigation -->
                    <div id="navigation">
                        <ul>
                          	<li><a title="Home" href="Index.aspx">Home</a></li>
							<li><a title="About Us" href="AboutUs.aspx">About Us</a></li>
							<li><%--<a title="Admin Login" href="AdminLogin.aspx">Admin Login</a>--%></li>
                        </ul>
                    </div>
                    <div class="cl">
                    </div>
                    <!-- END Navigation -->
                    <!-- Dropdown Navigation -->
                    <!-- END Dropdown Navigation -->
                    <div class="cl">
                    </div>
                </div>
                <!-- END Header -->
                <!-- Main -->
                <div id="main">
                    <!-- Slider -->
                    
                    <!-- END Slider -->
                    <!-- Content -->
                    <div id="content">
                        <!-- Featured Products -->
                    </div>
                </div>
                <!-- END Slider -->
                <!-- Content -->
                <div>
                
                    <!-- Featured Products -->
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <div >  
                                <asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager>
                            <div class="middle">
                            <div>
                            
                                <table class="style2">
                                    <tr>
                                        <td class="style5">
                                            <br />
                                        </td>
                                        <td class="style3">
                                            <asp:Image ID="Image1" runat="server" Height="275px" Width="339px" />
                                        </td>
                                        <td class="style10">
                                        </td>
                                        <td>
                                            <table class="style2">
                                                <tr>
                                                    <td class="style9">
                                                        <asp:Label ID="l8" runat="server" Font-Bold="True" Font-Size="Medium">Specifications :</asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="l1" runat="server" Font-Size="Medium"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="l2" runat="server" Font-Size="Medium"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="l3" runat="server" Font-Size="Medium"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="l4" runat="server" Font-Size="Medium"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="l5" runat="server" Font-Size="Medium"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="l6" runat="server" Font-Size="Medium"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="l7" runat="server" Font-Size="Medium"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td class="style6">
                                                        </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style5">
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td class="style10">
                                            &nbsp;</td>
                                        <td>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style5">
                                            &nbsp;</td>
                                        <td>
                                            <table class="style2">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label3" runat="server" Height="22px" 
                                                            Text="Give your reviews here..."></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="txtcomment" runat="server" BorderColor="Black" Height="45px" 
                                                            Width="338px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Button ID="btnComment" runat="server" BackColor="#34495E" 
                                                            ForeColor="White" OnClick="btnComment_click" Text="Comment" Width="80px" />
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:GridView ID="GridViewComment" runat="server" AutoGenerateColumns="False" 
                                                            CellPadding="4" DataKeyNames="C_Cid" GridLines="Both" 
                                                            ShowHeader="False" Width="347px" AllowPaging="True" 
                                                            onpageindexchanging="GridViewComment_PageIndexChanging" PageSize="5" 
                                                            ForeColor="#333333">
                                                            <RowStyle BackColor="#EFF3FB" />
                                                            <Columns>
                                                                <asp:TemplateField ItemStyle-VerticalAlign="Top" ItemStyle-Width="25px">
                                                                    <ItemTemplate>
                                                                        <asp:Image ID="Image1" runat="server" Height="20px" ImageUrl="~/no_user.png" 
                                                                            Width="20px" />
                                                                    </ItemTemplate>
                                                                    <ItemStyle VerticalAlign="Top" Width="25px" />
                                                                </asp:TemplateField>
                                                                <asp:TemplateField>
                                                                    <ItemTemplate>
                                                                        <div style="word-wrap: break-word; width: 330px; text-align: justify">
                                                                            <asp:Label ID="lblcomment" runat="server" Font-Size="Small" ForeColor="#34495E" 
                                                                                Style="font-family: Arial;" 
                                                                                Text='<%# Eval("C_Commenttext").ToString().Replace("\n", "<br />") %>'></asp:Label>
                                                                        </div>
                                                                        &nbsp;<asp:Label ID="Label1" runat="server" Font-Size="Small" 
                                                                            Style="font-family: Arial;" Text="Commented On:"></asp:Label>
                                                                        <asp:Label ID="lbldate" runat="server" Font-Size="Small" 
                                                                            Style="font-family: Arial;" Text='<%# Eval("C_Currentdate") %>'></asp:Label>
                                                                    </ItemTemplate>
                                                                </asp:TemplateField>
                                                            </Columns>
                                                            <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                                                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                                            <EditRowStyle BackColor="#2461BF" />
                                                            <AlternatingRowStyle BackColor="White" />
                                                        </asp:GridView>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Button ID="btn_SeeMore" runat="server" BackColor="#34495E" 
                                                            ForeColor="White" OnClick="btn_SeeMore_click" Text="See More..." 
                                                            Visible="False" Width="131px" />
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                        <td class="style10">
                                            &nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="style8">
                                                        <asp:Label ID="l9" runat="server" Font-Bold="True" Font-Size="Medium">Comment Details :</asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style8">
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        Total No. of Comments :-&nbsp;
                                                        <asp:Label ID="lblcomment_cnt" runat="server" 
                                                            Text='<%#Eval("C_Comment_cnt") %>'></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="lbl_good" runat="server"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="lbl_bad" runat="server"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="lbl_cnt_say" runat="server"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style7">
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style5">
                                            <asp:Label ID="lblTop" runat="server" Visible="False"></asp:Label>
                                            <asp:Label ID="lblcmt" runat="server" Visible="False"></asp:Label>
                                        </td>
                                        <td>
                                            &nbsp;</td>
                                        <td class="style10">
                                            &nbsp;</td>
                                    </tr>
                                </table>
                            
                            </div>
                            </div>                           
                                
                                <div class="bottom">
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <!-- END Featured Products -->
                    <!-- Best Sellers -->
                    <!-- END Best Sellers -->
                    <!-- Bottom Strip -->
                    <div class="bottom-strip">
                        <div class="cl">
                        </div>
                    </div>
                    <!-- END Bottom Strip -->
                </div>
                <!-- END Content -->
            </div>
            <!-- END Main -->
        </div>
    </div>
    <div id="footer-push">
    </div>
    </div>
    <!-- END Wrapper -->
    <!-- Footer -->
    <div id="footer"><div id="Div1"><a href="http:///www.smarthit.co.in"><img src="css/images/logo.png" / align="right">
        </a>&nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="White" 
            NavigateUrl="~/Index.aspx">Home &gt;</asp:HyperLink>
        <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="White" 
            onclick="LinkButton1_Click"></asp:LinkButton>
&nbsp;<asp:Label ID="Label4" runat="server" ForeColor="White"></asp:Label>
        <br />
        <br />
        <span class="style11">&nbsp;&nbsp; Copyright © 2014-15, smarthit Group. All 
        Rights Reserved.</span></div>
    <!-- END Footer -->
    </form>
</body>
</html>
