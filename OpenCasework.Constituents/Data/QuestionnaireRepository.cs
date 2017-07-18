using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenCaseWork.Constituents.Data
{

    public interface IQuestionnaireRepository
    {
        //Task<List<Questionnaire>> Search(ConstituentSearchRequest constituent);
  

    }

    public class QuestionnaireRepository : IQuestionnaireRepository
    {
        private ConstituentContext _context;

        public QuestionnaireRepository(ConstituentContext dbContext)
        {
            _context = dbContext;
        }

    }
}
