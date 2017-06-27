<%@ Page Title="" Language="C#" MasterPageFile="~/Administradores/Administrador.Master" AutoEventWireup="true" CodeBehind="IngresarDevoluciones.aspx.cs" Inherits="MotorHack.Administradores.IngresarDevoluciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul class="breadcrumb">
				<li>
					<i class="icon-home"></i>
					<a href="Index.aspx">Home</a> 
					<i class="icon-angle-right"></i>
				</li>
				<li>
                    <a href="Productos.aspx">Productos</a>
                    <i class="icon-angle-right"></i>
				</li>
                <li><a href="#">Ingresar Devoluciones</a></li>
			</ul>
    <br />
    <h1>Aqui se hacen las devoluciones</h1>
    <div class="form-group">
        <asp:Label ID="Label1" runat="server" Text="Nº de Almacen"></asp:Label>
        <asp:TextBox ID="txtAlmacN" CssClass="text text-center" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label ID="Label2" runat="server" Text="Nº de Producto"></asp:Label>
        <asp:TextBox ID="txtProdN" CssClass="text text-center" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label ID="Label3" runat="server" Text="Cantidad"></asp:Label>
        <asp:TextBox ID="txtCant" CssClass="text text-center" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label ID="Label4" runat="server" Text="Costo"></asp:Label>
        <asp:TextBox ID="txtCosto" CssClass="text text-center" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label ID="Label5" runat="server" Text="Motivo"></asp:Label>
        <asp:TextBox ID="txtMotivo" CssClass="text text-center" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Button ID="btnAgregarDev" CssClass="btn btn-primary" runat="server" Text="Ingresar Devolucion" />
    </div>
</asp:Content>
