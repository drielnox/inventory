using SmartInventorySystem.Model;
using SmartInventorySystem.ViewModel.Grids;
using System.Collections.Generic;
using System.Linq;

namespace SmartInventorySystem.Transformation.ToViewModel
{
    public static class ItemToViewModel
    {
        public static IEnumerable<StockRowViewModel> ToViewModels(this IEnumerable<Item> its)
        {
            return its.Select(x => x.ToViewModel());
        }

        public static StockRowViewModel ToViewModel(this Item it)
        {
            var vm = new StockRowViewModel();
            vm.Name = it.Name;
            vm.Description = it.Description;
            vm.Manufacturer = it.Manufacturer;
            vm.StockLevel = it.StockLevel;
            vm.ReOrderLevel = it.ReOrderLevel;
            vm.MajorSupplier = it.MajorSupplier;
            vm.PurchasePrice = it.PurchasePrice;
            vm.SellingPrice = it.SellingPrice;

            return vm;
        }
    }
}
