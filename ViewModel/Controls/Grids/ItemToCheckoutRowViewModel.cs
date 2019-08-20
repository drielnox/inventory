using System;
using System.ComponentModel.DataAnnotations;

namespace SmartInventorySystem.ViewModel.Controls.Grids
{
    public class ItemToCheckoutRowViewModel : Core.ViewModel
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
