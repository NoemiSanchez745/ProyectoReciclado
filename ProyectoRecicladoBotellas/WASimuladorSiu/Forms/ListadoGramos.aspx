<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListadoGramos.aspx.cs" Inherits="WASimuladorSiu.Forms.ListadoGramos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styles/SListadoGramos.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <fieldset>
        <legend class="bold">Lista de Gramos</legend>
        <table class="tabla">
            <tr>
                <td>
                    <asp:Label CssClass="lblFecha" runat="server" Font-Bold="True" Text="Buscar por fecha:"></asp:Label>
                    <asp:TextBox ID="txtBusquedaFecha" TextMode="Date" CssClass="txtFecha" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label CssClass="lblHora" runat="server" Font-Bold="True" Text="Buscar por hora:"></asp:Label>
                    <asp:TextBox ID="txtBusquedaHora" CssClass="txtHora" TextMode="Time" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <asp:GridView ID="gvListaGramos" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="ContenedorID" />
                <asp:BoundField DataField="Gramos" HeaderText="GRAMOS" />
                <asp:BoundField DataField="Fecha" HeaderText="FECHA" DataFormatString="{0:d}" />
                <asp:BoundField DataField="Hora" HeaderText="HORA" DataFormatString="{0:HH:mm}" />
                <asp:BoundField DataField="UsuarioID" />
            </Columns>
        </asp:GridView>
        <table class="formulario">
            <tr>
                <td class="fila">
                    <asp:Label CssClass="lblNombre" runat="server" Font-Bold="True" Text="Usuario:"></asp:Label>
                    <asp:Label ID="lbNombre" CssClass="lbNombre" runat="server"></asp:Label>
                    <asp:Label CssClass="lblCodigo" runat="server" Font-Bold="True" Text="Código:"></asp:Label>
                    <asp:Label ID="lbCodigo" CssClass="lbCodigo" runat="server"></asp:Label>
                    <asp:Label CssClass="lblGramos" runat="server" Font-Bold="True" Text="Gramos acumulados:"></asp:Label>
                    <asp:Label ID="lbGramos" CssClass="lbGramos" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </fieldset>
</asp:Content>
