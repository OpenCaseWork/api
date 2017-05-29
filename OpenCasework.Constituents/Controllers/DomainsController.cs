using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using OpenCaseWork.Constituents.Data;
using OpenCaseWork.Models.Constituents.Domains;
using System.Linq;
using OpenCaseWork.Models.Domains;

namespace OpenCaseWork.Constituents.Controllers
{
   

    [Route("api/constituents/[controller]")]
    public class DomainsController: Controller
    {
        ConstituentDomains _loadedDomains;

        IDomainRepository _domainRepository;
        public DomainsController(IDomainRepository domainRepository)
        {
            _domainRepository = domainRepository;
        }

        [HttpPost]
        public IActionResult Clear()
        {
            _loadedDomains = null;
            return Ok(null);
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Domains()
        {
            if (_loadedDomains != null)
                return Ok(_loadedDomains);

            ConstituentDomains record = new ConstituentDomains();
            var taskGetCities = _domainRepository.Cities();
            var taskGetContactTypes = _domainRepository.ContactTypes();
            var taskPostal = _domainRepository.PostalCodes();
            var taskState = _domainRepository.States();
            var taskGetSuffix = _domainRepository.Suffixes();
            var taskGetTitles = _domainRepository.Titles();
            var taskTownships = _domainRepository.Townships();
            var taskList = new List<Task>() {
                taskGetCities,
                taskGetContactTypes,
                taskPostal,
                taskState,
                taskGetTitles, 
                taskGetSuffix,
                taskTownships 
            };
            await Task.WhenAll(taskList.ToArray());

            record.Cities = taskGetCities.Result.Select(x => new SelectItem() { Id = x.CityId, ShortDescription = x.CityName }).ToList(); 
            record.Suffixes = taskGetSuffix.Result.Select(x => new SelectItem() { Id = x.SuffixId, ShortDescription = x.SuffixText }).ToList();
            record.Titles = taskGetTitles.Result.Select(x => new SelectItem() { Id = x.TitleId, ShortDescription = x.TitleText }).ToList();
            record.ContactTypes = taskGetContactTypes.Result;
            record.PostalCodes = taskPostal.Result;
            record.States = taskState.Result;
            record.Townships = taskTownships.Result;

            _loadedDomains = record;

            return Ok(record);
        }
    }
}
