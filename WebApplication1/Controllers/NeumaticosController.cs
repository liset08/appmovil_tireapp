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
    [RoutePrefix("api/neu")]
    public class NeumaticosController : ApiController
    {
        private TireappsEntities db = new TireappsEntities();

        [HttpGet]
        [Route("find")]
        public HttpResponseMessage Buscar()
        {
            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(db.Neumatico.ToList()));
                response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                return response;
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadGateway);
            }

        }

        [HttpGet]
        [Route("getByDot/{dot}")]
        public HttpResponseMessage getByDot(String dot)
        {
            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(
                    db.Neumatico.SingleOrDefault(p => p.dot == dot)));
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
        public HttpResponseMessage Create(Neumatico neumatico)
        {

            try
            {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
                db.Neumatico.Add(neumatico);
                db.SaveChanges();
                return response;

            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadGateway);
            }
        }

        [Route("delete/{id}")]
        public HttpResponseMessage delete(int id)
        {
            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                db.Neumatico.Remove(db.Neumatico.SingleOrDefault(p => p.Neumatico_id == id));
                db.SaveChanges();
                return response;
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadGateway);
            }

        }

        [HttpPut]
        [Route("update")]
        public HttpResponseMessage update(Neumatico neumatico)
        {
            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                var neumaticos = db.Neumatico.SingleOrDefault(p => p.Neumatico_id == neumatico.Neumatico_id);
                neumaticos.marca = neumatico.marca;
                neumaticos.estado = neumatico.estado;
                neumaticos.modelo = neumatico.modelo;
                neumaticos.observacion = neumatico.observacion;
                neumaticos.perfil = neumatico.perfil;
                neumaticos.precio = neumatico.precio;
                neumaticos.fecreg = neumatico.fecreg;
                neumaticos.indice_carga = neumatico.indice_carga;
                neumaticos.altura_max = neumatico.altura_max;
                neumaticos.altura_min = neumatico.altura_min;
                neumaticos.presion_max = neumatico.presion_max;
                neumaticos.presion_min = neumatico.presion_min;
                neumaticos.temperatura = neumatico.temperatura;
                neumaticos.tag = neumatico.tag;
                neumaticos.dot = neumatico.dot;
                neumaticos.desgaste = neumatico.desgaste;
                neumaticos.usureg = neumatico.usureg;
                neumaticos.usumod = neumatico.usumod;
                neumaticos.indice_velocidad = neumatico.indice_velocidad;
                neumaticos.empresa_id = neumatico.empresa_id;
                neumaticos.cant_reencauche = neumatico.cant_reencauche;
                neumaticos.observacion = neumatico.observacion;
                 neumaticos.estado = neumatico.estado;


                db.SaveChanges();
                return response;

            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadGateway);
            }

        }

    }

}
