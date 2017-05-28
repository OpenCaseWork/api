using System.ComponentModel.DataAnnotations.Schema;

namespace OpenCaseWork.Models.Constituents.Domains
{
    [Table("zip_code")]
    public class PostalCode
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("zip_code_id")]
        public int Id { get; set; }
        [Column("zip_code")]
        public string Code { get; set; }
        [Column("state")]
        public string State { get; set; }

    }
}
