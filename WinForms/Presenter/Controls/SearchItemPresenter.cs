// <copyright file="SearchItemPresenter.cs" company="Open Source">
// Copyright (c) Open Source. All rights reserved.
// </copyright>

namespace SmartInventorySystem.WinForms.Presenter.Controls
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DataAccess;
    using SmartInventorySystem.WinForms.Core;
    using SmartInventorySystem.WinForms.View.Controls;
    using Transformation.ToViewModel;
    using ViewModel.Forms.Grids;

    class SearchItemPresenter : Presenter<IItemSearchView>
    {
        public SearchItemPresenter(IItemSearchView view)
            : base(view)
        {
        }

        internal void PerformSearch()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(View.State.SearchText))
                {
                    return;
                }

                int parsedId;
                int.TryParse(View.State.SearchText, out parsedId);

                using (var ctx = new InventoryModel())
                {
                    View.State.SearchResult = ctx.Items
                        .Where(x => x.Name.StartsWith(View.State.SearchText)
                                    || x.Code == View.State.SearchText
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

        internal void SelectItem()
        {
            try
            {
                if (View.SelectedItem == null)
                {
                    return;
                }

                View.FireOnItemSelected(View.SelectedItem);
            }
            catch (Exception ex)
            {
                View.ShowError(ex);
            }
        }
    }
}
