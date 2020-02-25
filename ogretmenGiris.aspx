<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ogretmenGiris.aspx.cs" Inherits="Yaz_Okulu_Otomasyonu.ogretmenGiris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MY | Yaz Okulu Otomasyonu</title>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
<!--===============================================================================================-->	
	<link rel="icon" type="image/png" href="images/icons/favicon.ico"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/bootstrap/css/bootstrap.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/font-awesome-4.7.0/css/font-awesome.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/Linearicons-Free-v1.0.0/icon-font.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/animate/animate.css">
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="vendor/css-hamburgers/hamburgers.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/select2/select2.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="css/util.css">
	<link rel="stylesheet" type="text/css" href="css/main.css">
</head>
<body>
    <div class="limiter">
		<div class="container-login100" style="background-image: url('images/img-01.jpg');">
			<div class="wrap-login100 p-t-190 p-b-30">
				<form class="login100-form validate-form" runat="server">
					<div class="login100-form-avatar">
						<img src="images/logo.jpg" alt="AVATAR">
					</div>

					<span class="login100-form-title p-t-20 p-b-45">
						Öğretmen Girişi
					</span>

					<div class="wrap-input100 validate-input m-b-10" data-validate = "Username is required">
                        <asp:TextBox ID="txtTcKimlikNo" CssClass="input100" runat="server">Tc Kimlik No</asp:TextBox>
                        <span class="focus-input100"></span>
						<span class="symbol-input100">
							<i class="fa fa-user"></i>
						</span>
					</div>

					<div class="wrap-input100 validate-input m-b-10" data-validate = "Password is required">
                        <asp:TextBox ID="txtSifre" CssClass="input100" runat="server" TextMode="Password">Şifre</asp:TextBox>
						<span class="focus-input100"></span>
						<span class="symbol-input100">
							<i class="fa fa-lock"></i>
						</span>
					</div>

					<div class="container-login100-form-btn p-t-10">
						
                        <asp:Button ID="btnGiris" CssClass="login100-form-btn" runat="server" Text="Giriş Yap" OnClick="btnGiris_Click" />
					<br />
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="" BackColor="Red" BorderColor="White"></asp:Label>
                    </div>
                     

					<div class="text-center w-full p-t-25 p-b-230">
						<a href="#" class="txt1">
							Şifremi Unuttum
						</a>
					</div>

					<div class="text-center w-full">
						<a class="txt1" href="#">
							Sisteme Kayıt Ol
							<i class="fa fa-long-arrow-right"></i>						
						</a>
					</div>
                   
				</form>
			</div>
		</div>
	</div>
	
	

	
<!--===============================================================================================-->	
	<script src="vendor/jquery/jquery-3.2.1.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/bootstrap/js/popper.js"></script>
	<script src="vendor/bootstrap/js/bootstrap.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/select2/select2.min.js"></script>
<!--===============================================================================================-->
	<script src="js/main.js"></script>
</body>
</html>
