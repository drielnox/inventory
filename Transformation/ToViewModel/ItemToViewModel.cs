using SmartInventorySystem.Model;
using SmartInventorySystem.ViewModel.Forms.Grids;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SmartInventorySystem.Transformation.ToViewModel
{
    public static class ItemToViewModel
    {
        public static IEnumerable<TResult> ToViewModels<TResult>(this IEnumerable<Item> its)
            where TResult : ViewModel.Core.ViewModel
        {
            return its.Select(x => x.ToViewModel<TResult>());
        }

        public static TResult ToViewModel<TResult>(this Item it)
            where TResult : ViewModel.Core.ViewModel
        {
            var resultType = typeof(TResult);

            if (resultType == typeof(ItemRowViewModel))
            {
                return (TResult)(ViewModel.Core.ViewModel)it.ToItemRowViewModel();
            }
            else if (resultType is StockRowViewModel)
            {
                return (TResult)(ViewModel.Core.ViewModel)it.ToStockRowViewModel();
            }
            else
            {
                throw new ApplicationException("El tipo de resultado elegido no esta contemplado para la transformación.");
            }
        }

        public static ItemRowViewModel ToItemRowViewModel(this Item it)
        {
            var vm = new ItemRowViewModel();
            vm.Identifier = it.Identifier;
            vm.Code = it.Code;
            vm.Name = it.Name;
            vm.Description = it.Description;
            vm.AlternativeName = it.AlternativeName;
            vm.Manufacturer = it.Manufacturer;
            vm.MajorSupplier = it.MajorSupplier;
            vm.PackQuantity = it.PackQuantity;
            vm.PackDescription = it.PackDescription;
            vm.AlternativeItem = it.AlternativeItem;
            vm.StandardIssueQuantity = it.StandardIssueQuantity;
            vm.EconomicOrderQuantity = it.EconomicOrderQuantity;
            vm.PurchasePrice = it.PurchasePrice;
            vm.MarkupPercent = it.MarkupPercent;
            vm.SellingPrice = it.SellingPrice;
            vm.StockLevel = it.StockLevel;
            vm.MinimumLevel = it.MinimumLevel;
            vm.ReOrderLevel = it.ReOrderLevel;
            vm.MaximumLevel = it.MaximumLevel;
            vm.LeadDays = it.LeadDays;
            return vm;
        }

        public static StockRowViewModel ToStockRowViewModel(this Item it)
        {
            var vm = new StockRowViewModel();
            vm.Identifier = it.Identifier;
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
