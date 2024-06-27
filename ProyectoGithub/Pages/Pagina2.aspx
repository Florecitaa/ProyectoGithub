<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pagina2.aspx.cs" Inherits="ProyectoGithub.Pages.Pagina2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Noticias del Clima en los Ultimos 18 años</h1>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table">
        <Columns>
            <asp:BoundField DataField="Year" HeaderText="Año" />
            <asp:BoundField DataField="Event" HeaderText="Evento" />
            <asp:BoundField DataField="Location" HeaderText="Ubicación" />
            <asp:BoundField DataField="Impact" HeaderText="Impacto" />
        </Columns>
    </asp:GridView>

</asp:Content>
