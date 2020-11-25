using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;


using Newtonsoft.Json;

using JusiBase;
//Update-Package

namespace IOBrokerDataCollector.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IoBrokerController : ControllerBase
    {
        // GET: api/IoBrokerInt
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/IoBroker/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult Get(string id)
            //public string Get(string id)
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();

                Console.WriteLine("getter aufgerufen: " + id);            

                IOBrokerWebConnector ioColl = new IOBrokerWebConnector();
                IOBrokerJSONGet result = ioColl.GetIOBrokerValue(id);
                if (result != null)
                {
                    Console.WriteLine("content zurück erhalten, dauer: {0}", sw.ElapsedMilliseconds);
                    return Content(JsonConvert.SerializeObject(result), "application/json");
                }
                else
                {
                    Console.WriteLine("content null, ohne error");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error bei return: " + ex.InnerException);
                return null;
                //throw;
            }
            //return "value " + intColl.getIntValue(id);
        }

        // POST: api/IoBrokerInt
        [HttpPost]
        public void Post([FromBody] string value)
        {
            Console.WriteLine("Post");
            Console.WriteLine(value);
        }

        // PUT: api/IoBrokerInt/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
