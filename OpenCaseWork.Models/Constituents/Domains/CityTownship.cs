using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenCaseWork.Models.Constituents.Domains
{
    [Table("city_townships")]
    public class CityTownship
    {
        [Column("CITY_ID")]
        public int CityId { get; set; }
        [Column("city")]
        public string CityName { get; set; }
        [Column("Zip_Code")]
        public string PostalCode { get; set; }
        [Column("township_id")]
        public int? TownshipId { get; set; }
        [Column("is_default")]
        public bool IsDefault { get; set; }
    }
}
  