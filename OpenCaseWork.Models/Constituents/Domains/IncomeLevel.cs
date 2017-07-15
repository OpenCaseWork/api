using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenCaseWork.Models.Constituents.Domains
{
    [Table("income_level")]
    public class IncomeLevel
    {
        [Column("income_level_id")]
        public int Id { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("code")]
        public string Code { get; set; }
    }
}
