<%@ Page Title="" Language="C#" MasterPageFile="~/header.Master" AutoEventWireup="true" CodeBehind="login_page.aspx.cs" Inherits="WebApplication1.login_page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph" runat="server">
    <!DOCTYPE html>
<html>
<head>


	<title>Login</title>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
<!--===============================================================================================-->	
	<link rel="icon" type="image/png" href="Login_v13/images/icons/favicon.ico"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="Login_v13/vendor/bootstrap/css/bootstrap.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="Login_v13/fonts/font-awesome-4.7.0/css/font-awesome.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="Login_v13/fonts/Linearicons-Free-v1.0.0/icon-font.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="Login_v13/fonts/iconic/css/material-design-iconic-font.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="Login_v13/vendor/animate/animate.css">
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="Login_v13/vendor/css-hamburgers/hamburgers.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="Login_v13/vendor/animsition/css/animsition.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="Login_v13/vendor/select2/select2.min.css">
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="Login_v13/vendor/daterangepicker/daterangepicker.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="Login_v13/css/util.css">
	<link rel="stylesheet" type="text/css" href="Login_v13/css/main.css">
<!--===============================================================================================-->
    <script type="text/javascript">
    function check() {
        var username = TextBox1.Text;
        PageMethods.CheckUserName(username, function (response) {
            var message = document.getElementById("message");
            if (response) {
                Response.redirect("index.aspx");
            }
            else {
                Response.redirect("login_page.aspx");
            }
        });
    };
 
    function ClearMessage() {
        document.getElementById("message").innerHTML = "";
    };
</script>
</head>
<body>


        <form>
	
	<div class="limiter">
		<div class="container-login100">
			<div class="login100-more" style="background-image: url('Login_v13/images/bg-01.jpg');"></div>

			<div class="wrap-login100 p-l-50 p-r-50 p-t-72 p-b-50">
				<form class="login100-form validate-form">

                    

					<span class="login100-form-title p-b-59">
						Login
					</span>

                    <div class="wrap-input100 validate-input">
						<span class="label-input100">Username</span>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
						<span class="focus-input100"></span>
					</div>

					<div class="wrap-input100 validate-input">
						<span class="label-input100">Password</span>
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
						<span class="focus-input100"></span>
					</div>

					<div class="container-login100-form-btn">
						<div class="wrap-login100-form-btn">
							<div class="login100-form-bgbtn"></div>
                            <asp:Button ID="Button2" runat="server" Text="Login"/>
						</div>
                        <div class="wrap-login100-form-btn">
							<div class="login100-form-bgbtn"></div>
						    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
						</div>
                        <div class="wrap-login100-form-btn">
							<div class="login100-form-bgbtn"></div>
                            <asp:Button ID="Button1" runat="server" Text="Signup" OnClick="Button1_Click" />
						</div>
					</div>
				</form>
			</div>
		</div>
	</div>
	
<!--===============================================================================================-->
	<script src="vendor/jquery/jquery-3.2.1.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/animsition/js/animsition.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/bootstrap/js/popper.js"></script>
	<script src="vendor/bootstrap/js/bootstrap.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/select2/select2.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/daterangepicker/moment.min.js"></script>
	<script src="vendor/daterangepicker/daterangepicker.js"></script>
<!--===============================================================================================-->
	<script src="vendor/countdowntime/countdowntime.js"></script>
<!--===============================================================================================-->
	<script src="js/main.js"></script>

            </form>
</body>
</html>
</asp:Content>
