using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInventorySystem.ViewModel
{
    public class DispenseSheetViewModel
    {
        public int DispenseQuantity { get; set; }
        public string ItemName { get; set; }
        public float SubAmount { get; set; }
    }
}
