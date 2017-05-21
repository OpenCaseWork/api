using System.ComponentModel.DataAnnotations.Schema;

namespace OpenCaseWork.Constituents.Models.Domains
{
    [Table("titles")]
    public class Title
    {
        [Column("title_id")]
        public System.Int16 TitleId { get; set; }
        [Column("title_text")]
        public string TitleText { get; set; }
    }
}
