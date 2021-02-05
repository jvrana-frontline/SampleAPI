using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace FL.PG.PLM_EEM_API.ViewModels
{
    public class ActivityModel
    {
        public int Id { get; set; }
        public string ActivityTitle { get; set; }
        public string ActivityDesc { get; set; }
        public int DistrictID { get; set; }
        public int ProviderID { get; set; }
        public int ActivityFormatID { get; set; }
        public int PaymentFormatID { get; set; }
        public int CCatalogID { get; set; }
        public int EventID { get; set; }
        public string Type { get; set; }
        public int InstructorUserID { get; set; }
        public string InstructorName { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string MeetingDates { get; set; }
        public DateTime? DateExpired { get; set; }
        public string URL { get; set; }
        public int MaxUsers { get; set; }
        public bool ApprovalRequired { get; set; }
        public bool UserCanEdit { get; set; }
        public bool QuickApprove { get; set; }
        public float ActivityHours { get; set; }
        public float Credits { get; set; }
        public string Comments { get; set; }
        public int? FormID { get; set; }
        public string ConferenceLocation { get; set; }
        public string Audience { get; set; }
        public string Level { get; set; }
        public decimal SubscriberFee { get; set; }
        public decimal NonSubscriberFee { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Archived { get; set; }
        public bool Future2 { get; set; }
        public bool Future3 { get; set; }
        public string Future1 { get; set; }
        public string SessionCode { get; set; }
        public string Future3 { get; set; }
        public float Future1 { get; set; }
        public float Future2 { get; set; }
        public float Future3 { get; set; }
        public int MinUsers { get; set; }
        public int CourseCodeID { get; set; }
        public int Future3 { get; set; }
        public bool ShowSubscriberFee { get; set; }
        public DateTime? StartShowing { get; set; }
        public DateTime? StopShowing { get; set; }
        public string ProviderName { get; set; }
        public string CourseCode { get; set; }
        public int WaitListMax { get; set; }
        public bool WaitListAuto { get; set; }
        public int EvalFormID { get; set; }
        public int ConfTimeSlotID { get; set; }
        public int ProgramID { get; set; }
        public bool TeamRoomDiscussEnabled { get; set; }
        public bool TeamRoomFilesEnabled { get; set; }
        public bool PreRegOnly { get; set; }
        public string DescriptionLarge { get; set; }
        public int ProposalLPID { get; set; }
        public string Annotations { get; set; }
        public int? OwnerID { get; set; }
        public string ExternalID { get; set; }
        public int? FeaturedPriority { get; set; }
    }

    public class ActivityModelValidator : AbstractValidator<ActivityModel>
    {
        public ActivityModelValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.ActivityTitle).NotNull().Length(0, 250);
            RuleFor(x => x.ActivityDesc).NotNull().Length(0, 2048);
            RuleFor(x => x.DistrictID).NotNull();
            RuleFor(x => x.ProviderID).NotNull();
            RuleFor(x => x.ActivityFormatID).NotNull();
            RuleFor(x => x.PaymentFormatID).NotNull();
            RuleFor(x => x.CCatalogID).NotNull();
            RuleFor(x => x.EventID).NotNull();
            RuleFor(x => x.Type).NotNull().Length(0, 50);
            RuleFor(x => x.InstructorUserID).NotNull();
            RuleFor(x => x.InstructorName).NotNull().Length(0, 50);
            RuleFor(x => x.Date).Null();
            RuleFor(x => x.StartDate).Null();
            RuleFor(x => x.EndDate).Null();
            RuleFor(x => x.MeetingDates).NotNull().Length(0, 250);
            RuleFor(x => x.DateExpired).Null();
            RuleFor(x => x.URL).NotNull().Length(0, 256);
            RuleFor(x => x.MaxUsers).NotNull();
            RuleFor(x => x.ApprovalRequired).NotNull();
            RuleFor(x => x.UserCanEdit).NotNull();
            RuleFor(x => x.QuickApprove).NotNull();
            RuleFor(x => x.ActivityHours).NotNull();
            RuleFor(x => x.Credits).NotNull();
            RuleFor(x => x.Comments).NotNull().Length(0, 2048);
            RuleFor(x => x.FormID).Null();
            RuleFor(x => x.ConferenceLocation).NotNull().Length(0, 50);
            RuleFor(x => x.Audience).Null().Length(0, 500);
            RuleFor(x => x.Level).NotNull().Length(0, 100);
            RuleFor(x => x.SubscriberFee).NotNull();
            RuleFor(x => x.NonSubscriberFee).NotNull();
            RuleFor(x => x.DateAdded).NotNull();
            RuleFor(x => x.DateUpdated).NotNull();
            RuleFor(x => x.Archived).NotNull();
            RuleFor(x => x.Future2).NotNull();
            RuleFor(x => x.Future3).NotNull();
            RuleFor(x => x.Future1).NotNull().Length(0, 75);
            RuleFor(x => x.SessionCode).NotNull().Length(0, 75);
            RuleFor(x => x.Future3).NotNull().Length(0, 75);
            RuleFor(x => x.Future1).NotNull();
            RuleFor(x => x.Future2).NotNull();
            RuleFor(x => x.Future3).NotNull();
            RuleFor(x => x.MinUsers).NotNull();
            RuleFor(x => x.CourseCodeID).NotNull();
            RuleFor(x => x.Future3).NotNull();
            RuleFor(x => x.ShowSubscriberFee).NotNull();
            RuleFor(x => x.StartShowing).Null();
            RuleFor(x => x.StopShowing).Null();
            RuleFor(x => x.ProviderName).NotNull().Length(0, 100);
            RuleFor(x => x.CourseCode).NotNull().Length(0, 25);
            RuleFor(x => x.WaitListMax).NotNull();
            RuleFor(x => x.WaitListAuto).NotNull();
            RuleFor(x => x.EvalFormID).NotNull();
            RuleFor(x => x.ConfTimeSlotID).NotNull();
            RuleFor(x => x.ProgramID).NotNull();
            RuleFor(x => x.TeamRoomDiscussEnabled).NotNull();
            RuleFor(x => x.TeamRoomFilesEnabled).NotNull();
            RuleFor(x => x.PreRegOnly).NotNull();
            RuleFor(x => x.DescriptionLarge).NotNull();
            RuleFor(x => x.ProposalLPID).NotNull();
            RuleFor(x => x.Annotations).Null().Length(0, 500);
            RuleFor(x => x.OwnerID).Null();
            RuleFor(x => x.ExternalID).Null().Length(0, 50);
            RuleFor(x => x.FeaturedPriority).Null();
        }
    }
}
