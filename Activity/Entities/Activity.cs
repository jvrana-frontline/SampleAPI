using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FL.PG.PLM_EEM_API.Entities
{
    public class Activity
    {
        public int int_ActivityID { get; set; }
        public string var_ActivityTitle { get; set; }
        public string var_ActivityDesc { get; set; }
        public int int_DistrictID { get; set; }
        public int int_ProviderID { get; set; }
        public int int_ActivityFormatID { get; set; }
        public int int_PaymentFormatID { get; set; }
        public int int_CCatalogID { get; set; }
        public int int_EventID { get; set; }
        public string var_Type { get; set; }
        public int int_InstructorUserID { get; set; }
        public string var_InstructorName { get; set; }
        public DateTime? dt_Date { get; set; }
        public DateTime? dt_StartDate { get; set; }
        public DateTime? dt_EndDate { get; set; }
        public string var_MeetingDates { get; set; }
        public DateTime? dt_DateExpired { get; set; }
        public string var_URL { get; set; }
        public int int_MaxUsers { get; set; }
        public bool bit_ApprovalRequired { get; set; }
        public bool bit_UserCanEdit { get; set; }
        public bool bit_QuickApprove { get; set; }
        public float rl_ActivityHours { get; set; }
        public float rl_Credits { get; set; }
        public string var_Comments { get; set; }
        public int? int_FormID { get; set; }
        public string var_ConferenceLocation { get; set; }
        public string var_Audience { get; set; }
        public string var_Level { get; set; }
        public decimal mon_SubscriberFee { get; set; }
        public decimal mon_NonSubscriberFee { get; set; }
        public DateTime dt_DateAdded { get; set; }
        public DateTime dt_DateUpdated { get; set; }
        public bool bit_Archived { get; set; }
        public bool bit_Future2 { get; set; }
        public bool bit_Future3 { get; set; }
        public string var_Future1 { get; set; }
        public string var_SessionCode { get; set; }
        public string var_Future3 { get; set; }
        public float rl_Future1 { get; set; }
        public float rl_Future2 { get; set; }
        public float rl_Future3 { get; set; }
        public int int_MinUsers { get; set; }
        public int int_CourseCodeID { get; set; }
        public int int_Future3 { get; set; }
        public bool bit_ShowSubscriberFee { get; set; }
        public DateTime? dt_StartShowing { get; set; }
        public DateTime? dt_StopShowing { get; set; }
        public string var_ProviderName { get; set; }
        public string var_CourseCode { get; set; }
        public int int_WaitListMax { get; set; }
        public bool bit_WaitListAuto { get; set; }
        public int int_EvalFormID { get; set; }
        public int int_ConfTimeSlotID { get; set; }
        public int int_ProgramID { get; set; }
        public bool bit_TeamRoomDiscussEnabled { get; set; }
        public bool bit_TeamRoomFilesEnabled { get; set; }
        public bool bit_PreRegOnly { get; set; }
        public string var_DescriptionLarge { get; set; }
        public int int_ProposalLPID { get; set; }
        public string var_Annotations { get; set; }
        public int? int_OwnerID { get; set; }
        public string var_ExternalID { get; set; }
        public int? int_FeaturedPriority { get; set; }
    }
}
