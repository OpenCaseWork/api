using System.ComponentModel.DataAnnotations.Schema;

namespace OpenCaseWork.Models.Constituents.Domains
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
