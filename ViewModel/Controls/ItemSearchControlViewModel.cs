using SmartInventorySystem.ViewModel.Core;
using SmartInventorySystem.ViewModel.Forms.Grids;
using System.Collections.Generic;

namespace SmartInventorySystem.ViewModel.Controls
{
    public class ItemSearchControlViewModel : FormViewModel
    {
        public ItemSearchControlViewModel()
        {
            SearchResult = new List<ItemRowViewModel>();
        }

        public string SearchText { get; set; }
        public List<ItemRowViewModel> SearchResult { get; set; }
    }
}
