using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenCaseWork.Models.Constituents.Domains
{
    [Table("gender")]
    public class Gender
    {
        [Column("gender_id")]
        public int Id { get; set; }
        [Column("gender_description")]
        public string Description { get; set; }
    }
}
