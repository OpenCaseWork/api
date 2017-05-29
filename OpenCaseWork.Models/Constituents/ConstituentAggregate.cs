using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCaseWork.Models.Constituents
{
    public class ConstituentAggregate
    {
        public Constituent Constituent { get; set; }
        public List<ConstituentContact> Contacts { get; set; }
    }
}
