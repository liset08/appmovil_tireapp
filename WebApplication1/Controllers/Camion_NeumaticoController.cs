using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [RoutePrefix("api/CamNeu")]

    public class Camion_NeumaticoController : ApiController
    {

        private TireappsEntities dd = new TireappsEntities();

        [HttpGet]
        [Route("getAll")]
        public HttpResponseMessage getAll()
        {
            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(dd.Camion_neumaticos.ToList()));
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
        public HttpResponseMessage create(Camion_neumaticos camion_Neumaticos)
        {

            try
            {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
                dd.Camion_neumaticos.Add(camion_Neumaticos);
                dd.SaveChanges();

                return response;

            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadGateway);
            }
        }

        [HttpGet]
        [Route("getAllbyCamion/{id}")]
        public HttpResponseMessage getAllbyCompany(int id)
        {
            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(
                    dd.Camion_neumaticos.Where(p => p.camion_id == id)));
                response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                return response;
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadGateway);
            }

        }

        [HttpDelete]
        [Route("delete/{id}")]
        public HttpResponseMessage delete(int id)
        {
            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                dd.Camion_neumaticos.Remove(dd.Camion_neumaticos.Single(p => p.neumatico_id == id));
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