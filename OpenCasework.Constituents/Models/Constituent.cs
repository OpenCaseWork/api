﻿using OpenCaseWork.Models.Audit;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenCaseWork.Constituents.Models
{
    public class Constituent: AuditFields
    {
        [Column("constituent_id")]
        public long ConstituentId { get; set; }
        [Column("title_id")]
        public int TitleID { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("middle_name")]
        public string MiddleName { get; set; }
        [Column("suffix_id")]
        public int SuffixID { get; set; }
        public string NickName { get; set; }
        [Column("addr1")]
        public string Address1 { get; set; }
        [Column("addr2")]
        public string Address2 { get; set; }
        [Column("city_id")]
        public int CityID { get; set; }
        [Column("township_id")]
        public int TownshipID { get; set; }
        [Column("state_cd")]
        public string StateCd { get; set; }
        [Column("zip_code_id")]
        public int PostalCodeID { get; set; }
        [Column("zip_code")]
        public string PostalCode { get; set; }

        [Column("federal_id")]
        public string FederalID { get; set; }
        [Column("birth_date")]
        public DateTime BirthDate { get; set; }
        [Column("gender")]
        public int GenderId { get; set; }
        [Column("minority_id")]
        public int MinorityId { get; set; }
        [Column("income_level_id")]
        public int IncomeLevelId { get; set; }
        [Column("maiden_name")]
        public string MaidenName { get; set; }

        [Column("living_alone")]
        public bool LivingAlone { get; set; }
        [Column("lives_in_nursing_home")]
        public bool LivesInNursingHome { get; set; }
        [Column("frail_disabled")]
        public bool FrailDisabled { get; set; }
        [Column("limited_english")]
        public bool LimitedEnglish { get; set; }
        [Column("case_worker_risk")]
        public bool CaseWorkerRisk { get; set; }
        [Column("homeless")]
        public bool Homeless { get; set; }
        [Column("female_headed_household")]
        public bool FemaleHeadedHousehold { get; set; }
        [Column("pet")]
        public bool Pet { get; set; }


    }
}
