using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenCaseWork.Models.Constituents.Domains
{
    [Table("zip_code_cities")]
    public class PostalCodeCity
    {
        [Column("zip_code")]
        public string PostalCode { get; set; }
        [Column("city_id")]
        public int CityId { get; set; }
        [Column("is_primary")]
        public bool IsPrimary { get; set; }
    }
}
