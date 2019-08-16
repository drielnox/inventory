using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartInventorySystem.Model;

namespace SmartInventorySystem.DataAccess.Mapping
{
    class StockUpdateTypeConfiguration : EntityTypeConfiguration<StockUpdate>
    {
        public StockUpdateTypeConfiguration()
        {
            ToTable("stock_update");

            HasKey(x => x.Identifier);

            Property(x => x.Identifier)
                .HasColumnName("update_id")
                .IsRequired()
                .HasColumnOrder(0)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ItemId)
                .HasColumnName("item_id")
                .IsRequired()
                .HasColumnOrder(1)
                .IsVariableLength()
                .HasMaxLength(30);
            Property(x => x.ItemCode)
                .HasColumnName("item_code")
                .IsOptional()
                .HasColumnOrder(2)
                .IsVariableLength()
                .HasMaxLength(30);
            Property(x => x.ItemName)
                .HasColumnName("item_name")
                .IsRequired()
                .HasColumnOrder(3)
                .IsVariableLength()
                .HasMaxLength(100);
            Property(x => x.StockLevel)
                .HasColumnName("stock_level")
                .IsRequired()
                .HasColumnOrder(4);
            Property(x => x.QuantityAdded)
                .HasColumnName("qty_added")
                .IsOptional()
                .HasColumnOrder(5);
            Property(x => x.QuantityDeducted)
                .HasColumnName("qty_deducted")
                .IsOptional()
                .HasColumnOrder(6);
            Property(x => x.StockBalance)
                .HasColumnName("stock_balance")
                .IsOptional()
                .HasColumnOrder(7);
            Property(x => x.UpdatedAt)
                .HasColumnName("date_updated")
                .IsOptional()
                .HasColumnOrder(8);
            Property(x => x.UpdatedBy)
                .HasColumnName("user_updated")
                .IsOptional()
                .HasColumnOrder(9)
                .IsVariableLength()
                .HasMaxLength(45);
        }
    }
}
