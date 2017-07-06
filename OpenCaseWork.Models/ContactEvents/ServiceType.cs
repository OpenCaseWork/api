using OpenCaseWork.Models.Audit;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenCaseWork.Models.ContactEvents
{
    [Table("service_types")]
    public class ServiceType: AuditedEntity
    {
        [Column("SERVICE_type_ID")]
        public int Id { get; set; }
        [Column("service_type_name")]
        public string Name { get; set; }
        [Column("service_type_abbreviation")]
        public string Abbreviation { get; set; }
        [Column("type")]
        public string Type { get; set; }
        [Column("report_category")]
        public string ReportCategory { get; set; }
        [Column("sequence")]
        public int? Sequence {get;set;}
	    [Column("is_active")]
        public bool IsActive { get; set;}
    }
}
