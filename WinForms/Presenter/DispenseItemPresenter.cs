using System;
using SmartInventorySystem.WinForms.Core;
using SmartInventorySystem.WinForms.View;
using SmartInventorySystem.DataAccess;
using System.Linq;
using SmartInventorySystem.Transformation.ToViewModel;
using SmartInventorySystem.ViewModel.Forms.Grids;

namespace SmartInventorySystem.WinForms.Presenter
{
    class DispenseItemPresenter : Presenter<IDispenseItemView>
    {
        public DispenseItemPresenter(IDispenseItemView view) : base(view)
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
    }
}
