using System.Data.Entity.ModelConfiguration;
using SmartInventorySystem.Model;

namespace SmartInventorySystem.DataAccess.Mapping
{
    class UserTypeConfiguration : EntityTypeConfiguration<User>
    {
        public UserTypeConfiguration() 
            : base()
        {
            ToTable("users");

            HasKey(x => x.Identifier);

            Property(x => x.Identifier)
                .HasColumnName("id")
                .IsRequired()
                .HasColumnOrder(0)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.FirstName)
                .HasColumnName("first_name")
                .IsOptional()
                .HasColumnOrder(1)
                .IsVariableLength()
                .HasMaxLength(45);
            Property(x => x.LastName)
                .HasColumnName("last_name")
                .IsOptional()
                .HasColumnOrder(2)
                .IsVariableLength()
                .HasMaxLength(45);
            Property(x => x.UserName)
                .HasColumnName("username")
                .IsRequired()
                .HasColumnOrder(3)
                .IsVariableLength()
                .HasMaxLength(45);
            Property(x => x.Password)
                .HasColumnName("password")
                .IsRequired()
                .HasColumnOrder(4)
                .IsVariableLength()
                .HasMaxLength(45);
            Property(x => x.Role)
                .HasColumnName("user_role")
                .IsOptional()
                .HasColumnOrder(5)
                .IsVariableLength()
                .HasMaxLength(45);
            Property(x => x.Email)
                .HasColumnName("email")
                .IsOptional()
                .HasColumnOrder(6)
                .IsVariableLength()
                .HasMaxLength(100);
            Property(x => x.Phone)
                .HasColumnName("phone")
                .IsRequired()
                .HasColumnOrder(7)
                .IsVariableLength()
                .HasMaxLength(30);
            Property(x => x.CreatedAt)
                .HasColumnName("date_created")
                .IsOptional()
                .HasColumnOrder(8);
            Property(x => x.CreatedBy)
                .HasColumnName("user_created")
                .IsOptional()
                .HasColumnOrder(9)
                .IsVariableLength()
                .HasMaxLength(30);
            Property(x => x.ModifiedAt)
                .HasColumnName("date_amended")
                .IsOptional()
                .HasColumnOrder(10);
            Property(x => x.ModifiedBy)
                .HasColumnName("user_amended")
                .IsOptional()
                .HasColumnOrder(11)
                .IsVariableLength()
                .HasMaxLength(30);
        }
    }
}
