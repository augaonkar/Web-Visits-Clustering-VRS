<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index_Cat1.aspx.cs" Inherits="Index" %>

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
					<h1 id="logo"><a href="http://www.smarthit.co.in" title="Home">accessories store</a></h1>
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
				<div id="main">
				
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
                                        src="css/images/1.jpg" /></asp:LinkButton>				
									<div class="desc">
										<p class="name">SONY ALPHA A37K<span lang="en-us"> </span></p>
										
									</div>	
									<div class="price-box">
										<p>Rs<span class="price"> 30,990</span></p>
									</div>
								<span class="price">
								 <sup>                              
                                            </sup></span>
									<div class="cl"></div>																														
								</div>
								<div class="product">																										
							
                                        <asp:LinkButton ID="lnkb_pro_2" runat="server" onclick="lnkb_pro_2_Click"><img src="css/images/2.jpg"/></asp:LinkButton>																											
									    <div class="desc">
										<p class="name">Sony Alpha A65VK SLT SLR</p>
										
									</div>	
									<div class="price-box">
										<p>Rs<span class="price"> 59,690</span></p>
									</div>
									<div class="cl"></div>																											
								</div>
								<div class="product">																												
                                  
                                    <asp:LinkButton ID="lnkb_pro_3" runat="server" onclick="lnkb_pro_3_Click"><img src="css/images/3.jpg" alt="paperclip" /></asp:LinkButton>
                                    &nbsp;
                                    <div class="desc">
										<p class="name">Sony Cybershot DSC-T2 8MP</p>
										
									</div>	
									<div class="price-box">
										<p>Rs<span class="price"> 8,495</span></p>
									</div>
									<div class="cl"></div>																															
								</div>
								<div class="product">																												
                               
                                        <asp:LinkButton ID="lnkb_pro_4" runat="server" onclick="lnkb_pro_4_Click"><img src="css/images/4.jpg" alt="paperclip" /></asp:LinkButton>
                                        &nbsp;
                                        <div class="desc">
										<p class="name">Sony Cyber-shot DSC-WX200</p>
										<p>Model: <span> DSC-WX200</span></p>
										
									</div>	
									<div class="price-box">
										<p>Rs<span class="price"> 14,490</span></p>
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
	<div id="footer"><div id="Div1"><span lang="en-us">&nbsp;</span><a href="http://www.smarthit.co.in"><img src="css/images/logo.png" / align="right"></a>
        <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="White" 
            NavigateUrl="~/Index.aspx">Home &gt;</asp:HyperLink>
        <asp:Label ID="Label1" runat="server" ForeColor="White" Text="Sony "></asp:Label>
	    <br />
        <span class="style1">
        <br />
        <span lang="en-us">&nbsp; </span>Copyright © 2014-15, smarthit Group. All Rights Reserved.</span></div>
	<!-- END Footer -->
    </form>
</body>
</html>
