// <copyright file="DispenseItemDetailsControl.cs" company="Open Source">
// Copyright (c) Open Source. All rights reserved.
// </copyright>

namespace SmartInventorySystem.WinForms
{
    using System;
    using System.Windows.Forms;
    using Controls;
    using Presenter.Controls;
    using View.Controls;
    using ViewModel.Controls;

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

        /// <inheritdoc/>
        public DispenseItemDetailsControlViewModel State { get; protected set; }

        public void LoadItemDetails(int id, string code, string name, decimal unitPrice, int stock)
        {
            _presenter.LoadItemDetails(id, code, name, unitPrice, stock);
        }

        /// <inheritdoc/>
        public void ShowError(Exception ex)
        {
            MessageBox.Show(this, ex.Message, "Items details to dispense.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <inheritdoc/>
        public void ShowInfo(string msg)
        {
            MessageBox.Show(this, msg, "Items details to dispense.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <inheritdoc/>
        public void UpdateFormBindingSource()
        {
            bsControl.ResetBindings(false);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            State.HasErrors = false;

            if (ValidateChildren())
            {
                _presenter.AddItemToCart();
            }
        }

        public void FireOnAddCartItem(AddCartItemEventArgs args)
        {
            OnAddToCart?.Invoke(this, args);
        }

        private void btnAddItem_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _presenter.ValidateQuantity();

            e.Cancel = State.HasErrors;
        }

        /// <inheritdoc/>
        public void ShowQuantityError(string v)
        {
            epQuantity.SetError(nudQuantity, v);
        }

        private void btnAddItem_Validated(object sender, EventArgs e)
        {
            _presenter.ClearErrors();
        }

        /// <inheritdoc/>
        public void ClearErrors()
        {
            epQuantity.SetError(nudQuantity, string.Empty);
        }
    }
}
