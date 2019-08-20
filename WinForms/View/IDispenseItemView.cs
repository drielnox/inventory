using SmartInventorySystem.ViewModel.Forms;
using SmartInventorySystem.ViewModel.Forms.Grids;
using SmartInventorySystem.WinForms.Core;

namespace SmartInventorySystem.WinForms.View
{
    interface IDispenseItemView : IView<DispenseItemFormViewModel>
    {
        void SetSelectItemEnable(bool v);
        void SetItemDetailsPanelEnable(bool v);
        void LoadItemsDetails(ItemRowViewModel selectedItem);
    }
}
