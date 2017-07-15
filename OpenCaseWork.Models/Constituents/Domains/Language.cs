using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenCaseWork.Models.Constituents.Domains
{
    [Table("tracking_preferred_language")]
    public class Language
    {
        [Column("code_id")]
        public int Id { get; set; }
        [Column("code_text")]
        public string CodeText { get; set; }
        [Column("active")]
        public string Active { get; set; }
    }
}
