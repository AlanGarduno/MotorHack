<%@ Page Title="" Language="C#" MasterPageFile="~/Nosotros/Nosotros.Master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="MotorHack.Nosotros.Contacto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenedor_nosotros" runat="server">
   
    <div class="container v-center">
        <div class="row">
            <div class="col-md-12">
                <h1 class="text-center">Contáctanos</h1>
                <hr>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-9">
              <form runat="server" id="frmLogin" class="col-md-10 col-md-offset-1 col-xs-12 col-xs-offset-0">
                <div class="row form-group">
                    <div class="col-sm-3">
                        <asp:TextBox type="text" class="form-control" id="nombre" name="nombre" placeholder="Nombre:" required="" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="row form-group">
                    <div class="col-sm-5">
                        <asp:TextBox  type="email" class="form-control" id="txtcorreo" name="correo" placeholder="Correo Electrónico:" required="" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-sm-5">
                        <asp:TextBox type="text" class="form-control" id="txttelefono" MaxLength="10" name="tel" placeholder="Telefono:" required="" runat="server"></asp:TextBox>
                        <br />
                    </div>
                    <div class="col-sm-10">
                        <asp:TextBox  type="text" class="form-control" id="txtdescripcion" name="descripcion" placeholder="Comentarios:" MaxLength="500" required="" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="row form-group">
                    
                </div>
                <div class="row form-group">
                    <div class="col-sm-10">
                        <asp:Button ID="btnContactar" class="btn btn-default btn-lg pull-right" Text="Contactar" OnClick="btnContactar_Click" runat="server"/>
                    </div>
                </div>
                  </form>
            </div>
            <div class="col-sm-3 pull-right">
                <address>
              <strong>Taxqueña</strong><br>
              Av. Taxqueña 1620, Col. Paseos de Taxqueña, Del. Coyoacán,
              C.P. 04249.<br>
              Ciudad de México, Distrito Federal.<br>
              Tel: 56127492
            </address>
                <address>
              <strong>Correo Electrónico</strong><br>
              <a href="mailto:#">motorhack0@gmail.com</a>
            </address>
            </div>
        </div>
    </div>

    <!--Staff-->
     <div class="container v-center">
        <div class="row" style="padding-top:50px;">
            <div class="col-md-12">
                <h1 class="text-center">Equipo de Trabajo</h1>
                <hr>
            </div>
         </div>
     </div>
    <div class="row">
      <div class="col-sm-6 col-md-3">
        <div class="thumbnail" style="height:500px;">
            <img src="../Imagenes/Staff/COHEN.jpg" class="img-circle" />
          <div class="caption">
            <h3>Cohen Quintana Rogelio</h3>
            <a href="https://www.facebook.com/roge.cohen" class="thumbnail"><img src="../Imagenes/Botones/Facebook.jpg" class="btn btn-round btn-clear btn-facebook"></a>
            <a href="https://twitter.com/r_cohen11" class="thumbnail"><img src="../Imagenes/Botones/Twitter.png" class="btn btn-round btn-clear btn-twitter"/></a>
          </div>
        </div>
      </div>
      <div class="col-sm-6 col-md-3">
        <div class="thumbnail" style="height:500px;">
            <img src="../Imagenes/Staff/ALAN.jpg" class="img-circle" />
          <div class="caption">
            <h3>Garduño Velazquez Alan</h3>
            <a href="https://www.facebook.com/129388189923a?fref=ts" class="thumbnail"><img src="../Imagenes/Botones/Facebook.jpg" class="btn btn-round btn-clear btn-facebook"></a>
             <a href="https://twitter.com/LRD_AGV" class="thumbnail"><img src="../Imagenes/Botones/Twitter.png" class="btn btn-round btn-clear btn-twitter"/></a>
          </div>
        </div>
      </div>
      <div class="col-sm-6 col-md-3">
        <div class="thumbnail" style="height:500px;">
            <img src="../Imagenes/Staff/ALVARO.jpg" class="img-circle" />
          <div class="caption">
            <h3>Rodriguez Muñoz Álvaro</h3>
            <a href="https://www.facebook.com/isshin.asakura.7?fref=ts" class="thumbnail"><img src="../Imagenes/Botones/Facebook.jpg" class="btn btn-round btn-clear btn-facebook"></a>
            <a href="#" class="thumbnail"> <img src="../Imagenes/Botones/Twitter.png" class="btn btn-round btn-clear btn-twitter"/></a>
          </div>
        </div>
      </div>
      <div class="col-sm-6 col-md-3">
        <div class="thumbnail" style="height:500px;">
            <img src="../Imagenes/Staff/EDGAR.jpg" class="img-circle" />
          <div class="caption">
            <h3>Villanueva Reyes Edgar Jafet</h3>
            <a href="https://www.facebook.com/edgar.train?fref=ts" class="thumbnail"><img src="../Imagenes/Botones/Facebook.jpg" class="btn btn-round btn-clear btn-facebook"></a> 
            <a href="https://twitter.com/SPARTAN0011700" class="thumbnail"><img src="../Imagenes/Botones/Twitter.png" class="btn btn-round btn-clear btn-twitter"/></a>
          </div>
        </div>
      </div>
    </div>

    <section>
        <object id="FlashID" classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" width="550" height="200">
                  <param name="movie" value="../Media/IForma.swf" />
                  <param name="quality" value="high" />
                  <param name="wmode" value="opaque" />
                  <param name="swfversion" value="15.0.0.0" />
                  <!-- Esta etiqueta param indica a los usuarios de Flash Player 6.0 r65 o posterior que descarguen la versión más reciente de Flash Player. Elimínela si no desea que los usuarios vean el mensaje. -->
                  <param name="expressinstall" value="Scripts/expressInstall.swf" />
        <object type="application/x-shockwave-flash" data="../Media/IForma.swf" width="550" height="200">
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

    <script src="../bootstrap/scripts/jquery.scrollTo.min.js"></script>
    <script src="../bootstrap/scripts/jquery.scrollTo.js"></script>
 </asp:Content>
