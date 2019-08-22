using SmartInventorySystem.ViewModel.Core;

namespace SmartInventorySystem.ViewModel.Controls
{
    public class DispenseItemDetailsControlViewModel : FormViewModel
    {
        public int ItemId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockLevel { get; set; }
        public int Quantity { get; set; }
    }
}
