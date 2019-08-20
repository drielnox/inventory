// <copyright file="DispenseItemDetailsControl.cs" company="Open Source">
// Copyright (c) Open Source. All rights reserved.
// </copyright>

using System;
using System.Windows.Forms;
using SmartInventorySystem.WinForms.View.Controls;
using SmartInventorySystem.ViewModel.Controls;
using SmartInventorySystem.WinForms.Presenter.Controls;
using SmartInventorySystem.WinForms.Controls;

namespace SmartInventorySystem.WinForms
{
    public partial class DispenseItemDetailsUserControl : UserControl, IDispenseItemDetailsView
    {
        public event EventHandler<AddCartItemEventArgs> OnAddToCart;

        private readonly DispenseItemDetailsPresenter _presenter;

        public DispenseItemDetailsUserControl()
        {
            InitializeComponent();

            _presenter = new DispenseItemDetailsPresenter(this);

            State = new DispenseItemDetailsControlViewModel();
        }

        public DispenseItemDetailsControlViewModel State { get; private set; }

        public void ShowError(Exception ex)
        {
            MessageBox.Show(this, ex.Message, "Items details to dispense.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowInfo(string msg)
        {
            MessageBox.Show(this, msg, "Items details to dispense.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void UpdateFormBindingSource()
        {
            bsControl.ResetBindings(false);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            _presenter.AddItemToCart();
        }

        public void FireOnAddCartItem(AddCartItemEventArgs args)
        {
            OnAddToCart?.Invoke(this, args);
        }
    }
}
