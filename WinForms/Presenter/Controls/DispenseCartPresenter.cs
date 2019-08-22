// <copyright file="DispenseCartPresenter.cs" company="Open Source">
// Copyright (c) Open Source. All rights reserved.
// </copyright>

namespace SmartInventorySystem.WinForms.Presenter.Controls
{
    using System;
    using Core;
    using View.Controls;
    using ViewModel.Controls.Grids;

    class DispenseCartPresenter : Presenter<IDispenseCartView>
    {
        public DispenseCartPresenter(IDispenseCartView view)
            : base(view)
        {
        }

        internal void AddItemToCart(int id, string name, int quantity, decimal unitPrice)
        {
            try
            {
                var itemDispensed = new ItemToCheckoutRowViewModel();
                itemDispensed.ItemId = id;
                itemDispensed.ItemName = name;
                itemDispensed.Quantity = quantity;
                itemDispensed.UnitPrice = unitPrice;
                View.State.ItemsToCheckout.Add(itemDispensed);
                View.UpdateFormBindingSource();
            }
            catch (Exception ex)
            {
                View.ShowError(ex);
            }
        }

        internal void RemoveSelectedItem()
        {
            try
            {
                var selectedItem = View.SelectedItem;
                View.State.ItemsToCheckout.Remove(selectedItem);
                View.UpdateFormBindingSource();
            }
            catch (Exception ex)
            {
                View.ShowError(ex);
            }
        }

        internal void EnableRemoveItem()
        {
            try
            {
                View.EnableRemoveButton(View.SelectedItem != null);
            }
            catch (Exception ex)
            {
                View.ShowError(ex);
            }
        }

        internal void Save()
        {
            try
            {
                var state = View.State;
                View.FireOnSave(state);
            }
            catch (Exception ex)
            {
                View.ShowError(ex);
            }
        }
    }
}
