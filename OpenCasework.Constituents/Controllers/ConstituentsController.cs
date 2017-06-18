﻿
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

            List<Constituent> list = await _constituentRepository.Search(searchFilter);
            foreach(Constituent c in list)
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
            }

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

        // Search
        [HttpGet]
        public async Task<IActionResult> Constituents()
        {
            var result = new ConstituentSearchResponse();
            ConstituentSearchRecord record = new ConstituentSearchRecord();
            record.Address = "89 golfview";
            record.Name = "Keith Katsma";
            record.Id = 1;
            result.Records = new List<ConstituentSearchRecord>();
            result.Records.Add(record);
            var task = Task.FromResult(result);
            return Ok(await task);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var constituent = new Constituent();
            constituent.Address1 = "89 golfview";
            constituent.FirstName = "Keith";
            constituent.LastName = "Katsma";
            constituent.CityId = 1;
            constituent.ConstituentId = 123;
            constituent.MiddleName = "Matthew";
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
