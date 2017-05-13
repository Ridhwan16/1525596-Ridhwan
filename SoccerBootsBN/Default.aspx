    <%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SoccerBootsBN.Default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
  

    <!-- #region Jssor Slider Begin -->
    <!-- Generator: Jssor Slider Maker -->
    <!-- Source: http://www.jssor.com -->
    <!-- This code works with jquery library. -->
    <script src="js/jquery-1.11.3.min.js" type="text/javascript"></script>
    <script src="js/jssor.slider-23.0.0.mini.js" type="text/javascript"></script>
    <link href="StyleSheet/Banner_Style.css" rel="stylesheet" />
    <script src="js/JavaScript.js"></script>
    
    
    <div id="jssor_1" style="position:relative;margin:0 auto;top:0px;left:0px;width:600px;height:300px;overflow:hidden;visibility:hidden;">
        <!-- Loading Screen -->
        <div data-u="loading" style="position:absolute;top:0px;left:0px;background-color:rgba(0,0,0,0.7);">
            <div style="filter: alpha(opacity=70); opacity: 0.7; position: absolute; display: block; top: 0px; left: 0px; width: 100%; height: 100%;"></div>
            <div style="position:absolute;display:block;background:url('img/loading.gif') no-repeat center center;top:0px;left:0px;width:100%;height:100%;"></div>
        </div>
        <div data-u="slides" style="cursor:default;position:relative;top:0px;left:0px;width:600px;height:300px;overflow:hidden;">
            <div>
                <img data-u="image" src="img/01.jpg" alt="nike boots" />
                <div data-u="thumb">Nike</div>
                <!--image taken from https://www.netolocker.net/-->
                </div>
            <div>
          
                <img data-u="image" src="img/02.jpg" alt="adidas boots" />
                <div data-u="thumb">Adidas</div>
                <!--image taken from https://www.netolocker.net/-->
            </div>
            <div>
                <img data-u="image" src="img/03.jpg" alt="puma boots" />
                <div data-u="thumb">Puma</div>
                <!--image taken from https://www.unisportstore.com -->
            </div>
            
        </div>
 
        <!-- Thumbnail Navigator -->
        <div data-u="thumbnavigator" class="jssort09-600-45" style="position:absolute;bottom:0px;left:0px;width:600px;height:45px;">
            <div style="position:absolute;top:0;left:0;width:100%;height:100%;background-color:#000;filter:alpha(opacity=40.0);opacity:0.4;"></div>
            <!-- Thumbnail Item Skin Begin -->
            <div data-u="slides" style="cursor: default;">
                <div data-u="prototype" class="p">
                    <div data-u="thumbnailtemplate" class="t"></div>
                </div>
            </div>
            <!-- Thumbnail Item Skin End -->
        </div>
        <!-- Bullet Navigator -->
        <div data-u="navigator" class="jssorb01" style="bottom:16px;right:16px;">
            <div data-u="prototype" style="width:12px;height:12px;"></div>
        </div>
        <!-- Arrow Navigator -->
        <span data-u="arrowleft" class="jssora05l" style="top:0px;left:8px;width:40px;height:40px;" data-autocenter="2"></span>
        <span data-u="arrowright" class="jssora05r" style="top:0px;right:8px;width:40px;height:40px;" data-autocenter="2"></span>
    </div>
    <!-- #endregion Jssor Slider End -->
    <div id="homeproduct">
    <table>
        <Caption>Nike Products</Caption>
        <tr>
          <td><img src="img/productimage/nikehypervenom.jpg" alt=""/> 
              <p>Nike Hypervenom</p> 
              <p>$240</p>
          </td>
            <td><img src="img/productimage/nikehypervenom2.jpg" alt=""/> 
              <p>Nike Hypervenom 2</p> 
              <p>$270</p>
          </td>
            <td><img src="img/productimage/nikemecurial.jpg" alt=""/> 
              <p>Nike Mecurial</p> 
              <p>$250</p>
          </td>
          <td><img src="img/productimage/Niketiempo.jpg" alt=""/> 
              <p>Nike Tiempo</p> 
              <p>$230</p>
          </td>
        </tr>
     </table>
     <table>
        <Caption>Adidas Products</Caption>
        <tr>
          <td><img src="img/productimage/adidasace.jpg" alt=""/> 
              <p>Adidas ace</p> 
              <p>$200</p>
          </td>
            <td><img src="img/productimage/adidasace151.jpg" alt=""/> 
              <p>Adidas ace v151</p> 
              <p>$245</p>
          </td>
            <td><img src="img/productimage/adidasadipure.jpg" alt=""/> 
              <p>Adidas adi pure</p> 
              <p>$230</p>
          </td>
          <td><img src="img/productimage/adidasdecathlon.jpg" alt=""/> 
              <p>Adidas Decathlon</p> 
              <p>$240</p>
          </td>
        </tr>
     </table>
        <table>
        <Caption>Puma Products</Caption>
        <tr>
          <td><img src="img/productimage/pumaclassic.jpg" alt=""/> 
              <p>Puma Classic</p> 
              <p>$230</p>
          </td>
            <td><img src="img/productimage/pumaevopowervigor.jpg" alt=""/> 
              <p>Puma Evopower Vigor 1</p> 
              <p>$220</p>
          </td>
            <td><img src="img/productimage/pumaevospeed17.jpg" alt=""/> 
              <p>Puma Evospeed 17</p> 
              <p>$240</p>
          </td>
          <td><img src="img/productimage/pumaswanmoor.jpg" alt=""/> 
              <p>Puma Swanmoor</p> 
              <p>$250</p>
          </td>
        </tr>
     </table>
     </div>

</asp:Content>
