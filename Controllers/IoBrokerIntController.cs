using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IOBrokerDataCollector.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IoBrokerIntController : ControllerBase
    {
        // GET: api/IoBrokerInt
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/IoBrokerInt/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(string id)
        {
            Console.WriteLine("get string");
            Console.WriteLine(id);
            return "value " + id;
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
