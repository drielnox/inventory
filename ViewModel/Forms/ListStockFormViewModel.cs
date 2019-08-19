using SmartInventorySystem.ViewModel.Core;
using SmartInventorySystem.ViewModel.Grids;
using System.Collections.Generic;
using System;

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
