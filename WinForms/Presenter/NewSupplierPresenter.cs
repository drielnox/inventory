// <copyright file="NewSupplierPresenter.cs" company="Open Source">
// Copyright (c) Open Source. All rights reserved.
// </copyright>

using SmartInventorySystem.DataAccess;
using SmartInventorySystem.Model;
using SmartInventorySystem.WinForms.Core;
using SmartInventorySystem.WinForms.View;
using System;

namespace SmartInventorySystem.WinForms.Presenter
{
    class NewSupplierPresenter : Presenter<INewSupplierView>
    {
        public NewSupplierPresenter(INewSupplierView view)
            : base(view)
        {
        }

        internal void PerformSave()
        {
            try
            {
                var newSupplier = new Supplier();
                newSupplier.Name = View.State.SupplierName;
                newSupplier.ContactPerson = View.State.ContextPerson;
                newSupplier.Address = View.State.Address;
                newSupplier.Email = View.State.Email;
                newSupplier.Phone = View.State.Phone;

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
            View.State.SupplierName = string.Empty;
            View.State.ContextPerson = string.Empty;
            View.State.Address = string.Empty;
            View.State.Email = string.Empty;
            View.State.Phone = string.Empty;
            View.UpdateFormBindingSource();
        }
    }
}
