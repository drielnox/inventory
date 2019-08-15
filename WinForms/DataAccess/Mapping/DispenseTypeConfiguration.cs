using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartInventorySystem.WinForms.Model;

namespace SmartInventorySystem.WinForms.DataAccess.Mapping
{
    class DispenseTypeConfiguration : EntityTypeConfiguration<Dispense>
    {
        public DispenseTypeConfiguration()
        : base()
        {
            ToTable("dispense");

            HasKey(x => x.Identifier);

            Property(x => x.Identifier)
                .HasColumnName("dispense_id")
                .IsRequired()
                .HasColumnOrder(0)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ItemId)
                .HasColumnName("item_id")
                .IsRequired()
                .HasColumnOrder(1)
                .IsVariableLength()
                .HasMaxLength(30);
            Property(x => x.GroupId)
                .HasColumnName("group_id")
                .IsRequired()
                .HasColumnOrder(2)
                .IsVariableLength()
                .HasMaxLength(11);
            Property(x => x.GroupDate)
                .HasColumnName("group_date")
                .IsRequired()
                .HasColumnOrder(3);
            Property(x => x.ItemCode)
                .HasColumnName("item_code")
                .IsOptional()
                .HasColumnOrder(4)
                .IsVariableLength()
                .HasMaxLength(30);
            Property(x => x.ItemName)
                .HasColumnName("item_name")
                .IsRequired()
                .HasColumnOrder(5)
                .IsVariableLength()
                .HasMaxLength(100);
            Property(x => x.StockLevel)
                .HasColumnName("stock_level")
                .IsRequired()
                .HasColumnOrder(6);
            Property(x => x.UnitPrice)
                .HasColumnName("unit_price")
                .IsOptional()
                .HasColumnOrder(7);
            Property(x => x.DispenseQuantity)
                .HasColumnName("dispense_quantity")
                .IsRequired()
                .HasColumnOrder(8);
            Property(x => x.SubAmount)
                .HasColumnName("sub_amount")
                .IsOptional()
                .HasColumnOrder(9);
            Property(x => x.Vat)
                .HasColumnName("vat")
                .IsOptional()
                .HasColumnOrder(10);
            Property(x => x.TotalAmount)
                .HasColumnName("total_amount")
                .IsOptional()
                .HasColumnOrder(11);
            Property(x => x.StockBalance)
                .HasColumnName("stock_balance")
                .IsOptional()
                .HasColumnOrder(12);
            Property(x => x.DateDispensed)
                .HasColumnName("date_dispensed")
                .IsOptional()
                .HasColumnOrder(13);
            Property(x => x.UserDispensed)
                .HasColumnName("user_dispensed")
                .IsOptional()
                .HasColumnOrder(14)
                .IsVariableLength()
                .HasMaxLength(45);
            Property(x => x.DispenseCompleted)
                .HasColumnName("dispense_completed")
                .IsOptional()
                .HasColumnOrder(15)
                .IsVariableLength()
                .HasMaxLength(5);
        }
    }
}
