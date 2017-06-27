<%@ Page Title="" Language="C#" MasterPageFile="~/Clientes/Cliente.Master" AutoEventWireup="true" CodeBehind="Anticongelantes.aspx.cs" Inherits="MotorHack.Clientes.Productos.Anticongelantes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenedor_clientes" runat="server">

        <div class="row" style="margin-top:60px;">
        <asp:ScriptManager EnablePageMethods="true" ID="scripmn" runat="server"></asp:ScriptManager>
        <asp:Repeater ID="Listado" runat="server">
            <HeaderTemplate></HeaderTemplate>
            <ItemTemplate>
                <div class="col-sm-6 col-md-4">
                    <div class="thumbnail">
                        <div class="caption">
                            <h3><%#DataBinder.Eval(Container.DataItem, "nombre")%></h3>
                            Precio:<label><%#DataBinder.Eval(Container.DataItem, "precio_venta")%>   </label>
                            Stock: <label><%#DataBinder.Eval(Container.DataItem, "existencia")%>  </label>
                            <img src="../../Imagenes_Productos/<%#DataBinder.Eval(Container.DataItem, "nombre_imagen")%>" class="img-responsive" />
                            <div class="container" style="margin-top: 60px;">                                                 
                            </div>
                            Desccripcion:<label><%#DataBinder.Eval(Container.DataItem,"descripion")%>  </label>
                            <br />
                            <input type="number" value="1" id="txtCantidad_<%#DataBinder.Eval(Container.DataItem, "id_producto")%>" />
                            <input type="button" class="btn btn-primary" value="Agregar a carrito" onclick="agregarCarrito('<%#DataBinder.Eval(Container.DataItem, "precio_venta")%>    ','<%#DataBinder.Eval(Container.DataItem, "nombre")%>    ', 'txtCantidad_<%#DataBinder.Eval(Container.DataItem, "id_producto")%>    ','<%#DataBinder.Eval(Container.DataItem, "descripion")%>    ', '<%#DataBinder.Eval(Container.DataItem, "id_producto")%>)'  ;" />

                         </div>
                       </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>

    </div>

    <script type="text/javascript">
        function agregarCarrito(precio_venta, p_nombre, p_cantidad, p_descripcion,p_id_producto) {
            t_cantidad = jQuery("#" + p_cantidad).val();

            jQuery.ajax({
                type        : "GET",
                url         : "../acciones.aspx",
                data        : { accion : "agregar_anticongelantes", id_producto: p_id_producto,nombre:p_nombre, cantidad: t_cantidad, precio:precio_venta},
                success     : function(resultado){
                    alert(resultado);
                }
            });
        }

    </script>


</asp:Content>
