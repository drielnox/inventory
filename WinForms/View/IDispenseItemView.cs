// <copyright file="IDispenseItemView.cs" company="Open Source">
// Copyright (c) Open Source. All rights reserved.
// </copyright>

namespace SmartInventorySystem.WinForms.View
{
    using Core;
    using ViewModel.Forms;
    using ViewModel.Forms.Grids;

    interface IDispenseItemView : IView<DispenseItemFormViewModel>
    {
        void SetSelectItemEnable(bool v);
        void SetItemDetailsPanelEnable(bool v);
        void LoadItemsDetails(ItemRowViewModel selectedItem);
        void AddItemToCart(object itemToCart);
    }
}
