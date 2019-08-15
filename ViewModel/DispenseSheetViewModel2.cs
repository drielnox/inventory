using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInventorySystem.ViewModel
{
    public class DispenseSheetViewModel2
    {
        public string DispenseCompleted { get; set; }
        public int DispenseQuantity { get; set; }
        public DateTime GroupDate { get; set; }
        public string GroupId { get; set; }
        public string ItemName { get; set; }
        public float UnitPrice { get; set; }
    }
}
