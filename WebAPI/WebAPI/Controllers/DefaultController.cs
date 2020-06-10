using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class DefaultController : ApiController
    {
        EmployeeEntities db = new EmployeeEntities();

        public HttpResponseMessage Index()
        {
            var employees = db.tblEmployees.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, employees);
        }
    }
}
