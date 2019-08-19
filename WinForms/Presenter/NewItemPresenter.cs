using SmartInventorySystem.DataAccess;
using SmartInventorySystem.Model;
using SmartInventorySystem.WinForms.Core;
using SmartInventorySystem.WinForms.View;
using System;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace SmartInventorySystem.WinForms.Presenter
{
    class NewItemPresenter : Presenter<INewItemView>
    {
        public NewItemPresenter(INewItemView view) : base(view)
        {
        }

        internal void PerformSave()
        {
            try
            {
                var newItem = new Item();
                newItem.Code = View.ViewModel.Code;
                newItem.Name = View.ViewModel.Name;
                newItem.Description = View.ViewModel.Description;
                newItem.AlternativeName = View.ViewModel.AlternativeName;
                newItem.Manufacturer = View.ViewModel.Manufacturer;
                newItem.MajorSupplier = View.ViewModel.MajorSupplier;
                newItem.PackQuantity = View.ViewModel.PackSize;
                newItem.PackDescription = View.ViewModel.PackDescription;
                newItem.AlternativeItem = View.ViewModel.AlternativeItem;
                newItem.StandardIssueQuantity = View.ViewModel.StandardIssueQuantity;
                newItem.EconomicOrderQuantity = View.ViewModel.EconomicOrderQuantity;

                using (var ctx = new InventoryModel())
                {
                    ctx.Items.Add(newItem);

                    ctx.SaveChanges();
                }

                View.ShowInfo("New Drug/Item Successfully Added to System");
            }
            catch (DbEntityValidationException deve)
            {
                foreach (var devr in deve.EntityValidationErrors)
                {
                    Debug.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:", devr.Entry.Entity.GetType().Name, devr.Entry.State);

                    foreach (var dve in devr.ValidationErrors)
                    {
                        Debug.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"", dve.PropertyName, devr.Entry.CurrentValues.GetValue<object>(dve.PropertyName), dve.ErrorMessage);
                    }
                }

                throw;
            }
            catch (Exception ex)
            {
                View.ShowError(ex);
            }
        }

        internal void CleanFields()
        {
            View.ViewModel.Code = string.Empty;
            View.ViewModel.Name = string.Empty;
            View.ViewModel.Description = string.Empty;
            View.ViewModel.AlternativeName = string.Empty;
            View.ViewModel.Manufacturer = string.Empty;
            View.ViewModel.MajorSupplier = string.Empty;
            View.ViewModel.PackSize = string.Empty;
            View.ViewModel.PackDescription = string.Empty;
            View.ViewModel.AlternativeItem = string.Empty;
            View.ViewModel.StandardIssueQuantity = string.Empty;
            View.ViewModel.EconomicOrderQuantity = string.Empty;
            View.UpdateFormBindingSource();
        }
    }
}
