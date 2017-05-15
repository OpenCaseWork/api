
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OpenCaseWork.Constituents.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;

namespace OpenCaseWork.Constituents.Controllers
{
    [Route("api/[controller]")]
    public class ConstituentsController : Controller
    {
        // GET api/values
        [HttpPost]
        public async Task<IActionResult> Constituents([FromBody] ConstituentSearchRequest searchFilter)
        {
            var result = new ConstituentSearchResponse();
            ConstituentSearchRecord record = new ConstituentSearchRecord();
            record.Address = "89 golfview";
            record.Name = "Keith Katsma";
            result.Records = new List<ConstituentSearchRecord>();
            result.Records.Add(record);
            var task = Task.FromResult(result);
            return Ok(await task);
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Constituents()
        {
            var result = new ConstituentSearchResponse();
            ConstituentSearchRecord record = new ConstituentSearchRecord();
            record.Address = "89 golfview";
            record.Name = "Keith Katsma";
            result.Records = new List<ConstituentSearchRecord>();
            result.Records.Add(record);
            var task = Task.FromResult(result);
            return Ok(await task);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
