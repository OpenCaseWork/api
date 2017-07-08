using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using OpenCaseWork.Models.Constituents;
using OpenCaseWork.Constituents.Data;
using OpenCaseWork.Core.Data;
using System.Linq;
using OpenCaseWork.Models.Base;
using Microsoft.AspNetCore.Http;
using System.Net;

namespace OpenCaseWork.Constituents.Controllers
{
    [Route("api/constituent-aggregates")]
    public class ConstituentAggregatesController: Controller
    {
        private Repository<Constituent> _repository;
        private Repository<ConstituentContact> _contactRepo;
        private ConstituentContext _context;
        private IConstituentRepository _constituentRepository;

        public ConstituentAggregatesController(ConstituentContext context, IConstituentRepository constituentRepository)
        {
            _repository = new Repository<Constituent>(context);
            _contactRepo = new Repository<ConstituentContact>(context);
            _context = context;
            _constituentRepository = constituentRepository;
            
        }


        // GET api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ConstituentAggregate aggregate)
        {
            HttpStatusCode responseCode;
            var constituent = aggregate.Constituent;
            if (constituent.ConstituentId <= 0)
            {
                // constituent.ConstituentId = await _constituentRepository.GetNextConstituentId();
                constituent = await _repository.Add(constituent, _context.Constituents);
                responseCode = HttpStatusCode.Created;
            }
            else
            {
                constituent = await _repository.Update(constituent);
                responseCode = HttpStatusCode.OK;
            }


            //contacts
            var contacts = aggregate.Contacts ?? new List<ConstituentContact>();
            contacts.Select(c => { c.ConstituentId = constituent.ConstituentId; return c; }).ToList();
            _contactRepo.AddWithoutSave(contacts.Where(c => c.Id == 0).ToList(), _context.Contacts);
            _contactRepo.UpdateWithoutSave(contacts.Where(c => c.Id > 0).ToList(), _context.Contacts);
            await _contactRepo.Save();

            //rebuild response 
            var response = new EntityResponse();
            var returnAggregate = new ConstituentAggregate()
            {
                Constituent = constituent,
                Contacts = contacts
            };
            response.Data = returnAggregate;

            if (responseCode == HttpStatusCode.Created)
                return Created("",response);
            else
                return Ok(response);

        }


        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var aggregate = new ConstituentAggregate();
            //aggregate.Constituent = await _repository.FindByID(id, _context.Constituents);
            //aggregate.Contacts = await _constituentRepository.GetContactsForConstituentId(id);

            var taskGetConstituent = _repository.FindByID(id, _context.Constituents);
            var taskGetContacts = _constituentRepository.GetContactsForConstituentId(id);
          
            var taskList = new List<Task>() {
                taskGetConstituent,
                taskGetContacts
            };
            await Task.WhenAll(taskList.ToArray());

            var response = new EntityResponse();
            aggregate.Constituent = taskGetConstituent.Result;
            aggregate.Contacts = taskGetContacts.Result;
            response.Data = aggregate;
 
            return Ok(response);
        }



    }
}
