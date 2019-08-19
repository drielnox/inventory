using SmartInventorySystem.DataAccess;
using SmartInventorySystem.Transformation.ToViewModel;
using SmartInventorySystem.WinForms.Core;
using SmartInventorySystem.WinForms.View;
using System;
using System.Linq;

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
                    View.ViewModel.CurrentStock = ctx.Items
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
    }
}
