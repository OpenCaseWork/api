using OpenCaseWork.Models.Audit;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenCaseWork.Models.Contacts
{
    public class Contact: AuditedEntity
    {
        [Column("contact_id")]
        public int Id { get; set; }
        [Column("parent_id")]
        public int ConstituentId { get; set; }
        [Column("contact_type_id")]
        public int ContactTypeId { get; set; }
        [Column("contact_text")]
        public string Value { get; set; }
        [Column("contact_text_2")]
        public string Value2 { get; set; }
        [Column("contact_notes")]
        public string Notes { get; set; }
        [Column("extension")]
        public string Extension { get; set; }
    }
}
