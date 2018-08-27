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

    [RoutePrefix("api/camion")]
    public class CamionController : ApiController
    {
        private TireappsEntities dd = new TireappsEntities();

        [HttpGet]
        [Route("getAll")]
        public HttpResponseMessage getAll()
        {
            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(dd.Camion.ToList()));
                response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                return response;
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadGateway);
            }

        }


        [HttpGet]
        [Route("getByPlaca/{placa}")]
        public HttpResponseMessage getByPlaca(string placa) {
            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(
                    dd.Camion.SingleOrDefault(p=>p.placa == placa)));
                response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                return response;

            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadGateway);
            }
        }




        [HttpGet]
        [Route("getAllbyCompany/{id}")]
        public HttpResponseMessage getAllbyCompany(int id)
        {
            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(
                    dd.Camion.Where(p => p.empresa_id == id)));
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
        public HttpResponseMessage create(Camion camion) {

            try {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
                dd.Camion.Add(camion);
                dd.SaveChanges();
                return response;

            }
            catch {
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
