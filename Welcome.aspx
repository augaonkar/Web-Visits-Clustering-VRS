<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Welcome.aspx.cs" Inherits="Welcome" %>

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
        .style3
        {
            text-align: justify;
        }
        .style5
        {
            font-weight: bold;
            font-size: large;
        }
        .style6
        {
            color: #0099FF;
        }
        .style8
        {
            width: 54%;
            height: 128px;
            color: #0099FF;
        }
        .style9
        {
            width: 16px;
        }
        .style13
        {
            color: #FF0000;
        }
        .style18
        {
            color: #0099FF;
            font-size: large;
            font-weight: bold;
            text-decoration: underline;
        }
        .style19
        {
            text-decoration: underline;
            font-weight: bold;
            font-size: medium;
        }
        .style21
        {
            width: 887px;
            height: 86px;
        }
        .style23
        {
            width: 887px;
            height: 69px;
        }
        .style24
        {
            color: #FFFFFF;
            font-style: normal;
            font-weight: bold;
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
						     	<li><a title="Welcome" href="Welcome.aspx">Welcome</a></li>
							    <li><a title="Home" href="Index.aspx">Home</a></li>
								<li><a title="About Us" href="AboutUs.aspx">About Us</a></li>
							<li><%--<a title="Admin Login" href="AdminLogin.aspx">Admin Login</a>--%></li>
						</ul>						
					</div>	
					<div class="cl"></div>				
					<!-- END Navigation -->
					<!-- Dropdown Navigation -->
					<div id="sort-nav">						
							<div class="label-bg">						
						</div>
					</div>					
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
									<img src="css/images/s1.jpg" alt="colour pencils" title="" />
								</li>
								
								<li>
									<img src="css/images/s3.jpg" alt="pencils" />
									</li>
								<li>
									<img src="css/images/s4.jpg" alt="pencils" />
									</li>
								<li>
									<img src="css/images/s5.jpg" alt="pencils" />
									</li>
								<li>
									<img src="css/images/s6.jpg" alt="pencils" />
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
							     <div class="style4">
									 <br />
                                     <div class="label">
                                        							
								</div>												
								<table>
								
								<tr>
								<td class="style3">
								    <br />
                                    <span class="style18" lang="en-us">WHAT WE ARE DOING ??</span><br class="style19" />
                                    &nbsp;<p class="style23">
                                        In this competitive era, organizations have to be fast but very careful in 
                                        taking decisions regarding operations of the organization. Business decisions 
                                        are only as<span lang="en-us">&nbsp; </span>&nbsp;good as the information on which they 
                                        are based. A correct decision opens the door to competitive advantage and a host 
                                        of other benefits, allowing companies to substantially enhance bottom-line 
                                        profitability.
                                        <br />
                                    </p>
                                    <span class="style18">WHY WE ARE DOING ??</span>
                                    <br />
                                    <br />
                                    <p class="style21">
                                        &quot;Business Intelligence is a set of methodologies, processes, architectures, and 
                                        technologies that transform raw data into meaningful and useful information used 
                                        to enable more effective strategic, tactical, and operational insights and 
                                        decision-making.&quot; In<a href="http://www.gartner.com/newsroom/id/856714"> 2009 
                                        Gartner paper </a>predicted about business intelligence: &quot;Because of lack of 
                                        information, processes, and tools, through 2012, more than 35 percent of the top 
                                        5,000 global companies will regularly fail to make insightful decisions about 
                                        significant changes in their business and markets.&quot;
                                    </p>
                                  
                                    <span class="style18">HOW WE ARE DOING IT ??</span>
                                    <br /><br />
                                    <table class="style8">
                                        <tr>
                                            <td class="style9">
                                                <span lang="en-us">1</span></td>
                                            <td>
                                                Know your Customers
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style9">
                                                <span lang="en-us">2</span></td>
                                            <td>
                                                Manage Financial Performance</td>
                                        </tr>
                                        <tr>
                                            <td class="style9">
                                                <span lang="en-us">3</span></td>
                                            <td>
                                                Mitigate your Risk
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style9">
                                                <span lang="en-us">4</span></td>
                                            <td>
                                                Optimize your Operations</td>
                                        </tr>
                                        <tr>
                                            <td class="style9">
                                                <span lang="en-us">5</span></td>
                                            <td>
                                                Reporting</td>
                                        </tr>
                                    </table>
                                    <span class="style18" lang="en-us">
                                    <br />
                                    HOW CAN YOU HELP US<br />
                                    </span>
                                    
                                    <br />
                                    <span class="style6"><span class="style5">
                                    <br />
                                    </span>
                                    </span>
                                </td>
								<td>
							        &nbsp;</td>
						</tr>
						
						</table>
								
						
							<table> </table>
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
	
	
	<!-- hitwebcounter Code START -->
<a href="#" target="_blank">

<img src="http://hitwebcounter.com/counter/counter.php?page=5284651&style=0027&nbdigits=6&type=ip&initCount=0" title="easily put counter" Alt="easily put counter"   border="0" >

</a><br/>
<!-- hitwebcounter.com --><a href="#" title="Website Traffic" 
target="_blank" style="font-family: Geneva, Arial, Helvetica, sans-serif; 
font-size: 9px; color: #908C86; text-decoration: underline ;"><strong>Unique 
    Visitors</strong>
</a>   
  

  
	
	
	
	<!-- END Wrapper -->
	<!-- Footer -->
	<div id="footer"><div id="Div1"><a href="http:///www.smarthit.co.in"><img src="css/images/logo.png" / align="right"></a>
        <br />
        <span lang="en-us"><span class="style13"  style="font-family: Arial, Helvetica, sans-serif; font-variant: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; display: inline !important; float: none;">
        &nbsp; </span><span class="style24"  
            style="font-family: Arial, Helvetica, sans-serif; font-variant: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; display: inline !important; float: none;">
        Copyright © 2014-15, smarthit Group. All Rights Reserved.</span><span 
            class="style24">&nbsp;&nbsp;
        </span>
        </span>
	</div>
	<!-- END Footer -->
    </form>
</body>

</html>
