using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Web.Http;
using Microsoft.Ajax.Utilities;

namespace WebAPIClass2.Controllers
{
    public class DellAPIController : ApiController
    {
        [HttpGet]
        public string Get()
        {
            return "custom get call within custom controller - DellAPICOntroller";
        }
        [HttpGet]
        public List<string> Get(int id)
        {
            return new List <string> { "shriram", "ram", "shri" };
        }
    }
}
