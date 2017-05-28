using OpenCaseWork.Models.Audit;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OpenCaseWork.Constituents.Models
{
    [Table("contact")]
    public class ConstituentContact: AuditFields
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("contact_id")]
        public int Id { get; set; }
        [Column("parent_id")]
        public int ConstituentId { get; set; }
        [Column("contact_type_id")]
        public int ContactTypeId { get; set; }
        [Column("contact_text")]
        public int ContactValue { get; set; }
        [Column("contact_text_2")]
        public int ContactVelue2 { get; set; }        
        [Column("contact_notes")]
        public string Notes { get; set; }
        [Column("extension")]
        public string Extension { get; set; }

    }
}
