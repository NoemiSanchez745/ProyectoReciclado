<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PáginaMostrarGramos.aspx.cs" Inherits="WASimuladorSiu.PáginaMostrarGramos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>
        <asp:PlaceHolder ID="Title" runat="server">
        </asp:PlaceHolder>
    </title>
    <link href="Estilos/main.css" rel="stylesheet" />
    <asp:PlaceHolder ID="head" runat="server">
    </asp:PlaceHolder>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center"><image src="img/Head.PNG" width="71%"></div>
        
        <%--<h3>Usuario</h3>                    
        <br/>
        <h3>ING. DE SISTEMAS INFORMÁTICOS</h3>--%>
        <div>   
            <div class="col">
                    <h3>Usuario</h3>  
                    <br/>
                    <h3>ING. DE SISTEMAS INFORMÁTICOS</h3>
                    </div>
                    <div class="col" style="text-align:center;">
                    <h3>Manual de Usuario</h3>  
                    <br/>
                    <h3>SEDE ACADÉMICA COCHABAMBA</h3>
                    </div>
                    <div class="clearfi"></div>
        </div>
        <div class="wrapper">
            <div class="menu">   
                <ul>
                    <li><a href="#">Social</a></li>
                    <li><a href="#">Material</a></li>
                    <li><a href="#">Académica</a></li>
                    <li><a href="#">Recursos</a></li>
                    <li><a href="#">Tip</a></li>
                    <li><a href="#"></a></li>
                </ul>
            </div>
            <div class="clear"></div>
                <div class="content">   
            <asp:PlaceHolder ID="ContentBody" runat="server"> 
                <br />
                <br />
                <br />
                <br />
              
                <%--<div class="v-line">   
                <table style="text-align:center;">
                  <tr>
                    <th>Reciclado</th>
                     <%-- <hr style="text-align: right; margin-right: 0px;">
                    <th>Información</th>
                  </tr>
                  <tr>
                    <td width="50">Ana</td>
                    <td>Ortiz</td>
                  </tr>
                  <tr>
                    <td>Pedro</td>
                    <td>Duarte</td>
                  </tr>
                </table>
                  </div>--%>

                <div class="columnar">
                    <h4>Reciclado</h4>
                    
                    </div>
                    <div class="columnar" style="text-align:center;">
                    <h2>Grid o Tabla</h2>
                    Desplegar Datos</div>
                    <div class="clearfix"></div>
           
                    </asp:PlaceHolder>
            </div>
            <div class="clear"></div>
            <div class="footer">
                <h2></h2>
            </div>
        </div>
    </form>
</body>
</html>
