using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenCaseWork.Models.Attributes;
using OpenCaseWork.Models.Audit;
using OpenCaseWork.Models.Domains;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenCaseWork.Models.Constituents
{
    [Table("constituent")]
    public class Constituent : AuditedEntity
    {
        [Column("constituent_id")]
        public int ConstituentId { get; set; }
        [Column("title_id")]
        public int? TitleId { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("middle_name")]
        public string MiddleName { get; set; }
        [Column("suffix_id")]
        public int? SuffixId { get; set; }
        public string NickName { get; set; }
        [Column("addr1")]
        public string Address1 { get; set; }
        [Column("addr2")]
        public string Address2 { get; set; }
        [Column("city_id")]
        public int? CityId { get; set; }
        [Column("township_id")]
        public int? TownshipId { get; set; }
        [Column("state_id")]
        public int? StateId { get; set; }
        [Column("state_cd")]
        public string StateCd { get; set; }
        [Column("zip_id")]
        public int? PostalCodeId { get; set; }
        [Column("zip_code")]
        private string PostalCode { get; set; }
        [Column("federal_id")]
        public string FederalId { get; set; }
        [Column("birth_date")]
        public DateTime? BirthDate { get; set; }
        [Column("gender")]
        public int? GenderId { get; set; }
        [Column("minority_id")]
        public int? MinorityId { get; set; }
        [Column("ethnicity_id")]
        public int? EthnicityId { get; set; }
        [Column("income_level_id")]
        public int? IncomeLevelId { get; set; }
        [Column("preferred_language_id")]
        public int? PreferredLanguageId { get; set; }
        [Column("marital_status_id")]
        public int? MaritalStatusId { get; set; }
        [Column("maiden_name")]
        public string MaidenName { get; set; }
        [Column("living_alone")]
        public string LivingAlone { get; set; }
        [Column("lives_in_nursing_home")]
        public string LivesInNursingHome { get; set; }
        [Column("frail_disabled")]
        public string FrailDisabled { get; set; }
        [Column("limited_english")]
        public string LimitedEnglish { get; set; }
        [Column("case_worker_risk")]
        public string CaseWorkerRisk { get; set; }
        [Column("homeless")]
        public string Homeless { get; set; }
        [Column("female_headed_household")]
        public string FemaleHeadedHousehold { get; set; }
        [Column("pet")]
        public string Pet { get; set; }
        [Column("eccpis_number")]
        public string EccpisNumber { get; set; }
        [Column("rin_number")]
        public string RinNumber { get; set; }
        [Column("grg_count")]
        public int? GrgCount { get; set; }



    }
     

}