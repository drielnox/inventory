// <copyright file="SelectedItemEventArgs.cs" company="Open Source">
// Copyright (c) Open Source. All rights reserved.
// </copyright>

namespace SmartInventorySystem.WinForms.Controls
{
    using System;
    using ViewModel.Forms.Grids;

    public class SelectedItemEventArgs : EventArgs
    {
        public SelectedItemEventArgs()
        {
        }

        public ItemRowViewModel SelectedItem { get; internal set; }
    }
}