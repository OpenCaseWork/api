using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OpenCaseWork.Constituents.Data;
using OpenCaseWork.Models.Questionnaire;
using OpenCaseWork.Core.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OpenCaseWork.Constituents.Controllers
{
    [Route("api/questionnaire-aggregates")]
    public class QuestionnaireController : Controller
    {
        private Repository<ClientQuestionnaire> _repository;
        private Repository<ClientQuestionnaireOther> _otherRepository;
        private Repository<ClientQuestionnaireService> _serviceRepository;

        public QuestionnaireController(ConstituentContext context)
        {
            _repository = new Repository<ClientQuestionnaire>(context);
            _otherRepository = new Repository<ClientQuestionnaireOther>(context);
            _serviceRepository = new Repository<ClientQuestionnaireService>(context);

        }


        // GET api/values/5
        [HttpGet("{id}")]
        public QuestionnaireAggregate Get(int id)
        {
            return new QuestionnaireAggregate();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] QuestionnaireAggregate value)
        {
        }
 

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
