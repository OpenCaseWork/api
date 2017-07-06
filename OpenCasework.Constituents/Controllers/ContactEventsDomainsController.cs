using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OpenCaseWork.Models.ContactEvents.Domains;
using OpenCaseWork.Constituents.Data;
using OpenCaseWork.Models.Base;
using OpenCaseWork.Models.Domains;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OpenCaseWork.Constituents.Controllers
{
    [Route("api/contact-events/domains")]
    public class ContactEventsDomainsController : Controller
    {
        ContactEventDomains _loadedDomains;

        IContactEventDomainRepository _domainRepository;
        public ContactEventsDomainsController(IContactEventDomainRepository domainRepository)
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

            var response = new BasePostResponse<ContactEventDomains>();
            ContactEventDomains record = new ContactEventDomains();
            var taskGetServices = _domainRepository.Services();
            var taskGetServiceTypes = _domainRepository .ServiceTypes();
            var taskList = new List<Task>() {
                taskGetServices,
                taskGetServiceTypes
            };
            await Task.WhenAll(taskList.ToArray());

            record.ServiceCodes = taskGetServices.Result.Select(x => new SelectItem() { Id = x.Id, Code = x.Code.ToString(), ShortDescription = x.Description }).ToList();
            record.ServiceTypes = taskGetServiceTypes.Result.Select(x => new SelectItem() { Id = x.Id, ShortDescription = x.Abbreviation, LongDescription = x.Name }).ToList();

            _loadedDomains = record;
            response.Data = record;

            return Ok(response);
        }
    }
}
