using OpenCaseWork.Models.Audit;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenCaseWork.Models.ContactEvents.Domains
{
    [Table("service_codes")]
    public class Service : AuditedEntity
    {
        [Column("SERVICE_CODE_ID")]
        public int Id { get; set; }
        [Column("SERVICE_CODE")]
        public int Code { get; set; }
        [Column("SERVICE_TYPE")]
        public string Type { get; set; }
        [Column("SERVICE_DESCRIPTION")]
        public string Description { get; set; }
        [Column("Is_ACTIVE")]
        public bool IsActive { get; set; }
        [Column("UNITED_WAY_CATEGORY")]
        public string UnitedWayCategory { get; set; }
        [Column("is_CAREGIVER")]
        public bool IsCaregiver { get; set; }
        [Column("SERVICE_CODE_PARENT_CODE")]
        public int? ParentCode { get; set; }
        [Column("TITLE3_CATEGORY")]
        public string Title3Category { get; set; }
        [Column("AGE_OPTIONS_CATEGORY")]
        public string AgeOptionsCategory { get; set; }
        [Column("has_WEEKLY_BLUE_SHEET")]
        public bool HasWeeklyBlueSheet { get; set; }
        [Column("is_subcode")]
        public bool IsSubCode { get; set; }
        [Column("SERVICE_TYPE_GROUP_ID")]
        public int? ServiceTypeGroupId { get; set; }
        [Column("Notes")]
        public string Notes { get; set; }
        [Column("AGE_OPTIONS_CATEGORY_2")]
        public string AgeOptionsCategory2 { get; set; }
        [Column("AGE_OPTIONS_CATEGORY_3")]
        public string AgeOptionsCategory3 { get; set; }
        [Column("is_AO_CAREGIVER_REQUIRED")]
        public bool IsAoCaregiverRequired { get; set; }

    }
}
