using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsSearch.Dto;
using NewsSearch.Entity;
using NewsSearch.Solr;

namespace NewsSearch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        ISolrIndexService<SolrNewsEntity> solrIndexService;

        public ValuesController(ISolrIndexService<SolrNewsEntity> _solr)
        {
            solrIndexService = _solr;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post(NewsDto post)
        {
            solrIndexService.AddUpdate(new SolrNewsEntity(post));

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
