using SmartInventorySystem.WinForms.Core;
using SmartInventorySystem.ViewModel.Forms;
using SmartInventorySystem.ViewModel.Grids;

namespace SmartInventorySystem.WinForms.View
{
    interface IListStockView : IView<ListStockFormViewModel>
    {
        void ShowUpdateStockForm(StockRowViewModel selectedStock);
        void AskDeleteStockMessage(StockRowViewModel selectedStock);
        void SetUpdateButtonEnable(bool v);
        void SetDeleteButtonEnable(bool v);
    }
}
