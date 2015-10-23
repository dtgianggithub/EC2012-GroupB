using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TMDT_WebAPI.Filters;
using TMDT_WebAPI.Models;

namespace TMDT_WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [IdentityBasicAuthentication]
    [Authorize]
    public class OrderController : ApiController
    {
        static readonly IOrderRepository repository = new OrderRepository();

        public HttpResponseMessage CreateResponse<T>(HttpStatusCode statusCode, T data)
        {
            return Request.CreateResponse(statusCode, data);
        }

        public HttpResponseMessage CreateResponse(HttpStatusCode httpStatusCode)
        {
            return Request.CreateResponse(httpStatusCode);
        }

        [HttpGet]
        [Route("orders")]
        public HttpResponseMessage GetAllOrder([FromUri] string supplier_key)
        {
            return CreateResponse(HttpStatusCode.OK, repository.GetAll(supplier_key));
        }


        [HttpPost]
        [Route("orders/start_shipping")]
        public HttpResponseMessage AddOrderShipping([FromBody] OrderShipping sv)
        {
            repository.Add(sv);
            return CreateResponse(HttpStatusCode.OK);
        }
    }
}
