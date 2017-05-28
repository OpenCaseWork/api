using System.ComponentModel.DataAnnotations.Schema;

namespace OpenCaseWork.Constituents.Models.Domains
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
        public int Sequence { get; set; }
        [Column("is_phone")]
        public bool IsPhone { get; set; }

    }
}
