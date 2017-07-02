using OpenCaseWork.Models.Domains;
using System;
using System.Collections.Generic;

namespace OpenCaseWork.Models.Constituents.Domains
{
    public class ConstituentDomains: BaseResponse
    {                
        //public List<City> Cities { get; set; }
        public List<SelectItem> Cities { get; set; }
        public List<ContactType> ContactTypes { get; set; }
        public List<PostalCode> PostalCodes { get; set; }
        public List<State> States { get; set; }
        public List<SelectItem> Suffixes { get; set; }
        public List<SelectItem> Titles { get; set; }
        public List<Township> Townships { get; set; }
        
        
    }
}
