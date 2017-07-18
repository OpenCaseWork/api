using Newtonsoft.Json.Linq;
using OpenCaseWork.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCaseWork.Models.Constituents
{
    public class ConstituentAggregate : BaseResponse
    {
        public Constituent Constituent { get; set; }
        public List<ConstituentContact> Contacts { get; set; }
        public ConstituentMaritalStatus Maritalstatus { get; set; }
        public ConstituentNote Note { get; set; }
        public List<ConstituentQuestionnaire> Questionnaires { get; set; }

    }
}
