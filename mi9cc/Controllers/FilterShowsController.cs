using mi9cc.JsonModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Web.Http;

namespace mi9cc.Controllers
{
    [RoutePrefix("/")]
    public class FilterShowsController : ApiController
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        [HttpPost]
        public IHttpActionResult Post([FromBody]PayLoadContainer value)
        {
            //Request.Content           
            //return Ok(value);
            //JsonConvert.DeserializeObject<List<payLoad>>(value.ToString(),
            //    new JsonSerializerSettings
            //        {
            //            ContractResolver = new CamelCasePropertyNamesContractResolver()
            //        }
            //    );
           
            return Ok(Request.Content.ReadAsStringAsync().Result);

        }

        //[HttpPost]
        //public IHttpActionResult Filter([FromBody]string value)
        //{
        //    //return 
        //    //Request.Content
        //    return Ok(Request.Content.ReadAsStringAsync().Result);

        //}

       
    }
}
