using SmartInventorySystem.Model;
using SmartInventorySystem.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace SmartInventorySystem.Transformation.ToViewModel
{
    public static class DispenseToViewModel
    {
        public static IEnumerable<DispenseSheetViewModel2> ToViewModels(this IEnumerable<Dispense> dis)
        {
            return dis.Select(x => x.ToViewModel());
        }

        public static DispenseSheetViewModel2 ToViewModel(this Dispense di)
        {
            var vm = new DispenseSheetViewModel2();
            vm.GroupId = di.GroupId;
            vm.ItemName = di.ItemName;
            vm.UnitPrice = di.UnitPrice;
            vm.DispenseQuantity = di.DispenseQuantity;
            vm.DispenseCompleted = di.DispenseCompleted;
            vm.GroupDate = di.GroupDate;

            return vm;
        }
    }
}
