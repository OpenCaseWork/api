using System.ComponentModel.DataAnnotations.Schema;

namespace OpenCaseWork.Constituents.Models.Domains
{
    [Table("zip_code")]
    public class PostalCode
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("zip_code_id")]
        public int Id { get; set; }
        [Column("zip_code")]
        public System.Int16 TownshipCode { get; set; }
        [Column("state")]
        public string State { get; set; }

    }
}
