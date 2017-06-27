<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Olvidaste_Contrasena.aspx.cs" Inherits="MotorHack.Olvidaste_Contrasena" %>

<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <meta name="description" content="">
    <meta name="author" content="">
    <link rel="icon" href="Imagenes/Escudo/IconoMH.ico">

    <title>Contraseña Olvidada</title>

    <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet" />

    <link href="sticky-footer.css" rel="stylesheet">

    <script src="../../assets/js/ie-emulation-modes-warning.js"></script>

  </head>

  <body>


      <form runat="server">
    <div class="container">
      <div class="page-header">
        <h1 style="padding-left:400px;">MotorHack<img src="Imagenes/Escudo/MH.png" class="top-right" style="padding-right:20px;"/></h1>
      </div>
        <p>Parece que haz olvidado tu contraseña, por favor introduce el correo con el cual te registraste para mandar la recuperación de tu contraseña.</p>
    </div>

          <br />
          <br />

      <div class="row form-group" style="padding-left:110px;">
                    <div class="col-sm-5">
                        <asp:TextBox ID="txtCorreo" CssClass="form-group" required="" runat="server"></asp:TextBox>
                    </div>
          </div>

          <br />

      <div class="row" style="padding-left:120px;">
          <asp:Button ID="btnEnviar" CssClass="btn btn-danger" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
          <br />
          <br />
           <span ><a href="Index.aspx" data-toggle="modal" onclick="fnRegresar();" data-target="#InicioSesion">Regresar</a></span>
      </div>

          </form>
     
     
      <script src="bootstrap/scripts/bootstrap.min.js"></script>
      <script src="bootstrap/scripts/jquery.min.js"></script>
      <script type="text/javascript">
          function fnRegresar() {
          jQuery("#txtCorreo").removeProp("required");
          }

      </script>

   </body>
</html>
