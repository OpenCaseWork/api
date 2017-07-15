using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using OpenCaseWork.Constituents.Data;
using OpenCaseWork.Models.Constituents.Domains;
using System.Linq;
using OpenCaseWork.Models.Domains;
using OpenCaseWork.Models.Base;

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

            var response = new BasePostResponse<ConstituentDomains>();      
            ConstituentDomains record = new ConstituentDomains();
            var taskGetCities = _domainRepository.Cities();
            var taskGetContactTypes = _domainRepository.ContactTypes();
            var taskPostal = _domainRepository.PostalCodes();
            var taskState = _domainRepository.States();
            var taskGetSuffix = _domainRepository.Suffixes();
            var taskGetTitles = _domainRepository.Titles();
            var taskTownships = _domainRepository.Townships();
            var taskEthnicities = _domainRepository.Ethnicities();
            var taskGenders = _domainRepository.Genders();
            var taskIncomeLevels = _domainRepository.IncomeLevels();
            var taskLanguages = _domainRepository.Languages();
            var taskMaritalStatuses = _domainRepository.MaritalStatuses();
            var taskRaces = _domainRepository.Races();
            var taskList = new List<Task>() {
                taskGetCities,
                taskGetContactTypes,
                taskPostal,
                taskState,
                taskGetTitles, 
                taskGetSuffix,
                taskTownships,
                taskEthnicities,
                taskGenders,
                taskIncomeLevels,
                taskLanguages,
                taskMaritalStatuses,
                taskRaces
            };
            await Task.WhenAll(taskList.ToArray());

            record.Cities = taskGetCities.Result.Select(x => new SelectItem() { Id = x.CityId, ShortDescription = x.CityName }).ToList(); 
            record.Suffixes = taskGetSuffix.Result.Select(x => new SelectItem() { Id = x.SuffixId, ShortDescription = x.SuffixText }).ToList();
            record.Titles = taskGetTitles.Result.Select(x => new SelectItem() { Id = x.TitleId, ShortDescription = x.TitleText }).ToList();
            record.ContactTypes = taskGetContactTypes.Result;
            record.PostalCodes = taskPostal.Result.Select(x => new SelectItem() { Id = x.Id, ShortDescription = x.Code }).ToList();
            record.States = taskState.Result.Select(x => new SelectItem() { Id = x.Id, ShortDescription = x.StateCd }).ToList();
            record.Townships = taskTownships.Result.Select(x => new SelectItem() { Id = x.Id, ShortDescription = x.TownshipName }).ToList();
            record.Ethnicities = taskEthnicities.Result.Select(x => new SelectItem() { Id = x.Id, ShortDescription = x.Description }).ToList();
            record.Genders = taskGenders.Result.Select(x => new SelectItem() { Id = x.Id, ShortDescription = x.Description }).ToList();
            record.IncomeLevels = taskIncomeLevels.Result.Select(x => new SelectItem() { Id = x.Id, ShortDescription = x.Description }).ToList();
            record.Languages = taskLanguages.Result.Select(x => new SelectItem() { Id = x.Id, ShortDescription = x.CodeText }).ToList();
            record.MaritalStatuses = taskMaritalStatuses.Result.Select(x => new SelectItem() { Id = x.Id, ShortDescription = x.MaritalType }).ToList();
            record.Races = taskRaces.Result.Select(x => new SelectItem() { Id = x.Id, ShortDescription = x.Type }).ToList();

            _loadedDomains = record;
            response.Data = record;

            return Ok(response);
        }
    }
}
