using System.Data.Entity.ModelConfiguration;
using SmartInventorySystem.WinForms.Model;

namespace SmartInventorySystem.WinForms.DataAccess.Mapping
{
    class SupplierTypeConfiguration : EntityTypeConfiguration<Supplier>
    {
        public SupplierTypeConfiguration() 
            : base()
        {
            ToTable("suppliers");

            HasKey(x => x.Identifier);

            Property(x => x.Identifier)
                .HasColumnName("supplier_id")
                .IsRequired()
                .HasColumnOrder(0)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name)
                .HasColumnName("supplier_name")
                .IsRequired()
                .HasColumnOrder(1)
                .IsVariableLength()
                .HasMaxLength(50);
            Property(x => x.ContactPerson)
                .HasColumnName("contact_person")
                .IsRequired()
                .HasColumnOrder(2)
                .IsVariableLength()
                .HasMaxLength(50);
            Property(x => x.Address)
                .HasColumnName("office_address")
                .IsOptional()
                .HasColumnOrder(3)
                .IsVariableLength()
                .HasMaxLength(100);
            Property(x => x.Email)
                .HasColumnName("email")
                .IsOptional()
                .HasColumnOrder(4)
                .IsVariableLength()
                .HasMaxLength(100);
            Property(x => x.Phone)
                .HasColumnName("phone")
                .IsRequired()
                .HasColumnOrder(5)
                .IsVariableLength()
                .HasMaxLength(30);
            Property(x => x.CreatedAt)
                .HasColumnName("date_created")
                .IsOptional()
                .HasColumnOrder(6);
            Property(x => x.CreatedBy)
                .HasColumnName("user_created")
                .IsOptional()
                .HasColumnOrder(7)
                .IsVariableLength()
                .HasMaxLength(30);
            Property(x => x.ModifiedAt)
                .HasColumnName("date_amended")
                .IsOptional()
                .HasColumnOrder(8);
            Property(x => x.ModifiedBy)
                .HasColumnName("user_amended")
                .IsOptional()
                .HasColumnOrder(9)
                .IsVariableLength()
                .HasMaxLength(30);
        }
    }
}
