
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OpenCaseWork.Constituents.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;
using OpenCaseWork.Constituents.Models.Search;
using OpenCaseWork.Models.Constituents;
using OpenCaseWork.Core.Data;
using OpenCaseWork.Constituents.Data;

namespace OpenCaseWork.Constituents.Controllers
{
    [Route("api/[controller]")]
    public class ConstituentsController : Controller
    {
        private Repository<Constituent> _repository;
        private Repository<ConstituentContact> _contactRepo;
        private ConstituentContext _context;
        private IConstituentRepository _constituentRepository;

        public ConstituentsController(ConstituentContext context, IConstituentRepository constituentRepository)
        {
            _repository = new Repository<Constituent>(context);
            _contactRepo = new Repository<ConstituentContact>(context);
            _context = context;
            _constituentRepository = constituentRepository;

        }

        // GET api/values
        [HttpPost("search")]
        public async Task<IActionResult> Constituents([FromBody] ConstituentSearchRequest searchFilter)
        {
            var result = new ConstituentSearchResponse();
            result.Records = new List<ConstituentSearchRecord>();

            result.Records = await _constituentRepository.Search(searchFilter);
            /*foreach(Constituent c in list)
            {
                var record = new ConstituentSearchRecord()
                {
                    Address = c.Address1,
                    Name = c.FirstName + ' ' + c.LastName,
                    Id = c.ConstituentId,
                    City = "",
                    Phone = "",
                    PostalCode = c.PostalCode,
                    State = c.StateCd
                };
                result.Records.Add(record);
            }*/

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Constituents([FromBody] Constituent constituent)
        {
            if (constituent.ConstituentId == 0)
                constituent.ConstituentId = 1;
            var task = Task.FromResult(constituent);
            return Ok(await task);
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
