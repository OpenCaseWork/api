using OpenCaseWork.Models.Audit;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OpenCaseWork.Models.Constituents
{
    [Table("contact")]
    public class ConstituentContact: AuditedEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("contact_id")]
        public int Id { get; set; }
        [Column("parent_id")]
        public int ConstituentId { get; set; }
        [Column("contact_type_id")]
        public int ContactTypeId { get; set; }
        [Column("contact_text")]
        public string ContactValue { get; set; }
        [Column("contact_text_2")]
        public string ContactValue2 { get; set; }        
        [Column("contact_notes")]
        public string Notes { get; set; }
        [Column("extension")]
        public string Extension { get; set; }

    }
}
