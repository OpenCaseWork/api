using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OpenCaseWork.Constituents.Models.Domains
{
    [Table("suffix")]
    public class Suffix
    {
        [Column("suffix_id")]
        public System.Int16 SuffixId { get; set; }
        [Column("suffix_text")]
        public string SuffixText { get; set; }
    }
}
