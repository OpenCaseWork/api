using OpenCaseWork.Models.Domains;
using System;
using System.Collections.Generic;

namespace OpenCaseWork.Models.Constituents.Domains
{
    public class ConstituentDomains
    {                
        //public List<City> Cities { get; set; }
        public List<SelectItem> Cities { get; set; }
        public List<ContactType> ContactTypes { get; set; }
        public List<SelectItem> PostalCodes { get; set; }
        public List<SelectItem> States { get; set; }
        public List<SelectItem> Suffixes { get; set; }
        public List<SelectItem> Titles { get; set; }
        public List<SelectItem> Townships { get; set; }
        public List<SelectItem> MaritalStatuses { get; set; }
        public List<SelectItem> Genders { get; set; }
        public List<SelectItem> IncomeLevels { get; set; }
        public List<SelectItem> Races { get; set; }
        public List<SelectItem> Ethnicities { get; set; }
        public List<SelectItem> Languages { get; set; }
    }
}
