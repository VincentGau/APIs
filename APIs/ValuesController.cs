﻿using APIs.Logic;
using APIs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace APIs
{
    //[EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<object> Get()
        {
            var resultList = new List<object>();
            resultList.Add(new { name = "abc", value = "cba" });
            resultList.Add(new { name = "xyz", value = "zyx" });
            return resultList;

            
        }

        // GET api/values/5 
        [HttpGet]
        [Route("api/values/{id}")]
        public string Get(int id)
        {
            return "value";
        }        

        // POST api/values 
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5 
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5 
        public void Delete(int id)
        {
        }
    }
}
