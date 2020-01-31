using Microsoft.AspNetCore.Mvc;
using NewsSearch.Dto;
using NewsSearch.Entity;
using NewsSearch.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsSearch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewsApplicationServices newsApplicationServices;

        public NewsController(INewsApplicationServices newsApplicationServices)
        {
            this.newsApplicationServices = newsApplicationServices;
        }
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpPost]
        public NewsDto Post([FromBody] NewsDto post)
        {
           return  newsApplicationServices.Insert(post);

        }

    }
}
