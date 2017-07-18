using OpenCaseWork.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenCaseWork.Models.Questionnaire
{
    [Table("client_questionaire")]
    public class ClientQuestionnaire: BaseEntity
    {
 
        [Column("questionaire_id")] public int Id { get; set; }
        [Column("constituent_id")] public int ConstituentId { get; set; }
        [Column("PROVIDER_ID")] public int? ProviderId { get; set; }
        [Column("EATING")] public string Eating { get; set; }
        [Column("BATHING")] public string Bathing { get; set; }
        [Column("GROOMING")] public string Grooming { get; set; }
        [Column("Dressing")] public string Dressing { get; set; }
        [Column("Transfer_Bed")] public string TransferBed { get; set; }
        [Column("Incontinence")] public string Incontinence { get; set; }
        [Column("Managing_Money")] public string ManagingMoney { get; set; }
        [Column("Telephoning")] public string Telephoning { get; set; }
        [Column("PREPARING_MEALS")] public string PreparingMeals { get; set; }
        [Column("Laundry")] public string Laundry { get; set; }
        [Column("Housework")] public string Housework { get; set; }
        [Column("OUTSIDE_HOME")] public string OutsideHome { get; set; }
        [Column("ROUTINE_MED_DIRECTIONS")] public string RoutineMedDirections { get; set; }
        [Column("SPECIAL_MED_DIRECTIONS")] public string   SpecialMedDirections { get; set; }
        [Column("BEING_ALONE")] public string BeingAlone { get; set; }
        [Column("QUES1")] public string  Ques1 { get; set; }
        [Column("Ques2")] public string  Ques2 { get; set; }
        [Column("Ques3")] public string  Ques3 { get; set; }
        [Column("Ques4")] public string  Ques4 { get; set; }
        [Column("Ques5")] public string  Ques5 { get; set; }
        [Column("Ques6")] public string  Ques6 { get; set; }
        [Column("Ques7")] public string  Ques7 { get; set; }
        [Column("Ques8")] public string  Ques8 { get; set; }
        [Column("Ques9")] public string  Ques9 { get; set; }
        [Column("Ques10")] public string  Ques10 { get; set; }
        [Column("EATING_UNMET_NEED")] public string  EatingUnmetNeed { get; set; }
        [Column("BATHING_UNMET_NEED")] public string  BathingUnmetNeed { get; set; }
        [Column("GROOMING_UNMET_NEED")] public string  GroomingUnmetNeed { get; set; }
        [Column("DRESSING_UNMET_NEED")] public string  DressingUnmetNeed { get; set; }
        [Column("TRANSFER_BED_UNMET_NEED")] public string  TransferBedUnmetNeed { get; set; }
        [Column("INCONTINENCE_UNMET_NEED")] public string  IncontinenceUnmetNeed { get; set; }
        [Column("MANAGING_MONEY_UNMET_NEED")] public string  ManagingMoneyUnmetNeed { get; set; }
        [Column("TELEPHONING_UNMET_NEED")] public string  TelephoningUnmetNeed { get; set; }
        [Column("PREPARING_MEALS_UNMET_NEED")] public string  PreparingMealsUnmetNeed { get; set; }
        [Column("LAUNDRY_UNMET_NEED")] public string  LaundryUnmetNeed { get; set; }
        [Column("HOUSEWORK_UNMET_NEED")] public string  HouseworkUnmetNeed { get; set; }
        [Column("OUTSIDE_HOME_UNMET_NEED")] public string  OutsideHomeUnmetNeed { get; set; }
        [Column("ROUTINE_MED_DIRECTIONS_UNMET_NEED")] public string  RoutineMedDirectionsUnmetNeed { get; set; }
        [Column("SPECIAL_MED_DIRECTIONS_UNMET_NEED")] public string  SpecialMedDirectionsUnmetNeed { get; set; }
        [Column("BEING_ALONE_UNMET_NEED")] public string  BeingAloneUnmetNeed { get; set; }
        [Column("MEALS_ON_WHEELS")] public string  MealsOnWheels { get; set; }
        [Column("CCP")] public string  Ccp { get; set; }
        [Column("HOME_HEALTH_CARE")] public string  HomeHealthCare { get; set; }
        [Column("PRIVATE_DUTY")] public string  PrivateDuty { get; set; }
        [Column("MONEY_MANAGEMENT")] public string  MoneyManagement { get; set; }
        [Column("SENIOR_ADVOCACY")] public string  SeniorAdvocacy { get; set; }
        [Column("CHORE_HOUSEKEEPING")] public string  ChoreHousekeeping { get; set; }
        [Column("TRANSPORTATION")] public string  Transportation { get; set; }
        [Column("ADULT_DAY_CARE")] public string  AdultDayCare { get; set; }
        [Column("TOTAL_DON_SCORE")] public int? TotalDonScore { get; set; }
        [Column("MMSE")] public int? Mmse { get; set; }
        [Column("FRIENDLY_VISITING")] public string  FriendlyVisiting { get; set; }
        [Column("PEER_COUNSELING")] public string  PeerCounseling { get; set; }
        [Column("LEGAL")] public string  Legal { get; set; }
        [Column("I_A")] public string  IA { get; set; }
        [Column("RETIREMENT_NURSING")] public string  RetirementNursing { get; set; }
        [Column("ENTITLEMENTS")] public string  Entitlements { get; set; }
        [Column("RESPITE")] public string  Respite { get; set; }
        [Column("COUNSELING")] public string  Counseling { get; set; }
        [Column("ELDER_ABUSE_SERVICES")] public string  ElderAbuseServices { get; set; }
        [Column("SUPPORT_GROUP")] public string  SupportGroup { get; set; }
        [Column("EMERGENCY_RESPONSE_SYSTEM")] public string  EmergencyResponseSystem { get; set; }
        [Column("ADVANCE_DIRECTIVES")] public string  AdvanceDirectives { get; set; }
        [Column("created_date")] public DateTime? CreatedDate { get; set; }
        [Column("RIGHTS")] public string  Rights { get; set; }
        [Column("MEALS_ON_WHEELS_DISCUSSED")] public string  MealsOnWheelsDiscussed { get; set; }
        [Column("CCP_DISCUSSED")] public string  CcpDiscussed { get; set; }
        [Column("HOME_HEALTH_CARE_DISCUSSED")] public string  HomeHealthCareDiscussed { get; set; }
        [Column("PRIVATE_DUTY_DISCUSSED")] public string  PrivateDutyDiscussed { get; set; }
        [Column("MONEY_MANAGEMENT_DISCUSSED")] public string  MoneyManagementDiscussed { get; set; }
        [Column("SENIOR_ADVOCACY_DISCUSSED")] public string  SeniorAdvocacyDiscussed { get; set; }
        [Column("CHORE_HOUSEKEEPING_DISCUSSED")] public string  ChoreHousekeepingDiscussed { get; set; }
        [Column("TRANSPORTATION_DISCUSSED")] public string  TransportationDiscussed { get; set; }
        [Column("ADULT_DAY_CARE_DISCUSSED")] public string  AdultDayCareDiscussed { get; set; }
        [Column("COGNITIVELY_INTACT")] public string  CognitivelyIntact { get; set; }
        [Column("COGNITIVELY_INTACT_UNMET_NEED")] public string  CognitivelyIntactUnmetNeed { get; set; }
        [Column("ADVANCE_DIRECTIVES_IN_PLACE")] public string  AdvanceDirectivesInPlace { get; set; }
        [Column("COUNSELING_IN_PLACE")] public string  CounselingInPlace { get; set; }
        [Column("ELDER_ABUSE_SERVICES_IN_PLACE")] public string  ElderAbuseServicesInPlace { get; set; }
        [Column("EMERGENCY_RESPONSE_SYSTEM_IN_PLACE")] public string  EmergencyResponseSystemInPlace { get; set; }
        [Column("ENTITLEMENTS_IN_PLACE")] public string  EntitlementsInPlace { get; set; }
        [Column("FRIENDLY_VISITING_IN_PLACE")] public string  FriendlyVisitingInPlace { get; set; }
        [Column("I_A_IN_PLACE")] public string  IAInPlace { get; set; }
        [Column("LEGAL_IN_PLACE")] public string  LegalInPlace { get; set; }
        [Column("PEER_COUNSELING_IN_PLACE")] public string  PeerCounselingInPlace { get; set; }
        [Column("RESPITE_IN_PLACE")] public string  RespiteInPlace { get; set; }
        [Column("RETIREMENT_NURSING_IN_PLACE")] public string  RetirementNursingInPlace { get; set; }
        [Column("RIGHTS_IN_PLACE")] public string  RightsInPlace { get; set; }
        [Column("SUPPORT_GROUP_IN_PLACE")] public string  SupportGroupInPlace { get; set; }
        [Column("CLIENT_AGREES")] public string  ClientAgrees { get; set; }
        [Column("MEALS_ON_WHEELS_REASON")] public string  MealsOnWheelsReason { get; set; }
        [Column("CCP_REASON")] public string  CcpReason { get; set; }
        [Column("HOME_HEALTH_CARE_REASON")] public string  HomeHealthCareReason { get; set; }
        [Column("PRIVATE_DUTY_REASON")] public string  PrivateDutyReason { get; set; }
        [Column("MONEY_MANAGEMENT_REASON")] public string  MoneyManagementReason { get; set; }
        [Column("SENIOR_ADVOCACY_REASON")] public string  SeniorAdvocacyReason { get; set; }
        [Column("CHORE_HOUSEKEEPING_REASON")] public string  ChoreHousekeepingReason { get; set; }
        [Column("TRANSPORTATION_REASON")] public string  TransportationReason { get; set; }
        [Column("ADULT_DAY_CARE_REASON")] public string  AdultDayCareReason { get; set; }
        [Column("COUNSELING_REASON")] public string  CounselingReason { get; set; }
        [Column("ELDER_ABUSE_SERVICES_REASON")] public string  ElderAbuseServicesReason { get; set; }
        [Column("FRIENDLY_VISITING_REASON")] public string  FriendlyVisitingReason { get; set; }
        [Column("PEER_COUNSELING_REASON")] public string  PeerCounselingReason { get; set; }
        [Column("RESPITE_REASON")] public string  RespiteReason { get; set; }
        [Column("SUPPORT_GROUP_REASON")] public string  SupportGroupReason { get; set; }
        [Column("IS_DEPRESSED")] public string  IsDepressed { get; set; }
        [Column("IS_STRESSED")] public string  IsStressed { get; set; }
        [Column("HAS_EMOTIONAL_ISSUES")] public string  HasEmotionalIssues { get; set; }
        [Column("NEEDS_SOCIAL_SUPPORT")] public string  NeedsSocialSupport { get; set; }
        [Column("MEANINGFUL_VOLUNTEER_ACTIVITY")] public string  MeaningfulVolunteerActivity { get; set; }
        [Column("HOUSING")] public string  Housing { get; set; }
        [Column("PRIVATE_GCM")] public string  PrivateGcm { get; set; }
        [Column("HOUSING_IN_PLACE")] public string  HousingInPlace { get; set; }
        [Column("PRIVATE_GCM_IN_PLACE")] public string  PrivateGcmInPlace { get; set; }
        [Column("created_by")] public string  CreatedBy { get; set; }
        [Column("updated_date")] public DateTime? UpdatedDate { get; set; }
        [Column("updated_by")] public string  UpdatedBy { get; set; }

    }
}
