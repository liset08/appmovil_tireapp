//Jordan 
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using WebApplication1.Models;

namespace webServiceLocal.Controllers
{

    [RoutePrefix("api/lectura")]
    public class LecturaController : ApiController
    {
        private TireappsEntities dd = new TireappsEntities();

        [HttpGet]
        [Route("getAll")]
        public HttpResponseMessage getAll()
        {
            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(dd.Lectura.ToList()));
                response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                return response;
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadGateway);
            }

        }


        

        [HttpPost]
        [Route("create")]
        public HttpResponseMessage create(Lectura lectura)
        {

            try
            {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
                dd.Lectura.Add(lectura);
                dd.SaveChanges();
                return response;

            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadGateway);
            }
        }

        [HttpPost]
        [Route("asignNeumatic")]
        public HttpResponseMessage asignNeumatic(Camion_neumaticos camion_neumaticos)
        {

            try
            {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
                dd.Camion_neumaticos.Add(camion_neumaticos);
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
