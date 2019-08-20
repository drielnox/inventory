using SmartInventorySystem.ViewModel.Controls;
using SmartInventorySystem.WinForms.Controls;
using SmartInventorySystem.WinForms.Core;

namespace SmartInventorySystem.WinForms.View.Controls
{
    interface IDispenseItemDetailsView : IView<DispenseItemDetailsControlViewModel>
    {
        void FireOnAddCartItem(AddCartItemEventArgs args);
    }
}
