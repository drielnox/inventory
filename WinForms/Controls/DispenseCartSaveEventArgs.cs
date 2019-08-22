// <copyright file="DispenseCartSaveEventArgs.cs" company="Open Source">
// Copyright (c) Open Source. All rights reserved.
// </copyright>

namespace SmartInventorySystem.WinForms.Controls
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ViewModel.Controls.Grids;

    public class DispenseCartSaveEventArgs : EventArgs
    {
        public decimal Discount { get; internal set; }
        public List<ItemToCheckoutRowViewModel> Items { get; internal set; }
        public decimal SubTotal { get; internal set; }
        public decimal Total { get; internal set; }
        public decimal Vat { get; internal set; }
    }
}
