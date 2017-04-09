<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LunchApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


	<!--<head>
		<title>Lunch App</title>
		<link href="lunch.css" rel="stylesheet" type="text/css">
	</head>-->

	<body>
		
			<!--<div id="nav-top">
				<div id="logo">
					<h2>Lunch App</h2>
				</div>
			
			</div>-->
		
			<div id="container-left">
				<div id="nav-left-top">
					<ul>
						<li>
							<h3><a id="create-group" href="#button" id="button1" class="button">Create new group</a></h3>
						</li>
						<li>
                            <h3><asp:Button ID="GroupButton0" runat="server" CssClass="AspButton" Text="DefaultGroup" /></h3>
						</li>
						
					
					</ul>
					
				</div>
				<div id="nav-left-bottom">
					<ul>
						<li>
                            <h3><asp:Button ID="Button2" CssClass="AspButton" runat="server" Text="profile settings" /></h3>
						</li>
					</ul>
					
				</div>
				<!--<div id = "profile-box">
					<h4>Name: Dillon</h4>
					<h4>My Orders</h4>
					<h4>My Responsibilities</h4>
					<h4>Debt</h4>
					<h4>Dues</h4>
						
				</div>-->
			</div>
		
		<div id="container-right">
		
		</div>
		
		<script   src="http://code.jquery.com/jquery-3.1.1.js"   integrity="sha256-16cdPddA6VdVInumRGo6IbivbERE8p7CQR3HzTBuELA="   crossorigin="anonymous"></script>
		
		
		<!-- script to add new group -->
		<script type="text/javascript">
		
			$( "#create-group" ).click(function() {
						$( "#nav-left-top ul" ).append('<li><h3><a href="#button" id="button1" class="button">Group</a></h3></li>');
					});
		
		
		
		</script>
	
	</body>

</asp:Content>
