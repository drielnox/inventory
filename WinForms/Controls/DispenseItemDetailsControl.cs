// <copyright file="DispenseItemDetailsControl.cs" company="Open Source">
// Copyright (c) Open Source. All rights reserved.
// </copyright>

namespace SmartInventorySystem.WinForms
{
    using System;
    using System.Windows.Forms;
    using SmartInventorySystem.ViewModel.Controls;
    using SmartInventorySystem.ViewModel.Forms.Grids;
    using SmartInventorySystem.WinForms.Controls;
    using SmartInventorySystem.WinForms.Presenter.Controls;
    using SmartInventorySystem.WinForms.View.Controls;

    public partial class DispenseItemDetailsUserControl : UserControl, IDispenseItemDetailsView
    {
        public event EventHandler<AddCartItemEventArgs> OnAddToCart;

        private readonly DispenseItemDetailsPresenter _presenter;

        public DispenseItemDetailsUserControl()
        {
            InitializeComponent();

            _presenter = new DispenseItemDetailsPresenter(this);

            State = new DispenseItemDetailsControlViewModel();

            bsControl.DataSource = State;
        }

        public DispenseItemDetailsControlViewModel State { get; protected set; }

        public void LoadItemDetails(int id, string code, string name, decimal unitPrice, int stock, int quantity)
        {
            _presenter.LoadItemDetails(id, code, name, unitPrice, stock, quantity);
        }

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
