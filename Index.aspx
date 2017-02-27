<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

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
            width: 104px;
        }
        .style3
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
							<li><a title="Home" href="#">Home</a></li>
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
					<!-- Slider -->
					<div class="slider-holder">
						<div class="promo">
							<img src="css/images/promo.jpg" alt="Big Sale This Week -30% OFF!" />
						</div>						
						<div id="slider">
							<ul>
								<li>
									<img src="css/images/slide1.jpg" alt="colour pencils" title="" />
								</li>
								<li>
									<img src="css/images/slide2.jpg" alt="pencils"  title=""/>
									</li>
								<li>
									<img src="css/images/slide3.jpg" alt="pencils" />
									</li>
								<li>
									<img src="css/images/slide4.jpg" alt="pencils" />
									</li>
								<li>
									<img src="css/images/slide5.jpg" alt="pencils" />
									</li>
							</ul>																		
						</div>						
						<div class="cl"></div>
						<div class="jcarousel-control">
							<a title="Slide 1" href="#">1</a>
							<a title="Slide 2" href="#">2</a>
							<a title="Slide 3" href="#">3</a>
							<a title="Slide 4" href="#">4</a>
							<a title="Slide 5" href="#">5</a>																													 
						</div>						
					</div>	
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
								<table>
								<tr>
								<td class="style1">
								</td>
								<td>
										<div class="product">									
                                    <asp:LinkButton ID="lnkb_pro_1" runat="server" onclick="LinkButton1_Click"><img 
                                        src="css/images/Cat3.jpg" /></asp:LinkButton>				
									        <br />
								<span class="price">
								 <sup>                              
                                            </sup>
                                            <asp:ImageButton ID="ImageButton4" runat="server" 
                                                ImageUrl="~/css/images/str.png" Height="41px" onclick="ImageButton4_Click" 
                                                Width="188px" />
                                            </span>
									<div class="cl">
									</div>	
								</div>
								<div class="product">																										
						
                                        <asp:LinkButton ID="lnkb_pro_2" runat="server" onclick="lnkb_pro_2_Click"><img src="css/images/Cat2.jpg"/></asp:LinkButton>																											
									    <br />
                                        <asp:ImageButton ID="ImageButton1" runat="server" Height="41px" 
                                            ImageUrl="~/css/images/str.png" Width="188px" 
                                            onclick="ImageButton1_Click" />
									<div class="cl"></div>																											
								</div>
								<div class="product">																												
                               
                                    <asp:LinkButton ID="lnkb_pro_3" runat="server" onclick="lnkb_pro_3_Click"><img src="css/images/Cat1.jpg" alt="paperclip" /></asp:LinkButton>
                                    <br />
                                    <asp:ImageButton ID="ImageButton5" runat="server" 
                                        ImageUrl="~/css/images/str.png" Height="41px" onclick="ImageButton5_Click" 
                                        Width="188px" />
                                    <br />
                                    &nbsp;
                                    </div>
								</td>
								</tr>
								
								</table>
								
						
							
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
       
		
		<%--<a title="free world map tracker" href="http://24counter.com/vmap/1392975154/">
<img title="free world map counter" src="http://24counter.com/map/view.php?type=180&id=1392975154" border="1" alt="world map hits counter" /></a><br>
<a href="http://24counter.com">map counter</a>
	  
	  <a target="_blank" href="http://24counter.com/cc_stats/1392975154/"><img alt="blog counter" border="0" src="http://24counter.com/online/ccc.php?id=1392975154"></a><br>
<a href="http://24counter.com">blog counter</a>--%>
     
<!-- hitwebcounter Code START -->
<a href="#" target="_blank">

<img src="http://hitwebcounter.com/counter/counter.php?page=5284651&style=0027&nbdigits=6&type=ip&initCount=0" title="easily put counter" Alt="easily put counter"   border="0" >

</a><br/>
<!-- hitwebcounter.com --><a href="#" title="Website Traffic" 
target="_blank" style="font-family: Geneva, Arial, Helvetica, sans-serif; 
font-size: 9px; color: #908C86; text-decoration: underline ;"><strong>Unique Visitors</strong>
</a>   
  
  
  
		
<%--<!-- hitwebcounter Code START -->
<a href="#" target="_blank">
<img src="http://hitwebcounter.com/counter/counter.php?page=5284605&style=0027&nbdigits=8&type=page&initCount=0" title="useful counter" Alt="useful counter"   border="0" >
</a><br/>
<!-- hitwebcounter.com --><a href="#" title="Visitor's Count" 
target="_blank" style="font-family: Arial, Helvetica, sans-serif; 
font-size: 10px; color: #6E6A68; text-decoration: none ;"><em>Visitor's Count

		<div id="footer-push"></div>
	</div>--%>
	
	
	<!-- END Wrapper -->
	<!-- Footer -->
	<div id="footer"><a href="http:///www.smarthit.co.in"><img src="css/images/logo.png" / align="right"></a>
        <br />
        <span class="style3">
        <br />
        &nbsp;Copyright © 2014-15, smarthit Group. All Rights 
        Reserved.</span></div>
	<!-- END Footer -->
    </form>
</body>
</html>
