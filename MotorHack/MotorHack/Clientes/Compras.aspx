<%@ Page Title="" Language="C#" MasterPageFile="~/Clientes/Cliente.Master" AutoEventWireup="true" CodeBehind="Compras.aspx.cs" Inherits="MotorHack.Clientes.Compras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenedor_clientes" runat="server">
 

    <div class="row" style="padding-top:80px;">
    <h1>Su compra se ha realizado exitosamente</h1>
    <br />
  
    <asp:Button ID="btnNotaVenta" CssClass="btn btn-danger" runat="server" Text="Imprimir nota de venta" OnClick="btnNotaVenta_Click" />

   </div> 
</asp:Content>
