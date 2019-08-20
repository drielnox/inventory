// <copyright file="IView.cs" company="Open Source">
// Copyright (c) Open Source. All rights reserved.
// </copyright>

namespace SmartInventorySystem.WinForms.Core
{
    using System;
    using SmartInventorySystem.ViewModel.Core;

    interface IView
    {
        void ShowInfo(string msg);
        void ShowError(Exception ex);
    }

    interface IView<out TFormViewModel> : IView
        where TFormViewModel : FormViewModel
    {
        TFormViewModel State { get; }
        void UpdateFormBindingSource();
    }
}
