// <copyright file="DispenseItemDetailsPresenter.cs" company="Open Source">
// Copyright (c) Open Source. All rights reserved.
// </copyright>

namespace SmartInventorySystem.WinForms.Presenter.Controls
{
    using System;
    using Core;
    using SmartInventorySystem.WinForms.Controls;
    using View.Controls;

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
                args.Amount = View.State.Quantity;
                args.UnitPrice = View.State.UnitPrice;

                View.FireOnAddCartItem(args);
            }
            catch (Exception ex)
            {
                View.ShowError(ex);
            }
        }

        internal void LoadItemDetails(int id, string code, string name, decimal unitPrice, int stock)
        {
            try
            {
                View.State.ItemId = id;
                View.State.ItemCode = code;
                View.State.ItemName = name;
                View.State.UnitPrice = unitPrice;
                View.State.StockLevel = stock;
                View.UpdateFormBindingSource();
            }
            catch (Exception ex)
            {
                View.ShowError(ex);
            }
        }

        internal void ValidateQuantity()
        {
            try
            {
                if (View.State.Quantity < 1)
                {
                    View.State.HasErrors |= true;
                    View.ShowQuantityError("Quantity less than one.");
                }
                else
                {
                    View.State.HasErrors |= false;
                }
            }
            catch (Exception ex)
            {
                View.ShowError(ex);
            }
        }

        internal void ClearErrors()
        {
            try
            {
                View.ClearErrors();
            }
            catch (Exception ex)
            {
                View.ShowError(ex);
            }
        }
    }
}
