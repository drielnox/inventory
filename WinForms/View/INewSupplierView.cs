// <copyright file="INewSupplierView.cs" company="Open Source">
// Copyright (c) Open Source. All rights reserved.
// </copyright>

using SmartInventorySystem.ViewModel.Forms;
using SmartInventorySystem.WinForms.Core;

namespace SmartInventorySystem.WinForms.View
{
    interface INewSupplierView : IView<NewSupplierFormViewModel>
    {
        void UpdateFormBindingSource();
    }
}
