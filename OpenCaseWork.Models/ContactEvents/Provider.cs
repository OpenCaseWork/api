using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenCaseWork.Models.ContactEvents
{
    [Table("provider")]
    public class Provider
    {
        [Column("PROVIDER_ID")]
        public int Id { get; set; }
        [Column("PROVIDER_NUMBER")]
        public int ProviderNumber { get; set; }
        [Column("DESCRIPTION")]
        public string Description { get; set; }
        [Column("ACTIVE")]
        public string Active { get; set; }
        [Column("BLUE_SHEET")]
        public string BlueSheet { get; set; }
        [Column("PROVIDER_LOCATION")]
        public string ProviderLocation { get; set; }
        [Column("GROUP_PROVIDER")]
        public string GroupProvider { get; set; }
        [Column("GROUP_PROVIDER_NAME")]
        public string GroupProviderName { get; set; }
        [Column("manager_id")]
        public int? ManagerId { get; set; }
        [Column("is_manager")]
        public string IsManager { get; set; }
        [Column("create_date")]
        public DateTime? CreateDate { get; set; }
        [Column("update_date")]
        public DateTime? UpdateDate { get; set; }
        [Column("create_user")]
        public string CreateUser { get; set; }
        [Column("update_user")]
        public string UpdateUser { get; set; }
        [Column("hours_per_week")]
        public int? HoursPerWeek { get; set; }
        [Column("manager2_id")]
        public int? Manager2Id { get; set; }
        [Column("manager3_id")]
        public int? Manager3Id { get; set; }
        [Column("start_date")]
        public DateTime? StartDate { get; set; }
        [Column("term_date")]
        public DateTime? TermDate { get; set; }
         
 
	 
 

    }
}
