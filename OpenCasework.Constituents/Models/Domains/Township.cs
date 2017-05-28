using System.ComponentModel.DataAnnotations.Schema;

namespace OpenCaseWork.Constituents.Models.Domains
{
    [Table("township")]
    public class Township
    {
        [Column("township_id")]
        public int Id { get; set; }
        [Column("township_code")]
        public System.Int16 TownshipCode { get; set; }
        [Column("township_name")]
        public string TownshipName { get; set; }

    }
}
