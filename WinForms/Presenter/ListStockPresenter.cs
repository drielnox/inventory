using SmartInventorySystem.DataAccess;
using SmartInventorySystem.Transformation.ToViewModel;
using SmartInventorySystem.WinForms.Core;
using SmartInventorySystem.WinForms.View;
using System;
using System.Linq;
using SmartInventorySystem.ViewModel.Grids;

namespace SmartInventorySystem.WinForms.Presenter
{
    class ListStockPresenter : Presenter<IListStockView>
    {
        public ListStockPresenter(IListStockView view) : base(view)
        {
        }

        internal void LoadStockList()
        {
            try
            {
                using (var ctx = new InventoryModel())
                {
                    View.State.CurrentStock = ctx.Items
                        .ToViewModels()
                        .ToList();
                }
            }
            catch (Exception err)
            {
                View.ShowError(err);
            }

            View.UpdateFormBindingSource();
        }

        internal void EnableUpdate()
        {
            try
            {
                View.SetUpdateButtonEnable(View.State.SelectedStock != null);
            }
            catch (Exception ex)
            {
                View.ShowError(ex);
            }
        }

        internal void EnableDelete()
        {
            try
            {
                View.SetDeleteButtonEnable(View.State.SelectedStock != null);
            }
            catch (Exception ex)
            {
                View.ShowError(ex);
            }
        }

        internal void DeleteStock(StockRowViewModel selectedStock)
        {
            try
            {
                using (var ctx = new InventoryModel())
                {
                    var stockToDelete = ctx.Items
                        .Single(x => x.Identifier == selectedStock.Identifier);

                    ctx.Items.Remove(stockToDelete);

                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                View.ShowError(ex);
            }
        }

        internal void ShowUpdateStockForm()
        {
            try
            {
                View.ShowUpdateStockForm(View.State.SelectedStock);
            }
            catch (Exception ex)
            {
                View.ShowError(ex);
            }
        }

        internal void ShowDeleteStockMessage()
        {
            try
            {
                View.AskDeleteStockMessage(View.State.SelectedStock);
            }
            catch (Exception ex)
            {
                View.ShowError(ex);
            }
        }
    }
}
