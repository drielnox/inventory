// <copyright file="AddCartItemEventArgs.cs" company="Open Source">
// Copyright (c) Open Source. All rights reserved.
// </copyright>

namespace SmartInventorySystem.WinForms.Controls
{
    using System;

    public class AddCartItemEventArgs : EventArgs
    {
        public int Amount { get; internal set; }
        public decimal UnitPrice { get; internal set; }
    }
}
