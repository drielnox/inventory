// <copyright file="DispenseCartControl.cs" company="Open Source">
// Copyright (c) Open Source. All rights reserved.
// </copyright>

namespace SmartInventorySystem.WinForms.Controls
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Presenter.Controls;
    using View.Controls;
    using ViewModel.Controls;
    using ViewModel.Controls.Grids;

    public partial class DispenseCartControl : UserControl, IDispenseCartView
    {
        private readonly DispenseCartPresenter _presenter;

        public event EventHandler<DispenseCartSaveEventArgs> OnSave;

        public DispenseCartControl()
        {
            InitializeComponent();

            _presenter = new DispenseCartPresenter(this);

            State = new DispenseCartControlViewModel();

            bsControl.DataSource = State;
        }

        public DispenseCartControlViewModel State { get; private set; }

        public ItemToCheckoutRowViewModel SelectedItem => bsItemsToCheckout.Current as ItemToCheckoutRowViewModel;

        internal void AddItemDispense(int id, string name, int quantity, decimal unitPrice)
        {
            _presenter.AddItemToCart(id, name, quantity, unitPrice);
        }

        public void ShowError(Exception ex)
        {
            MessageBox.Show(this, ex.Message, "Dispense Cart", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowInfo(string msg)
        {
            MessageBox.Show(this, msg, "Dispense Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void UpdateFormBindingSource()
        {
            bsControl.ResetBindings(false);
        }

        private void tsbRemoveItemCart_Click(object sender, EventArgs e)
        {
            _presenter.RemoveSelectedItem();
        }

        private void bsItemsToCheckout_CurrentChanged(object sender, EventArgs e)
        {
            _presenter.EnableRemoveItem();
        }

        public void EnableRemoveButton(bool v)
        {
            tsbRemoveItemCart.Enabled = v;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _presenter.Save();
        }

        public void FireOnSave(DispenseCartControlViewModel state)
        {
            var args = new DispenseCartSaveEventArgs();
            args.Items = state.ItemsToCheckout;
            args.SubTotal = state.SubTotal;
            args.Discount = state.Discount;
            args.Vat = state.Vat;
            args.Total = state.Total;

            OnSave?.Invoke(this, args);
        }
    }
}
