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

        public DispenseCartControl()
        {
            InitializeComponent();

            _presenter = new DispenseCartPresenter(this);

            State = new DispenseCartControlViewModel();

            bsControl.DataSource = State;
        }

        public DispenseCartControlViewModel State { get; private set; }

        internal void AddItemDispense(string itemId, string itemName, decimal quantity, decimal unitPrice)
        {
            var itemDispensed = new ItemToCheckoutRowViewModel();
            itemDispensed.ItemId = int.Parse(itemId);
            itemDispensed.ItemName = itemName;
            itemDispensed.Quantity = (int)quantity;
            itemDispensed.UnitPrice = unitPrice;
            _presenter.AddItemToCart(itemDispensed);
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

        
    }
}
