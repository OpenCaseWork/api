using System.ComponentModel.DataAnnotations.Schema;

namespace OpenCaseWork.Models.Constituents.Domains
{
    [Table("city")]
    public class City
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CITY_ID")]
        public int CityId { get; set; }
        [Column("CITY_CODE")]
        public System.Int16 CityCode { get; set; }
        [Column("city")]
        public string CityName { get; set; }

    }
}
