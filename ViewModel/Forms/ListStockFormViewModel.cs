using SmartInventorySystem.ViewModel.Core;
using System.Collections.Generic;
using SmartInventorySystem.ViewModel.Forms.Grids;

namespace SmartInventorySystem.ViewModel.Forms
{
    public class ListStockFormViewModel : FormViewModel
    {
        public StockRowViewModel SelectedStock { get; set; }
        public List<StockRowViewModel> CurrentStock { get; set; }

        public ListStockFormViewModel()
        {
            CurrentStock = new List<StockRowViewModel>();
        }
    }
}
