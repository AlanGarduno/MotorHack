<%@ Page Title="" Language="C#" MasterPageFile="~/Clientes/Cliente.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="MotorHack.Clientes.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenedor_clientes" runat="server">


                  <div class="row" style="margin-top:60px;">
        <asp:ScriptManager EnablePageMethods="true" ID="scripmn" runat="server"></asp:ScriptManager>
        <asp:Repeater ID="Listado" runat="server">
            <HeaderTemplate></HeaderTemplate>
            <ItemTemplate>
                <div class="col-sm-6 col-md-4">
                    <div class="thumbnail">
                        <div class="caption">
                            IdProducto:<label ID="lblnProd"><%#DataBinder.Eval(Container.DataItem, "id_producto")%></label>
                            Nombre:<label><%#DataBinder.Eval(Container.DataItem, "nombre_producto")%></label>
                            Cantidad:<label><%#DataBinder.Eval(Container.DataItem, "cantidad")%></label>
                            Precio:<label><%#DataBinder.Eval(Container.DataItem, "precio")%></label>
                            Fecha:<label><%#DataBinder.Eval(Container.DataItem,"fecha")%></label>
                            <br />

                        </div>
                            Total:<label><%#DataBinder.Eval(Container.DataItem,"total") %></label>
                       </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
  
                      <asp:Label ID="lblTotal" runat="server" Text="Total"></asp:Label>

                      <br />
                      <br />
                      <div>
                          <asp:Button ID="btnComprar" CssClass="btn btn-danger" runat="server" Text="Comprar" OnClick="btnComprar_Click" />
                      </div>
                      
                      <br />
                      <div>
                          <asp:Button ID="btnCancelar" CssClass="btn btn-danger" runat="server" Text="Cancelar Orden" OnClick="btnCancelar_Click" />
                      </div>

    </div>

    <script type="text/javascript">
        function idProd(i_prod) {
            jQuery.ajax({
                type: "GET",
                url: "carrito.aspx",
                data: {i_prod:},
                succes: function (resultado) {
                    alert(resultado);
                }
            })
        }
    </script>

</asp:Content>
