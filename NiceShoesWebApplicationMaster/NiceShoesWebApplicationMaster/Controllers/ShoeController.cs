using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NiceShoesWebApplicationMaster.Controllers
{
    public class ShoeController : ApiController
    {

        string brand = string.Empty;
        
        
        
        // GET: api/Shoe
        public IEnumerable<string> Get()
        {
            return new string[] { brand, "value2" };
        }

        


        // GET: api/Shoe/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Shoe
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Shoe/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Shoe/5
        public void Delete(int id)
        {
        }
    }
}
