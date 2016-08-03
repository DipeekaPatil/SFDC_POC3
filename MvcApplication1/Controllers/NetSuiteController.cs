using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft;
using Newtonsoft.Json;
using System.IO;
using System.Web;

namespace MvcApplication1.Controllers
{
    public class NetSuiteController : ApiController
    {
        // GET api/NetSuite
       
        // POST api/NetSuite
        [HttpPost]
        public HttpResponseMessage CreateCustomer(Customer customer)
        {
            if (customer != null)
            {
                try
                {
                    string custJson = JsonConvert.SerializeObject(customer, Formatting.Indented);
                    string folder = HttpContext.Current.Server.MapPath("~/App_Data");
                    string path =Path.Combine(folder,"Customer.txt");
                    if (File.Exists(path))
                    {
                        File.AppendAllText(path, custJson);
                    }
                  
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
                }
                return Request.CreateResponse(HttpStatusCode.Created);
            }
            return Request.CreateErrorResponse(HttpStatusCode.PreconditionFailed, "customer object is null");
        }

        [HttpPost]
        public HttpResponseMessage CreateSOW(SOW sow)
        {
            if (sow != null)
            {
                try
                {
                    string custJson = JsonConvert.SerializeObject(sow, Formatting.Indented);
                    string folder = HttpContext.Current.Server.MapPath("~/App_Data");
                    string path = Path.Combine(folder, "sow.txt");
                    if (File.Exists(path))
                    {
                        File.AppendAllText(path, custJson);
                    }

                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
                }
                return Request.CreateResponse(HttpStatusCode.Created);
            }
            return Request.CreateErrorResponse(HttpStatusCode.PreconditionFailed, "sow object is null");
        }


        // PUT api/NetSuite/5
     
    }
}