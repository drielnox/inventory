// <copyright file="DispenseItemPresenter.cs" company="Open Source">
// Copyright (c) Open Source. All rights reserved.
// </copyright>

namespace SmartInventorySystem.WinForms.Presenter
{
    using System;
    using System.Linq;
    using SmartInventorySystem.DataAccess;
    using SmartInventorySystem.Transformation.ToViewModel;
    using SmartInventorySystem.ViewModel.Forms.Grids;
    using SmartInventorySystem.WinForms.Core;
    using SmartInventorySystem.WinForms.View;

    class DispenseItemPresenter : Presenter<IDispenseItemView>
    {
        public DispenseItemPresenter(IDispenseItemView view)
            : base(view)
        {
        }

        internal void SearchItem()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(View.State.SearchItemText))
                {
                    return;
                }

                int parsedId;
                int.TryParse(View.State.SearchItemText, out parsedId);

                using (var ctx = new InventoryModel())
                {
                    View.State.SearchItemResult = ctx.Items
                        .Where(x => x.Name.StartsWith(View.State.SearchItemText)
                                    || x.Code == View.State.SearchItemText
                                    || x.Identifier == parsedId)
                        .ToViewModels<ItemRowViewModel>()
                        .ToList();
                }

                View.UpdateFormBindingSource();
            }
            catch (Exception ex)
            {
                View.ShowError(ex);
            }
        }

        internal void ClearSearchItemText()
        {
            View.State.SearchItemText = string.Empty;
        }

        internal void EnableSelectItem()
        {
            View.SetSelectItemEnable(View.State.SelectedItem != null);
        }

        internal void LoadSelectedItemDetails()
        {
            try
            {
                View.SetItemDetailsPanelEnable(View.State.SelectedItem != null);
                View.LoadItemsDetails(View.State.SelectedItem);
            }
            catch (Exception ex)
            {
                View.ShowError(ex);
            }
        }

        internal void AddItemToCart()
        {
            try
            {
                var itemToCart = View.State.ItemToDispense;
                View.State.ItemsForCheckout.Add(itemToCart);
                View.AddItemToCart(itemToCart);
            }
            catch (Exception ex)
            {
                View.ShowError(ex);
            }
        }
    }
}
