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
                newItem.Code = View.State.Code;
                newItem.Name = View.State.Name;
                newItem.Description = View.State.Description;
                newItem.AlternativeName = View.State.AlternativeName;
                newItem.Manufacturer = View.State.Manufacturer;
                newItem.MajorSupplier = View.State.MajorSupplier;
                newItem.PackQuantity = View.State.PackSize;
                newItem.PackDescription = View.State.PackDescription;
                newItem.AlternativeItem = View.State.AlternativeItem;
                newItem.StandardIssueQuantity = View.State.StandardIssueQuantity;
                newItem.EconomicOrderQuantity = View.State.EconomicOrderQuantity;

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
            View.State.Code = string.Empty;
            View.State.Name = string.Empty;
            View.State.Description = string.Empty;
            View.State.AlternativeName = string.Empty;
            View.State.Manufacturer = string.Empty;
            View.State.MajorSupplier = string.Empty;
            View.State.PackSize = string.Empty;
            View.State.PackDescription = string.Empty;
            View.State.AlternativeItem = string.Empty;
            View.State.StandardIssueQuantity = string.Empty;
            View.State.EconomicOrderQuantity = string.Empty;
            View.UpdateFormBindingSource();
        }
    }
}
