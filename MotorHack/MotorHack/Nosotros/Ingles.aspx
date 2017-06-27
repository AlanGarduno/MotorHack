<%@ Page Title="" Language="C#" MasterPageFile="~/Nosotros/Nosotros.Master" AutoEventWireup="true" CodeBehind="Ingles.aspx.cs" Inherits="MotorHack.Nosotros.Ingles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenedor_nosotros" runat="server">
    
    <div class="row" style= "padding-top:40px;">
        <div class="jumbotron" style= "padding-top:30px;">
           <div class="container">
                <h1>Inglés</h1>
               <video src="ImagenesNos/Comercial%20MotorHack.mp4" controls="controls" />
               <video controls="controls" width="900" height="800" class="center-block">
                    <source src="ImagenesUAp/Comercial%20MotorHack.wmv" type="video/x-ms-wmv" />
                    <source src="ImagenesNos/Comercial%20MotorHack.mp4" type="video/mp4">
                    <source src="ImagenesUAp/Comercial%20MotorHack.webm" type="video/webm">
                </video>

           </div>
       </div>
          <div class="panel panel-primary">
                        <div class="panel-body">
                            Profesor:
                        </div>
                  <div class="panel-footer">Mario Montes...</div>
          </div>
   </div>	

</asp:Content>
