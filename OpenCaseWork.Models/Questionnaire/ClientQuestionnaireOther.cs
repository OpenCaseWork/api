using OpenCaseWork.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenCaseWork.Models.Questionnaire
{
    [Table("client_questionaire_other")]
    public class ClientQuestionnaireOther: BaseEntity
    {
        [Column("questionaire_other_id")] public int Id { get; set; }
        [Column("questionaire_other_guid")] public Guid? QuestionaireOtherGuid { get; set; }
        [Column("questionaire_id")] public int? QuestionaireId { get; set; }
        [Column("type_id")] public int? TypeId { get; set; }
        [Column("caregiver_stress")] public string CaregiverStress { get; set; }
        [Column("other_stress")] public string OtherStress { get; set; }
        [Column("other_mental_health")] public string OtherMentalHealth { get; set; }
        [Column("social_support")] public string SocialSupport { get; set; }
        [Column("legal_issues")] public string LegalIssues { get; set; }
        [Column("financial_issues")] public string FinancialIssues { get; set; }
        [Column("hearing")] public string Hearing { get; set; }
        [Column("chronic")] public string Chronic { get; set; }
        [Column("home_safety")] public string HomeSafety { get; set; }
        [Column("spirituality")] public string Spirituality { get; set; }
 
    }
}
