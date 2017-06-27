<%@ Page Title="" Language="C#" MasterPageFile="~/Administradores/Administrador.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="MotorHack.Administradores.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul class="breadcrumb">
				<li>
					<i class="icon-home"></i>
					<a href="Index.aspx">Home</a> 
					<i class="icon-angle-right"></i>
				</li>
				<li><a href="#">Usuarios</a></li>
			</ul>

			<div class="row-fluid sortable">		
				<div class="box span12">
					<div class="box-header" data-original-title="usuarios y clientes">
						<h2><i class="halflings-icon user"></i><span class="break"></span>Usuarios</h2>
						<div class="box-icon">
							<a href="#" class="btn-minimize"><i class="halflings-icon chevron-up"></i></a>
							<a href="#" class="btn-close"><i class="halflings-icon remove"></i></a>
						</div>
					</div>
                    <div class="box-content">
                        <div class="table-responsive">
						<table class="table table-striped table-bordered table-condensed  bootstrap-datatable datatable">
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
</asp:Content>
