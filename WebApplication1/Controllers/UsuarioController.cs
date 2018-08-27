
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

    [RoutePrefix("api/usuario")]
    public class UsuarioController : ApiController
    {
        private TireappsEntities dd = new TireappsEntities();

        [HttpPost]
        [Route("login")]
        public HttpResponseMessage login(User user) {

            
            try
            {
                var model = dd.Usuarios.SingleOrDefault(p => p.username == user.username);
                var model2 = dd.Usuarios.Where(p=> p.username == user.username && p.password == user.pass);

                var response = new HttpResponseMessage(HttpStatusCode.OK);
                
                response.Content = new StringContent(JsonConvert.SerializeObject(model2));
                response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                return response;
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadGateway);
            }
        }

        [HttpGet]
        [Route("findall")]
        public HttpResponseMessage findall()
        {


            try
            {

                var response = new HttpResponseMessage(HttpStatusCode.OK);

                response.Content = new StringContent(JsonConvert.SerializeObject(dd.Usuarios.ToList()));
                response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");


                return response;
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadGateway);
            }
        }

        [HttpGet]
        [Route("getAll")]
        public HttpResponseMessage getAll()
        {
            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(dd.Usuarios.ToList()));
                response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                return response;
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadGateway);
            }

        }




        /*
        [HttpGet]
        [Route("identifyRole/{id}")]
        public HttpResponseMessage identifyRoleById(int id) {

            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                response.Content = 
            }
            catch
            {
            
            }

        }*/


    }
}
