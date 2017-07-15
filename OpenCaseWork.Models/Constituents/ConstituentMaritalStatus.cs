using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenCaseWork.Models.Constituents
{
    [Table("constituent_marital_status")]
    public class ConstituentMaritalStatus
    {
        [Column("constituent_marital_status_id")]
        public int Id { get; set; }
        [Column("marital_status_id")]
        public int? MaritalStatusId { get; set; }
        [Column("constituent_id")]
        public int? ConstituentId { get; set; }
        [Column("marital_status_date")]
        public DateTime? MaritalStatusDate { get; set; }
        [Column("significant_other")]
        public string SignificantOther { get; set; }
    }
}
