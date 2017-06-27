<%@ Page Title="" Language="C#" MasterPageFile="~/Administradores/Administrador.Master" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="MotorHack.Administradores.Ventas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul class="breadcrumb">
				<li>
					<i class="icon-home"></i>
					<a href="Index.aspx">Home</a> 
					<i class="icon-angle-right"></i>
				</li>
				<li><a href="#">Ventas</a></li>
	</ul>

    <div id="dvTotVenMen">
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
							<div id="piechart" style="height:450px" onclick="fnVenMen"></div>
					</div>
				</div>
			</div><!--/row-->
        </div>
    
    <div id="dvGVentas">
    <div class="row-fluid">
				
				<div class="box" >
					<div class="box-header">
						<h2><i class="halflings-icon list-alt"></i><span class="break"></span>Ventas Mensuales por Producto</h2>
						<div class="box-icon">
							<a href="#" class="btn-minimize"><i class="halflings-icon chevron-up"></i></a>
							<a href="#" class="btn-close"><i class="halflings-icon remove"></i></a>
						</div>
					</div>
					<div class="box-content">
						 <div id="stackchart" class="center" onload="With satcking Lines" style="height:300px;"></div>
					</div>
				</div>

			</div><!--/row-->
        </div>

    <br/>

    <div id="dvTVentas">
    <div class="row-fluid sortable">		
				<div class="box span12">
					<div class="box-header" data-original-title="ventas">
						<h2><i class="halflings-icon align-justify"></i><span class="break"></span>Ventas Mensuales por Articulo</h2>
						<div class="box-icon">
							<a href="#" class="btn-minimize"><i class="halflings-icon chevron-up"></i></a>
							<a href="#" class="btn-close"><i class="halflings-icon remove"></i></a>
						</div>
					</div>
					<div class="box-content">
						<table class="table table-striped table-bordered table-condensed  bootstrap-datatable datatable">
						  <thead>
							  <tr>
								  <th>N° de Venta</th>
								  <th>Fecha de Venta</th>
								  <th>N° de Usuario</th>
                                  <th>N° de Producto</th>
								  <th>Cantidad</th>
                                  <th>Ganancia por Producto</th>
                                  <th>Ganancia Total</th>
							  </tr>
						  </thead>   
						  <tbody>
							<asp:Repeater ID="Ventas1" runat="server">
                                <HeaderTemplate></HeaderTemplate>
                                <ItemTemplate>
                                    <tr>
                                        <td class="center"><%#DataBinder.Eval(Container.DataItem,"id_venta") %></td>
								        <td class="center"><%#DataBinder.Eval(Container.DataItem,"fecha_venta") %></td>
								        <td class="center"><%#DataBinder.Eval(Container.DataItem,"id_usuario") %></td>
								    </tr>
                              </ItemTemplate>
                            </asp:Repeater>
                              <asp:Repeater ID="Clientes" runat="server">
                              <HeaderTemplate></HeaderTemplate>
                              <ItemTemplate>
							<tr>
                                <td class="center"><%#DataBinder.Eval(Container.DataItem,"id_producto") %></td>
								<td class="center"><%#DataBinder.Eval(Container.DataItem,"cantidad") %></td>
                                <td class="center"><%#DataBinder.Eval(Container.DataItem,"existencia") %></td>
                                <td class="center"><%#DataBinder.Eval(Container.DataItem,"estado") %></td>
							</tr>
                                  </ItemTemplate>
                          </asp:Repeater>
						  </tbody>
					  </table>            
					</div>
				</div><!--/span-->
			
			</div><!--/row-->
        </div>
</asp:Content>
