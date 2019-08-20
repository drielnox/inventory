using SmartInventorySystem.ViewModel.Controls.Grids;
using SmartInventorySystem.ViewModel.Core;
using System.Collections.Generic;
using System.Linq;

namespace SmartInventorySystem.ViewModel.Controls
{
    public class DispenseCartControlViewModel : FormViewModel
    {
        public DispenseCartControlViewModel()
        {
            ItemsToCheckout = new List<ItemToCheckoutRowViewModel>();
        }

        public List<ItemToCheckoutRowViewModel> ItemsToCheckout { get; set; }

        public decimal SubTotal => ItemsToCheckout.Sum(x => x.Quantity * x.UnitPrice);
        public decimal Discount { get; set; }
        public decimal Vat { get; set; }
        public decimal Total => SubTotal - Discount + Vat > 0 ? (Vat / 100 * (SubTotal - Discount)) : 0;
    }
}
