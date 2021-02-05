using FL.PG.PLM_EEM_API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FL.PG.PLM_EEM_API.EntityMaps
{
    public class BuildingMap : IEntityTypeConfiguration<Building>
    {
        public void Configure(EntityTypeBuilder<Building> builder)
        {
            builder.ToTable("tbl_Buildings");

            builder.HasKey(t => t.Id);

            builder.Property(e => e.Id).HasColumnName("int_BuildingID").HasDefaultValue(0);
            builder.Property(e => e.DistrictID).HasColumnName("int_DistrictID").HasDefaultValue(0);
            builder.Property(e => e.BuildingName).HasColumnName("var_BuildingName").HasDefaultValue("");
            builder.Property(e => e.BuildingType).HasColumnName("var_BuildingType").HasDefaultValue("");
            builder.Property(e => e.BuildingAddress2).HasColumnName("var_BuildingAddress2").HasDefaultValue("");
            builder.Property(e => e.BuildingAddress1).HasColumnName("var_BuildingAddress1").HasDefaultValue("");
            builder.Property(e => e.BuildingCity).HasColumnName("var_BuildingCity").HasDefaultValue("");
            builder.Property(e => e.BuildingState).HasColumnName("var_BuildingState").HasDefaultValue("");
            builder.Property(e => e.BuildingZip).HasColumnName("var_BuildingZip").HasDefaultValue("");
            builder.Property(e => e.BuildingContact).HasColumnName("var_BuildingContact").HasDefaultValue("");
            builder.Property(e => e.BuildingPhone).HasColumnName("var_BuildingPhone").HasDefaultValue("");
            builder.Property(e => e.AdminID).HasColumnName("int_AdminID").HasDefaultValue(0);
            builder.Property(e => e.Order).HasColumnName("int_Order").HasDefaultValue(0);
            builder.Property(e => e.Admin2ID).HasColumnName("int_Admin2ID").HasDefaultValue(0);
            builder.Property(e => e.BuildingCode).HasColumnName("var_BuildingCode").HasDefaultValue("");
            builder.Property(e => e.Admin3ID).HasColumnName("int_Admin3ID").HasDefaultValue(0);
            builder.Property(e => e.Active).HasColumnName("bit_Active").HasDefaultValue(true);
            builder.Property(e => e.Admin4ID).HasColumnName("int_Admin4ID").HasDefaultValue(0);
            builder.Property(e => e.Admin5ID).HasColumnName("int_Admin5ID").HasDefaultValue(0);
            builder.Property(e => e.BNCESID).HasColumnName("var_BNCESID").HasDefaultValue("");
            builder.Property(e => e.Admin6ID).HasColumnName("int_Admin6ID").HasDefaultValue(0);
            builder.Property(e => e.Admin7ID).HasColumnName("int_Admin7ID").HasDefaultValue(0);
            builder.Property(e => e.Admin8ID).HasColumnName("int_Admin8ID").HasDefaultValue(0);
            builder.Property(e => e.Admin9ID).HasColumnName("int_Admin9ID").HasDefaultValue(0);
            builder.Property(e => e.IsExternal).HasColumnName("bit_IsExternal").HasDefaultValue(true);
            builder.Property(e => e.RemoteSysName).HasColumnName("var_RemoteSysName").HasDefaultValue("");
            builder.Property(e => e.RemoteSysID).HasColumnName("var_RemoteSysID").HasDefaultValue("");
        }
    }
}
