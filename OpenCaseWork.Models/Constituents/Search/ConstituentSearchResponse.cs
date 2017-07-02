using OpenCaseWork.Models;
using System.Collections.Generic;

namespace OpenCaseWork.Constituents.Models.Search
{
    public class ConstituentSearchResponse: BaseResponse
    {
        public List<ConstituentSearchRecord> Data { get; set; }
    }
}