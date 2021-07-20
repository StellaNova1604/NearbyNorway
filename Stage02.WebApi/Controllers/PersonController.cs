using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stage02.WebApi.Controllers
{
    [ApiController]
    [Route("person")]
    public class PersonController : Controller
    {
        [HttpGet]
        public String Index()
        {
            var name = "Wiis";
            string result = String.Format("Hello, I'm {0}", name);
            return result;
        }
    }
}
