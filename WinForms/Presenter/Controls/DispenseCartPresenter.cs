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

        internal void AddItemToCart(ItemToCheckoutRowViewModel itemDispensed)
        {
            try
            {
                View.State.ItemsToCheckout.Add(itemDispensed);
                View.UpdateFormBindingSource();
            }
            catch (Exception ex)
            {
                View.ShowError(ex);
            }
        }
    }
}
