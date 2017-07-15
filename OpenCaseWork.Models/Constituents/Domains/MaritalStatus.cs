using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenCaseWork.Models.Constituents.Domains
{
    [Table("marital_status")]
    public class MaritalStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("marital_status_id")]
        public int Id { get; set; }
        [Column("marital_status_code")]
        public string Code { get; set; }
        [Column("marital_type")]
        public string MaritalType { get; set; }

        
    }
}
