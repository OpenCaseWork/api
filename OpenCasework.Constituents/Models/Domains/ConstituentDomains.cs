using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenCaseWork.Constituents.Models.Domains
{
    public class ConstituentDomains
    {
        public List<Title> Titles { get; set; }
        public List<Suffix> Suffixes { get; set; }
        public List<City> Cities { get; set; }
    }
}
