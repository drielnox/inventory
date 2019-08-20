// <copyright file="ListDispensePresenter.cs" company="Open Source">
// Copyright (c) Open Source. All rights reserved.
// </copyright>

using SmartInventorySystem.DataAccess;
using SmartInventorySystem.Transformation.ToViewModel;
using SmartInventorySystem.ViewModel;
using SmartInventorySystem.WinForms.Core;
using SmartInventorySystem.WinForms.View;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SmartInventorySystem.WinForms.Presenter
{
    class ListDispensePresenter : Presenter<IListDispenseView>
    {
        public ListDispensePresenter(IListDispenseView view)
            : base(view)
        {
        }

        internal void LoadDispensedItems()
        {
            try
            {
                var disSheet = new List<DispenseSheetViewModel2>();

                using (var ctx = new InventoryModel())
                {
                    disSheet = ctx.Dispenses
                        .OrderByDescending(x => x.Identifier)
                        .ToViewModels()
                        .ToList();
                }

                View.SetDispenseBindingSource(disSheet);
            }
            catch (Exception ex)
            {
                View.ShowError(ex);
            }
        }
    }
}
