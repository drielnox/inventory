using SmartInventorySystem.DataAccess;
using SmartInventorySystem.Model;
using SmartInventorySystem.WinForms.Core;
using SmartInventorySystem.WinForms.View;
using System;

namespace SmartInventorySystem.WinForms.Presenter
{
    class NewSupplierPresenter : Presenter<INewSupplierView>
    {
        public NewSupplierPresenter(INewSupplierView view) : base(view)
        {
        }

        internal void PerformSave()
        {
            try
            {
                var newSupplier = new Supplier();
                newSupplier.Name = View.ViewModel.SupplierName;
                newSupplier.ContactPerson = View.ViewModel.ContextPerson;
                newSupplier.Address = View.ViewModel.Address;
                newSupplier.Email = View.ViewModel.Email;
                newSupplier.Phone = View.ViewModel.Phone;

                using (var ctx = new InventoryModel())
                {
                    ctx.Suppliers.Add(newSupplier);

                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                View.ShowError(ex);
            }

            View.ShowInfo("New Supplier Successfully Added to System");
        }

        internal void CleanFields()
        {
            View.ViewModel.SupplierName = string.Empty;
            View.ViewModel.ContextPerson = string.Empty;
            View.ViewModel.Address = string.Empty;
            View.ViewModel.Email = string.Empty;
            View.ViewModel.Phone = string.Empty;
            View.UpdateFormBindingSource();
        }
    }
}
