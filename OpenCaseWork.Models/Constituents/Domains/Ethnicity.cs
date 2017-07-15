using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenCaseWork.Models.Constituents.Domains
{
    [Table("ethnicity")]
    public class Ethnicity
    {
        [Column("ethnicity_id")]
        public int Id { get; set; }
        [Column("ethnicity_description")]
        public string Description { get; set; }
        [Column("ba_report_description")]
        public string BaReportDescription { get; set; }
        [Column("harmony_description")]
        public string HarmonyDescription { get; set; }
    }
}
