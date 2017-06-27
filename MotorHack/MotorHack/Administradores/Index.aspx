<%@ Page Title="" Language="C#" MasterPageFile="~/Administradores/Administrador.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="MotorHack.Administradores.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul class="breadcrumb">
				<li>
					<i class="icon-home"></i>
					<a href="Index.aspx">Home</a> 
				</li>
			</ul>


    <div class="row-fluid sortable">
				<div class="box span12">
					<div class="box-header">
						<h2><i class="halflings-icon align-justify"></i><span class="break"></span>Productos de Baja Existencia</h2>
						<div class="box-icon">
							<a href="#" class="btn-minimize"><i class="halflings-icon chevron-up"></i></a>
							<a href="#" class="btn-close"><i class="halflings-icon remove"></i></a>
						</div>
					</div>
                    <div class="box-content">
                        <div class="table-responsive">
						<table class="table table-bordered table-condensed table-striped">
							  <thead>
								  <tr>
									  <th>N° de Producto</th>
								      <th>Nombre</th>
								      <th>Precio de Venta</th>
								      <th>Costo</th>
                                      <th>N° de Categoria</th>
                                      <th>Existencia</th>
                                      <th>Estado del Producto</th>
                                      <th>Descripcion</th>                                          
								  </tr>
							  </thead>   
							  <tbody>
								<asp:Repeater ID="ProductosBE" runat="server">
                              <HeaderTemplate></HeaderTemplate>
                              <ItemTemplate>
							<tr>
                                <td class="center"><%#DataBinder.Eval(Container.DataItem,"id_producto") %></td>
								<td class="center"><%#DataBinder.Eval(Container.DataItem,"nombre") %></td>
								<td class="center"><%#DataBinder.Eval(Container.DataItem,"precio_venta") %></td>
								<td class="center"><%#DataBinder.Eval(Container.DataItem,"precio_compra") %></td>
								<td class="center"><%#DataBinder.Eval(Container.DataItem,"id_catalogo") %></td>
                                <td class="center"><%#DataBinder.Eval(Container.DataItem,"existencia") %></td>
                                <td class="center"><%#DataBinder.Eval(Container.DataItem,"estado") %></td>
                                <td class="center"><%#DataBinder.Eval(Container.DataItem,"descripcion") %></td>
                            </tr>
                                  </ItemTemplate>
                          </asp:Repeater>
							 </tbody>
						 </table>
                            </div>  
					</div>
                </div><!--/span-->
			</div><!--/row-->
			
        <div class="row-fluid sortable">
				<div class="box span12">
					<div class="box-header">
						<h2><i class="halflings-icon user"></i><span class="break"></span>Nuevos Usuarios</h2>
						<div class="box-icon">
							<a href="#" class="btn-minimize"><i class="halflings-icon chevron-up"></i></a>
							<a href="#" class="btn-close"><i class="halflings-icon remove"></i></a>
						</div>
					</div>
                    <div class="box-content">
                        <div class="table-responsive">
						<table class="table table-bordered table-condensed table-striped">
							  <thead>
								  <tr>
									  <th>N° de Usuario</th>
								      <th>Usuario</th>
								      <th>Contraseña</th>
								      <th>Correo</th>
                                      <th>Tipo de Usuario</th>
                                      <th>Estado</th>
                                      <th>N° de Cliente</th>
								      <th>Nombre Completo</th>
                                      <th>RFC</th>                                          
								  </tr>
							  </thead>   
							  <tbody>
								<asp:Repeater ID="Usuarios1" runat="server">
                              <HeaderTemplate></HeaderTemplate>
                              <ItemTemplate>
							<tr>
                                <td class="center"><%#DataBinder.Eval(Container.DataItem,"id_usuario") %></td>
								<td class="center"><%#DataBinder.Eval(Container.DataItem,"usuario") %></td>
								<td class="center"><%#DataBinder.Eval(Container.DataItem,"contrasena") %></td>
								<td class="center"><%#DataBinder.Eval(Container.DataItem,"correo") %></td>
								<td class="center"><%#DataBinder.Eval(Container.DataItem,"tipo_usuario") %></td>
                                <td class="center"><%#DataBinder.Eval(Container.DataItem,"estado") %></td>
                            </tr>
                                  </ItemTemplate>
                          </asp:Repeater>
                              <asp:Repeater ID="Clientes" runat="server">
                              <HeaderTemplate></HeaderTemplate>
                              <ItemTemplate>
							<tr>
                                <td class="center"><%#DataBinder.Eval(Container.DataItem,"id_cliente") %></td>
								<td class="center"><%#DataBinder.Eval(Container.DataItem,"nombre_completo") %></td>
								<td class="center"><%#DataBinder.Eval(Container.DataItem,"rfc") %></td>
							</tr>
                                  </ItemTemplate>
                          </asp:Repeater>
							 </tbody>
						 </table>
                            </div>  
					</div>
                </div><!--/span-->
			</div><!--/row-->


    <div class="row-fluid sortable">
				<div class="box span6">
					<div class="box-header">
						<h2><i class="halflings-icon list-alt"></i><span class="break"></span>Ventas Mensuales</h2>
						<div class="box-icon">
							<a href="#" class="btn-minimize"><i class="halflings-icon chevron-up"></i></a>
							<a href="#" class="btn-close"><i class="halflings-icon remove"></i></a>
						</div>
					</div>
					<div class="box-content">
							<div id="piechart" style="height:450px"></div>
					</div>
				</div>
			</div><!--/row-->
		
			<hr>
</asp:Content>
