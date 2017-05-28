using System.ComponentModel.DataAnnotations.Schema;


namespace OpenCaseWork.Constituents.Models.Domains
{
    [Table("state")]
    public class State
    {
        [Column("state_id")]
        public int Id { get; set; }
        [Column("state")]
        public string StateCd { get; set; }
        [Column("state_name")]
        public string StateName { get; set; }
    }
}
