using SmartInventorySystem.WinForms.Controls;
using SmartInventorySystem.WinForms.Core;
using SmartInventorySystem.WinForms.View.Controls;
using System;

namespace SmartInventorySystem.WinForms.Presenter.Controls
{
    class DispenseItemDetailsPresenter : Presenter<IDispenseItemDetailsView>
    {
        public DispenseItemDetailsPresenter(IDispenseItemDetailsView view) : base(view)
        {
        }

        internal void AddItemToCart()
        {
            try
            {
                var args = new AddCartItemEventArgs();
                args.UnitPrice = View.State.UnitPrice;
                args.Amount = View.State.Amount;
                View.FireOnAddCartItem(args);
            }
            catch (Exception ex)
            {
                View.ShowError(ex);
            }
        }
    }
}
