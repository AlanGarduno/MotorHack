<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ajax.aspx.cs" Inherits="MotorHack.ajax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="bootstrap/scripts/jquery.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <input type="button" value="Clic" onclick="pedir_datos()" />
    <div id="html">
    
    </div>
    </form>
</body>
    <script type="text/javascript">

        function pedir_datos(){
            jQuery("#html").html("Procesando...");
            jQuery.ajax({
                url: "otro.aspx",

            }).success(function (resultado) {
                if (resultado === "correcto") {
                    alert("Usuario logueado");
                    location.href = "Index.aspx";
                } else {
                    alert("Usuario y/o contraseña incorrecta");
                }
                jQuery("#html").html(resultado);
            });
        }

    </script>
</html>
