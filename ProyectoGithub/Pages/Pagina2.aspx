<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pagina2.aspx.cs" Inherits="ProyectoGithub.Pages.Pagina2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Noticias del Clima en los Ultimos 10 años</h1>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="True" CssClass="table">
        <Columns>
            <asp:BoundField DataField="anho" HeaderText="Año" />
            <asp:BoundField DataField="evento" HeaderText="Evento" />
            <asp:BoundField DataField="lugar" HeaderText="Ubicación" />
            <asp:BoundField DataField="impacto" HeaderText="Impacto" />
        </Columns>
    </asp:GridView>

</asp:Content>
