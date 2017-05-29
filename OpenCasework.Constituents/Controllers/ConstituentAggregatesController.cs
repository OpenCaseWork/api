using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using OpenCaseWork.Models.Constituents;
using OpenCaseWork.Constituents.Data;
using OpenCaseWork.Core.Data;
using System.Linq;

namespace OpenCaseWork.Constituents.Controllers
{
    [Route("api/constituent-aggregates")]
    public class ConstituentAggregatesController: Controller
    {
        private IRepository<Constituent> _repository;
        private IRepository<ConstituentContact> _contactRepo;
        private ConstituentContext _context;
        private IConstituentRepository _constituentRepository;

        public ConstituentAggregatesController(IRepository<Constituent> repository, IRepository<ConstituentContact> contactRepo, ConstituentContext context, IConstituentRepository constituentRepository)
        {
            _repository = repository;
            _context = context;
            _constituentRepository = constituentRepository;
            _contactRepo = contactRepo;
        }


        // GET api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ConstituentAggregate aggregate)
        {
            var constituent = aggregate.Constituent;
            if (constituent.ConstituentId <= 0)
            {
                //constituent.ConstituentId = await _constituentRepository.GetNextConstituentId();
                constituent = await _repository.Add(constituent, _context.Constituents);
            }
            else
                constituent = await _repository.Update(constituent);


            //contacts
            var contacts = aggregate.Contacts;
            contacts.Select(c => { c.ConstituentId = constituent.ConstituentId; return c; }).ToList();
            _contactRepo.AddWithoutSave(contacts.Where(c => c.Id == 0).ToList(), _context.Contacts);
            _contactRepo.UpdateWithoutSave(contacts.Where(c => c.Id == 0).ToList(), _context.Contacts);
            await _contactRepo.Save();

            //rebuild response 
            var returnAggregate = new ConstituentAggregate();
            returnAggregate.Constituent = constituent;
            returnAggregate.Contacts = contacts;

            return Ok(returnAggregate);

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

            aggregate.Constituent = taskGetConstituent.Result;
            aggregate.Contacts = taskGetContacts.Result;
 
            return Ok(aggregate);
        }



    }
}
