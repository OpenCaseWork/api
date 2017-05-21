using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using OpenCaseWork.Constituents.Models.Domains;
using OpenCaseWork.Constituents.Data;

namespace OpenCaseWork.Constituents.Controllers
{
    [Route("api/constituents/[controller]")]
    public class DomainsController: Controller
    {
        IDomainRepository _domainRepository;
        public DomainsController(IDomainRepository domainRepository)
        {
            _domainRepository = domainRepository;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Domains()
        {
            ConstituentDomains record = new ConstituentDomains();
            var taskGetSuffix = _domainRepository.Suffixes();
            var taskGetTitles = _domainRepository.Titles();
            var taskGetCities = _domainRepository.Cities();
            var taskList = new List<Task>() { taskGetCities, taskGetTitles, taskGetSuffix };
            await Task.WhenAll(taskList.ToArray());

            record.Suffixes = taskGetSuffix.Result;
            record.Titles = taskGetTitles.Result;
            record.Cities = taskGetCities.Result;
           
            var task = Task.FromResult(record);
            return Ok(await task);
        }
    }
}
