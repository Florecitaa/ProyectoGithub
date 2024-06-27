<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pagina1.aspx.cs" Inherits="ProyectoGithub.Pages.Pagina1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<%--    titulo del clima 
    tabla clima de la semana 
    tabla con eventos del clima del anio 
    hyperlink a la paginna 2 
    en la pagina 2 eventos del clima importantes en los 10 anios --%>

    <h1> El clima </h1>
    <hr />
    <table>
  <tr>
    <td>Provincias</td>
    <td>San jose</td>
    <td>Limon</td>
    <td>Puntarenas</td>
    <td>Cartago</td>
  </tr>
  
  <tr>
    <td>Clima esta semana</td>
    <td>10</td>
    <td>11</td>
    <td>12</td>
    <td>13l</td>
  </tr>
         <tr>
   <td>Clima la semana pasada</td>
   <td>10</td>
   <td>11</td>
   <td>12</td>
   <td>13l</td>
 </tr>
  <tr>
    <td>pronostico de lluvia</td>
    <td>bajo</td>
    <td>bajo</td>
    <td>bajo</td>
    <td>bajo</td>
  </tr>
         <tr>
  <td>Cantones con posibilidad de lluvia</td>
  <td>San jose</td>
  <td>Limon</td>
  <td>Puntarenas</td>
  <td>Cartago</td>
</tr>
</table>

 

</asp:Content>
