using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInventorySystem.ViewModel
{
    public class ItemViewModel
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
    }
}
