<%@ Page Title="" Language="C#" MasterPageFile="~/Administradores/Administrador.Master" AutoEventWireup="true" CodeBehind="AgregarProductos.aspx.cs" Inherits="MotorHack.Administradores.AgregarProductos" %>
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
                <li><a href="#">Agregar Productos</a></li>
			</ul>
    <div id="almacen1">
        <h3>Ingrese los datos del almacen al que iran los productos</h3>
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Nº de Almacen"></asp:Label>
            <asp:TextBox ID="txtnAlmacen" CssClass="text text-center" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label7" runat="server" Text="Nombre del Almacen"></asp:Label>
            <asp:TextBox ID="txtNameAlmacen" CssClass="text text-center" runat="server"></asp:TextBox>
        </div><div class="form-group">
            <asp:Label ID="Label9" runat="server" Text="Ubicacion"></asp:Label>
            <asp:TextBox ID="txtLocation" CssClass="text text-center" runat="server"></asp:TextBox>
        </div>
    </div>
    <br />
    <div id="entradas1">
        <h3>Ingrese los datos principales de la entrada del producto</h3>
        <div class="form-group">
            <asp:Label ID="Label10" runat="server" Text="Cantidad"></asp:Label>
            <asp:TextBox ID="txtCantidad" CssClass="text text-center" runat="server"></asp:TextBox>
        </div><div class="form-group">
            <asp:Label ID="Label11" runat="server" Text="Fecha"></asp:Label>
            <asp:TextBox ID="txtDate" CssClass="text text-center" runat="server"></asp:TextBox>
        </div>
    </div>
    <br />
    <div id="productos1">
        <h3>Ingrese los datos del producto</h3>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Nombre del Producto"></asp:Label>
            <asp:TextBox ID="txtNameProd" CssClass="text text-center" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="Precio"></asp:Label>
            <asp:TextBox ID="txtPrice" CssClass="text text-center" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label4" runat="server" Text="Costo"></asp:Label>
            <asp:TextBox ID="txtCosto" CssClass="text text-center" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label5" runat="server" Text="Nº de Catalogo"></asp:Label>
            <asp:TextBox ID="txtnCat" CssClass="text text-center" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label6" runat="server" Text="Estado"></asp:Label>
            <asp:TextBox ID="txtState" CssClass="text text-center" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label8" runat="server" Text="Descripcion"></asp:Label>
            <asp:TextBox ID="txtDesc" CssClass="text text-center" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="form-group">
        <asp:Button ID="btnAgregarProd" CssClass="btn btn-primary" runat="server" Text="Agregar Producto" />
    </div>
</asp:Content>
