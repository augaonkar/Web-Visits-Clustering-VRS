<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index_Cat3.aspx.cs" Inherits="Index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<title>VRS - Variance Rover System </title>
	
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
        .style1
        {
            left: 0px;
            top: 0px;
        }
        .style2
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
					<h1 id="logo"><a href="http:///www.smarthit.co.in" title="Home">accessories store</a></h1>
					<!-- Search -->
					<div id="search">
						<div class="retract-button">
							<p>retract</p>
						</div>
							<input type="text" class="field" value="Search" title="Search" />
							<input type="submit" value="" class="submit-button" />
						</div>
					<!-- END Search -->
					<div class="cl"></div>
					<!-- Navigation -->
					<div id="navigation">
						<ul>
							<li><a title="Home" href="Index.aspx">Home</a></li>
								<li><a title="About Us" href="AboutUs.aspx">About Us</a></li>
							<li><%--<a title="Admin Login" href="AdminLogin.aspx">Admin Login</a>--%></li>
							
						</ul>						
					</div>	
					<div class="cl"></div>				
					<!-- END Navigation -->
					<!-- Dropdown Navigation -->
					<!-- END Dropdown Navigation -->
					<div class="cl"></div>
				</div>
				<!-- END Header -->
				<!-- Main -->
				<div id="main" class="style1">
					<!-- Slider -->
					
					<!-- END Slider -->
					<!-- Content -->
					<div id="content">
						<!-- Featured Products -->
                        <asp:ScriptManager ID="ScriptManager1" runat="server">
                        </asp:ScriptManager>
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                       <ContentTemplate>
                       	<div class="products-holder">
							<div class="top"></div>
							<div class="middle">													
								<div class="label">
									<h3>Latest Products</h3>									
								</div>
								<div class="cl"></div>	
								
								<div class="product">									
                                    <asp:LinkButton ID="lnkb_pro_1" runat="server" onclick="LinkButton1_Click"><img 
                                        src="css/images/9.jpg" /></asp:LinkButton>				
									<div class="desc">
										<p class="name">Nikon D3200 SLR</p>
									
									</div>	
									<div class="price-box">
										<p>Rs<span class="price"> 26,344</span></p>
									</div>
								<span class="price">
								 <sup>                              
                                            </sup></span>
									<div class="cl"></div>																														
								</div>
								<div class="product">																										
							<%--<asp:ImageButton ID="imgb_pro_2" runat="server" Height="202px" 
                                        ImageUrl="~/css/images/perforator.jpg" Width="217px" 
                                        onclick="imgb_pro_2_Click1" />--%>	
                                        <asp:LinkButton ID="lnkb_pro_2" runat="server" onclick="lnkb_pro_2_Click"><img src="css/images/10.jpg"/></asp:LinkButton>																											
									    <div class="desc">
										<p class="name">Nikon D5100 SLR</p>
									
									</div>	
									<div class="price-box">
										<p>Rs<span class="price"> 32,950</span></p>
									</div>
									<div class="cl"></div>																											
								</div>
								<div class="product">																												
                                    <%--<asp:ImageButton ID="imgb_pro_3" runat="server" Height="201px" 
                                        ImageUrl="~/css/images/markers.jpg" Width="206px" 
                                        onclick="imgb_pro_3_Click" />--%>
                                    <asp:LinkButton ID="lnkb_pro_3" runat="server" onclick="lnkb_pro_3_Click"><img src="css/images/11.jpg" alt="paperclip" /></asp:LinkButton>
                                    &nbsp;
                                    <div class="desc">
										<p class="name">Nikon Coolpix S9500 Advance Point and shoot</p>
									
									</div>	
									<div class="price-box">
										<p>Rs<span class="price"> 17,300</span></p>
									</div>
									<div class="cl"></div>																															
								</div>
								<div class="product">																												
                                   <%-- <asp:ImageButton ID="imgb_pro_4" runat="server" Height="202px"  Width="220px"
                                        ImageUrl="~/css/images/eraser.jpg" onclick="imgb_pro_4_Click" />--%>
                                        <asp:LinkButton ID="lnkb_pro_4" runat="server" onclick="lnkb_pro_4_Click"><img src="css/images/12.jpg" alt="paperclip" /></asp:LinkButton>
                                    &nbsp;
                                        <div class="desc">
										<p class="name">Nikon Coolpix S2700 Point Shoot</p>
										
									</div>	
									<div class="price-box">
										<p>Rs<span class="price"> 5,950</span></p>
									</div>
									<div class="cl"></div>																														
								</div>
								<div class="cl"></div>
							</div>
							<div class="bottom"></div>									
						</div>
                       </ContentTemplate>
					
						 </asp:UpdatePanel>
						<!-- END Featured Products -->
						<!-- Best Sellers -->
						<!-- END Best Sellers -->
						<!-- Bottom Strip -->
						<div class="bottom-strip">
							<div class="cl"></div>
						</div>
						<!-- END Bottom Strip -->
					</div>
					<!-- END Content -->
				</div>
				<!-- END Main -->
			</div>
		</div>
		<div id="footer-push"></div>
	</div>
	<!-- END Wrapper -->
	<!-- Footer -->
	<div id="footer"><div id="Div1"><a href="http:///www.smarthit.co.in"><img src="css/images/logo.png" / align="right"></a>&nbsp;
        <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="White" 
            NavigateUrl="~/Index.aspx">Home &gt;</asp:HyperLink>
        <asp:Label ID="Label1" runat="server" ForeColor="White" Text="Nikon"></asp:Label>
	    <br />
	    <br />
        <span lang="en-us">&nbsp; </span><span class="style2">Copyright © 2014-15, smarthit Group. All Rights 
        Reserved.</span></div>
	<!-- END Footer -->
    </form>
</body>
</html>
