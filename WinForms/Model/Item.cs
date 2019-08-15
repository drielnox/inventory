using System;

namespace SmartInventorySystem.WinForms.Model
{
    public class Item : IAuditable
    {
        public int Identifier { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AlternativeName { get; set; }
        public string Manufacturer { get; set; }
        public string MajorSupplier { get; set; }
        public string PackQuantity { get; set; }
        public string PackDescription { get; set; }
        public string AlternativeItem { get; set; }
        public string StandardIssueQuantity { get; set; }
        public string EconomicOrderQuantity { get; set; }
        public float PurchasePrice { get; set; }
        public float MarkupPercent { get; set; }
        public float SellingPrice { get; set; }
        public int StockLevel { get; set; }
        public int MinimumLevel { get; set; }
        public int ReOrderLevel { get; set; }
        public int MaximumLevel { get; set; }
        public int LeadDays { get; set; }
        public DateTime? Expire { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string ModifiedBy { get; set; }
    }
}
