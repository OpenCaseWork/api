using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCaseWork.Models.Questionnaire
{
    public class QuestionnaireAggregate
    {
        public ClientQuestionnaire Questionnaire { get; set; }
        public List<ClientQuestionnaireOther> Others { get; set; }
        public List<ClientQuestionnaireService> Services { get; set; }

    }
}
