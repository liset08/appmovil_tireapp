using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;


//Cambia por el nombre del proyecto
using WebApplication1.Models;

namespace webServiceLocal.Controllers
{
    [RoutePrefix("api/incidencia")]
    public class IncidenciaController : ApiController
    {

        //Cambia esta variable por el nombre que se generó por el modelo
        private TireappsEntities dd = new TireappsEntities();

        [HttpPost]
        [Route("create")]
        public HttpResponseMessage create(Incidencia incidencia)
        {

            try
            {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
                dd.Incidencia.Add(incidencia);
                dd.SaveChanges();
                return response;

            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadGateway);
            }
        }
    }
}
