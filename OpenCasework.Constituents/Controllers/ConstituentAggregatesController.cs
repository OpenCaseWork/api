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
using OpenCaseWork.Models.Entity;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace OpenCaseWork.Constituents.Controllers
{
    [Route("api/constituent-aggregates")]
    public class ConstituentAggregatesController: Controller
    {
        private Repository<Constituent> _repository;
        private Repository<ConstituentContact> _contactRepo;
        private Repository<Entity> _entityRepo;
        private ConstituentContext _context;
        private IConstituentRepository _constituentRepository;
        private IEntityRepository _entityRepository;

        public ConstituentAggregatesController(ConstituentContext context, IConstituentRepository constituentRepository, IEntityRepository entityRepository)
        {
            _repository = new Repository<Constituent>(context);
            _entityRepo = new Repository<Entity>(context);
            _contactRepo = new Repository<ConstituentContact>(context);
            _context = context;
            _constituentRepository = constituentRepository;
            _entityRepository = entityRepository;
            
        }


        // GET api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ConstituentAggregate aggregate)
        {
            var constituent = aggregate.Constituent;
            if (constituent.ConstituentId <= 0)
            {
                // constituent.ConstituentId = await _constituentRepository.GetNextConstituentId();
                constituent = await _repository.Add(constituent, _context.Constituents);
            }
            else
            {
                constituent = await _repository.Update(constituent);
            }
          

            //contacts
            var contacts = aggregate.Contacts ?? new List<ConstituentContact>();
            contacts.Select(c => { c.ConstituentId = constituent.ConstituentId; return c; }).ToList();
            _contactRepo.UpdateWithoutSave(contacts.Where(c => c.Id > 0).ToList(), _context.Contacts);
            _contactRepo.AddWithoutSave(contacts.Where(c => c.Id == 0).ToList(), _context.Contacts);
            await _contactRepo.Save();

            //rebuild response 
            var response = new EntityResponse<ConstituentAggregate>();


            var returnAggregate = new ConstituentAggregate()
            {
                Constituent = constituent,
                Contacts = contacts,
                //JsonEntity = JObject.Parse(entity.Json),
                //JsonEntityId = entity.Id
            };
            response.Data = returnAggregate;
            return Ok(response);

        }

        private void SetProperties(Constituent constituent)
        {

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
            var taskGetQuestionnaires = _constituentRepository.GetQuestionnaires(id);
            //var taskGetEntity = _entityRepository.GetEntity(id, 1);
          
            var taskList = new List<Task>() {
                taskGetConstituent,
                taskGetContacts,
                taskGetQuestionnaires,
            };
            await Task.WhenAll(taskList.ToArray());

            var response = new EntityResponse<ConstituentAggregate>();
            aggregate.Constituent = taskGetConstituent.Result;
            aggregate.Contacts = taskGetContacts.Result;
            aggregate.Questionnaires = taskGetQuestionnaires.Result;
            //List<Entity> entities = taskGetEntity.Result;
            /*if (entities.Count > 0)
            {
                //var settings = new JsonSerializerSettings
                //{
                //    ContractResolver = new CamelCasePropertyNamesContractResolver()
                //};
                //aggregate.JsonEntity = JsonConvert.DeserializeObject(entities[0].Json, settings); 
                aggregate.JsonEntity = JObject.Parse(entities[0].Json);
                aggregate.JsonEntityId = entities[0].Id;
            }
            else
            {
                //var serializer = new JsonSerializer
                //{
                //    ContractResolver = new CamelCasePropertyNamesContractResolver()
                //};
                //use same constituent if empty for now
                aggregate.JsonEntity = JObject.FromObject(aggregate.Constituent);
            }*/
            response.Data = aggregate;
 
            return Ok(response);
        }



    }
}
