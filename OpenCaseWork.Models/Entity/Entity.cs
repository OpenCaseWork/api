using OpenCaseWork.Models.Audit;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenCaseWork.Models.Entity
{
    [Table("entity")]
    public class Entity: AuditedEntity
    {
        [Column("entity_id")]
        public int Id { get; set; }
        [Column("source_entity_id")]
        public int SourceEntityId { get; set; }
        [Column("entity_type_id")]
        public int EntityTypeId { get; set; }
        [Column("json")]
        public string Json { get; set; }
    }
}
