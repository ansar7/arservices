using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPTTest.Models;
using WebAPTTest.Services;

namespace WebAPTTest.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values?log=71&lat=72&azu=1.2
        
        public ARDATA[] Get(double log,double lat,double azu)
        {
            ARservice ars = new ARservice();
            ARDATA[] ar=ars.GetContacts(log,lat,azu);
            return ar;
        }
        // GET api/values
        public ARDATA[] Get()
        {
            ARservice ars = new ARservice();
            ARDATA[] ar=ars.GetAllContacts();
            return ar;
        }

        // GET api/values/5
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