using SmartInventorySystem.WinForms.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartInventorySystem.ViewModel;

namespace SmartInventorySystem.WinForms.View
{
    interface IListStockView : IView
    {
        void SetStockBindingSource(List<StockViewModel> stock);
    }
}
