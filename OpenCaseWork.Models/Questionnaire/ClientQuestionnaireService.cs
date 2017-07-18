using OpenCaseWork.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenCaseWork.Models.Questionnaire
{
    [Table("[client_questionaire_service]")]
    public class ClientQuestionnaireService: BaseEntity
    {
        [Column("questionaire_service_id")] public int Id { get; set; }
        [Column("questionaire_service_guid")] public Guid? QuestionaireServiceGuid { get; set; }
        [Column("questionaire_id")] public int? QuestionaireId { get; set; }
        [Column("type_id")] public int? TypeId { get; set; }
        [Column("ads_ccp")] public string AdsCcp { get; set; }
        [Column("ads_transport")] public string AdsTransport { get; set; }
        [Column("ads")] public string Ads { get; set; }
        [Column("adult_protective")] public string AdultProtective { get; set; }
        [Column("advance_directives")] public string AdvanceDirectives { get; set; }
        [Column("advocacy_groups")] public string AdvocacyGroups { get; set; }
        [Column("ccp_homemaker")] public string CcpHomemaker { get; set; }
        [Column("chore_housekeeping")] public string ChoreHousekeeping { get; set; }
        [Column("counseling")] public string Counseling { get; set; }
        [Column("ers_ccp")] public string ErsCcp { get; set; }
        [Column("ers")] public string Ers { get; set; }
        [Column("entitlements")] public string Entitlements { get; set; }
        [Column("friendly_visiting")] public string FriendlyVisiting { get; set; }
        [Column("grg_program")] public string GrgProgram { get; set; }
        [Column("home_deliver_meals")] public string HomeDeliverMeals { get; set; }
        [Column("home_health_care")] public string HomeHealthCare { get; set; }
        [Column("housing")] public string Housing { get; set; }
        [Column("legal")] public string Legal { get; set; }
        [Column("money_management")] public string MoneyManagement { get; set; }
        [Column("private_home_care")] public string PrivateHomeCare { get; set; }
        [Column("private_care_mgmt")] public string PrivateCareMgmt { get; set; }
        [Column("respite")] public string Respite { get; set; }
        [Column("retirement")] public string Retirement { get; set; }
        [Column("support_groups")] public string SupportGroups { get; set; }
        [Column("transportation")] public string Transportation { get; set; }

    }
}
