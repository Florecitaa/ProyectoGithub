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
                new NoticiaClimatica { Anho = 2017, Evento = "Huracán María", Lugar = "Puerto Rico", Impacto = "Devastación extensa, cortes de energía" },
                new NoticiaClimatica { Anho = 2019, Evento = "Incendios forestales en Australia", Lugar = "Australia", Impacto = "Incendios generalizados, pérdida significativa de vida silvestre" },
                new NoticiaClimatica { Anho = 2020, Evento = "Incendios forestales", Lugar = "EE.UU. (California)", Impacto = "Evacuaciones a gran escala, daños a la propiedad" },
                new NoticiaClimatica { Anho = 2021, Evento = "Tormenta invernal en Texas", Lugar = "EE.UU. (Texas)", Impacto = "Cortes de energía, escasez de agua" },
                new NoticiaClimatica { Anho = 2007, Evento = "Inundaciones en Reino Unido", Lugar = "Reino Unido", Impacto = "Daños extensos, miles de evacuados" },
                new NoticiaClimatica { Anho = 2008, Evento = "Ciclón Nargis", Lugar = "Birmania", Impacto = "138,000 muertes, devastación masiva" },
                /*
                new NoticiaClimatica { Anho = 2009, Evento = "Ola de calor", Lugar = "India", Impacto = "Cientos de muertes, crisis agrícola" },
                new NoticiaClimatica { Anho = 2010, Evento = "Ola de calor", Lugar = "Rusia", Impacto = "Miles de muertes, incendios forestales" },
                new NoticiaClimatica { Anho = 2011, Evento = "Terremoto y tsunami", Lugar = "Japón", Impacto = "Destrucción masiva, crisis nuclear" },
                new NoticiaClimatica { Anho = 2012, Evento = "Huracán Sandy", Lugar = "EE.UU.", Impacto = "Daños graves en la costa este" },
                new NoticiaClimatica { Anho = 2013, Evento = "Tifón Haiyan", Lugar = "Filipinas", Impacto = "Más de 6,000 muertes, destrucción total" },
                new NoticiaClimatica { Anho = 2014, Evento = "Inundaciones en Balcanes", Lugar = "Serbia, Bosnia y Herzegovina", Impacto = "Miles de evacuados, daños extensos" },
                new NoticiaClimatica { Anho = 2015, Evento = "Ciclón Pam", Lugar = "Vanuatu", Impacto = "Devastación masiva, crisis humanitaria" },
                new NoticiaClimatica { Anho = 2016, Evento = "Incendios forestales en Canadá", Lugar = "Canadá", Impacto = "Evacuaciones masivas, destrucción de viviendas" },
                new NoticiaClimatica { Anho = 2017, Evento = "Huracán María", Lugar = "Puerto Rico", Impacto = "Devastación extensa, cortes de energía" },
                new NoticiaClimatica { Anho = 2018, Evento = "Incendios forestales en Grecia", Lugar = "Grecia", Impacto = "Muertes y destrucción de propiedades" },
                new NoticiaClimatica { Anho = 2019, Evento = "Incendios forestales en Australia", Lugar = "Australia", Impacto = "Incendios generalizados, pérdida significativa de vida silvestre" },
                new NoticiaClimatica { Anho = 2020, Evento = "Incendios forestales", Lugar = "EE.UU. (California)", Impacto = "Evacuaciones a gran escala, daños a la propiedad" },
                new NoticiaClimatica { Anho = 2021, Evento = "Tormenta invernal en Texas", Lugar = "EE.UU. (Texas)", Impacto = "Cortes de energía, escasez de agua" },
                new NoticiaClimatica { Anho = 2022, Evento = "Ola de calor en Europa", Lugar = "Europa", Impacto = "Altas temperaturas récord, crisis de salud pública" },
                new NoticiaClimatica { Anho = 2023, Evento = "Inundaciones en Pakistán", Lugar = "Pakistán", Impacto = "Desplazamiento masivo, daños severos a infraestructura" }
                */
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