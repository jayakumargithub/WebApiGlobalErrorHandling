﻿using System;
using System.Collections.Generic;
using System.Web.Http;
using log4net;

namespace DemoProject.Controllers
{
    public class DefaultController : ApiController
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            Log.Debug("GET Request traced");
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            throw new Exception("Nasty exception here");
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}