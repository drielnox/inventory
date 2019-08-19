using SmartInventorySystem.ViewModel.Core;
using System.Collections.Generic;

namespace SmartInventorySystem.ViewModel.Forms
{
    public class DispenseItemFormViewModel : FormViewModel
    {
        public DispenseItemFormViewModel()
        {
            SearchItemResult = new List<ItemRowViewModel>();
        }

        public string SearchItemText { get; set; }
        public List<ItemRowViewModel> SearchItemResult { get; set; }
        public ItemRowViewModel SelectedItem { get; set; }
    }
}
