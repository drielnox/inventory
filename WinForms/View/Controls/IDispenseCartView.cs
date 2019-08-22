// <copyright file="IDispenseCartView.cs" company="Open Source">
// Copyright (c) Open Source. All rights reserved.
// </copyright>

namespace SmartInventorySystem.WinForms.View.Controls
{
    using System;
    using Core;
    using SmartInventorySystem.WinForms.Controls;
    using ViewModel.Controls;
    using ViewModel.Controls.Grids;

    interface IDispenseCartView : IView<DispenseCartControlViewModel>
    {
        event EventHandler<DispenseCartSaveEventArgs> OnSave;

        ItemToCheckoutRowViewModel SelectedItem { get; }

        void EnableRemoveButton(bool v);

        void FireOnSave(DispenseCartControlViewModel state);
    }
}
