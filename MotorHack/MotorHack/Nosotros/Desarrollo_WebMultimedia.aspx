<%@ Page Title="" Language="C#" MasterPageFile="~/Nosotros/Nosotros.Master" AutoEventWireup="true" CodeBehind="Desarrollo_WebMultimedia.aspx.cs" Inherits="MotorHack.Nosotros.Desarrollo_WebMultimedia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenedor_nosotros" runat="server">
    
    <div class="row" style= "padding-top:40px;">
        <div class="jumbotron" style= "padding-top:30px;">
           <div class="container">
                <h1>Desarrollo Web y Multimedia</h1>
                    <p>Animaciones en Adobe Flash CS6 y lenguaje HTML5.<br /></p>
                        <!--Animaciones-->
           </div>
       </div>
        <section class="center">
            <object id="FlashID" classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" width="550" height="400" class="center-block">
                  <param name="movie" value="../Media/IMovimiento.swf" />
                  <param name="quality" value="high" />
                  <param name="wmode" value="opaque" />
                  <param name="swfversion" value="15.0.0.0" />
                  <param name="expressinstall" value="Scripts/expressInstall.swf" />
                  <object type="application/x-shockwave-flash" data="../Media/IMovimiento.swf" width="550" height="400">
                    <param name="quality" value="high" />
                    <param name="wmode" value="opaque" />
                    <param name="swfversion" value="15.0.0.0" />
                    <param name="expressinstall" value="Scripts/expressInstall.swf" />
                    <div>
                      <h4>El contenido de esta página requiere una versión más reciente de Adobe Flash Player.</h4>
                      <p><a href="http://www.adobe.com/go/getflashplayer"><img src="http://www.adobe.com/images/shared/download_buttons/get_flash_player.gif" alt="Obtener Adobe Flash Player" width="112" height="33" /></a></p>
                    </div>
              </object>
            </object>
        </section>
          <div class="panel panel-primary">
                        <div class="panel-body">
                            Profesor:
                        </div>
                  <div class="panel-footer">Armando Briseño Saquedo</div>
          </div>
   </div>

</asp:Content>
