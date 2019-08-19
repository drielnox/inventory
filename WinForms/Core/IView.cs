using SmartInventorySystem.ViewModel.Core;
using System;

namespace SmartInventorySystem.WinForms.Core
{
    interface IView
    {
        void ShowInfo(string msg);
        void ShowError(Exception ex);
    }

    interface IView<out TFormViewModel> : IView
        where TFormViewModel : FormViewModel
    {
        TFormViewModel ViewModel { get; }
        void UpdateFormBindingSource();
    }
}
