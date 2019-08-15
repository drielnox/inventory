using System;

namespace SmartInventorySystem.Model
{
    public class StockUpdate
    {
        public int Identifier { get; set; }
        public string ItemId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public int StockLevel { get; set; }
        public int QuantityAdded { get; set; }
        public int QuantityDeducted { get; set; }
        public int StockBalance { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }
}
