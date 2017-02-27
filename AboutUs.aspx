<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AboutUs.aspx.cs" Inherits="AboutUs" %>

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
        .style7
        {
            width: 62%;
            height: 179px;
        }
        .style8
        {
            width: 54%;
            height: 128px;
        }
        .style9
        {
            width: 16px;
        }
        .style10
        {
            height: 29px;
        }
        .style11
        {
            height: 29px;
            width: 17px;
        }
        .style12
        {
            width: 17px;
        }
        .style13
        {
            color: #FF0000;
        }
        .style14
        {
            text-decoration: underline;
        }
        .style15
        {
            width: 79%;
            height: 160px;
        }
        .style16
        {
            color: #0099FF;
            font-weight: bold;
        }
        .style17
        {
            font-weight: bold;
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
        .style22
        {
            text-decoration: underline;
            color: #CC0099;
            font-weight: bold;
        }
        .style23
        {
            width: 887px;
            height: 69px;
        }
        .style24
        {
            color: #FFFFFF;
            font-weight: bold;
        }
        .style25
        {
            color: #FFFFFF;
            font-weight: bold;
            font-style: normal;
        }
        .style26
        {
            color: #CC0099;
        }
        .style27
        {
            text-decoration: underline;
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
									<h3>About Us </h3>									
								</div>												
								<table>
								<tr>
								<td class="style3">
								    <br />
                                    <span class="style18" lang="en-us">Overview</span><br class="style19" />
                                    &nbsp;<p class="style23">
                                        In this competitive era, organizations have to be fast but very careful in 
                                        taking decisions regarding operations of the organization. Business decisions 
                                        are only as<span lang="en-us">&nbsp; </span>&nbsp;good as the information on which they 
                                        are based. A correct decision opens the door to competitive advantage and a host 
                                        of other benefits, allowing companies to substantially enhance bottom-line 
                                        profitability.
                                        <br />
                                    </p>
                                    <span class="style18">What is Business Intelligence?</span>
                                    <br />
                                    <br />
                                    <p class="style21">
                                        &quot;Business Intelligence is a set of methodologies, processes, architectures, and 
                                        technologies that transform raw data into meaningful and useful information used 
                                        to enable more effective strategic, tactical, and operational insights and 
                                        decision-making.&quot; In<a target="_blank" href="http://www.gartner.com/newsroom/id/856714"> 2009 
                                        Gartner paper </a>predicted about business intelligence: &quot;Because of lack of 
                                        information, processes, and tools, through 2012, more than 35 percent of the top 
                                        5,000 global companies will regularly fail to make insightful decisions about 
                                        significant changes in their business and markets.&quot;
                                    </p>
                                  
                                    <span class="style18">What is VRS (Variance Rover System)?</span><span 
                                        lang="en-us"> <a target="_blank" href="http://ijret.org/Volumes/V03/I01/IJRET_110301060.pdf">
                                    for more detail click here...</a></span><br />
                                    <br />
                                    <p class="style21">
                                        VRS is a <span class="style26">“<span class="style14">Smart Web Analytical Tool</span>” </span>
                                        developed using Data Mining Algorithms. The Variance Rover System (VRS) mainly 
                                        focused on the large data sets obtained from online web visiting&nbsp;<span 
                                            lang="en-us">and </span>categorizing this into clusters according some 
                                        similarity <span lang="en-us">and</span> the process of predicting customer 
                                        behavior <span lang="en-us">and</span> selecting actions to influence that 
                                        behavior to benefit the company, so as to take optimized and beneficial 
                                        decisions of business expansion<span 
                                            lang="en-us">.</span></p>
                                    <span class="style18" lang="en-us">Objectives<br />
                                    <br />
                                    </span>
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
                                    <br />
                                    <span class="style6"><span class="style5">
                                    <br />
                                    <span class="style18" lang="en-us">What VRS Offers ??<br />
                                    </span></span>
                                    <br class="style5" />
                                    </span>
                                    <p class="style21">
                                        VRS<span lang="en-us"> </span>&nbsp;has being built up to help companies in a wide 
                                        range of industries leverage business-critical information across the enterprise 
                                        - an essential first step in making decisions that are intelligent and timely. 
                                        Our business intelligence solutions include reporting, analytics, dashboards, 
                                        data mining and statistics. Our solution provides tools in the hands of senior 
                                        management of your organization to make decisions based on statistical reports 
                                        provided by VRS. VRS enable users to interactively analyze multidimensional data 
                                        from multiple perspectives. For example, all sales offices are rolled up to the 
                                        sales department or sales division to anticipate sales trends. In contrast, the 
                                        drill-down is a technique that allows users to navigate through the details. For 
                                        instance, users can access to the sales by individual products that make up a 
                                        region’s sales.
                                        <br />
                                    </p>
                                    <br />
                                    <span class="style18">
                                    <br />
                                    Benefits of Using VRS </span>
                                    <br />
                                    <br />
                                    <table class="style7">
                                        <tr>
                                            <td class="style11">
                                                <span lang="en-us">1 </span>
                                            </td>
                                            <td class="style10">
                                                Dashboard based Key Performance Indicators</td>
                                        </tr>
                                        <tr>
                                            <td class="style12">
                                                <span lang="en-us">2</span></td>
                                            <td>
                                                Graphics representation of the important data.
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style12">
                                                <span lang="en-us">3</span></td>
                                            <td>
                                                Data consolidation from multiple locations of organization and single view 
                                                presentation.
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style12">
                                                <span lang="en-us">4</span></td>
                                            <td>
                                                Helps in making Strategic decisions.
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style12">
                                                <span lang="en-us">5</span></td>
                                            <td>
                                                Alignment of the business processes to address the changing market conditions.
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style12">
                                                <span lang="en-us">6</span></td>
                                            <td>
                                                Benchmarking and measuring business performance.
                                            </td>
                                        </tr>
                                    </table>
                                    <br />
                                    <span class="style18" lang="en-us">Developed By</span><span class="style6"><span class="style5"><br />
                                    </span>
                                    <br class="style5" />
                                    </span>
                                    <span class="style26">Students of Final Year B.E Computer have developed this 
                                    tool and have <span class="style27">hosted this website for study purpose.</span></span><span 
                                        class="style13">
                                    <br />
                                    <br />
                                    </span>
                                    <table class="style15">
                                        <tr>
                                            <td>
                                                <span class="style16" lang="en-us">Developers</span><span class="style6" 
                                                    lang="en-us"> </span>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style17">
                                                <span class="style17" lang="en-us">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ms. Gauri Sanjay Kalekar</span><b>&nbsp;</b></td>
                                        </tr>
                                        <tr>
                                            <td class="style17">
                                                <span class="style17" lang="en-us">&nbsp;&nbsp; </span>&nbsp;<span class="style17" 
                                                    lang="en-us">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ms. Aditi Prakash Mulmule</span></td>
                                        </tr>
                                        <tr>
                                            <td class="style17">
                                                <span class="style17" lang="en-us">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Mr. Akshay Arvind Pujari</span><b>&nbsp;</b></td>
                                        </tr>
                                        <tr>
                                            <td class="style17">
                                                <span class="style17" lang="en-us">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Mr. Abhilash Ajay Ugaonkar</span><b>&nbsp;</b></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <span class="style16" lang="en-us">Guided By </span>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <span lang="en-us">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span><span class="style17" lang="en-us">
                                                Asst.Prof Nilesh V Alone </span><b>&nbsp;(Head of The Computer Department<span 
                                                    lang="en-us"> at</span> </b>
                                                <b>GES’s R.H.SAPAT COEMSR, Nashik.)
                                                </b>
                                            </td>
                                        </tr>
                                    </table>
                                    &nbsp;<br />
                                    <br />
                                    <span class="style16">Contact Us:</span> <span class="style22">
                                    smartvrs@gmail.com</span>
                                </td>
								<td>
							        &nbsp;</td>
						</tr>
						            <tr>
                                        <td class="style3">
                                            &nbsp;</td>
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
	</div>
	<!-- END Wrapper -->
	<!-- Footer -->
	<div id="footer"><div id="Div1"><a href="http:///www.smarthit.co.in"><img src="css/images/logo.png" / align="right"></a>
	<span lang="en-us"><span class="style4" 
            
            style="font-family: Arial, Helvetica, sans-serif; font-style: normal; font-variant: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; display: inline !important; float: none;">
        &nbsp;
        <br />
        <br />
        <span class="style24">&nbsp; Copyright © 2014-15, smarthit Group. All Rights 
        Reserved.</span></span><span 
            class="style25">&nbsp;&nbsp;
        </span>
        </span>
	
	</div>
	
	
	<!-- END Footer -->
    </form>
</body>


</html>
