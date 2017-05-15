using OpenCaseWork.Core.Models;
using System.Collections.Generic;

namespace OpenCaseWork.Constituents.Models
{
    public class ConstituentSearchResponse: BaseResponse
    {
        public List<ConstituentSearchRecord> Records { get; set; }
    }
}