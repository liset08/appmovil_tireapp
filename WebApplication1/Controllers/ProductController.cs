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
    [RoutePrefix("api/product")]
public class ProductController : ApiController
{
    private TireappsEntities dd = new TireappsEntities();

        [HttpGet]
        [Route("findall")]
        public HttpResponseMessage findAll()
        {
            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject
                  (dd.Grupoempresa.ToList()));
                response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                return response;
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadGateway);
            }

        }

       [HttpGet]
        [Route("finda/{id}")]
        public HttpResponseMessage find(int id)
        {
            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject
                  (dd.Grupoempresa.SingleOrDefault(p => p.GrupoEmpresa_ID == id)));
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
        public HttpResponseMessage create(Grupoempresa grupoempresa)
        {
            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                dd.Grupoempresa.Add(grupoempresa);
                dd.SaveChanges();
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
            dd.Grupoempresa.Remove(dd.Grupoempresa.SingleOrDefault(p => p.GrupoEmpresa_ID == id));
dd.SaveChanges();
                return response;
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadGateway);
            }

        }


        [HttpPut]
        [Route("update")]
        public HttpResponseMessage update(Grupoempresa grupoempresa)
        {
            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                var grupEmpresa = dd.Grupoempresa.SingleOrDefault(p => p.GrupoEmpresa_ID == grupoempresa.GrupoEmpresa_ID);
                grupEmpresa.nombre = grupoempresa.nombre;
                grupEmpresa.estado = grupoempresa.estado;

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
