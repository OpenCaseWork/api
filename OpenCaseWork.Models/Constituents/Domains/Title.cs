using System.ComponentModel.DataAnnotations.Schema;

namespace OpenCaseWork.Models.Constituents.Domains
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
