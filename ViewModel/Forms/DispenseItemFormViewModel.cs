using SmartInventorySystem.ViewModel.Core;
using SmartInventorySystem.ViewModel.Forms.Grids;
using System.Collections.Generic;

namespace SmartInventorySystem.ViewModel.Forms
{
    public class DispenseItemFormViewModel : FormViewModel
    {
        public DispenseItemFormViewModel()
        {
            SearchItemResult = new List<ItemRowViewModel>();
            ItemsForCheckout = new List<object>();
        }

        public string SearchItemText { get; set; }
        public List<ItemRowViewModel> SearchItemResult { get; set; }
        public ItemRowViewModel SelectedItem { get; set; }
        public List<object> ItemsForCheckout { get; set; }
        public object ItemToDispense { get; set; }
    }
}
