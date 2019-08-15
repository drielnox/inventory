using System;

namespace SmartInventorySystem.Model
{
    public class DispenseSummary
    {
        public int DispenserId { get; set; }
        public string GroupId { get; set; }
        public DateTime GroupDate { get; set; }
        public float SubAmount { get; set; }
        public float Discount { get; set; }
        public float Vat { get; set; }
        public float Total { get; set; }
        public DateTime DateDispensed { get; set; }
        public string UserDispensed { get; set; }
    }
}
