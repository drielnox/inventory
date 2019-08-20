// <copyright file="IDispenseItemDetailsView.cs" company="Open Source">
// Copyright (c) Open Source. All rights reserved.
// </copyright>

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
