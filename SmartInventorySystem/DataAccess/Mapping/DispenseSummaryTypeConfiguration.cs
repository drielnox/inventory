using SmartInventorySystem.Model;
using System.Data.Entity.ModelConfiguration;

namespace SmartInventorySystem.DataAccess.Mapping
{
    class DispenseSummaryTypeConfiguration : EntityTypeConfiguration<DispenseSummary>
    {
        public DispenseSummaryTypeConfiguration()
        {
            ToTable("dispense_summary");

            HasKey(x => x.DispenserId);

            Property(x => x.DispenserId)
                .HasColumnName("dsp_id")
                .IsRequired()
                .HasColumnOrder(0)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.GroupId)
                .HasColumnName("group_id")
                .IsRequired()
                .HasColumnOrder(1)
                .IsVariableLength()
                .HasMaxLength(10);
            Property(x => x.GroupDate)
                .HasColumnName("group_date")
                .IsRequired()
                .HasColumnOrder(2);
            Property(x => x.SubAmount)
                .HasColumnName("sub_amount")
                .IsRequired()
                .HasColumnOrder(3);
            Property(x => x.Total)
                .HasColumnName("discount")
                .IsOptional()
                .HasColumnOrder(4);
            Property(x => x.Vat)
                .HasColumnName("vat")
                .IsOptional()
                .HasColumnOrder(5);
            Property(x => x.Total)
                .HasColumnName("total")
                .IsOptional()
                .HasColumnOrder(6);
            Property(x => x.DateDispensed)
                .HasColumnName("date_dispensed")
                .IsOptional()
                .HasColumnOrder(7);
            Property(x => x.UserDispensed)
                .HasColumnName("user_dispensed")
                .IsOptional()
                .HasColumnOrder(8)
                .IsVariableLength()
                .HasMaxLength(30);
        }
    }
}
