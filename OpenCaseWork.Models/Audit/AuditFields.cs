using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCaseWork.Models.Audit
{
    public class AuditFields
    {
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string CreatedBy { get;set;}
        public string UpdatedBy { get; set; }
    }
}
