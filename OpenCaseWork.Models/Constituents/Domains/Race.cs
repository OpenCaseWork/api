using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenCaseWork.Models.Constituents.Domains
{
    [Table("minority")]
    public class Race
    {
        [Column("minority_id")]
        public int Id { get; set; }
        [Column("minority_code")]
        public string Code { get; set; }
        [Column("minority_type")]
        public string Type { get; set; }
        [Column("ba_report_description")]
        public string BaReportDescription { get; set; }
        [Column("is_active")]
        public string IsActive { get; set; }
        [Column("harmony_description")]
        public string HarmonyDescription { get; set; }
    }
}
