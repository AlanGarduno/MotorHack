<%@ Page Title="" Language="C#" MasterPageFile="~/Administradores/Administrador.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="MotorHack.Administradores.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul class="breadcrumb">
				<li>
					<i class="icon-home"></i>
					<a href="Index.aspx">Home</a> 
					<i class="icon-angle-right"></i>
				</li>
				<li><a href="#">Productos</a></li>
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

    <br/>

                <div class="form-group">
                    <asp:Button ID="btnAddProductos" runat="server" Text="Agregar Productos" CssClass="btn btn-primary" OnClick="btnAddProductos_Click" />
                    
                    <asp:Button ID="btnDevoluciones" runat="server" Text="Ingresar Devoluciones" CssClass="btn btn-primary" OnClick="btnDevoluciones_Click" />
				</div>
    
    <br/>

			<div class="row-fluid sortable">		
				<div class="box span12">
					<div class="box-header" data-original-title="productos">
						<h2><i class="halflings-icon align-justify"></i><span class="break"></span>Productos</h2>
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
                          <asp:Repeater ID="Productos1" runat="server">
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
</asp:Content>
