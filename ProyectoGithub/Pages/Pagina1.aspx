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
    <td>Clima de el lunes</td>
    <td>74°</td>
    <td>79°</td>
    <td>78°</td>
    <td>73°</td>
  </tr>
        <tr>
  <td>Clima de el martes</td>
  <td>72°</td>
  <td>78°</td>
  <td>79°</td>
  <td>74°</td>
</tr>
        <tr>
  <td>Clima de el miercoles</td>
  <td>75°</td>
  <td>81°</td>
  <td>81°</td>
  <td>73°</td>
</tr>
        <tr>
  <td>Clima de el jueves</td>
  <td>70°</td>
  <td>81°</td>
  <td>78°</td>
  <td>70°</td>
</tr>
        <tr>
  <td>Clima de el viernes</td>
  <td>72°</td>
  <td>79°</td>
  <td>83°</td>
  <td>71°</td>
</tr>
        <tr>
  <td>Clima de el sabado</td>
  <td>73°</td>
  <td>79°</td>
  <td>85°</td>
  <td>73°</td>
</tr>
        <tr>
  <td>Clima de el domingo</td>
  <td>74°</td>
  <td>77°</td>
  <td>78°</td>
  <td>71°</td>
</tr>
         <tr>
   <td>Temperatura mas baja la semana pasada</td>
   <td>69°</td>
   <td>76°</td>
   <td>74°</td>
   <td>68°</td>
 </tr>
  <tr>
    <td>pronostico de lluvia</td>
    <td>Alto</td>
    <td>bajo</td>
    <td>Medio</td>
    <td>bajo</td>
  </tr>
         <tr>
  <td>Cantones con posibilidad de lluvia</td>
  <td>Puriscal</td>
  <td>Siquirres</td>
  <td>Osa</td>
  <td>Paraiso</td>
</tr>
</table>
    <hr />
      <hr />
      <hr />
      <hr />

  <table>
       <tr>
                <th>Fecha</th>
                <th>Evento</th>
                <th>Región</th>
                <th>Intensidad</th>
     <tr>
                <td>15/06/2024</td>
                <td>Tormenta Tropical</td>
                <td>Pacífico Central</td>
                <td>Moderada</td>
             
            </tr>
            <tr>
                <td>22/07/2024</td>
                <td>Ola de Calor</td>
                <td>Guanacaste</td>
                <td>Alta</td>
           
            </tr>
            <tr>
                <td>10/08/2024</td>
                <td>Inundaciones</td>
                <td>Caribe</td>
                <td>Severa</td>
               
            </tr>
            <tr>
                <td>05/09/2024</td>
                <td>Sismo</td>
                <td>Valle Central</td>
                <td>Moderado</td>
             
            </tr>
            <tr>
                <td>20/10/2024</td>
                <td>Sequía</td>
                <td>Pacífico Norte</td>
                <td>Grave</td>
               
            </tr>
            </tr>

  </table>

    <h2>
        Te gustaria aprender mas de los eventos del clima mas importantes en los 10 años ? 
    </h2>
  <a href="Pagina2.Aspx">Da click aqui</a>

</asp:Content>
