<%@ Page Title="" Language="C#" MasterPageFile="~/Clientes/Cliente.Master" AutoEventWireup="true" CodeBehind="IndexClientes.aspx.cs" Inherits="MotorHack.Clientes.IndexClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenedor_clientes" runat="server">
    
    <div class="row" style="padding-top:80px;">

        <!--Bujias -->      
                    
                       <div class="col-sm-6 col-md-3" >
                                <div class="thumbnail" style="height:400px;">
                                     <div class="caption">
                                        <h3>Bujias</h3>
                                         <img src="../Imagenes/Bujias/bujias.jpg" class="img-responsive" />
                                           <div class="container" style="margin-top: 60px;">  
                                         <asp:Button ID="verBujias1" Class="btn btn-danger" OnClick="verBujias" runat="server" Text="Ver más" />                                                
                                          </div>
                                     </div>
                                </div>
                              </div>
                   
<!--Filtros de Aceite-->    
                       <div class="col-sm-6 col-md-3" >
                                <div class="thumbnail" style="height:400px;">
                                     <div class="caption">
                                        <h3>Filtros de Aceite</h3>
                                         <img src="../Imagenes/Filtros%20de%20Aceite/filtro-de-aceite-.jpg" class="img-responsive" />
                                           <div class="container" style="margin-top: 60px;">  
                                         <asp:Button ID="verFAc" Class="btn btn-danger" OnClick="verFiltrosAceite" runat="server" Text="Ver más" />                                                
                                          </div>
                                     </div>
                                </div>
                              </div>
   <!--Filtros de Aire-->    
                       <div class="col-sm-6 col-md-3">
                                <div class="thumbnail" style="height:400px;">
                                     <div class="caption">
                                        <h3>Filtros de Aire</h3>
                                         <img src="../Imagenes/Filtros%20de%20Aire/filtro%20de%20aire.jpg"  class="img-responsive"  />
                                           <div class="container" style="margin-top: 60px;">  
                                         <asp:Button ID="verFaire" Class="btn btn-danger" OnClick="verFiltrosAire" runat="server" Text="Ver más" />                                                
                                          </div>
                                     </div>
                                </div>
                              </div>
        
        <!--Aceites-->    
                       <div class="col-sm-6 col-md-3">
                                <div class="thumbnail" style="height:400px;">
                                     <div class="caption">
                                        <h3>Aceites</h3>
                                         <img src="../Imagenes/Aceites/cambiodeaceite.jpeg" class="img-responsive" />
                                           <div class="container" style="margin-top: 60px;">  
                                         <asp:Button ID="verAceit" Class="btn btn-danger" OnClick="verAceites" runat="server" Text="Ver más" />                                                
                                          </div>
                                     </div>
                                </div>
                              </div>
            </div>
        <div class="row" >
            <!--Neumaticos-->    
                       <div class="col-sm-6 col-md-3">
                                <div class="thumbnail" style="height:400px;">
                                     <div class="caption">
                                        <h3>Neumaticos</h3>
                                         <img src="../Imagenes/Llantas/neumaticos.jpg" class="img-responsive" />
                                           <div class="container" style="margin-top: 60px;">  
                                         <asp:Button ID="verNem" Class="btn btn-danger" OnClick="verNeumaticos" runat="server" Text="Ver más" />                                                
                                          </div>
                                     </div>
                                </div>
                              </div>
          <!--Rines-->    
                       <div class="col-sm-6 col-md-3">
                                <div class="thumbnail" style="height:400px;">
                                     <div class="caption">
                                        <h3>Rines</h3>
                                         <img src="../Imagenes/Rines/rin.jpg" class="img-responsive"/>
                                           <div class="container" style="margin-top: 60px;">  
                                         <asp:Button ID="verRin" Class="btn btn-danger" OnClick="verRines" runat="server" Text="Ver más" />                                                
                                          </div>
                                     </div>
                                </div>
                              </div>
          <!--Calipers-->    
                       <div class="col-sm-6 col-md-3">
                                <div class="thumbnail" style="height:400px;">
                                     <div class="caption">
                                        <h3>Calipers</h3>
                                         <img src="../Imagenes/Calipers/caliper.jpg" class="img-responsive" />
                                           <div class="container" style="margin-top: 60px;">  
                                         <asp:Button ID="verCalip" Class="btn btn-danger" OnClick="verCalipers" runat="server" Text="Ver más" />                                                
                                          </div>
                                     </div>
                                </div>
                              </div>
         <!--Amortiguadores-->    
                       <div class="col-sm-6 col-md-3">
                                <div class="thumbnail" style="height:400px;">
                                     <div class="caption">
                                        <h3>Amortiguadores</h3>
                                         <img src="../Imagenes/Amortiguadores/amortiguadores.jpeg" class="img-responsive"/>
                                           <div class="container" style="margin-top: 60px;">  
                                         <asp:Button ID="verAmort" Class="btn btn-danger" OnClick="verAmortiguadores" runat="server" Text="Ver más" />                                                
                                          </div>
                                     </div>
                                </div>
                              </div>
            </div>
        <div class="row" >
         <!--Suspensiones-->    
                       <div class="col-sm-6 col-md-3">
                                <div class="thumbnail" style="height:400px;">
                                     <div class="caption">
                                        <h3>Suspensiones</h3>
                                         <img src="../Imagenes/Suspensiones/susp-mcpherson-foto.jpg" class="img-responsive"/>
                                           <div class="container" style="margin-top: 60px;">  
                                         <asp:Button ID="verSusp" Class="btn btn-danger" OnClick="verSuspensiones" runat="server" Text="Ver más" />                                                
                                          </div>
                                     </div>
                                </div>
                              </div>
            <!--Anticongelantes-->    
                       <div class="col-sm-6 col-md-3">
                                <div class="thumbnail" style="height:400px;">
                                     <div class="caption">
                                        <h3>Anticongelantes</h3>
                                         <img src="../Imagenes/Anticongelantes/anticongelante.jpg" class="img-responsive"/>
                                           <div class="container" style="margin-top: 60px;">  
                                         <asp:Button ID="verAntico" Class="btn btn-danger" OnClick="verAnticongelantes" runat="server" Text="Ver más" />                                                
                                          </div>
                                     </div>
                                </div>
                              </div>
            <!--BombasGasolina-->    
                       <div class="col-sm-6 col-md-3">
                                <div class="thumbnail" style="height:400px;">
                                     <div class="caption">
                                        <h3>Bombas de Gasolina</h3>
                                         <img src="../Imagenes/Bomba%20de%20gasolina/bombagas.jpg" class="img-responsive"/>
                                           <div class="container" style="margin-top: 60px;">  
                                         <asp:Button ID="verBgas" Class="btn btn-danger" OnClick="verBombasGasolina" runat="server" Text="Ver más" />                                                
                                          </div>
                                     </div>
                                </div>
                              </div>


    
    </div>

</asp:Content>