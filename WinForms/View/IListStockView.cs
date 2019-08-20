// <copyright file="IListStockView.cs" company="Open Source">
// Copyright (c) Open Source. All rights reserved.
// </copyright>

using SmartInventorySystem.WinForms.Core;
using SmartInventorySystem.ViewModel.Forms;
using SmartInventorySystem.ViewModel.Forms.Grids;

namespace SmartInventorySystem.WinForms.View
{
    interface IListStockView : IView<ListStockFormViewModel>
    {
        void ShowUpdateStockForm(StockRowViewModel selectedStock);
        void AskDeleteStockMessage(StockRowViewModel selectedStock);
        void SetUpdateButtonEnable(bool v);
        void SetDeleteButtonEnable(bool v);
    }
}
