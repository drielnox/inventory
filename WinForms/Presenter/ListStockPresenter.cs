using SmartInventorySystem.DataAccess;
using SmartInventorySystem.Transformation.ToViewModel;
using SmartInventorySystem.ViewModel;
using SmartInventorySystem.WinForms.Core;
using SmartInventorySystem.WinForms.View;
using System;
using System.Collections.Generic;
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
            var stock = new List<StockViewModel>();

            try
            {
                using (var ctx = new InventoryModel())
                {
                    stock = ctx.Items
                        .ToViewModels()
                        .ToList();
                }

                View.SetStockBindingSource(stock);
            }
            catch (Exception err)
            {
                View.ShowError(err);
            }
        }
    }
}
