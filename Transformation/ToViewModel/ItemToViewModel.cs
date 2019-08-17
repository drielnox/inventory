using SmartInventorySystem.Model;
using SmartInventorySystem.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace SmartInventorySystem.Transformation.ToViewModel
{
    public static class ItemToViewModel
    {
        public static IEnumerable<StockViewModel> ToViewModels(this IEnumerable<Item> its)
        {
            return its.Select(x => x.ToViewModel());
        }

        public static StockViewModel ToViewModel(this Item it)
        {
            var vm = new StockViewModel();
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
