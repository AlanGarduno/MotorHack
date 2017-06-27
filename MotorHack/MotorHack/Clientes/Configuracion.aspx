<%@ Page Title="" Language="C#" MasterPageFile="~/Clientes/Cliente.Master" AutoEventWireup="true" CodeBehind="Configuracion.aspx.cs" Inherits="MotorHack.Clientes.Configuracion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenedor_clientes" runat="server">

    <br />
   <br />
    <br />


    <div class="form-group">
        <h1>
            Configuracion De la Cuenta
        </h1>

        <br />
        <br />

       <h4>
           Cambiar Contraseña
       </h4>
        <br />

        <asp:Label ID="Label1" runat="server" Text="Contraseña Actual"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtContra" MaxLength="15" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Nueva Contraseña"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtNuevaContra" MaxLength="15" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Text="Confirme la nueva contraseña"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtConfirmNcontra" MaxLength="15" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnGuardarContra" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardarContra_Click" />


    </div>

    <div class="form-group">
        <h4>
            Cambiar Correo
        </h4>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Correo actual"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Nuevo Correo"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtNuevoCorreo" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Text="Confirme su nuevo correo"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtConfrimNcorreo" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnGuardarCorreo" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardarCorreo_Click" />

    </div>

    <br />


    <div class="form-group">
        <h4>
            Eliminar Cuenta
        </h4>
        <br />

       <h6>
           Escriba su correo,contraseña y su RFC, con los que se registro para eliminar su cuenta
       </h6>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Correo"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtECorreo" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Contraseña"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtEContrasena" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="RFC"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtERFC" runat="server" MaxLength="13"></asp:TextBox>

        <p>
            Se eliminara su cuenta, si en algun momento deseara volver a ingresar, necesitara registrarse de nuevo.
        </p>

        <asp:Button ID="btnEliminaCuenta" CssClass="btn btn-danger" runat="server" Text="ELIMINAR" OnClick="btnEliminaCuenta_Click" />


    </div>

</asp:Content>
