// <copyright file="IItemSearchView.cs" company="Open Source">
// Copyright (c) Open Source. All rights reserved.
// </copyright>

namespace SmartInventorySystem.WinForms.View.Controls
{
    using Core;
    using ViewModel.Controls;
    using ViewModel.Forms.Grids;

    interface IItemSearchView : IView<ItemSearchControlViewModel>
    {
        ItemRowViewModel SelectedItem { get; }

        void FireOnItemSelected(ItemRowViewModel selectedItem);
    }
}
