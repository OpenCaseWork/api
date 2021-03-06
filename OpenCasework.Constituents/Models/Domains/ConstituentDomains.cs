﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenCaseWork.Constituents.Models.Domains
{
    public class ConstituentDomains
    {                
        public List<City> Cities { get; set; }
        public List<ContactType> ContactTypes { get; set; }
        public List<PostalCode> PostalCodes { get; set; }
        public List<State> States { get; set; }
        public List<Suffix> Suffixes { get; set; }
        public List<Title> Titles { get; set; }
        public List<Township> Townships { get; set; }
        
        
    }
}
