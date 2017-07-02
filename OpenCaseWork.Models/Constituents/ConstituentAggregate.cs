using OpenCaseWork.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCaseWork.Models.Constituents
{
    public class ConstituentAggregate: BaseResponse
    {
        public Constituent Constituent { get; set; }
        public List<ConstituentContact> Contacts { get; set; }
    }
}
