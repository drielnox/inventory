using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInventorySystem.Model
{
    public class Dispense
    {
        public int Identifier { get; set; }
        public string ItemId { get; set; }
        public string GroupId { get; set; }
        public DateTime GroupDate { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public int StockLevel { get; set; }
        public float UnitPrice { get; set; }
        public int DispenseQuantity { get; set; }
        public float SubAmount { get; set; }
        public float Vat { get; set; }
        public float TotalAmount { get; set; }
        public int StockBalance { get; set; }
        public DateTime DateDispensed { get; set; }
        public string UserDispensed { get; set; }
        public string DispenseCompleted { get; set; }
    }
}
