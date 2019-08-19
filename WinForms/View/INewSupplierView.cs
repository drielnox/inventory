using SmartInventorySystem.ViewModel.Forms;
using SmartInventorySystem.WinForms.Core;

namespace SmartInventorySystem.WinForms.View
{
    interface INewSupplierView : IView<NewSupplierFormViewModel>
    {
        void UpdateFormBindingSource();
    }
}
