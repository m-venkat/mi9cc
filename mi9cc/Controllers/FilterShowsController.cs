using mi9cc.BusinessLayer;
using Mi9cc.JsonModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace mi9cc.Controllers
{
   // [RoutePrefix("/")]
    public class FilterShowsController : ApiController
    {
        // GET api/values
        [HttpGet]
        public String Get()
        {
            return "Welcome to Mi9 Code Challenge WebService end point.  Please submit your JSON payload to the WebService root using POST";
        }


        [HttpPost]
        public IHttpActionResult Post([FromBody]PayLoadContainer submittedPayload)
        {
            try
            { 
                if(submittedPayload == null ||
                  (submittedPayload != null && submittedPayload.payload ==null)  
                 )
                {  
                    return Content(HttpStatusCode.BadRequest, new { error = "Could not decode request: JSON parsing failed" });
                }
                else
                {
                    FilterShows fs = new FilterShows();
                    return Ok(fs.ApplyFilter(submittedPayload)); 
                }
            }
            catch(Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, new { error = "Internal Server error, retry after sometime" });
            }


        }       
       
    }
}
