using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OpenCaseWork.Constituents.Models.Domains
{
    [Table("city")]
    public class City
    {
        [Column("CITY_ID")]
        public int CityId { get; set; }
        [Column("CITY_CODE")]
        public System.Int16 CityCode { get; set; }
        [Column("city")]
        public string CityName { get; set; }

    }
}
