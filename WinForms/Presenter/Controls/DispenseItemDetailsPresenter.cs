// <copyright file="DispenseItemDetailsPresenter.cs" company="Open Source">
// Copyright (c) Open Source. All rights reserved.
// </copyright>

namespace SmartInventorySystem.WinForms.Presenter.Controls
{
    using System;
    using SmartInventorySystem.ViewModel.Forms.Grids;
    using SmartInventorySystem.WinForms.Controls;
    using SmartInventorySystem.WinForms.Core;
    using SmartInventorySystem.WinForms.View.Controls;
    using ViewModel.Controls;

    class DispenseItemDetailsPresenter : Presenter<IDispenseItemDetailsView>
    {
        public DispenseItemDetailsPresenter(IDispenseItemDetailsView view)
            : base(view)
        {
        }

        internal void AddItemToCart()
        {
            try
            {
                var args = new AddCartItemEventArgs();
                //args.UnitPrice = View.State.UnitPrice;

                View.FireOnAddCartItem(args);
            }
            catch (Exception ex)
            {
                View.ShowError(ex);
            }
        }

        internal void LoadItemDetails(int id, string code, string name, decimal unitPrice, int stock, int quantity)
        {
            try
            {
                View.State.ItemId = id;
                View.State.ItemCode = code;
                View.State.ItemName = name;
                View.State.UnitPrice = unitPrice;
                View.State.StockLevel = stock;
                View.State.Quantity = quantity;
                View.UpdateFormBindingSource();
            }
            catch (Exception ex)
            {
                View.ShowError(ex);
            }
        }
    }
}
