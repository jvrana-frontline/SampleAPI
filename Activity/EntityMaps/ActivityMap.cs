using FL.PG.PLM_EEM_API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FL.PG.PLM_EEM_API.EntityMaps
{
    public class ActivityMap : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.ToTable("tbl_Activities");

            builder.HasKey(t => t.Id);

            builder.Property(e => e.Id).HasColumnName("int_ActivityID").HasDefaultValue(0);
            builder.Property(e => e.ActivityTitle).HasColumnName("var_ActivityTitle").HasDefaultValue("");
            builder.Property(e => e.ActivityDesc).HasColumnName("var_ActivityDesc").HasDefaultValue("");
            builder.Property(e => e.DistrictID).HasColumnName("int_DistrictID").HasDefaultValue(0);
            builder.Property(e => e.ProviderID).HasColumnName("int_ProviderID").HasDefaultValue(0);
            builder.Property(e => e.ActivityFormatID).HasColumnName("int_ActivityFormatID").HasDefaultValue(0);
            builder.Property(e => e.PaymentFormatID).HasColumnName("int_PaymentFormatID").HasDefaultValue(0);
            builder.Property(e => e.CCatalogID).HasColumnName("int_CCatalogID").HasDefaultValue(0);
            builder.Property(e => e.EventID).HasColumnName("int_EventID").HasDefaultValue(0);
            builder.Property(e => e.Type).HasColumnName("var_Type").HasDefaultValue("");
            builder.Property(e => e.InstructorUserID).HasColumnName("int_InstructorUserID").HasDefaultValue(0);
            builder.Property(e => e.InstructorName).HasColumnName("var_InstructorName").HasDefaultValue("");
            builder.Property(e => e.Date).HasColumnName("dt_Date").HasDefaultValue(new System.DateTime(1900, 1, 1));
            builder.Property(e => e.StartDate).HasColumnName("dt_StartDate").HasDefaultValue(new System.DateTime(1900, 1, 1));
            builder.Property(e => e.EndDate).HasColumnName("dt_EndDate").HasDefaultValue(new System.DateTime(1900, 1, 1));
            builder.Property(e => e.MeetingDates).HasColumnName("var_MeetingDates").HasDefaultValue("");
            builder.Property(e => e.DateExpired).HasColumnName("dt_DateExpired").HasDefaultValue(new System.DateTime(1900, 1, 1));
            builder.Property(e => e.URL).HasColumnName("var_URL").HasDefaultValue("");
            builder.Property(e => e.MaxUsers).HasColumnName("int_MaxUsers").HasDefaultValue(0);
            builder.Property(e => e.ApprovalRequired).HasColumnName("bit_ApprovalRequired").HasDefaultValue(true);
            builder.Property(e => e.UserCanEdit).HasColumnName("bit_UserCanEdit").HasDefaultValue(true);
            builder.Property(e => e.QuickApprove).HasColumnName("bit_QuickApprove").HasDefaultValue(true);
            builder.Property(e => e.ActivityHours).HasColumnName("rl_ActivityHours").HasDefaultValue(0);
            builder.Property(e => e.Credits).HasColumnName("rl_Credits").HasDefaultValue(0);
            builder.Property(e => e.Comments).HasColumnName("var_Comments").HasDefaultValue("");
            builder.Property(e => e.FormID).HasColumnName("int_FormID").HasDefaultValue(0);
            builder.Property(e => e.ConferenceLocation).HasColumnName("var_ConferenceLocation").HasDefaultValue("");
            builder.Property(e => e.Audience).HasColumnName("var_Audience").HasDefaultValue("");
            builder.Property(e => e.Level).HasColumnName("var_Level").HasDefaultValue("");
            builder.Property(e => e.SubscriberFee).HasColumnName("mon_SubscriberFee").HasDefaultValue(0);
            builder.Property(e => e.NonSubscriberFee).HasColumnName("mon_NonSubscriberFee").HasDefaultValue(0);
            builder.Property(e => e.DateAdded).HasColumnName("dt_DateAdded").HasDefaultValue(new System.DateTime(1900, 1, 1));
            builder.Property(e => e.DateUpdated).HasColumnName("dt_DateUpdated").HasDefaultValue(new System.DateTime(1900, 1, 1));
            builder.Property(e => e.Archived).HasColumnName("bit_Archived").HasDefaultValue(true);
            builder.Property(e => e.Future2).HasColumnName("bit_Future2").HasDefaultValue(true);
            builder.Property(e => e.Future3).HasColumnName("bit_Future3").HasDefaultValue(true);
            builder.Property(e => e.Future1).HasColumnName("var_Future1").HasDefaultValue("");
            builder.Property(e => e.SessionCode).HasColumnName("var_SessionCode").HasDefaultValue("");
            builder.Property(e => e.Future3).HasColumnName("var_Future3").HasDefaultValue("");
            builder.Property(e => e.Future1).HasColumnName("rl_Future1").HasDefaultValue(0);
            builder.Property(e => e.Future2).HasColumnName("rl_Future2").HasDefaultValue(0);
            builder.Property(e => e.Future3).HasColumnName("rl_Future3").HasDefaultValue(0);
            builder.Property(e => e.MinUsers).HasColumnName("int_MinUsers").HasDefaultValue(0);
            builder.Property(e => e.CourseCodeID).HasColumnName("int_CourseCodeID").HasDefaultValue(0);
            builder.Property(e => e.Future3).HasColumnName("int_Future3").HasDefaultValue(0);
            builder.Property(e => e.ShowSubscriberFee).HasColumnName("bit_ShowSubscriberFee").HasDefaultValue(true);
            builder.Property(e => e.StartShowing).HasColumnName("dt_StartShowing").HasDefaultValue(new System.DateTime(1900, 1, 1));
            builder.Property(e => e.StopShowing).HasColumnName("dt_StopShowing").HasDefaultValue(new System.DateTime(1900, 1, 1));
            builder.Property(e => e.ProviderName).HasColumnName("var_ProviderName").HasDefaultValue("");
            builder.Property(e => e.CourseCode).HasColumnName("var_CourseCode").HasDefaultValue("");
            builder.Property(e => e.WaitListMax).HasColumnName("int_WaitListMax").HasDefaultValue(0);
            builder.Property(e => e.WaitListAuto).HasColumnName("bit_WaitListAuto").HasDefaultValue(true);
            builder.Property(e => e.EvalFormID).HasColumnName("int_EvalFormID").HasDefaultValue(0);
            builder.Property(e => e.ConfTimeSlotID).HasColumnName("int_ConfTimeSlotID").HasDefaultValue(0);
            builder.Property(e => e.ProgramID).HasColumnName("int_ProgramID").HasDefaultValue(0);
            builder.Property(e => e.TeamRoomDiscussEnabled).HasColumnName("bit_TeamRoomDiscussEnabled").HasDefaultValue(true);
            builder.Property(e => e.TeamRoomFilesEnabled).HasColumnName("bit_TeamRoomFilesEnabled").HasDefaultValue(true);
            builder.Property(e => e.PreRegOnly).HasColumnName("bit_PreRegOnly").HasDefaultValue(true);
            builder.Property(e => e.DescriptionLarge).HasColumnName("var_DescriptionLarge").HasDefaultValue("");
            builder.Property(e => e.ProposalLPID).HasColumnName("int_ProposalLPID").HasDefaultValue(0);
            builder.Property(e => e.Annotations).HasColumnName("var_Annotations").HasDefaultValue("");
            builder.Property(e => e.OwnerID).HasColumnName("int_OwnerID").HasDefaultValue(0);
            builder.Property(e => e.ExternalID).HasColumnName("var_ExternalID").HasDefaultValue("");
            builder.Property(e => e.FeaturedPriority).HasColumnName("int_FeaturedPriority").HasDefaultValue(0);
        }
    }
}
