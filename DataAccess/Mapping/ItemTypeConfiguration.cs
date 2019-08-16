using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartInventorySystem.Model;

namespace SmartInventorySystem.DataAccess.Mapping
{
    class ItemTypeConfiguration : EntityTypeConfiguration<Item>
    {
        public ItemTypeConfiguration()
        {
            ToTable("items_record");

            HasKey(x => x.Identifier);

            Property(x => x.Identifier)
                .HasColumnName("item_id")
                .IsRequired()
                .HasColumnOrder(0)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code)
                .HasColumnName("item_code")
                .IsOptional()
                .HasColumnOrder(1)
                .IsVariableLength()
                .HasMaxLength(30);
            Property(x => x.Name)
                .HasColumnName("item_name")
                .IsRequired()
                .HasColumnOrder(2)
                .IsVariableLength()
                .HasMaxLength(100);
            Property(x => x.Description)
                .HasColumnName("description")
                .IsOptional()
                .HasColumnOrder(3)
                .IsVariableLength()
                .HasMaxLength(200);
            Property(x => x.AlternativeName)
                .HasColumnName("alternative_name")
                .IsOptional()
                .HasColumnOrder(4)
                .IsVariableLength()
                .HasMaxLength(50);
            Property(x => x.Manufacturer)
                .HasColumnName("manufacturer")
                .IsOptional()
                .HasColumnOrder(5)
                .IsVariableLength()
                .HasMaxLength(100);
            Property(x => x.MajorSupplier)
                .HasColumnName("major_supplier")
                .IsOptional()
                .HasColumnOrder(6)
                .IsVariableLength()
                .HasMaxLength(100);
            Property(x => x.PackQuantity)
                .HasColumnName("pack_quantity")
                .IsOptional()
                .HasColumnOrder(7)
                .IsVariableLength()
                .HasMaxLength(50);
            Property(x => x.PackDescription)
                .HasColumnName("pack_description")
                .IsOptional()
                .HasColumnOrder(8)
                .IsVariableLength()
                .HasMaxLength(50);
            Property(x => x.AlternativeItem)
                .HasColumnName("alternative_item")
                .IsOptional()
                .HasColumnOrder(9)
                .IsVariableLength()
                .HasMaxLength(50);
            Property(x => x.StandardIssueQuantity)
                .HasColumnName("standard_issue_qty")
                .IsOptional()
                .HasColumnOrder(10)
                .IsVariableLength()
                .HasMaxLength(9);
            Property(x => x.EconomicOrderQuantity)
                .HasColumnName("economic_order_qty")
                .IsOptional()
                .HasColumnOrder(11)
                .IsVariableLength()
                .HasMaxLength(9);
            Property(x => x.PurchasePrice)
                .HasColumnName("purchase_price")
                .IsOptional()
                .HasColumnOrder(12);
            Property(x => x.MarkupPercent)
                .HasColumnName("markup_percent")
                .IsOptional()
                .HasColumnOrder(13);
            Property(x => x.SellingPrice)
                .HasColumnName("selling_price")
                .IsOptional()
                .HasColumnOrder(14);
            Property(x => x.StockLevel)
                .HasColumnName("stock_level")
                .IsOptional()
                .HasColumnOrder(15);
            Property(x => x.MinimumLevel)
                .HasColumnName("minimum_level")
                .IsOptional()
                .HasColumnOrder(16);
            Property(x => x.ReOrderLevel)
                .HasColumnName("reorder_level")
                .IsOptional()
                .HasColumnOrder(17);
            Property(x => x.MaximumLevel)
                .HasColumnName("maximum_level")
                .IsOptional()
                .HasColumnOrder(18);
            Property(x => x.LeadDays)
                .HasColumnName("lead_days")
                .IsOptional()
                .HasColumnOrder(19);
            Property(x => x.Expire)
                .HasColumnName("expire_days")
                .IsOptional()
                .HasColumnOrder(20);
            Property(x => x.CreatedAt)
                .HasColumnName("date_created")
                .IsOptional()
                .HasColumnOrder(21);
            Property(x => x.CreatedBy)
                .HasColumnName("user_created")
                .IsOptional()
                .HasColumnOrder(22)
                .IsVariableLength()
                .HasMaxLength(30);
            Property(x => x.ModifiedAt)
                .HasColumnName("date_amended")
                .IsOptional()
                .HasColumnOrder(23);
            Property(x => x.ModifiedBy)
                .HasColumnName("user_amended")
                .IsOptional()
                .HasColumnOrder(24)
                .IsVariableLength()
                .HasMaxLength(30);
        }
    }
}
