using OpenCaseWork.Models.Audit;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenCaseWork.Models.Constituents
{
    [Table("constituent_notes")]
    public class ConstituentNote: AuditFields
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("constituent_note_id")]
        public int Id { get; set; }
        [Column("constituent_id")]
        public int ConstituentId { get; set; }
        [Column("notes")]
        public string notes { get; set; }
    }
}
