using OpenCaseWork.Models.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCaseWork.Models.ContactEvents.Domains
{
    public class ContactEventDomains
    {
        //public List<City> Cities { get; set; }
        public List<SelectItem> ServiceCodes { get; set; }
        public List<SelectItem> ServiceTypes { get; set; }
    }
}
