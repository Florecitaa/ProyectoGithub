using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoGithub.Pages
{
    public partial class Pagina2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var noticias = ObtenerNoticiasDelClima();
                GridView1.DataSource = noticias;
                GridView1.DataBind();
            }
        }

        private List<NoticiaClimatica> ObtenerNoticiasDelClima()
        {
            return new List<NoticiaClimatica>
            {
                new NoticiaClimatica { Anho = 2006, Evento = "Huracán Katrina", Lugar = "EE.UU.", Impacto = "Inundaciones masivas y destrucción" },
                new NoticiaClimatica { Anho = 2010, Evento = "Ola de calor", Lugar = "Rusia", Impacto = "Miles de muertes, incendios forestales" },
                new NoticiaClimatica { Anho = 2012, Evento = "Huracán Sandy", Lugar = "EE.UU.", Impacto = "Daños graves en la costa este" },
                new NoticiaClimatica { Anho = 2006, Evento = "Huracán Katrina", Lugar = "EE.UU.", Impacto = "Inundaciones masivas y destrucción" },
                new NoticiaClimatica { Anho = 2010, Evento = "Ola de calor", Lugar = "Rusia", Impacto = "Miles de muertes, incendios forestales" },
                new NoticiaClimatica { Anho = 2012, Evento = "Huracán Sandy", Lugar = "EE.UU.", Impacto = "Daños graves en la costa este" },
                new NoticiaClimatica { Anho = 2006, Evento = "Huracán Katrina", Lugar = "EE.UU.", Impacto = "Inundaciones masivas y destrucción" },
                new NoticiaClimatica { Anho = 2010, Evento = "Ola de calor", Lugar = "Rusia", Impacto = "Miles de muertes, incendios forestales" },
                new NoticiaClimatica { Anho = 2012, Evento = "Huracán Sandy", Lugar = "EE.UU.", Impacto = "Daños graves en la costa este" }

            };
        }

        public class NoticiaClimatica
        {
            public int Anho { get; set; }
            public string Evento { get; set; }
            public string Lugar { get; set; }
            public string Impacto { get; set; }
        }

    }
}