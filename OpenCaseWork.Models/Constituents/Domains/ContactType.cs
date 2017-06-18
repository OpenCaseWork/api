using System.ComponentModel.DataAnnotations.Schema;

namespace OpenCaseWork.Models.Constituents.Domains
{
    [Table("contact_type")]
    public class ContactType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("contact_type_id")]
        public int Id { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("sequence")]
        public int? Sequence { get; set; }
        [Column("is_phone")]
        public bool IsPhone { get; set; }
        [Column("ui_sequence")]
        public int UISequence { get; set; }
        [Column("is_default")]
        public bool IsDefault { get; set; }
        [Column("is_email")]
        public bool IsEmail { get; set; }

    }
}
