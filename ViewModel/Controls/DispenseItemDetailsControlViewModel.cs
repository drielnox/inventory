using SmartInventorySystem.ViewModel.Core;

namespace SmartInventorySystem.ViewModel.Controls
{
    public class DispenseItemDetailsControlViewModel : FormViewModel
    {
        public int Amount { get; set; }
        public int UnitPrice { get; set; }
    }
}
