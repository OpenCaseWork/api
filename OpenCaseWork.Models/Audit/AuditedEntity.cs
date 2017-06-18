using OpenCaseWork.Models.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenCaseWork.Models.Audit
{
    public class AuditedEntity: BaseEntity
    {
        [Column("created_date")]
        public DateTime? CreatedDate { get; set; }
        [Column("updated_date")]
        public DateTime? UpdatedDate { get; set; }
        [Column("created_by")]
        public string CreatedBy { get;set;}
        [Column("updated_by")]
        public string UpdatedBy { get; set; }
    }
}
